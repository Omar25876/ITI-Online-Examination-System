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

namespace onlineExam.Instructor
{
	public partial class AddExamForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		User user;
		private int Course_id;
		private int Track_id;
		public AddExamForm(User user)
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
						TrackscomboBox1.DisplayMember = "T_Name";
						TrackscomboBox1.ValueMember = "T_id";
						TrackscomboBox1.DataSource = dt;


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
						cmd.ExecuteNonQuery();
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						cboCourseIdgetAllCourses.DisplayMember = "C_Name";
						cboCourseIdgetAllCourses.ValueMember = "C_id";
						cboCourseIdgetAllCourses.DataSource = dt;

						if (dt.Rows.Count > 0)
						{
							Course_id = Convert.ToInt32(dt.Rows[0]["C_id"]);
							LoadExams();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

						dataGridView1.DataSource = dt;


						dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


						 
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading tracks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}







		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void AddExamForm_Load(object sender, EventArgs e)
		{

		}

		private void examNametextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void totalScoretextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void DurationExamnumericUpDown_ValueChanged(object sender, EventArgs e)
		{

		}

		private void ExamdateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void SaveExamBtn_Click(object sender, EventArgs e)
		{
			string examName = examNametextBox.Text.Trim();

			int totalScore;
			if (!int.TryParse(totalScoretextBox.Text, out totalScore))
			{
				totalScore = 0;  
			}

			float duration = (float)DurationExamnumericUpDown.Value;

			DateTime examDate = ExamdateTimePicker.Value;

			try
			{
				
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

			 
					using (SqlCommand cmd = new SqlCommand("InsertExam", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;

					 
						cmd.Parameters.AddWithValue("@E_Name", examName);
						cmd.Parameters.AddWithValue("@E_Total_Score", totalScore);
						cmd.Parameters.AddWithValue("@E_Duration", duration);
						cmd.Parameters.AddWithValue("@E_Date", examDate);
						cmd.Parameters.AddWithValue("@Ins_Id", user.UserId);
						cmd.Parameters.AddWithValue("@C_Id", Course_id);
						cmd.Parameters.AddWithValue("@T_Id", Track_id);

					 
						cmd.ExecuteNonQuery();
					}
				}

				LoadExams();

				MessageBox.Show("Exam inserted successfully!", "Success",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Handle errors (e.g., show an error message)
				MessageBox.Show($"Error inserting exam: {ex.Message}", "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TrackscomboBox1.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(TrackscomboBox1.SelectedValue);
				LoadAllTracks();

			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
