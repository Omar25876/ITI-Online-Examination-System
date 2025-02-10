namespace onlineExam.Instructor
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
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.cboTrackIdgetAllTracks = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TrackscomboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(477, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 45);
			this.label1.TabIndex = 2;
			this.label1.Text = "Students";
			// 
			// dgvStudents
			// 
			this.dgvStudents.AllowUserToAddRows = false;
			this.dgvStudents.AllowUserToDeleteRows = false;
			this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(69, 259);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.ReadOnly = true;
			this.dgvStudents.RowHeadersWidth = 51;
			this.dgvStudents.RowTemplate.Height = 24;
			this.dgvStudents.Size = new System.Drawing.Size(1065, 344);
			this.dgvStudents.TabIndex = 3;
			this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
			// 
			// cboTrackIdgetAllTracks
			// 
			this.cboTrackIdgetAllTracks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTrackIdgetAllTracks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTrackIdgetAllTracks.FormattingEnabled = true;
			this.cboTrackIdgetAllTracks.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.cboTrackIdgetAllTracks.Location = new System.Drawing.Point(485, 187);
			this.cboTrackIdgetAllTracks.MaximumSize = new System.Drawing.Size(400, 0);
			this.cboTrackIdgetAllTracks.MinimumSize = new System.Drawing.Size(200, 0);
			this.cboTrackIdgetAllTracks.Name = "cboTrackIdgetAllTracks";
			this.cboTrackIdgetAllTracks.Size = new System.Drawing.Size(327, 36);
			this.cboTrackIdgetAllTracks.TabIndex = 4;
			this.cboTrackIdgetAllTracks.SelectedIndexChanged += new System.EventHandler(this.cboTrackIdgetAllTracks_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(309, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 41);
			this.label7.TabIndex = 36;
			this.label7.Text = "Track :";
			// 
			// TrackscomboBox1
			// 
			this.TrackscomboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackscomboBox1.FormattingEnabled = true;
			this.TrackscomboBox1.Location = new System.Drawing.Point(485, 106);
			this.TrackscomboBox1.Name = "TrackscomboBox1";
			this.TrackscomboBox1.Size = new System.Drawing.Size(327, 33);
			this.TrackscomboBox1.TabIndex = 35;
			this.TrackscomboBox1.SelectedIndexChanged += new System.EventHandler(this.TrackscomboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(309, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 41);
			this.label2.TabIndex = 37;
			this.label2.Text = "Course :";
			// 
			// StudentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 729);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TrackscomboBox1);
			this.Controls.Add(this.cboTrackIdgetAllTracks);
			this.Controls.Add(this.dgvStudents);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentsForm";
			this.Text = "StudentsForm";
			this.Load += new System.EventHandler(this.StudentsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.ComboBox cboTrackIdgetAllTracks;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox TrackscomboBox1;
		private System.Windows.Forms.Label label2;
	}
}