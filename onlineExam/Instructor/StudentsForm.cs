using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using onlineExam.models;

namespace onlineExam.Instructor
{
	public partial class StudentsForm : Form
	{
		private readonly string connectionString = ConfigurationManager.ConnectionStrings["OnlineExaminationDBConnection"].ConnectionString;
		private int Course_id;
		private int Track_id;
		private string Course_Name;
		User user;
		public StudentsForm(User user)
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


						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						cboTrackIdgetAllTracks.DisplayMember = "C_Name";   
						cboTrackIdgetAllTracks.ValueMember = "C_Id";   
						cboTrackIdgetAllTracks.DataSource = dt;

						if (dt.Rows.Count > 0)
						{
							Course_id = Convert.ToInt32(dt.Rows[0]["C_Id"]); 
							LoadStudents();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadStudents()
		{
			try
			{
				if (Course_id == 0 || user == null || user.UserId == 0)
				{
					MessageBox.Show("Invalid Course or Instructor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open(); 

					using (SqlCommand cmd = new SqlCommand("GetAllStudentsReportWithCourseId", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@C_id", Course_id); 
						cmd.Parameters.AddWithValue("@Ins_id", user.UserId);

						using (SqlDataAdapter da = new SqlDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							da.Fill(dt);
							dgvStudents.DataSource = dt;
							dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void StudentsForm_Load(object sender, EventArgs e)
		{

		}

		private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void cboTrackIdgetAllTracks_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTrackIdgetAllTracks.SelectedValue != null)
			{
				Course_id = Convert.ToInt32(cboTrackIdgetAllTracks.SelectedValue);
				LoadStudents();
			}
		}

		private void TrackscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TrackscomboBox1.SelectedValue != null)
			{
				Track_id = Convert.ToInt32(TrackscomboBox1.SelectedValue);

			}
		}
	}
}
