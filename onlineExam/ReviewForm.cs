using onlineExam.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineExam
{
    public partial class ReviewForm : Form
    {
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        private ReviewModel[] reviewModels;
        private int index = 0;
        private string e_name;
        private int e_id;
        User user;
		Panel panel111;
		public ReviewForm(ReviewModel[] rvModel, User user , string e_name, int e_id,Panel panel111)
        {
            this.panel111 = panel111;
			InitializeComponent();
            reviewModels = rvModel;
            this.user = user;
            this.e_name = e_name;
            this.e_id = e_id;
           
            buildScreen();
            
        }

     

        private void ReviewForm_Load(object sender, EventArgs e)
        {

        }

        private void buildScreen()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false,

            };
            panel.HorizontalScroll.Maximum = 0;
            panel.VerticalScroll.Visible = true;

            foreach (ReviewModel rv in reviewModels)
            {
                Label Q = new Label
                {
                    Text = rv.Question,
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Padding = new Padding(5),
                    Margin = new Padding(5)
                };
                if(rv.Answer==0)
                {
                    Q.ForeColor= Color.Red;
                }
                panel.Controls.Add(Q);

                LoadAnswer(panel, rv.QID, rv.Answer, rv.RAnswer);
            }

           
            Controls.Add(panel);
        }

        private void LoadAnswer(FlowLayoutPanel panel, int qID,int myAns,int rAns)
        {
            int answerIndex = 0;
            SqlCommand sqlCommand = new SqlCommand("GetQuestion", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@q_ID", qID);
            try
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    answerIndex++;
                    Label ans = new Label
                    {
                        Text = reader[7].ToString(),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5),
                        Margin = new Padding(5)
                        
                    };
                    if (answerIndex==myAns)
                    {
                        ans.ForeColor = Color.Red;
                    }
                    if (answerIndex==rAns)
                    {
                        ans.ForeColor = Color.Green;
                    }

					panel.Controls.Add(ans);
					

				}
				Panel panel900 = new Panel
				{
					Size = new Size(1300, 5),
					BackColor = Color.Black,
					Padding = new Padding(10),
					Margin = new Padding(10)
				};
				panel.Controls.Add(panel900);

			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
