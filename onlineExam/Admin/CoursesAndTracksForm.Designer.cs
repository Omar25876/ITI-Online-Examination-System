namespace onlineExam.Admin
{
	partial class CoursesAndTracksForm
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
			this.CoursesdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.CNametextBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TracksdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TNametextBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.saveCourseBtn = new System.Windows.Forms.Button();
			this.SaveTrackBtn = new System.Windows.Forms.Button();
			this.AgenumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.assignTrackCourseBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.InstructorsdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.CoursesdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TracksdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InstructorsdataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(921, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Courses";
			// 
			// CoursesdataGridView1
			// 
			this.CoursesdataGridView1.AllowUserToAddRows = false;
			this.CoursesdataGridView1.AllowUserToDeleteRows = false;
			this.CoursesdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.CoursesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CoursesdataGridView1.Location = new System.Drawing.Point(607, 262);
			this.CoursesdataGridView1.Name = "CoursesdataGridView1";
			this.CoursesdataGridView1.ReadOnly = true;
			this.CoursesdataGridView1.RowHeadersWidth = 51;
			this.CoursesdataGridView1.RowTemplate.Height = 24;
			this.CoursesdataGridView1.Size = new System.Drawing.Size(690, 193);
			this.CoursesdataGridView1.TabIndex = 3;
			this.CoursesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesdataGridView1_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 31);
			this.label2.TabIndex = 10;
			this.label2.Text = "Course Name :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// CNametextBox1
			// 
			this.CNametextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CNametextBox1.Location = new System.Drawing.Point(278, 280);
			this.CNametextBox1.Multiline = true;
			this.CNametextBox1.Name = "CNametextBox1";
			this.CNametextBox1.Size = new System.Drawing.Size(294, 34);
			this.CNametextBox1.TabIndex = 9;
			this.CNametextBox1.TextChanged += new System.EventHandler(this.BNametextBox1_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(35, 357);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(201, 31);
			this.label3.TabIndex = 12;
			this.label3.Text = "Course Duration :";
			// 
			// TracksdataGridView1
			// 
			this.TracksdataGridView1.AllowUserToAddRows = false;
			this.TracksdataGridView1.AllowUserToDeleteRows = false;
			this.TracksdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.TracksdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TracksdataGridView1.Location = new System.Drawing.Point(607, 603);
			this.TracksdataGridView1.Name = "TracksdataGridView1";
			this.TracksdataGridView1.ReadOnly = true;
			this.TracksdataGridView1.RowHeadersWidth = 51;
			this.TracksdataGridView1.RowTemplate.Height = 24;
			this.TracksdataGridView1.Size = new System.Drawing.Size(690, 188);
			this.TracksdataGridView1.TabIndex = 14;
			this.TracksdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TracksdataGridView1_CellContentClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(902, 543);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 41);
			this.label4.TabIndex = 15;
			this.label4.Text = "Tracks";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(153, 543);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(232, 41);
			this.label6.TabIndex = 17;
			this.label6.Text = "Add New Track";
			// 
			// TNametextBox1
			// 
			this.TNametextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TNametextBox1.Location = new System.Drawing.Point(278, 619);
			this.TNametextBox1.Multiline = true;
			this.TNametextBox1.Name = "TNametextBox1";
			this.TNametextBox1.Size = new System.Drawing.Size(294, 34);
			this.TNametextBox1.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(62, 619);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(151, 31);
			this.label7.TabIndex = 19;
			this.label7.Text = "Track Name :";
			// 
			// saveCourseBtn
			// 
			this.saveCourseBtn.BackColor = System.Drawing.Color.Black;
			this.saveCourseBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveCourseBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.saveCourseBtn.Location = new System.Drawing.Point(123, 467);
			this.saveCourseBtn.Name = "saveCourseBtn";
			this.saveCourseBtn.Size = new System.Drawing.Size(354, 54);
			this.saveCourseBtn.TabIndex = 20;
			this.saveCourseBtn.Text = "Save";
			this.saveCourseBtn.UseVisualStyleBackColor = false;
			this.saveCourseBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// SaveTrackBtn
			// 
			this.SaveTrackBtn.BackColor = System.Drawing.Color.Black;
			this.SaveTrackBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveTrackBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.SaveTrackBtn.Location = new System.Drawing.Point(123, 718);
			this.SaveTrackBtn.Name = "SaveTrackBtn";
			this.SaveTrackBtn.Size = new System.Drawing.Size(354, 57);
			this.SaveTrackBtn.TabIndex = 21;
			this.SaveTrackBtn.Text = "Save";
			this.SaveTrackBtn.UseVisualStyleBackColor = false;
			this.SaveTrackBtn.Click += new System.EventHandler(this.SaveTrackBtn_Click);
			// 
			// AgenumericUpDown
			// 
			this.AgenumericUpDown.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgenumericUpDown.Location = new System.Drawing.Point(278, 350);
			this.AgenumericUpDown.Name = "AgenumericUpDown";
			this.AgenumericUpDown.Size = new System.Drawing.Size(294, 38);
			this.AgenumericUpDown.TabIndex = 27;
			this.AgenumericUpDown.ValueChanged += new System.EventHandler(this.AgenumericUpDown_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(132, 218);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(253, 41);
			this.label5.TabIndex = 28;
			this.label5.Text = "Add New Course";
			// 
			// assignTrackCourseBtn
			// 
			this.assignTrackCourseBtn.BackColor = System.Drawing.Color.Black;
			this.assignTrackCourseBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignTrackCourseBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.assignTrackCourseBtn.Location = new System.Drawing.Point(812, 464);
			this.assignTrackCourseBtn.Name = "assignTrackCourseBtn";
			this.assignTrackCourseBtn.Size = new System.Drawing.Size(361, 60);
			this.assignTrackCourseBtn.TabIndex = 29;
			this.assignTrackCourseBtn.Text = "Assign";
			this.assignTrackCourseBtn.UseVisualStyleBackColor = false;
			this.assignTrackCourseBtn.Click += new System.EventHandler(this.assignTrackCourseBtn_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(-1, 530);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1573, 10);
			this.panel1.TabIndex = 30;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(-1, 205);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1573, 10);
			this.panel2.TabIndex = 31;
			// 
			// InstructorsdataGridView1
			// 
			this.InstructorsdataGridView1.AllowUserToAddRows = false;
			this.InstructorsdataGridView1.AllowUserToDeleteRows = false;
			this.InstructorsdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.InstructorsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InstructorsdataGridView1.Location = new System.Drawing.Point(413, 12);
			this.InstructorsdataGridView1.Name = "InstructorsdataGridView1";
			this.InstructorsdataGridView1.ReadOnly = true;
			this.InstructorsdataGridView1.RowHeadersWidth = 51;
			this.InstructorsdataGridView1.RowTemplate.Height = 24;
			this.InstructorsdataGridView1.Size = new System.Drawing.Size(884, 187);
			this.InstructorsdataGridView1.TabIndex = 32;
			this.InstructorsdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstructorsdataGridView1_CellContentClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(59, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(227, 54);
			this.label8.TabIndex = 33;
			this.label8.Text = "Instructors";
			// 
			// CoursesAndTracksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1554, 1028);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.InstructorsdataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.assignTrackCourseBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.AgenumericUpDown);
			this.Controls.Add(this.SaveTrackBtn);
			this.Controls.Add(this.saveCourseBtn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TNametextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TracksdataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CNametextBox1);
			this.Controls.Add(this.CoursesdataGridView1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CoursesAndTracksForm";
			this.Text = "CoursesForm";
			this.Load += new System.EventHandler(this.CoursesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.CoursesdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TracksdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InstructorsdataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView CoursesdataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CNametextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView TracksdataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TNametextBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button saveCourseBtn;
		private System.Windows.Forms.Button SaveTrackBtn;
		private System.Windows.Forms.NumericUpDown AgenumericUpDown;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button assignTrackCourseBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView InstructorsdataGridView1;
		private System.Windows.Forms.Label label8;
	}
}