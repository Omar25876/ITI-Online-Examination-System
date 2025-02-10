using onlineExam.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineExam
{
    public partial class ResultForm : Form
    {
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        private ReviewModel[] reviewModels;
        private User user;
        private string e_name;
        private int e_ID;
		Panel panel;

		public ResultForm(int myGrade, string EName, ReviewModel[] rvModel, User user, string e_name, int e_ID,Panel panel)
        {
			this.panel = panel;
			InitializeComponent();
            SetIniteValues(myGrade, EName, rvModel, user, e_name, e_ID);
            
        }

        private void SetIniteValues(int myGrade, string EName, ReviewModel[] rvModel, User user , string e_name, int e_ID)
        {
            label3.Text = myGrade.ToString();
            reviewModels = rvModel;
            this.user = user;
            this.e_name = e_name;
            this.e_ID = e_ID;
            SqlCommand sqlCommand = new SqlCommand("getExamGrade", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@eName", EName);
            
            try
            {
                sqlConnection.Open();
                string totalGrade = sqlCommand.ExecuteScalar().ToString();
                label4.Text = totalGrade;
                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                
                if (myGrade >= int.Parse(totalGrade) / 2)
                {
                    
                    string imagePath = Path.Combine(projectDirectory, "img", "Personal goals-bro.png");
                    
                    imgItem.Image = Image.FromFile(imagePath);
                    
                }
                else
                {
                    string imagePath = Path.Combine(projectDirectory, "img", "No data-bro.png");
                  
                    imgItem.Image = Image.FromFile(imagePath);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            MessageBox.Show(reviewModels.Length.ToString());
         
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void ShowForm(Form form)
		{
			panel.Controls.Clear();
			panel.Controls.Add(form);
			form.Show();
		}
		private void button1_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm(reviewModels, user, e_name, e_ID,panel) { TopLevel = false, Dock = DockStyle.Fill };
            ShowForm(reviewForm);
		}
    }
}
