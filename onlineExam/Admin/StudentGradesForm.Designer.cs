namespace onlineExam.Admin
{
	partial class StudentGradesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.StudentsdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.cboTrackIdgetAllTracks = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboCourseIdgetAllCourses = new System.Windows.Forms.ComboBox();
			this.SaveInstructorbutton = new System.Windows.Forms.Button();
			this.cboBranchIdgetAllBranches = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboExamIdgetAllExams = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Student11GradesdataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Student11GradesdataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(790, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 54);
			this.label1.TabIndex = 3;
			this.label1.Text = "Students Grades";
			// 
			// StudentsdataGridView1
			// 
			this.StudentsdataGridView1.AllowUserToAddRows = false;
			this.StudentsdataGridView1.AllowUserToDeleteRows = false;
			this.StudentsdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.StudentsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsdataGridView1.Location = new System.Drawing.Point(623, 82);
			this.StudentsdataGridView1.Name = "StudentsdataGridView1";
			this.StudentsdataGridView1.ReadOnly = true;
			this.StudentsdataGridView1.RowHeadersWidth = 51;
			this.StudentsdataGridView1.RowTemplate.Height = 24;
			this.StudentsdataGridView1.Size = new System.Drawing.Size(661, 219);
			this.StudentsdataGridView1.TabIndex = 13;
			this.StudentsdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TracksdataGridView1_CellContentClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(30, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 45);
			this.label5.TabIndex = 15;
			this.label5.Text = "Track : ";
			// 
			// cboTrackIdgetAllTracks
			// 
			this.cboTrackIdgetAllTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTrackIdgetAllTracks.FormattingEnabled = true;
			this.cboTrackIdgetAllTracks.Location = new System.Drawing.Point(258, 157);
			this.cboTrackIdgetAllTracks.Name = "cboTrackIdgetAllTracks";
			this.cboTrackIdgetAllTracks.Size = new System.Drawing.Size(271, 36);
			this.cboTrackIdgetAllTracks.TabIndex = 14;
			this.cboTrackIdgetAllTracks.SelectedIndexChanged += new System.EventHandler(this.cboTrackIdgetAllTracks_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 45);
			this.label2.TabIndex = 17;
			this.label2.Text = "Course : ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// cboCourseIdgetAllCourses
			// 
			this.cboCourseIdgetAllCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboCourseIdgetAllCourses.FormattingEnabled = true;
			this.cboCourseIdgetAllCourses.Location = new System.Drawing.Point(258, 250);
			this.cboCourseIdgetAllCourses.Name = "cboCourseIdgetAllCourses";
			this.cboCourseIdgetAllCourses.Size = new System.Drawing.Size(271, 36);
			this.cboCourseIdgetAllCourses.TabIndex = 16;
			this.cboCourseIdgetAllCourses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// SaveInstructorbutton
			// 
			this.SaveInstructorbutton.BackColor = System.Drawing.Color.Black;
			this.SaveInstructorbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveInstructorbutton.ForeColor = System.Drawing.SystemColors.Control;
			this.SaveInstructorbutton.Location = new System.Drawing.Point(169, 609);
			this.SaveInstructorbutton.Name = "SaveInstructorbutton";
			this.SaveInstructorbutton.Size = new System.Drawing.Size(315, 51);
			this.SaveInstructorbutton.TabIndex = 34;
			this.SaveInstructorbutton.Text = "Show Results";
			this.SaveInstructorbutton.UseVisualStyleBackColor = false;
			this.SaveInstructorbutton.Click += new System.EventHandler(this.SaveInstructorbutton_Click);
			// 
			// cboBranchIdgetAllBranches
			// 
			this.cboBranchIdgetAllBranches.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboBranchIdgetAllBranches.FormattingEnabled = true;
			this.cboBranchIdgetAllBranches.Location = new System.Drawing.Point(258, 71);
			this.cboBranchIdgetAllBranches.Name = "cboBranchIdgetAllBranches";
			this.cboBranchIdgetAllBranches.Size = new System.Drawing.Size(271, 36);
			this.cboBranchIdgetAllBranches.TabIndex = 35;
			this.cboBranchIdgetAllBranches.SelectedIndexChanged += new System.EventHandler(this.cboBranchIdgetAllBranches_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 45);
			this.label3.TabIndex = 36;
			this.label3.Text = "Branch : ";
			// 
			// cboExamIdgetAllExams
			// 
			this.cboExamIdgetAllExams.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboExamIdgetAllExams.FormattingEnabled = true;
			this.cboExamIdgetAllExams.Location = new System.Drawing.Point(258, 350);
			this.cboExamIdgetAllExams.Name = "cboExamIdgetAllExams";
			this.cboExamIdgetAllExams.Size = new System.Drawing.Size(271, 36);
			this.cboExamIdgetAllExams.TabIndex = 37;
			this.cboExamIdgetAllExams.SelectedIndexChanged += new System.EventHandler(this.cboExamIdgetAllExams_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 45);
			this.label4.TabIndex = 38;
			this.label4.Text = "Exam : ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(790, 350);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(284, 54);
			this.label6.TabIndex = 39;
			this.label6.Text = "Student Exam";
			// 
			// Student11GradesdataGridView1
			// 
			this.Student11GradesdataGridView1.AllowUserToAddRows = false;
			this.Student11GradesdataGridView1.AllowUserToDeleteRows = false;
			this.Student11GradesdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.Student11GradesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Student11GradesdataGridView1.Location = new System.Drawing.Point(623, 441);
			this.Student11GradesdataGridView1.Name = "Student11GradesdataGridView1";
			this.Student11GradesdataGridView1.ReadOnly = true;
			this.Student11GradesdataGridView1.RowHeadersWidth = 51;
			this.Student11GradesdataGridView1.RowTemplate.Height = 24;
			this.Student11GradesdataGridView1.Size = new System.Drawing.Size(661, 219);
			this.Student11GradesdataGridView1.TabIndex = 40;
			this.Student11GradesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// StudentGradesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 725);
			this.Controls.Add(this.Student11GradesdataGridView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboExamIdgetAllExams);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboBranchIdgetAllBranches);
			this.Controls.Add(this.SaveInstructorbutton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboCourseIdgetAllCourses);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboTrackIdgetAllTracks);
			this.Controls.Add(this.StudentsdataGridView1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentGradesForm";
			this.Text = "TracksForm";
			this.Load += new System.EventHandler(this.TracksForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Student11GradesdataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView StudentsdataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboTrackIdgetAllTracks;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboCourseIdgetAllCourses;
		private System.Windows.Forms.Button SaveInstructorbutton;
		private System.Windows.Forms.ComboBox cboBranchIdgetAllBranches;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboExamIdgetAllExams;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView Student11GradesdataGridView1;
	}
}