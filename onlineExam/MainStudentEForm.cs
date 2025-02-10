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
using WindowsFormsApp;

namespace onlineExam
{
	public partial class MainStudentEForm : Form
	{
		User user;
		ExamsForm examsForm;
		ExamsDetails examsDetails;
		ResultForm resultForm;
		ReviewForm reviewForm;

		public MainStudentEForm(User user)
		{
			this.user = user;
			InitializeComponent();
			instructorLabel.Text = $"{user.FirstName} {user.LastName} ";
		}
		private void ShowForm(Form form)
		{
			panelContent.Controls.Clear();
			panelContent.Controls.Add(form);
			form.Show();
		}


		private void panelContent_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
			this.Hide();
		}

		private void MainStudentEForm_Load(object sender, EventArgs e)
		{
			examsForm =new ExamsForm(user,panelContent) { TopLevel = false, Dock = DockStyle.Fill };
			   

			ShowForm(examsForm);
		}

		private void sidebar_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
