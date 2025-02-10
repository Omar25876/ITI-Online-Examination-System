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
	public partial class CoursesAndTracksForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private int Track_id = 0;
		private int Course_id = 0;
		private int Ins_id = 0;
		 
		public CoursesAndTracksForm()
		{
		 
			InitializeComponent();
			LoadAllCourses();
			LoadAllTracks();
			LoadAllInstructors();
		}

		private void LoadAllInstructors()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllInstructors", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						InstructorsdataGridView1.DataSource = dt;
						InstructorsdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading instructors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadAllTracks()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllTracksWithCourses", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						TracksdataGridView1.DataSource = dt;
						TracksdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadAllCourses()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllCoursesWithTracks", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
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
				MessageBox.Show($"Error loading Branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void CoursesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = CoursesdataGridView1.Rows[e.RowIndex];

				if (selectedRow.Cells["C_Id"].Value != null)
				{
					if (int.TryParse(selectedRow.Cells["C_Id"].Value.ToString(), out int courseId))
					{
						Course_id = courseId;
						MessageBox.Show($"Selected Course ID: {Course_id}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Invalid Course ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}



		private void CoursesForm_Load(object sender, EventArgs e)
		{

		}

		private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
		{

		}

		private void BNametextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		 

	 

		private void saveBtn_Click(object sender, EventArgs e)
		{
			string cName = CNametextBox1.Text.Trim();
			int cDuration = (int)AgenumericUpDown.Value;
			string courseDuration = cDuration.ToString();


			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("insertcourse", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@C_Name", cName);
						cmd.Parameters.AddWithValue("@C_Duration", courseDuration);

						cmd.ExecuteNonQuery();
					}
				}
				LoadAllCourses();
			 
				MessageBox.Show("Course inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting Course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveTrackBtn_Click(object sender, EventArgs e)
		{
			string tName = TNametextBox1.Text.Trim();
			 


			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("online_Track_Insert", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@T_name", tName);
					

						cmd.ExecuteNonQuery();
					}
				}
				LoadAllTracks();

				MessageBox.Show("Track inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting Track: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void assignTrackCourseBtn_Click_1(object sender, EventArgs e)
		{ 
			if(Track_id == 0 || Course_id == 0 || Ins_id == 0)
			{
				MessageBox.Show("Please select a Track, Course and Instructor to assign", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("insertTrackCourse", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@T_id", Track_id);
						cmd.Parameters.AddWithValue("@C_Id", Course_id);
						cmd.Parameters.AddWithValue("@Ins_Id", Ins_id);

						cmd.ExecuteNonQuery();
					}
				}
				LoadAllTracks();
				LoadAllCourses();

				MessageBox.Show("Track And Course inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting Track: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TracksdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = TracksdataGridView1.Rows[e.RowIndex];

				if (selectedRow.Cells["T_Id"].Value != null)
				{
					if (int.TryParse(selectedRow.Cells["T_Id"].Value.ToString(), out int trackId))
					{
						Track_id = trackId;
						MessageBox.Show($"Selected Track ID: {Track_id}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Invalid Track ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}


		private void AgenumericUpDown_ValueChanged(object sender, EventArgs e)
		{

		}

		private void InstructorsdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = InstructorsdataGridView1.Rows[e.RowIndex]; 

				if (selectedRow.Cells["Ins_Id"].Value != null)  
				{
					if (int.TryParse(selectedRow.Cells["Ins_Id"].Value.ToString(), out int instructorId))
					{
						Ins_id = instructorId;  
						MessageBox.Show($"Selected Instructor ID: {Ins_id}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Invalid Instructor ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

	}
}
