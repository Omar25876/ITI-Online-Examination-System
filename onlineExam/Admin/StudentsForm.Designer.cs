namespace onlineExam.Admin
{
	partial class StudentsForm
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
			this.FNametextBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LNametextBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EmailtextBox1 = new System.Windows.Forms.TextBox();
			this.cboTrackIdgetAllTracks = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddresstextBox2 = new System.Windows.Forms.TextBox();
			this.GendercomboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SaveStudentButn = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.assignTrackCourseBtn = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.BranchesPanel = new System.Windows.Forms.Panel();
			this.CoursesdataGridView1 = new System.Windows.Forms.DataGridView();
			this.branchAndCourselabel10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView1)).BeginInit();
			this.BranchesPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CoursesdataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(793, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "Students";
			// 
			// StudentsdataGridView1
			// 
			this.StudentsdataGridView1.AllowUserToAddRows = false;
			this.StudentsdataGridView1.AllowUserToDeleteRows = false;
			this.StudentsdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.StudentsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsdataGridView1.Location = new System.Drawing.Point(494, 77);
			this.StudentsdataGridView1.Name = "StudentsdataGridView1";
			this.StudentsdataGridView1.ReadOnly = true;
			this.StudentsdataGridView1.RowHeadersWidth = 51;
			this.StudentsdataGridView1.RowTemplate.Height = 24;
			this.StudentsdataGridView1.Size = new System.Drawing.Size(817, 205);
			this.StudentsdataGridView1.TabIndex = 2;
			this.StudentsdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsdataGridView1_CellContentClick);
			// 
			// FNametextBox1
			// 
			this.FNametextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FNametextBox1.Location = new System.Drawing.Point(193, 146);
			this.FNametextBox1.Multiline = true;
			this.FNametextBox1.Name = "FNametextBox1";
			this.FNametextBox1.Size = new System.Drawing.Size(271, 38);
			this.FNametextBox1.TabIndex = 3;
			this.FNametextBox1.TextChanged += new System.EventHandler(this.FNametextBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 31);
			this.label2.TabIndex = 4;
			this.label2.Text = "First Name : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Last Name : ";
			// 
			// LNametextBox2
			// 
			this.LNametextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LNametextBox2.Location = new System.Drawing.Point(193, 220);
			this.LNametextBox2.Multiline = true;
			this.LNametextBox2.Name = "LNametextBox2";
			this.LNametextBox2.Size = new System.Drawing.Size(271, 38);
			this.LNametextBox2.TabIndex = 6;
			this.LNametextBox2.TextChanged += new System.EventHandler(this.LNametextBox2_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 295);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 31);
			this.label4.TabIndex = 7;
			this.label4.Text = "E-mail : ";
			// 
			// EmailtextBox1
			// 
			this.EmailtextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailtextBox1.Location = new System.Drawing.Point(193, 295);
			this.EmailtextBox1.Multiline = true;
			this.EmailtextBox1.Name = "EmailtextBox1";
			this.EmailtextBox1.Size = new System.Drawing.Size(271, 38);
			this.EmailtextBox1.TabIndex = 8;
			this.EmailtextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// cboTrackIdgetAllTracks
			// 
			this.cboTrackIdgetAllTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTrackIdgetAllTracks.FormattingEnabled = true;
			this.cboTrackIdgetAllTracks.Location = new System.Drawing.Point(193, 372);
			this.cboTrackIdgetAllTracks.Name = "cboTrackIdgetAllTracks";
			this.cboTrackIdgetAllTracks.Size = new System.Drawing.Size(271, 36);
			this.cboTrackIdgetAllTracks.TabIndex = 9;
			this.cboTrackIdgetAllTracks.SelectedIndexChanged += new System.EventHandler(this.TrackcomboBox1_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(27, 377);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 31);
			this.label5.TabIndex = 10;
			this.label5.Text = "Track : ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// AddresstextBox2
			// 
			this.AddresstextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddresstextBox2.Location = new System.Drawing.Point(193, 522);
			this.AddresstextBox2.Multiline = true;
			this.AddresstextBox2.Name = "AddresstextBox2";
			this.AddresstextBox2.Size = new System.Drawing.Size(271, 38);
			this.AddresstextBox2.TabIndex = 11;
			this.AddresstextBox2.TextChanged += new System.EventHandler(this.AddresstextBox2_TextChanged);
			// 
			// GendercomboBox1
			// 
			this.GendercomboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GendercomboBox1.FormattingEnabled = true;
			this.GendercomboBox1.Location = new System.Drawing.Point(193, 450);
			this.GendercomboBox1.Name = "GendercomboBox1";
			this.GendercomboBox1.Size = new System.Drawing.Size(271, 36);
			this.GendercomboBox1.TabIndex = 12;
			this.GendercomboBox1.SelectedIndexChanged += new System.EventHandler(this.GendercomboBox1_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(27, 450);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 31);
			this.label6.TabIndex = 13;
			this.label6.Text = "Gender : ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(27, 525);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 31);
			this.label7.TabIndex = 14;
			this.label7.Text = "Address : ";
			// 
			// SaveStudentButn
			// 
			this.SaveStudentButn.BackColor = System.Drawing.Color.Black;
			this.SaveStudentButn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveStudentButn.ForeColor = System.Drawing.SystemColors.Control;
			this.SaveStudentButn.Location = new System.Drawing.Point(91, 725);
			this.SaveStudentButn.Name = "SaveStudentButn";
			this.SaveStudentButn.Size = new System.Drawing.Size(349, 57);
			this.SaveStudentButn.TabIndex = 15;
			this.SaveStudentButn.Text = "Save";
			this.SaveStudentButn.UseVisualStyleBackColor = false;
			this.SaveStudentButn.Click += new System.EventHandler(this.SaveStudentButn_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(193, 658);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(271, 25);
			this.dateTimePicker1.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(27, 652);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(138, 31);
			this.label8.TabIndex = 17;
			this.label8.Text = "Birth Date : ";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(193, 585);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(271, 38);
			this.textBox1.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(27, 586);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 31);
			this.label9.TabIndex = 19;
			this.label9.Text = "Phone : ";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(557, 387);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(148, 42);
			this.radioButton3.TabIndex = 44;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Students";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(1017, 387);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(125, 42);
			this.radioButton2.TabIndex = 43;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Course";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// assignTrackCourseBtn
			// 
			this.assignTrackCourseBtn.BackColor = System.Drawing.Color.Black;
			this.assignTrackCourseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignTrackCourseBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.assignTrackCourseBtn.Location = new System.Drawing.Point(695, 311);
			this.assignTrackCourseBtn.Name = "assignTrackCourseBtn";
			this.assignTrackCourseBtn.Size = new System.Drawing.Size(353, 60);
			this.assignTrackCourseBtn.TabIndex = 41;
			this.assignTrackCourseBtn.Text = "Assign";
			this.assignTrackCourseBtn.UseVisualStyleBackColor = false;
			this.assignTrackCourseBtn.Click += new System.EventHandler(this.assignTrackCourseBtn_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(97, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(293, 45);
			this.label10.TabIndex = 45;
			this.label10.Text = "Add New Student";
			// 
			// BranchesPanel
			// 
			this.BranchesPanel.Controls.Add(this.CoursesdataGridView1);
			this.BranchesPanel.Controls.Add(this.branchAndCourselabel10);
			this.BranchesPanel.Location = new System.Drawing.Point(494, 450);
			this.BranchesPanel.Name = "BranchesPanel";
			this.BranchesPanel.Size = new System.Drawing.Size(808, 352);
			this.BranchesPanel.TabIndex = 46;
			// 
			// CoursesdataGridView1
			// 
			this.CoursesdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.CoursesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CoursesdataGridView1.Location = new System.Drawing.Point(0, 72);
			this.CoursesdataGridView1.Name = "CoursesdataGridView1";
			this.CoursesdataGridView1.RowHeadersWidth = 51;
			this.CoursesdataGridView1.RowTemplate.Height = 24;
			this.CoursesdataGridView1.Size = new System.Drawing.Size(817, 260);
			this.CoursesdataGridView1.TabIndex = 35;
			this.CoursesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BranchesdataGridView1_CellContentClick);
			// 
			// branchAndCourselabel10
			// 
			this.branchAndCourselabel10.AutoSize = true;
			this.branchAndCourselabel10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.branchAndCourselabel10.Location = new System.Drawing.Point(307, 5);
			this.branchAndCourselabel10.Name = "branchAndCourselabel10";
			this.branchAndCourselabel10.Size = new System.Drawing.Size(142, 45);
			this.branchAndCourselabel10.TabIndex = 36;
			this.branchAndCourselabel10.Text = "Courses";
			// 
			// StudentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 835);
			this.Controls.Add(this.BranchesPanel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.assignTrackCourseBtn);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.SaveStudentButn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.GendercomboBox1);
			this.Controls.Add(this.AddresstextBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboTrackIdgetAllTracks);
			this.Controls.Add(this.EmailtextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LNametextBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FNametextBox1);
			this.Controls.Add(this.StudentsdataGridView1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentsForm";
			this.Text = "StudentsForm";
			this.Load += new System.EventHandler(this.StudentsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView1)).EndInit();
			this.BranchesPanel.ResumeLayout(false);
			this.BranchesPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CoursesdataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView StudentsdataGridView1;
		private System.Windows.Forms.TextBox FNametextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox LNametextBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox EmailtextBox1;
		private System.Windows.Forms.ComboBox cboTrackIdgetAllTracks;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox AddresstextBox2;
		private System.Windows.Forms.ComboBox GendercomboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button SaveStudentButn;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button assignTrackCourseBtn;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel BranchesPanel;
		private System.Windows.Forms.DataGridView CoursesdataGridView1;
		private System.Windows.Forms.Label branchAndCourselabel10;
	}
}