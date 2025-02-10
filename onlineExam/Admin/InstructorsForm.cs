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
	public partial class InstructorsForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private string selectedGenderValue;
		private int branchId;
		private int BranchIdForCombo;
		private int InstructorId;
		private int courseId;
		private int Track_id;
		public InstructorsForm()
		{
			InitializeComponent();
			LoadAllInstructors();
			LoadAllBranches();
			LoadAllBranchesForCombo();
			radioButton2.Visible = false;

		}
		private void LoadAllBranchesForCombo()
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
						comboBranchesBox.DisplayMember = "B_Name";
						comboBranchesBox.ValueMember = "B_Id";
						comboBranchesBox.DataSource = dt;

						if(dt.Rows.Count > 0)
						{
							BranchIdForCombo = Convert.ToInt32(dt.Rows[0]["B_Id"]);
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
						BranchesdataGridView1.DataSource = dt;
						BranchesdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
						BranchesdataGridView1.DataSource = dt;
						BranchesdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
					using (SqlCommand cmd = new SqlCommand("GetAllTracksByBranchId", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@B_Id", BranchIdForCombo);
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						TrackcomboBox1.DisplayMember = "T_Name";
						TrackcomboBox1.ValueMember = "T_id";
						TrackcomboBox1.DataSource = dt;


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


		private void GetAllInstructorsWithCourses()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllInstructorsWithCourses", conn))
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

		private void GetAllInstructorsWithBranches()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand("GetAllInstructorsWithBranches", conn))
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

		private void FNametextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void LNametextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void EmailtextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void AgenumericUpDown_ValueChanged(object sender, EventArgs e)
		{

		}

		private void GendercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedGenderValue = GendercomboBox1.SelectedItem.ToString() ?? "";
		}

		private void SalarytextBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void AddresstextBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void SaveInstructorbutton_Click(object sender, EventArgs e)
		{
			string firstName = FNametextBox1.Text.Trim();
			string lastName = LNametextBox2.Text.Trim();
			string email = EmailtextBox3.Text.Trim();
			string address = AddresstextBox5.Text.Trim();
			string phone = textBox1.Text.Trim();
			int sPhone = int.Parse(phone);
			DateTime dob = dateTimePicker1.Value;
			int age = (int)AgenumericUpDown.Value;

			
			decimal salary;
			if (!decimal.TryParse(SalarytextBox4.Text, out salary))
			{
				salary = 0m; 
			}

			try
			{
				 
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("InsertInstructor", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						cmd.Parameters.AddWithValue("@F_Name", firstName);
						cmd.Parameters.AddWithValue("@L_Name", lastName);
						cmd.Parameters.AddWithValue("@Ins_Age", age);
						cmd.Parameters.AddWithValue("@Ins_Email", email);
						cmd.Parameters.AddWithValue("@Ins_Address", address);
						cmd.Parameters.AddWithValue("@Ins_Gender", selectedGenderValue);
						cmd.Parameters.AddWithValue("@Ins_DOB", dob);
						cmd.Parameters.AddWithValue("@Ins_Salary", salary);
						cmd.Parameters.AddWithValue("@B_id", BranchIdForCombo);
						cmd.Parameters.AddWithValue("@Phone ", sPhone);
						cmd.Parameters.AddWithValue("@T_Id ", Track_id);

						object result = cmd.ExecuteScalar();

						if (result != null)
						{
							MessageBox.Show($"New Instructor ID: {result}", "Insert Successful",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}

				
				LoadAllInstructors();
				  FNametextBox1.Clear();
				  LNametextBox2.Clear();
				 EmailtextBox3.Clear();
				 AddresstextBox5.Clear();
				SalarytextBox4.Clear();
				textBox1.Clear();
				MessageBox.Show("Instructor inserted successfully!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting instructor: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InstructorsForm_Load(object sender, EventArgs e)
		{
			GendercomboBox1.Items.Add("Male");
			GendercomboBox1.Items.Add("Female");

			GendercomboBox1.SelectedIndex = 0;

			radioButton3.Checked = true;
			BranchesPanel.Visible = false;
			branchAndCourselabel10.Text = "";
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void assignTrackCourseBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand(radioButton1.Checked?"insertBranchInstructor": "insertInstructorCourse", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						if (radioButton1.Checked)
						{
							cmd.Parameters.AddWithValue("@B_Id", branchId);
							cmd.Parameters.AddWithValue("@Ins_Id", InstructorId);
						}
						else if (radioButton2.Checked)
						{
							cmd.Parameters.AddWithValue("@C_Id", courseId);
							cmd.Parameters.AddWithValue("@Ins_Id", InstructorId);
						}
					 

						cmd.ExecuteNonQuery();
					}
				}

				LoadAllInstructors();
				if (radioButton1.Checked)
					LoadAllBranches();
				else if (radioButton2.Checked)
					LoadAllBranches();

				MessageBox.Show("Instructor Assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InstructorsdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{

				DataGridViewRow selectedRow = InstructorsdataGridView1.Rows[e.RowIndex];

				InstructorId = int.Parse(selectedRow.Cells["Ins_Id"].Value?.ToString());

			}
		}

		private void BranchesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (radioButton1.Checked) 
			{
				if (e.RowIndex >= 0)
				{

					DataGridViewRow selectedRow = BranchesdataGridView1.Rows[e.RowIndex];

					branchId = int.Parse(selectedRow.Cells["B_Id"].Value?.ToString());

				}
			}
			else if(radioButton2.Checked)
			{
				if (e.RowIndex >= 0)
				{
					DataGridViewRow selectedRow = BranchesdataGridView1.Rows[e.RowIndex];
					courseId = int.Parse(selectedRow.Cells["C_Id"].Value?.ToString());
				}
			}

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				radioButton2.Checked = false;
				radioButton3.Checked = false;
				BranchesPanel.Visible = true;
				branchAndCourselabel10.Text = "Branches";
				LoadAllBranches();
				GetAllInstructorsWithBranches();

			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				radioButton1.Checked = false;
				radioButton3.Checked = false;
				branchAndCourselabel10.Text = "Courses";
				BranchesPanel.Visible = true;
				LoadAllCourses();
				GetAllInstructorsWithCourses();


			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton3.Checked)
			{
				radioButton1.Checked = false;
				radioButton2.Checked = false;
				branchAndCourselabel10.Text = "";
				BranchesPanel.Visible = false;
				LoadAllInstructors();

			}
			
		}

		private void BranchesPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void comboBranchesBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBranchesBox.SelectedItem != null)
			{
				BranchIdForCombo = Convert.ToInt32(comboBranchesBox.SelectedValue);
			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TrackcomboBox1.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(TrackcomboBox1.SelectedValue);
			 

			}
		}
	}
}
