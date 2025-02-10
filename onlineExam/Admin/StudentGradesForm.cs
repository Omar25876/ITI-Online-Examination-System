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

namespace onlineExam.Admin
{
	public partial class StudentGradesForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private int Branch_id;
		private int Track_id;
		private int Course_id;
		private int Exam_id;
		private int Student_id;
		public StudentGradesForm()
		{
			InitializeComponent();
			LoadAllBranches();
		}



		private void LoadAllBranches()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("SelectAllBranches", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						cboBranchIdgetAllBranches.DisplayMember = "B_Name";
						cboBranchIdgetAllBranches.ValueMember = "B_id";
						cboBranchIdgetAllBranches.DataSource = dt;

						if (dt.Rows.Count > 0)
						{
							Branch_id = Convert.ToInt32(dt.Rows[0]["B_id"]);
							LoadAllTracks();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadAllTracks()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllTracksByBranchId", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@B_Id", Branch_id);
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
					using (SqlCommand cmd = new SqlCommand("GetCoursesByTrackIdAndBranchId", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@B_Id", Branch_id);
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
							LoadAllExams();
							
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadAllExams()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetExamsForSpecificBranchTrackCourse", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@B_Id", Branch_id);
						cmd.Parameters.AddWithValue("@T_Id", Track_id);
						cmd.Parameters.AddWithValue("@C_Id", Course_id);

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
				MessageBox.Show($"Error loading exams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		private void LoadStudents()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetStudentsByBranchTrackCourseExamToGetGrades", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@B_id", Branch_id);
						cmd.Parameters.AddWithValue("@T_id", Track_id);
						cmd.Parameters.AddWithValue("@C_id", Course_id);
						cmd.Parameters.AddWithValue("@E_id", Exam_id);


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




		private void TracksForm_Load(object sender, EventArgs e)
		{

		}

		private void TracksdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

		private void cboTrackIdgetAllTracks_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTrackIdgetAllTracks.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(cboTrackIdgetAllTracks.SelectedValue);
				LoadAllTracks();
			 
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCourseIdgetAllCourses.SelectedValue != null)
			{
				Course_id = Convert.ToInt32(cboCourseIdgetAllCourses.SelectedValue);
				LoadAllExams();

			}
		}

		private void cboBranchIdgetAllBranches_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboBranchIdgetAllBranches.SelectedValue != null)
			{
				Branch_id = Convert.ToInt32(cboBranchIdgetAllBranches.SelectedValue);
				LoadAllTracks();

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

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void SaveInstructorbutton_Click(object sender, EventArgs e)
		{
			LoadStudentGrades();
		}
	}
}
