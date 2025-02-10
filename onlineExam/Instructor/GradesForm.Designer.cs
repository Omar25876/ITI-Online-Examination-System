namespace onlineExam.Instructor
{
	partial class GradesForm
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
			this.label4 = new System.Windows.Forms.Label();
			this.cboExamIdgetAllExams = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboCourseIdgetAllCourses = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboTrackIdgetAllTracks = new System.Windows.Forms.ComboBox();
			this.Student11GradesdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.StudentsdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.SaveInstructorbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Student11GradesdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(534, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Grades";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(52, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 45);
			this.label4.TabIndex = 46;
			this.label4.Text = "Exam : ";
			// 
			// cboExamIdgetAllExams
			// 
			this.cboExamIdgetAllExams.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboExamIdgetAllExams.FormattingEnabled = true;
			this.cboExamIdgetAllExams.Location = new System.Drawing.Point(280, 306);
			this.cboExamIdgetAllExams.Name = "cboExamIdgetAllExams";
			this.cboExamIdgetAllExams.Size = new System.Drawing.Size(271, 36);
			this.cboExamIdgetAllExams.TabIndex = 45;
			this.cboExamIdgetAllExams.SelectedIndexChanged += new System.EventHandler(this.cboExamIdgetAllExams_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 45);
			this.label2.TabIndex = 42;
			this.label2.Text = "Course : ";
			// 
			// cboCourseIdgetAllCourses
			// 
			this.cboCourseIdgetAllCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboCourseIdgetAllCourses.FormattingEnabled = true;
			this.cboCourseIdgetAllCourses.Location = new System.Drawing.Point(280, 206);
			this.cboCourseIdgetAllCourses.Name = "cboCourseIdgetAllCourses";
			this.cboCourseIdgetAllCourses.Size = new System.Drawing.Size(271, 36);
			this.cboCourseIdgetAllCourses.TabIndex = 41;
			this.cboCourseIdgetAllCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourseIdgetAllCourses_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(52, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 45);
			this.label5.TabIndex = 40;
			this.label5.Text = "Track : ";
			// 
			// cboTrackIdgetAllTracks
			// 
			this.cboTrackIdgetAllTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTrackIdgetAllTracks.FormattingEnabled = true;
			this.cboTrackIdgetAllTracks.Location = new System.Drawing.Point(280, 113);
			this.cboTrackIdgetAllTracks.Name = "cboTrackIdgetAllTracks";
			this.cboTrackIdgetAllTracks.Size = new System.Drawing.Size(271, 36);
			this.cboTrackIdgetAllTracks.TabIndex = 39;
			this.cboTrackIdgetAllTracks.SelectedIndexChanged += new System.EventHandler(this.cboTrackIdgetAllTracks_SelectedIndexChanged);
			// 
			// Student11GradesdataGridView1
			// 
			this.Student11GradesdataGridView1.AllowUserToAddRows = false;
			this.Student11GradesdataGridView1.AllowUserToDeleteRows = false;
			this.Student11GradesdataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.Student11GradesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Student11GradesdataGridView1.Location = new System.Drawing.Point(633, 477);
			this.Student11GradesdataGridView1.Name = "Student11GradesdataGridView1";
			this.Student11GradesdataGridView1.ReadOnly = true;
			this.Student11GradesdataGridView1.RowHeadersWidth = 51;
			this.Student11GradesdataGridView1.RowTemplate.Height = 24;
			this.Student11GradesdataGridView1.Size = new System.Drawing.Size(661, 238);
			this.Student11GradesdataGridView1.TabIndex = 50;
			this.Student11GradesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student11GradesdataGridView1_CellContentClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(832, 405);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(235, 45);
			this.label6.TabIndex = 49;
			this.label6.Text = "Student Exam";
			// 
			// StudentsdataGridView1
			// 
			this.StudentsdataGridView1.AllowUserToAddRows = false;
			this.StudentsdataGridView1.AllowUserToDeleteRows = false;
			this.StudentsdataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.StudentsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsdataGridView1.Location = new System.Drawing.Point(633, 113);
			this.StudentsdataGridView1.Name = "StudentsdataGridView1";
			this.StudentsdataGridView1.ReadOnly = true;
			this.StudentsdataGridView1.RowHeadersWidth = 51;
			this.StudentsdataGridView1.RowTemplate.Height = 24;
			this.StudentsdataGridView1.Size = new System.Drawing.Size(661, 248);
			this.StudentsdataGridView1.TabIndex = 48;
			this.StudentsdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsdataGridView1_CellContentClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(815, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(273, 45);
			this.label7.TabIndex = 47;
			this.label7.Text = "Students Grades";
			// 
			// SaveInstructorbutton
			// 
			this.SaveInstructorbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.SaveInstructorbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveInstructorbutton.ForeColor = System.Drawing.SystemColors.Control;
			this.SaveInstructorbutton.Location = new System.Drawing.Point(151, 583);
			this.SaveInstructorbutton.Name = "SaveInstructorbutton";
			this.SaveInstructorbutton.Size = new System.Drawing.Size(315, 51);
			this.SaveInstructorbutton.TabIndex = 51;
			this.SaveInstructorbutton.Text = "Show Results";
			this.SaveInstructorbutton.UseVisualStyleBackColor = false;
			this.SaveInstructorbutton.Click += new System.EventHandler(this.SaveInstructorbutton_Click);
			// 
			// GradesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 783);
			this.Controls.Add(this.SaveInstructorbutton);
			this.Controls.Add(this.Student11GradesdataGridView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.StudentsdataGridView1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboExamIdgetAllExams);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboCourseIdgetAllCourses);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboTrackIdgetAllTracks);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GradesForm";
			this.Text = "CoursesForm";
			this.Load += new System.EventHandler(this.CoursesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Student11GradesdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboExamIdgetAllExams;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboCourseIdgetAllCourses;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboTrackIdgetAllTracks;
		private System.Windows.Forms.DataGridView Student11GradesdataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView StudentsdataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button SaveInstructorbutton;
	}
}