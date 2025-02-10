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

namespace onlineExam.Instructor
{
	public partial class MainReportsForm : Form
	{
		User user;
		StudentsForm studentsForm;
		AddQuestionForExamsForm examsForm;
		GradesForm coursesForm;
		ReportsForm reportsForm;
		AddExamForm addExamForm;
		public MainReportsForm(User user)
		{
			this.user = user;
			InitializeComponent();
			instructorLabel.Text = $"{user.FirstName} {user.LastName} ";


		}


		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

	 

		private void MainReportsForm_Load(object sender, EventArgs e)
		{

			reportsForm = new ReportsForm(user) { TopLevel = false, Dock = DockStyle.Fill };

			studentsForm = new StudentsForm(user) { TopLevel = false, Dock = DockStyle.Fill };
			examsForm = new AddQuestionForExamsForm(user) { TopLevel = false, Dock = DockStyle.Fill };
			coursesForm = new GradesForm(user) { TopLevel = false, Dock = DockStyle.Fill };
			addExamForm = new AddExamForm(user) { TopLevel = false, Dock = DockStyle.Fill };

			ShowForm(reportsForm); 
		}
		bool sidebarExpand = false;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (sidebarExpand)
			{
				sidebar.Width -= 10;
				if (sidebar.Width <= 85) {
					sidebarExpand = false;
					sidebarTransition.Stop();
				}
				else
				{
					sidebar.Width += 10;
					if (sidebar.Width >= 251) {
						sidebarExpand = true;
						sidebarTransition.Stop();
					}
				}
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			sidebarTransition.Start();
		}

		private void sidebar_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ShowForm(Form form)
		{
			panelContent.Controls.Clear(); 
			panelContent.Controls.Add(form);
			form.Show();
		}

		private void studentsbtn_Click(object sender, EventArgs e)
		{
			ShowForm(studentsForm);
		}

		private void coursesbtn_Click(object sender, EventArgs e)
		{
			ShowForm(coursesForm);
		}

		private void examsbtn_Click(object sender, EventArgs e)
		{

			AddQuestionForExamsForm examsForm1 = new AddQuestionForExamsForm(user) { TopLevel = false, Dock = DockStyle.Fill };
			ShowForm(examsForm1);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panelContent_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void dashbordbtn_Click(object sender, EventArgs e)
		{
			ShowForm(reportsForm);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowForm(addExamForm);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
			this.Hide();
		}

		private void panelContent_Paint_1(object sender, PaintEventArgs e)
		{

		}
	}
}
