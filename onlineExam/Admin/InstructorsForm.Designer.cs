namespace onlineExam.Admin
{
	partial class InstructorsForm
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
			this.InstructorsdataGridView1 = new System.Windows.Forms.DataGridView();
			this.FNametextBox1 = new System.Windows.Forms.TextBox();
			this.LNametextBox2 = new System.Windows.Forms.TextBox();
			this.EmailtextBox3 = new System.Windows.Forms.TextBox();
			this.SalarytextBox4 = new System.Windows.Forms.TextBox();
			this.AddresstextBox5 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.AgenumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.GendercomboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.SaveInstructorbutton = new System.Windows.Forms.Button();
			this.assignTrackCourseBtn = new System.Windows.Forms.Button();
			this.BranchesdataGridView1 = new System.Windows.Forms.DataGridView();
			this.branchAndCourselabel10 = new System.Windows.Forms.Label();
			this.BranchesPanel = new System.Windows.Forms.Panel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBranchesBox = new System.Windows.Forms.ComboBox();
			this.TrackcomboBox1 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.InstructorsdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BranchesdataGridView1)).BeginInit();
			this.BranchesPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(805, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Instructors";
			// 
			// InstructorsdataGridView1
			// 
			this.InstructorsdataGridView1.AllowUserToAddRows = false;
			this.InstructorsdataGridView1.AllowUserToDeleteRows = false;
			this.InstructorsdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.InstructorsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InstructorsdataGridView1.Location = new System.Drawing.Point(486, 82);
			this.InstructorsdataGridView1.Name = "InstructorsdataGridView1";
			this.InstructorsdataGridView1.ReadOnly = true;
			this.InstructorsdataGridView1.RowHeadersWidth = 51;
			this.InstructorsdataGridView1.RowTemplate.Height = 24;
			this.InstructorsdataGridView1.Size = new System.Drawing.Size(825, 223);
			this.InstructorsdataGridView1.TabIndex = 1;
			this.InstructorsdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstructorsdataGridView1_CellContentClick);
			// 
			// FNametextBox1
			// 
			this.FNametextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FNametextBox1.Location = new System.Drawing.Point(194, 82);
			this.FNametextBox1.Multiline = true;
			this.FNametextBox1.Name = "FNametextBox1";
			this.FNametextBox1.Size = new System.Drawing.Size(257, 31);
			this.FNametextBox1.TabIndex = 2;
			this.FNametextBox1.TextChanged += new System.EventHandler(this.FNametextBox1_TextChanged);
			// 
			// LNametextBox2
			// 
			this.LNametextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LNametextBox2.Location = new System.Drawing.Point(194, 141);
			this.LNametextBox2.Multiline = true;
			this.LNametextBox2.Name = "LNametextBox2";
			this.LNametextBox2.Size = new System.Drawing.Size(257, 33);
			this.LNametextBox2.TabIndex = 3;
			this.LNametextBox2.TextChanged += new System.EventHandler(this.LNametextBox2_TextChanged);
			// 
			// EmailtextBox3
			// 
			this.EmailtextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailtextBox3.Location = new System.Drawing.Point(194, 203);
			this.EmailtextBox3.Multiline = true;
			this.EmailtextBox3.Name = "EmailtextBox3";
			this.EmailtextBox3.Size = new System.Drawing.Size(257, 33);
			this.EmailtextBox3.TabIndex = 4;
			this.EmailtextBox3.TextChanged += new System.EventHandler(this.EmailtextBox3_TextChanged);
			// 
			// SalarytextBox4
			// 
			this.SalarytextBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SalarytextBox4.Location = new System.Drawing.Point(194, 493);
			this.SalarytextBox4.Multiline = true;
			this.SalarytextBox4.Name = "SalarytextBox4";
			this.SalarytextBox4.Size = new System.Drawing.Size(257, 31);
			this.SalarytextBox4.TabIndex = 5;
			this.SalarytextBox4.TextChanged += new System.EventHandler(this.SalarytextBox4_TextChanged);
			// 
			// AddresstextBox5
			// 
			this.AddresstextBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddresstextBox5.Location = new System.Drawing.Point(194, 644);
			this.AddresstextBox5.Multiline = true;
			this.AddresstextBox5.Name = "AddresstextBox5";
			this.AddresstextBox5.Size = new System.Drawing.Size(257, 35);
			this.AddresstextBox5.TabIndex = 6;
			this.AddresstextBox5.TextChanged += new System.EventHandler(this.AddresstextBox5_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 31);
			this.label2.TabIndex = 7;
			this.label2.Text = "First Name :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 31);
			this.label3.TabIndex = 8;
			this.label3.Text = "Last Name :";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 31);
			this.label4.TabIndex = 9;
			this.label4.Text = "E-mail :";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 260);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 31);
			this.label5.TabIndex = 10;
			this.label5.Text = "Age :";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// AgenumericUpDown
			// 
			this.AgenumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgenumericUpDown.Location = new System.Drawing.Point(194, 260);
			this.AgenumericUpDown.Name = "AgenumericUpDown";
			this.AgenumericUpDown.Size = new System.Drawing.Size(257, 31);
			this.AgenumericUpDown.TabIndex = 26;
			this.AgenumericUpDown.ValueChanged += new System.EventHandler(this.AgenumericUpDown_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 491);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 31);
			this.label6.TabIndex = 27;
			this.label6.Text = "Salary :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 644);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 31);
			this.label7.TabIndex = 28;
			this.label7.Text = "Address :";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// GendercomboBox1
			// 
			this.GendercomboBox1.DropDownHeight = 200;
			this.GendercomboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GendercomboBox1.FormattingEnabled = true;
			this.GendercomboBox1.IntegralHeight = false;
			this.GendercomboBox1.ItemHeight = 25;
			this.GendercomboBox1.Location = new System.Drawing.Point(194, 320);
			this.GendercomboBox1.Name = "GendercomboBox1";
			this.GendercomboBox1.Size = new System.Drawing.Size(257, 33);
			this.GendercomboBox1.TabIndex = 29;
			this.GendercomboBox1.SelectedIndexChanged += new System.EventHandler(this.GendercomboBox1_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 322);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 31);
			this.label8.TabIndex = 30;
			this.label8.Text = "Gender :";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(194, 541);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(257, 25);
			this.dateTimePicker1.TabIndex = 31;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 541);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 31);
			this.label9.TabIndex = 32;
			this.label9.Text = "Birth Date :";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// SaveInstructorbutton
			// 
			this.SaveInstructorbutton.BackColor = System.Drawing.Color.Black;
			this.SaveInstructorbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveInstructorbutton.ForeColor = System.Drawing.SystemColors.Control;
			this.SaveInstructorbutton.Location = new System.Drawing.Point(92, 704);
			this.SaveInstructorbutton.Name = "SaveInstructorbutton";
			this.SaveInstructorbutton.Size = new System.Drawing.Size(315, 51);
			this.SaveInstructorbutton.TabIndex = 33;
			this.SaveInstructorbutton.Text = "Save";
			this.SaveInstructorbutton.UseVisualStyleBackColor = false;
			this.SaveInstructorbutton.Click += new System.EventHandler(this.SaveInstructorbutton_Click);
			// 
			// assignTrackCourseBtn
			// 
			this.assignTrackCourseBtn.BackColor = System.Drawing.Color.Black;
			this.assignTrackCourseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignTrackCourseBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.assignTrackCourseBtn.Location = new System.Drawing.Point(705, 336);
			this.assignTrackCourseBtn.Name = "assignTrackCourseBtn";
			this.assignTrackCourseBtn.Size = new System.Drawing.Size(379, 55);
			this.assignTrackCourseBtn.TabIndex = 34;
			this.assignTrackCourseBtn.Text = "Assign";
			this.assignTrackCourseBtn.UseVisualStyleBackColor = false;
			this.assignTrackCourseBtn.Click += new System.EventHandler(this.assignTrackCourseBtn_Click);
			// 
			// BranchesdataGridView1
			// 
			this.BranchesdataGridView1.AllowUserToAddRows = false;
			this.BranchesdataGridView1.AllowUserToDeleteRows = false;
			this.BranchesdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.BranchesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BranchesdataGridView1.Location = new System.Drawing.Point(0, 63);
			this.BranchesdataGridView1.Name = "BranchesdataGridView1";
			this.BranchesdataGridView1.ReadOnly = true;
			this.BranchesdataGridView1.RowHeadersWidth = 51;
			this.BranchesdataGridView1.RowTemplate.Height = 24;
			this.BranchesdataGridView1.Size = new System.Drawing.Size(805, 211);
			this.BranchesdataGridView1.TabIndex = 35;
			this.BranchesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BranchesdataGridView1_CellContentClick);
			// 
			// branchAndCourselabel10
			// 
			this.branchAndCourselabel10.AutoSize = true;
			this.branchAndCourselabel10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.branchAndCourselabel10.Location = new System.Drawing.Point(307, 2);
			this.branchAndCourselabel10.Name = "branchAndCourselabel10";
			this.branchAndCourselabel10.Size = new System.Drawing.Size(161, 45);
			this.branchAndCourselabel10.TabIndex = 36;
			this.branchAndCourselabel10.Text = "Branches";
			// 
			// BranchesPanel
			// 
			this.BranchesPanel.Controls.Add(this.BranchesdataGridView1);
			this.BranchesPanel.Controls.Add(this.branchAndCourselabel10);
			this.BranchesPanel.Location = new System.Drawing.Point(486, 478);
			this.BranchesPanel.Name = "BranchesPanel";
			this.BranchesPanel.Size = new System.Drawing.Size(808, 277);
			this.BranchesPanel.TabIndex = 37;
			this.BranchesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BranchesPanel_Paint);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(829, 420);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(125, 42);
			this.radioButton1.TabIndex = 38;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Branch";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(1166, 420);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(125, 42);
			this.radioButton2.TabIndex = 39;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Course";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(486, 420);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(172, 42);
			this.radioButton3.TabIndex = 40;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Instructors";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(194, 593);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(257, 35);
			this.textBox1.TabIndex = 41;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 597);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 31);
			this.label10.TabIndex = 42;
			this.label10.Text = "Phone :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(12, 381);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 31);
			this.label11.TabIndex = 44;
			this.label11.Text = "Branch :";
			// 
			// comboBranchesBox
			// 
			this.comboBranchesBox.DropDownHeight = 200;
			this.comboBranchesBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBranchesBox.FormattingEnabled = true;
			this.comboBranchesBox.IntegralHeight = false;
			this.comboBranchesBox.ItemHeight = 25;
			this.comboBranchesBox.Location = new System.Drawing.Point(194, 379);
			this.comboBranchesBox.Name = "comboBranchesBox";
			this.comboBranchesBox.Size = new System.Drawing.Size(257, 33);
			this.comboBranchesBox.TabIndex = 43;
			this.comboBranchesBox.SelectedIndexChanged += new System.EventHandler(this.comboBranchesBox_SelectedIndexChanged);
			// 
			// TrackcomboBox1
			// 
			this.TrackcomboBox1.DropDownHeight = 200;
			this.TrackcomboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackcomboBox1.FormattingEnabled = true;
			this.TrackcomboBox1.IntegralHeight = false;
			this.TrackcomboBox1.ItemHeight = 25;
			this.TrackcomboBox1.Location = new System.Drawing.Point(194, 440);
			this.TrackcomboBox1.Name = "TrackcomboBox1";
			this.TrackcomboBox1.Size = new System.Drawing.Size(257, 33);
			this.TrackcomboBox1.TabIndex = 45;
			this.TrackcomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(11, 442);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(81, 31);
			this.label12.TabIndex = 46;
			this.label12.Text = "Track :";
			// 
			// InstructorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1346, 792);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.TrackcomboBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboBranchesBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.BranchesPanel);
			this.Controls.Add(this.assignTrackCourseBtn);
			this.Controls.Add(this.SaveInstructorbutton);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.GendercomboBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.AgenumericUpDown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AddresstextBox5);
			this.Controls.Add(this.SalarytextBox4);
			this.Controls.Add(this.EmailtextBox3);
			this.Controls.Add(this.LNametextBox2);
			this.Controls.Add(this.FNametextBox1);
			this.Controls.Add(this.InstructorsdataGridView1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InstructorsForm";
			this.Text = "InstructorsForm";
			this.Load += new System.EventHandler(this.InstructorsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.InstructorsdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BranchesdataGridView1)).EndInit();
			this.BranchesPanel.ResumeLayout(false);
			this.BranchesPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView InstructorsdataGridView1;
		private System.Windows.Forms.TextBox FNametextBox1;
		private System.Windows.Forms.TextBox LNametextBox2;
		private System.Windows.Forms.TextBox EmailtextBox3;
		private System.Windows.Forms.TextBox SalarytextBox4;
		private System.Windows.Forms.TextBox AddresstextBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown AgenumericUpDown;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox GendercomboBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button SaveInstructorbutton;
		private System.Windows.Forms.Button assignTrackCourseBtn;
		private System.Windows.Forms.DataGridView BranchesdataGridView1;
		private System.Windows.Forms.Label branchAndCourselabel10;
		private System.Windows.Forms.Panel BranchesPanel;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBranchesBox;
		private System.Windows.Forms.ComboBox TrackcomboBox1;
		private System.Windows.Forms.Label label12;
	}
}