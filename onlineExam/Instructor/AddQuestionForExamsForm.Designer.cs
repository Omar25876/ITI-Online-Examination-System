namespace onlineExam.Instructor
{
	partial class AddQuestionForExamsForm
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
			this.dgvExamQu = new System.Windows.Forms.DataGridView();
			this.cboExams = new System.Windows.Forms.ComboBox();
			this.txtQuestion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pChoices = new System.Windows.Forms.Panel();
			this.txtGrade = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cboCourseIdgetAllCourses = new System.Windows.Forms.ComboBox();
			this.cboTrackIdgetAllTracks = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvExamQu)).BeginInit();
			this.pChoices.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(396, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 41);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add Question To Exam";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dgvExamQu
			// 
			this.dgvExamQu.AllowUserToAddRows = false;
			this.dgvExamQu.AllowUserToDeleteRows = false;
			this.dgvExamQu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.dgvExamQu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExamQu.Location = new System.Drawing.Point(16, 436);
			this.dgvExamQu.Name = "dgvExamQu";
			this.dgvExamQu.ReadOnly = true;
			this.dgvExamQu.RowHeadersWidth = 51;
			this.dgvExamQu.RowTemplate.Height = 24;
			this.dgvExamQu.Size = new System.Drawing.Size(1161, 298);
			this.dgvExamQu.TabIndex = 4;
			this.dgvExamQu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamQu_CellContentClick);
			// 
			// cboExams
			// 
			this.cboExams.DropDownHeight = 200;
			this.cboExams.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboExams.FormattingEnabled = true;
			this.cboExams.IntegralHeight = false;
			this.cboExams.ItemHeight = 25;
			this.cboExams.Location = new System.Drawing.Point(530, 272);
			this.cboExams.Name = "cboExams";
			this.cboExams.Size = new System.Drawing.Size(203, 33);
			this.cboExams.TabIndex = 5;
			this.cboExams.SelectedIndexChanged += new System.EventHandler(this.cboExams_SelectedIndexChanged);
			// 
			// txtQuestion
			// 
			this.txtQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuestion.Location = new System.Drawing.Point(198, 75);
			this.txtQuestion.Multiline = true;
			this.txtQuestion.Name = "txtQuestion";
			this.txtQuestion.Size = new System.Drawing.Size(349, 74);
			this.txtQuestion.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Enter Question :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(419, 279);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Exam : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Question Type :";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownHeight = 200;
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.IntegralHeight = false;
			this.comboBox1.ItemHeight = 25;
			this.comboBox1.Location = new System.Drawing.Point(198, 167);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(189, 33);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Model Answer :";
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(198, 221);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(189, 33);
			this.comboBox2.TabIndex = 12;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(173, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(223, 31);
			this.textBox1.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(6, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "Choice A";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(6, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Choice B";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(7, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "Choice C";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.Control;
			this.label9.Location = new System.Drawing.Point(7, 170);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 20);
			this.label9.TabIndex = 17;
			this.label9.Text = "Choice D";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(173, 68);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(223, 31);
			this.textBox2.TabIndex = 18;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(173, 119);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(223, 31);
			this.textBox3.TabIndex = 19;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(173, 174);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(223, 31);
			this.textBox4.TabIndex = 20;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(379, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(378, 49);
			this.button1.TabIndex = 21;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pChoices
			// 
			this.pChoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.pChoices.Controls.Add(this.label6);
			this.pChoices.Controls.Add(this.textBox1);
			this.pChoices.Controls.Add(this.label9);
			this.pChoices.Controls.Add(this.textBox4);
			this.pChoices.Controls.Add(this.label8);
			this.pChoices.Controls.Add(this.textBox2);
			this.pChoices.Controls.Add(this.label7);
			this.pChoices.Controls.Add(this.textBox3);
			this.pChoices.Location = new System.Drawing.Point(773, 75);
			this.pChoices.Name = "pChoices";
			this.pChoices.Size = new System.Drawing.Size(514, 258);
			this.pChoices.TabIndex = 22;
			this.pChoices.Paint += new System.Windows.Forms.PaintEventHandler(this.pChoices_Paint);
			// 
			// txtGrade
			// 
			this.txtGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGrade.Location = new System.Drawing.Point(198, 276);
			this.txtGrade.Name = "txtGrade";
			this.txtGrade.Size = new System.Drawing.Size(189, 31);
			this.txtGrade.TabIndex = 23;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 283);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(159, 20);
			this.label10.TabIndex = 24;
			this.label10.Text = "Question Grade : ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(419, 174);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 20);
			this.label11.TabIndex = 25;
			this.label11.Text = "Track : ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(420, 228);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(87, 20);
			this.label12.TabIndex = 26;
			this.label12.Text = "Course : ";
			// 
			// cboCourseIdgetAllCourses
			// 
			this.cboCourseIdgetAllCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.cboCourseIdgetAllCourses.FormattingEnabled = true;
			this.cboCourseIdgetAllCourses.Location = new System.Drawing.Point(530, 220);
			this.cboCourseIdgetAllCourses.Name = "cboCourseIdgetAllCourses";
			this.cboCourseIdgetAllCourses.Size = new System.Drawing.Size(203, 33);
			this.cboCourseIdgetAllCourses.TabIndex = 43;
			this.cboCourseIdgetAllCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourseIdgetAllCourses_SelectedIndexChanged);
			// 
			// cboTrackIdgetAllTracks
			// 
			this.cboTrackIdgetAllTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.cboTrackIdgetAllTracks.FormattingEnabled = true;
			this.cboTrackIdgetAllTracks.Location = new System.Drawing.Point(530, 167);
			this.cboTrackIdgetAllTracks.Name = "cboTrackIdgetAllTracks";
			this.cboTrackIdgetAllTracks.Size = new System.Drawing.Size(203, 33);
			this.cboTrackIdgetAllTracks.TabIndex = 42;
			this.cboTrackIdgetAllTracks.SelectedIndexChanged += new System.EventHandler(this.cboTrackIdgetAllTracks_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.panel1.Location = new System.Drawing.Point(403, 167);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 140);
			this.panel1.TabIndex = 44;
			// 
			// AddQuestionForExamsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 746);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cboCourseIdgetAllCourses);
			this.Controls.Add(this.cboTrackIdgetAllTracks);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtGrade);
			this.Controls.Add(this.pChoices);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtQuestion);
			this.Controls.Add(this.cboExams);
			this.Controls.Add(this.dgvExamQu);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddQuestionForExamsForm";
			this.Text = "ExamsForm";
			this.Load += new System.EventHandler(this.ExamsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvExamQu)).EndInit();
			this.pChoices.ResumeLayout(false);
			this.pChoices.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvExamQu;
		private System.Windows.Forms.ComboBox cboExams;
		private System.Windows.Forms.TextBox txtQuestion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel pChoices;
		private System.Windows.Forms.TextBox txtGrade;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cboCourseIdgetAllCourses;
		private System.Windows.Forms.ComboBox cboTrackIdgetAllTracks;
		private System.Windows.Forms.Panel panel1;
	}
}