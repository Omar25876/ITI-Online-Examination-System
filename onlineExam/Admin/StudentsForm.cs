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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace onlineExam.Admin
{
	public partial class StudentsForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private int Track_id;
		private string selectedGenderValue;
		private int courseId = 0 ;
		private int studentId = 0 ;
		public StudentsForm()
		{
			InitializeComponent();
			LoadAllStudents();
			LoadAllTracks();
			BranchesPanel.Visible = false;
			radioButton3.Checked = true;
		}

		private void GetAllStudentsWithCourses()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllStudentsWithCourses", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						StudentsdataGridView1.DataSource = dt;
						StudentsdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

						if (dt.Rows.Count > 0)
						{
							studentId = Convert.ToInt32(dt.Rows[0]["St_Id"]);

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show($"Error loading Courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadAllTracks()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("online_Track_SelectAll", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						cboTrackIdgetAllTracks.DisplayMember = "T_Name";
						cboTrackIdgetAllTracks.ValueMember = "T_id";
						cboTrackIdgetAllTracks.DataSource = dt;

					 
						if (dt.Rows.Count > 0)
						{
							Track_id = Convert.ToInt32(dt.Rows[0]["T_id"]);
							
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading tracks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		 
		private void LoadAllStudents()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("SelectAllStudents", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						StudentsdataGridView1.DataSource = dt;
						StudentsdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


						if (dt.Rows.Count > 0)
						{
							studentId = Convert.ToInt32(dt.Rows[0]["St_Id"]);

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void StudentsForm_Load(object sender, EventArgs e)
		{

			GendercomboBox1.Items.Add("Male");
			GendercomboBox1.Items.Add("Female");

			GendercomboBox1.SelectedIndex = 0;

		}

		private void TrackcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTrackIdgetAllTracks.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(cboTrackIdgetAllTracks.SelectedValue);
				 
			}
		}

	 
		private void SaveStudentButn_Click(object sender, EventArgs e)
		{
			string fName = FNametextBox1.Text.Trim();
			string lName = LNametextBox2.Text.Trim();
			string email = EmailtextBox1.Text.Trim();
			string address = AddresstextBox2.Text.Trim();
			string phone = textBox1.Text.Trim();
			int stPhone = Convert.ToInt32(phone);

			DateTime dob = dateTimePicker1.Value;

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("InsertStudent", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@fName", fName);
						cmd.Parameters.AddWithValue("@lName", lName);
						cmd.Parameters.AddWithValue("@email", email);
						cmd.Parameters.AddWithValue("@trackId", Track_id);
						cmd.Parameters.AddWithValue("@dob", dob);
						cmd.Parameters.AddWithValue("@address", address);
						cmd.Parameters.AddWithValue("@gender", selectedGenderValue);					
						cmd.Parameters.AddWithValue("@Phone", stPhone);					

						cmd.ExecuteNonQuery();
					}
				}
				LoadAllStudents();
				  FNametextBox1.Clear();
				 LNametextBox2.Clear();
				EmailtextBox1.Clear();
				AddresstextBox2.Clear();
				textBox1.Clear();
				MessageBox.Show("Student inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	 
		private void FNametextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void LNametextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void GendercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			 selectedGenderValue = GendercomboBox1.SelectedItem.ToString() ?? "";

		}

		private void AddresstextBox2_TextChanged(object sender, EventArgs e)
		{

		}

	

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				radioButton2.Checked = false;
				branchAndCourselabel10.Text = "";
				BranchesPanel.Visible = false;
				LoadAllStudents();

			}
		}


		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				 
				radioButton3.Checked = false;
				branchAndCourselabel10.Text = "Courses";
				BranchesPanel.Visible = true;
				LoadAllCourses();
				GetAllStudentsWithCourses();


			}
		}

		private void assignTrackCourseBtn_Click(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{

				MessageBox.Show("Please select a course to assign", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (courseId == 0 || studentId ==0)
			{
				MessageBox.Show("Please select a course and student to assign", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("InsertStudentsWithCourse", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						
							cmd.Parameters.AddWithValue("@St_Id", studentId );
							cmd.Parameters.AddWithValue("@C_Id", courseId);
						 


						cmd.ExecuteNonQuery();
					}
				}


				GetAllStudentsWithCourses();
				 

				MessageBox.Show("Student Assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void StudentsdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = StudentsdataGridView1.Rows[e.RowIndex];

				if (selectedRow.Cells["St_Id"].Value != null)
				{
					if (int.TryParse(selectedRow.Cells["St_Id"].Value.ToString(), out int st_id))
					{
						studentId = st_id;
						MessageBox.Show($"Selected Student ID: {studentId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Invalid Student ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void BranchesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (radioButton2.Checked)
			{

				if (e.RowIndex >= 0)
				{
					DataGridViewRow selectedRow = CoursesdataGridView1.Rows[e.RowIndex];

					if (selectedRow.Cells["C_Id"].Value != null)
					{
						if (int.TryParse(selectedRow.Cells["C_Id"].Value.ToString(), out int course_Id))
						{
							courseId = course_Id;
							MessageBox.Show($"Selected Course ID: {courseId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Invalid Course ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}
	}
}
