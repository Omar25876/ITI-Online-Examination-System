using onlineExam.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace onlineExam.Instructor
{
	public partial class AddQuestionForExamsForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private int E_id;
		private string E_Name;
		User user;
		private int Track_id;
		private int Course_id;
		private int Student_id;
		public AddQuestionForExamsForm(User user)
		{
			this.user = user;
			InitializeComponent();
			LoadAllTracks();


		}
		private void LoadAllTracks()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllTracksByInsId", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@Ins_Id", user.UserId);
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						cboTrackIdgetAllTracks.DisplayMember = "T_Name";
						cboTrackIdgetAllTracks.ValueMember = "T_id";
						cboTrackIdgetAllTracks.DataSource = dt;


						if (dt.Rows.Count > 0)
						{
							Track_id = Convert.ToInt32(dt.Rows[0]["T_id"]);
							LoadAllCourses();

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading tracks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadAllCourses()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetInstructorCoursesByInsId", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@Ins_Id", user.UserId);
						cmd.Parameters.AddWithValue("@T_Id", Track_id);

						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						cboCourseIdgetAllCourses.DisplayMember = "C_Name";
						cboCourseIdgetAllCourses.ValueMember = "C_Id";
						cboCourseIdgetAllCourses.DataSource = dt;

						if (dt.Rows.Count > 0)
						{
							Course_id = Convert.ToInt32(dt.Rows[0]["C_Id"]);
							LoadExams();

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadExams()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetExamsForSpecificInstructorTrackCourse", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@T_id", Track_id);
						cmd.Parameters.AddWithValue("@C_id", Course_id);
						cmd.ExecuteNonQuery();
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);


						cboExams.DisplayMember = "E_Name";
						cboExams.ValueMember = "E_Id";
						cboExams.DataSource = dt;

						
						if (dt.Rows.Count > 0)
						{
							E_id = Convert.ToInt32(dt.Rows[0]["E_id"]);
							E_Name = Convert.ToString(dt.Rows[0]["E_Name"]);
							LoadExamWithQuestions();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading tracks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadExamWithQuestions()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand("GetExamWithQuestionsForSpecificInstructor", conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@E_id", E_id);

					try
					{
						conn.Open();
						using (SqlDataAdapter da = new SqlDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							da.Fill(dt);
							dgvExamQu.DataSource = dt;
							dgvExamQu.Columns["E_Id"].Visible = false;
							dgvExamQu.Columns["E_Id1"].Visible = false;
							dgvExamQu.Columns["Q_Id1"].Visible = false;
							dgvExamQu.Columns["Q_Id"].Visible = false;


							dgvExamQu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}


		 
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ExamsForm_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("True/False");
			comboBox1.Items.Add("MCQ");

			 
			comboBox1.SelectedIndex = 0;

			if (comboBox1.Text == "MCQ") {
				comboBox2.Items.Clear();
				comboBox2.Items.Add("A");
				comboBox2.Items.Add("B");
				comboBox2.Items.Add("C");
				comboBox2.Items.Add("D");
				comboBox2.SelectedIndex = 0;
				pChoices.Visible = true;
			}
			else if (comboBox1.Text == "True/False")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("True");
				comboBox2.Items.Add("False");
				comboBox2.SelectedIndex = 0;
				pChoices.Visible = false;
			}

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedValue = comboBox1.SelectedItem.ToString();

			 
			if (selectedValue == "True/False")
			{
			 
					comboBox2.Items.Clear();
					comboBox2.Items.Add("True");
					comboBox2.Items.Add("False");
				comboBox2.SelectedIndex = 0;

				pChoices.Visible = false;


			}
			else if (selectedValue == "MCQ")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("A");
				comboBox2.Items.Add("B");
				comboBox2.Items.Add("C");
				comboBox2.Items.Add("D");
				comboBox2.SelectedIndex = 0;
				pChoices.Visible = true;
			}
		}

		private void cboExams_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboExams.SelectedItem != null)
			{
				E_id = Convert.ToInt32(cboExams.SelectedValue);
				E_Name = cboExams.Text;
				LoadExamWithQuestions();

			}
		}

		 

		private void dgvExamQu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedValue = comboBox2.SelectedItem.ToString();

			 
		}

		private void pChoices_Paint(object sender, PaintEventArgs e)
		{
		 
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("AddQuestionWithChoices", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						int grade = Convert.ToInt32(txtGrade.Text);
						int qType = comboBox1.SelectedItem.ToString() == "True/False" ? 1 : 2;
						string question = txtQuestion.Text;
						string modelAnswer = comboBox2.SelectedItem.ToString();
						int examID = E_id;

					
						int modelAnswerIndex = comboBox2.SelectedIndex + 1;

						string choices = "";
						if (qType == 2)
						{
							if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
							{
								MessageBox.Show("Please fill all choices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}

							choices += textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + ",";
							 
							choices = choices.TrimEnd(',');
						}

					
						cmd.Parameters.AddWithValue("@Grade", grade);
						cmd.Parameters.AddWithValue("@Qtype", qType);
						cmd.Parameters.AddWithValue("@Question", question);
						cmd.Parameters.AddWithValue("@ModelAnswer", modelAnswerIndex);
						cmd.Parameters.AddWithValue("@ExamID", examID);
						cmd.Parameters.AddWithValue("@Choices", choices);
 

						cmd.ExecuteNonQuery();
					}
				}
				MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding question: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadExamWithQuestions();

			}
		}

		private void cboTrackIdgetAllTracks_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTrackIdgetAllTracks.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(cboTrackIdgetAllTracks.SelectedValue);
				LoadAllTracks();

			}
		}

		private void cboCourseIdgetAllCourses_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCourseIdgetAllCourses.SelectedValue != null)
			{
				Course_id = Convert.ToInt32(cboCourseIdgetAllCourses.SelectedValue);
				LoadExams();

			}
		}
	}
}
