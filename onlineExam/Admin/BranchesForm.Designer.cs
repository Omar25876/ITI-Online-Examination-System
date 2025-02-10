namespace onlineExam.Admin
{
	partial class BranchesForm
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
			this.BNametextBox1 = new System.Windows.Forms.TextBox();
			this.BLocationtextBox1 = new System.Windows.Forms.TextBox();
			this.BPhonetextBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.BranchesdataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TracksdataGridView1 = new System.Windows.Forms.DataGridView();
			this.assignTrackCourseBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BranchesdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TracksdataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(843, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 54);
			this.label1.TabIndex = 3;
			this.label1.Text = "Branches";
			// 
			// BNametextBox1
			// 
			this.BNametextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BNametextBox1.Location = new System.Drawing.Point(270, 144);
			this.BNametextBox1.Multiline = true;
			this.BNametextBox1.Name = "BNametextBox1";
			this.BNametextBox1.Size = new System.Drawing.Size(268, 34);
			this.BNametextBox1.TabIndex = 4;
			// 
			// BLocationtextBox1
			// 
			this.BLocationtextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BLocationtextBox1.Location = new System.Drawing.Point(270, 219);
			this.BLocationtextBox1.Multiline = true;
			this.BLocationtextBox1.Name = "BLocationtextBox1";
			this.BLocationtextBox1.Size = new System.Drawing.Size(268, 34);
			this.BLocationtextBox1.TabIndex = 5;
			// 
			// BPhonetextBox2
			// 
			this.BPhonetextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BPhonetextBox2.Location = new System.Drawing.Point(270, 296);
			this.BPhonetextBox2.Multiline = true;
			this.BPhonetextBox2.Name = "BPhonetextBox2";
			this.BPhonetextBox2.Size = new System.Drawing.Size(268, 34);
			this.BPhonetextBox2.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 31);
			this.label2.TabIndex = 8;
			this.label2.Text = "Branch Name :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(39, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 31);
			this.label3.TabIndex = 9;
			this.label3.Text = "Branch Location :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 31);
			this.label4.TabIndex = 10;
			this.label4.Text = "Branch Phone :";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(76, 543);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(429, 57);
			this.button1.TabIndex = 11;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BranchesdataGridView1
			// 
			this.BranchesdataGridView1.AllowUserToAddRows = false;
			this.BranchesdataGridView1.AllowUserToDeleteRows = false;
			this.BranchesdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.BranchesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BranchesdataGridView1.Location = new System.Drawing.Point(579, 94);
			this.BranchesdataGridView1.Name = "BranchesdataGridView1";
			this.BranchesdataGridView1.ReadOnly = true;
			this.BranchesdataGridView1.RowHeadersWidth = 51;
			this.BranchesdataGridView1.RowTemplate.Height = 24;
			this.BranchesdataGridView1.Size = new System.Drawing.Size(753, 245);
			this.BranchesdataGridView1.TabIndex = 12;
			this.BranchesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BranchesdataGridView1_CellContentClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(123, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(340, 54);
			this.label5.TabIndex = 13;
			this.label5.Text = "Add New Branch";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(897, 458);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 54);
			this.label6.TabIndex = 14;
			this.label6.Text = "Tracks";
			// 
			// TracksdataGridView1
			// 
			this.TracksdataGridView1.AllowUserToAddRows = false;
			this.TracksdataGridView1.AllowUserToDeleteRows = false;
			this.TracksdataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.TracksdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TracksdataGridView1.Location = new System.Drawing.Point(579, 543);
			this.TracksdataGridView1.Name = "TracksdataGridView1";
			this.TracksdataGridView1.ReadOnly = true;
			this.TracksdataGridView1.RowHeadersWidth = 51;
			this.TracksdataGridView1.RowTemplate.Height = 24;
			this.TracksdataGridView1.Size = new System.Drawing.Size(753, 188);
			this.TracksdataGridView1.TabIndex = 15;
			this.TracksdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TracksdataGridView1_CellContentClick);
			// 
			// assignTrackCourseBtn
			// 
			this.assignTrackCourseBtn.BackColor = System.Drawing.Color.Black;
			this.assignTrackCourseBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignTrackCourseBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.assignTrackCourseBtn.Location = new System.Drawing.Point(787, 382);
			this.assignTrackCourseBtn.Name = "assignTrackCourseBtn";
			this.assignTrackCourseBtn.Size = new System.Drawing.Size(361, 60);
			this.assignTrackCourseBtn.TabIndex = 30;
			this.assignTrackCourseBtn.Text = "Assign";
			this.assignTrackCourseBtn.UseVisualStyleBackColor = false;
			this.assignTrackCourseBtn.Click += new System.EventHandler(this.assignTrackCourseBtn_Click);
			// 
			// BranchesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1359, 760);
			this.Controls.Add(this.assignTrackCourseBtn);
			this.Controls.Add(this.TracksdataGridView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BranchesdataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BPhonetextBox2);
			this.Controls.Add(this.BLocationtextBox1);
			this.Controls.Add(this.BNametextBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BranchesForm";
			this.Text = "BranchesForm";
			this.Load += new System.EventHandler(this.BranchesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.BranchesdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TracksdataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox BNametextBox1;
		private System.Windows.Forms.TextBox BLocationtextBox1;
		private System.Windows.Forms.TextBox BPhonetextBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView BranchesdataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView TracksdataGridView1;
		private System.Windows.Forms.Button assignTrackCourseBtn;
	}
}