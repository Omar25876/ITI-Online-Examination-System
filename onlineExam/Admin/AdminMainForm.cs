using onlineExam.Instructor;
using onlineExam.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineExam.Admin
{
	public partial class AdminMainForm : Form
	{
		InstructorsForm instructorsForm;
		StudentsForm studentsForm;
		CoursesAndTracksForm coursesForm;
		StudentGradesForm tracksForm;
		BranchesForm branchesForm;
		User user;
		public AdminMainForm(User user)
		{
			this.user = user;
			InitializeComponent();
			AdminLabel.Text = $"{user.FirstName} {user.LastName} ";
		}
		private void ShowForm(Form form)
		{
			panelContent11.Controls.Clear();
			panelContent11.Controls.Add(form);
			form.Show();
		}
		private void panelContent_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StudentGradesForm tracksForm1 = new StudentGradesForm() { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(tracksForm1);
		}

		private void dashbordbtn_Click(object sender, EventArgs e)
		{
			InstructorsForm instructorsForm1 = new InstructorsForm() { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(instructorsForm1);
		}

		private void studentsbtn_Click(object sender, EventArgs e)
		{
			StudentsForm studentsForm1 = new StudentsForm() { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(studentsForm1);
		}

		private void coursesbtn_Click(object sender, EventArgs e)
		{
			CoursesAndTracksForm coursesForm1 = new CoursesAndTracksForm() { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(coursesForm1);
		}

		private void branchesBtn_Click(object sender, EventArgs e)
		{
			BranchesForm branchesForm1 = new BranchesForm() { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(branchesForm1);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void AdminMainForm_Load(object sender, EventArgs e)
		{
			instructorsForm = new InstructorsForm() { TopLevel = false, Dock = DockStyle.Fill };
			coursesForm = new CoursesAndTracksForm() { TopLevel = false, Dock = DockStyle.Fill };
			studentsForm = new StudentsForm() { TopLevel = false, Dock = DockStyle.Fill };
			tracksForm = new StudentGradesForm() { TopLevel = false, Dock = DockStyle.Fill };
			branchesForm = new BranchesForm() { TopLevel = false, Dock = DockStyle.Fill };

			ShowForm(instructorsForm);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
			this.Hide();
		}
	}
}
