using onlineExam.Admin;
using onlineExam.Instructor;
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
    public partial class LoginForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            panel1.BackColor = Color.FromArgb(191, 39, 45);
            panel1.Height = (int)(this.ClientSize.Height * .5);
            panel1.Width = (int)(this.ClientSize.Width*1.1);
            this.FormBorderStyle = FormBorderStyle.None;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_AuthenticateUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && reader["Role"] != DBNull.Value)
                            {
                                string role = reader["Role"].ToString();
                                int userId = Convert.ToInt32(reader["UserId"]);
                                string firstName = reader["F_Name"].ToString();
                                string lastName = reader["L_Name"].ToString();
                                User user = new User(role, userId, firstName, lastName);


								MessageBox.Show($"Login Successful!\nWelcome {firstName} {lastName} ({role}) (Id:  {userId})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (role == "Student")
                                {

									MainStudentEForm mainStudentEForm = new MainStudentEForm(user);
									mainStudentEForm.Show();
									this.Hide();

								}
                                else if (role == "Instructor")
                                {
                                    MainReportsForm mainReportsForm = new MainReportsForm(user);
                                    mainReportsForm.Show();
                                    this.Hide();
                                }
                                else if(role == "Admin")
                                {
                                    AdminMainForm adminMainForm = new AdminMainForm(user);
                                    adminMainForm.Show();
                                    this.Hide();
                                }
                                else 
                                {
                                    MessageBox.Show("Invalid Role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid Email or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
