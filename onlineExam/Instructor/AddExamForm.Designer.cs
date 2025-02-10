namespace onlineExam.Instructor
{
	partial class AddExamForm
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
			this.examNametextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SaveExamBtn = new System.Windows.Forms.Button();
			this.totalScoretextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.DurationExamnumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.ExamdateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.cboCourseIdgetAllCourses = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TrackscomboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DurationExamnumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(431, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 38);
			this.label1.TabIndex = 2;
			this.label1.Text = "Add New Exam";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// examNametextBox
			// 
			this.examNametextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.examNametextBox.Location = new System.Drawing.Point(192, 71);
			this.examNametextBox.Multiline = true;
			this.examNametextBox.Name = "examNametextBox";
			this.examNametextBox.Size = new System.Drawing.Size(227, 28);
			this.examNametextBox.TabIndex = 4;
			this.examNametextBox.TextChanged += new System.EventHandler(this.examNametextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Exam Name :";
			// 
			// SaveExamBtn
			// 
			this.SaveExamBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.SaveExamBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveExamBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.SaveExamBtn.Location = new System.Drawing.Point(354, 265);
			this.SaveExamBtn.Name = "SaveExamBtn";
			this.SaveExamBtn.Size = new System.Drawing.Size(378, 49);
			this.SaveExamBtn.TabIndex = 22;
			this.SaveExamBtn.Text = "Save";
			this.SaveExamBtn.UseVisualStyleBackColor = false;
			this.SaveExamBtn.Click += new System.EventHandler(this.SaveExamBtn_Click);
			// 
			// totalScoretextBox
			// 
			this.totalScoretextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.totalScoretextBox.Location = new System.Drawing.Point(672, 186);
			this.totalScoretextBox.Multiline = true;
			this.totalScoretextBox.Name = "totalScoretextBox";
			this.totalScoretextBox.Size = new System.Drawing.Size(317, 28);
			this.totalScoretextBox.TabIndex = 23;
			this.totalScoretextBox.TextChanged += new System.EventHandler(this.totalScoretextBox_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(485, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 25);
			this.label3.TabIndex = 24;
			this.label3.Text = "Total Score :";
			// 
			// DurationExamnumericUpDown
			// 
			this.DurationExamnumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.DurationExamnumericUpDown.Location = new System.Drawing.Point(672, 65);
			this.DurationExamnumericUpDown.Name = "DurationExamnumericUpDown";
			this.DurationExamnumericUpDown.Size = new System.Drawing.Size(317, 31);
			this.DurationExamnumericUpDown.TabIndex = 25;
			this.DurationExamnumericUpDown.ValueChanged += new System.EventHandler(this.DurationExamnumericUpDown_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(485, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 25);
			this.label4.TabIndex = 26;
			this.label4.Text = "Duration : ";
			// 
			// ExamdateTimePicker
			// 
			this.ExamdateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.ExamdateTimePicker.Location = new System.Drawing.Point(672, 123);
			this.ExamdateTimePicker.Name = "ExamdateTimePicker";
			this.ExamdateTimePicker.Size = new System.Drawing.Size(317, 31);
			this.ExamdateTimePicker.TabIndex = 27;
			this.ExamdateTimePicker.ValueChanged += new System.EventHandler(this.ExamdateTimePicker_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(485, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 25);
			this.label5.TabIndex = 28;
			this.label5.Text = "Date : ";
			// 
			// cboCourseIdgetAllCourses
			// 
			this.cboCourseIdgetAllCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboCourseIdgetAllCourses.FormattingEnabled = true;
			this.cboCourseIdgetAllCourses.Location = new System.Drawing.Point(192, 186);
			this.cboCourseIdgetAllCourses.Name = "cboCourseIdgetAllCourses";
			this.cboCourseIdgetAllCourses.Size = new System.Drawing.Size(227, 33);
			this.cboCourseIdgetAllCourses.TabIndex = 29;
			this.cboCourseIdgetAllCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourseIdgetAllCourses_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(23, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 25);
			this.label6.TabIndex = 30;
			this.label6.Text = "Course :";
			// 
			// TrackscomboBox1
			// 
			this.TrackscomboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackscomboBox1.FormattingEnabled = true;
			this.TrackscomboBox1.Location = new System.Drawing.Point(192, 128);
			this.TrackscomboBox1.Name = "TrackscomboBox1";
			this.TrackscomboBox1.Size = new System.Drawing.Size(227, 33);
			this.TrackscomboBox1.TabIndex = 31;
			this.TrackscomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(23, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 25);
			this.label7.TabIndex = 32;
			this.label7.Text = "Track :";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(79, 346);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1039, 258);
			this.dataGridView1.TabIndex = 33;
			this.dataGridView1.UseWaitCursor = true;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// AddExamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 725);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TrackscomboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cboCourseIdgetAllCourses);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ExamdateTimePicker);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DurationExamnumericUpDown);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.totalScoretextBox);
			this.Controls.Add(this.SaveExamBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.examNametextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddExamForm";
			this.Text = "AddExamFormForm";
			this.Load += new System.EventHandler(this.AddExamForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DurationExamnumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox examNametextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SaveExamBtn;
		private System.Windows.Forms.TextBox totalScoretextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown DurationExamnumericUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker ExamdateTimePicker;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboCourseIdgetAllCourses;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox TrackscomboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}