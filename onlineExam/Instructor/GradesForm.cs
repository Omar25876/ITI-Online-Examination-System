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
	public partial class GradesForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
	
		User user;
		 
		private int Track_id;
		private int Course_id;
		private int Exam_id;
		private int Student_id;
		public GradesForm(User user)
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


						cboExamIdgetAllExams.DisplayMember = "E_Name";
						cboExamIdgetAllExams.ValueMember = "E_Id";
						cboExamIdgetAllExams.DataSource = dt;


						if (dt.Rows.Count > 0)
						{
							Exam_id = Convert.ToInt32(dt.Rows[0]["E_Id"]);
							LoadStudents();

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading tracks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	 
	 
	 


		private void LoadStudents()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetStudentsByInstructorTrackCourseExamToGetGrades", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@E_id", Exam_id);
						cmd.ExecuteNonQuery();

						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						StudentsdataGridView1.DataSource = dt;
						StudentsdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

						if (dt.Rows.Count > 0)
						{
							Student_id = Convert.ToInt32(dt.Rows[0]["ST_id"]);
							LoadStudentGrades();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void LoadStudentGrades()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("ModelAnswer", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@ExamID", Exam_id);
						cmd.Parameters.AddWithValue("@StudentID", Student_id);

						cmd.ExecuteNonQuery();
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						Student11GradesdataGridView1.DataSource = dt;
						Student11GradesdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Student Greads: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		private void CoursesForm_Load(object sender, EventArgs e)
		{

		}

		private void cboBranchIdgetAllBranches_SelectedIndexChanged(object sender, EventArgs e)
		{
			 
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

		private void cboExamIdgetAllExams_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboExamIdgetAllExams.SelectedValue != null)
			{
				Exam_id = Convert.ToInt32(cboExamIdgetAllExams.SelectedValue);
				LoadStudents();

			}
		}

		private void StudentsdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = StudentsdataGridView1.Rows[e.RowIndex];

				if (selectedRow.Cells["ST_Id"].Value != null)
				{
					if (int.TryParse(selectedRow.Cells["ST_Id"].Value.ToString(), out int stu_id))
					{
						Student_id = stu_id;
						MessageBox.Show($"Selected Student ID: {Student_id}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Invalid Student ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void SaveInstructorbutton_Click(object sender, EventArgs e)
		{
			LoadStudentGrades();
		}

		private void Student11GradesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
