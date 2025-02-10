using onlineExam.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineExam.Instructor
{
	public partial class ReportsForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		User user;
		int ExamNumber;
		int StudentNumber;
		int CourseNumber;
		int QuestionsNumber;
		private int Course_id;
		private int Track_id;

		public ReportsForm(User user)
		{
			this.user = user;
			InitializeComponent();
			LoadExamsAndStudentsAndCourses();
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
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						CoursesdataGridView1.DataSource = dt;
						CoursesdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadExamsAndStudentsAndCourses()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllExamsAndCoursesAndStudentsForSpecificInstructor", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@Ins_Id", user.UserId);
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						if (dt.Rows.Count > 0) 
						{
							ExamNumber = Convert.ToInt32(dt.Rows[0]["Total Exams"]);
							StudentNumber = Convert.ToInt32(dt.Rows[0]["Total Students"]);
							CourseNumber = Convert.ToInt32(dt.Rows[0]["Total Courses"]);
							QuestionsNumber = Convert.ToInt32(dt.Rows[0]["Total Questions"]);
						}

						studentsLabel.Text = $"{StudentNumber.ToString()} Students";
						examsLabel.Text = $"{ExamNumber.ToString()} Exams";
						coursesLabel.Text = $"{CourseNumber.ToString()} Courses";
						questionLabel.Text = $"{QuestionsNumber.ToString()} Questions";


					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void ReportsForm_Load(object sender, EventArgs e)
		{
			label1.Text = $"Welcome, {user.FirstName} ";
		}

		private void CoursesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{

				DataGridViewRow selectedRow = CoursesdataGridView1.Rows[e.RowIndex];

				Course_id = int.Parse(selectedRow.Cells["C_Id"].Value?.ToString());

			}
		}

		private void TrackscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TrackscomboBox1.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(TrackscomboBox1.SelectedValue);

			}
		}

		private void studentsLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
