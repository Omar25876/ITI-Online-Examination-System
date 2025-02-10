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
using System.Xml.Linq;
using WindowsFormsApp;

namespace onlineExam
{
    public partial class ExamsForm : Form
    {
        User user;
		Panel panel;
		private int E_id;
        private string E_name;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
        public ExamsForm(User user,Panel panel)
        {
			this.user = user;
			this.panel = panel;
			InitializeComponent();
            
            LoadExams();
            
        }

        private void ExamsForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadExams()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetAllExamsForSpecificStudentBasedOnTrackID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@St_id", user.UserId);

						SqlDataAdapter da = new SqlDataAdapter(cmd);
           
						DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboExams.DisplayMember = "E_Name";
                        cboExams.ValueMember = "E_Id";
                        cboExams.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading exams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExams.SelectedItem != null)
            {
                E_id = Convert.ToInt32(cboExams.SelectedValue);
                E_name= cboExams.Text;
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
			ExamsDetails examsDetails = new  ExamsDetails(E_id, E_name, user, panel) { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(examsDetails);


			//ExamsDetails examsDetails = new ExamsDetails(E_id, E_name, user);
			//         examsDetails.Show();
			//         this.Hide();
		}

		private void ShowForm(Form form)
		{
			panel.Controls.Clear();
			panel.Controls.Add(form);
			form.Show();
		}
	}
}
