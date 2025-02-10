namespace onlineExam
{
	partial class MainStudentEForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStudentEForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.instructorLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.panelContent = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.sidebar.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.instructorLabel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1442, 80);
			this.panel1.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(125, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 41);
			this.label4.TabIndex = 5;
			this.label4.Text = "Student :";
			// 
			// instructorLabel
			// 
			this.instructorLabel.AutoSize = true;
			this.instructorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instructorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.instructorLabel.Location = new System.Drawing.Point(276, 21);
			this.instructorLabel.Name = "instructorLabel";
			this.instructorLabel.Size = new System.Drawing.Size(247, 41);
			this.instructorLabel.TabIndex = 4;
			this.instructorLabel.Text = "Omar Mohamed";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(63, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "ITI";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(7, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// sidebar
			// 
			this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.sidebar.Controls.Add(this.panel3);
			this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebar.Location = new System.Drawing.Point(0, 80);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new System.Drawing.Size(78, 647);
			this.sidebar.TabIndex = 2;
			this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button2);
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(71, 97);
			this.panel3.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(-3, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(103, 97);
			this.button2.TabIndex = 3;
			this.button2.UseMnemonic = false;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panelContent
			// 
			this.panelContent.Location = new System.Drawing.Point(80, 83);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(1362, 644);
			this.panelContent.TabIndex = 11;
			this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
			// 
			// MainStudentEForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1442, 727);
			this.Controls.Add(this.panelContent);
			this.Controls.Add(this.sidebar);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "MainStudentEForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainStudentEForm";
			this.Load += new System.EventHandler(this.MainStudentEForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.sidebar.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label instructorLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel sidebar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panelContent;
	}
}