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

namespace onlineExam.Admin
{
	public partial class BranchesForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private int Track_id = 0;
		private int Branch_id = 0;
		public BranchesForm()
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
						BranchesdataGridView1.DataSource = dt;
						BranchesdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

						if(dt.Rows.Count > 0)
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
					using (SqlCommand cmd = new SqlCommand("GetAllTracksWithCourses", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						TracksdataGridView1.DataSource = dt;
						TracksdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

						if(dt.Rows.Count > 0)
						{
							Track_id = Convert.ToInt32(dt.Rows[0]["T_Id"]);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading Branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}






		private void label2_Click(object sender, EventArgs e)
		{

		}


		private void BranchesForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// 1. Gather data from form controls
			string branchName = BNametextBox1.Text.Trim();
			string branchLocation = BLocationtextBox1.Text.Trim();
			string branchPhone = BPhonetextBox2.Text.Trim();


			try
			{

				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("InsertBranch", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						cmd.Parameters.AddWithValue("@name", branchName);
						cmd.Parameters.AddWithValue("@location", branchLocation);
						cmd.Parameters.AddWithValue("@phone", branchPhone);
					 
						object result = cmd.ExecuteScalar();

						if (result != null)
						{
						
							MessageBox.Show($"New Branch", "Insert Successful",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				LoadAllBranches();
				BNametextBox1.Clear();
				BLocationtextBox1.Clear();
				BPhonetextBox2.Clear();

				MessageBox.Show("Branch inserted successfully!", "Success",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				

			}
			catch (Exception ex)
			{
				// Handle or log errors as needed
				MessageBox.Show($"Error inserting Branch: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
}

		private void BranchesdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = BranchesdataGridView1.Rows[e.RowIndex];

				if (selectedRow.Cells["B_Id"].Value != null)
				{
					if (int.TryParse(selectedRow.Cells["B_Id"].Value.ToString(), out int branchIdd))
					{
						Branch_id = branchIdd;
						MessageBox.Show($"Selected Branch ID: {Branch_id}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Invalid Branch ID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
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

		private void assignTrackCourseBtn_Click(object sender, EventArgs e)
		{
			if (Track_id == 0 )
			{
				MessageBox.Show("Please select a Track, Course and Instructor to assign", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("online_BranchTrack_Insert", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@B_id_fk", Branch_id);
						cmd.Parameters.AddWithValue("@T_Id_fk", Track_id);
						 

						cmd.ExecuteNonQuery();
					}
				}

				LoadAllBranches();
				 
			 

				MessageBox.Show("Branch And Track inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting Track: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

