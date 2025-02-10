namespace onlineExam.Instructor
{
	partial class MainReportsForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReportsForm));
			this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dashbordbtn = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.studentsbtn = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.coursesbtn = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.examsbtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
			this.panelContent = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.instructorLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.sidebar.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// sidebar
			// 
			this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.sidebar.Controls.Add(this.panel2);
			this.sidebar.Controls.Add(this.panel3);
			this.sidebar.Controls.Add(this.panel4);
			this.sidebar.Controls.Add(this.panel6);
			this.sidebar.Controls.Add(this.panel5);
			this.sidebar.Controls.Add(this.button2);
			this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebar.Location = new System.Drawing.Point(0, 80);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new System.Drawing.Size(209, 768);
			this.sidebar.TabIndex = 1;
			this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dashbordbtn);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(333, 122);
			this.panel2.TabIndex = 3;
			// 
			// dashbordbtn
			// 
			this.dashbordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.dashbordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.dashbordbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashbordbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.dashbordbtn.Image = ((System.Drawing.Image)(resources.GetObject("dashbordbtn.Image")));
			this.dashbordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dashbordbtn.Location = new System.Drawing.Point(0, 0);
			this.dashbordbtn.Margin = new System.Windows.Forms.Padding(0);
			this.dashbordbtn.Name = "dashbordbtn";
			this.dashbordbtn.Size = new System.Drawing.Size(216, 122);
			this.dashbordbtn.TabIndex = 2;
			this.dashbordbtn.Text = "         Dashbord";
			this.dashbordbtn.UseMnemonic = false;
			this.dashbordbtn.UseVisualStyleBackColor = false;
			this.dashbordbtn.Click += new System.EventHandler(this.dashbordbtn_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.studentsbtn);
			this.panel3.Location = new System.Drawing.Point(3, 131);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(333, 135);
			this.panel3.TabIndex = 4;
			// 
			// studentsbtn
			// 
			this.studentsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.studentsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.studentsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.studentsbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentsbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.studentsbtn.Image = ((System.Drawing.Image)(resources.GetObject("studentsbtn.Image")));
			this.studentsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.studentsbtn.Location = new System.Drawing.Point(0, 0);
			this.studentsbtn.Margin = new System.Windows.Forms.Padding(0);
			this.studentsbtn.Name = "studentsbtn";
			this.studentsbtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.studentsbtn.Size = new System.Drawing.Size(216, 135);
			this.studentsbtn.TabIndex = 2;
			this.studentsbtn.Text = "         Students";
			this.studentsbtn.UseMnemonic = false;
			this.studentsbtn.UseVisualStyleBackColor = false;
			this.studentsbtn.Click += new System.EventHandler(this.studentsbtn_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.Controls.Add(this.coursesbtn);
			this.panel4.Location = new System.Drawing.Point(3, 272);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(333, 122);
			this.panel4.TabIndex = 5;
			// 
			// coursesbtn
			// 
			this.coursesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.coursesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.coursesbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coursesbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.coursesbtn.Image = ((System.Drawing.Image)(resources.GetObject("coursesbtn.Image")));
			this.coursesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.coursesbtn.Location = new System.Drawing.Point(0, 0);
			this.coursesbtn.Margin = new System.Windows.Forms.Padding(0);
			this.coursesbtn.Name = "coursesbtn";
			this.coursesbtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.coursesbtn.Size = new System.Drawing.Size(216, 122);
			this.coursesbtn.TabIndex = 2;
			this.coursesbtn.Text = "        Grades";
			this.coursesbtn.UseMnemonic = false;
			this.coursesbtn.UseVisualStyleBackColor = false;
			this.coursesbtn.Click += new System.EventHandler(this.coursesbtn_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.Controls.Add(this.button1);
			this.panel6.Location = new System.Drawing.Point(3, 400);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(333, 122);
			this.panel6.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.button1.Size = new System.Drawing.Size(216, 122);
			this.button1.TabIndex = 2;
			this.button1.Text = "      Exams";
			this.button1.UseMnemonic = false;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Controls.Add(this.examsbtn);
			this.panel5.Location = new System.Drawing.Point(3, 528);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(333, 122);
			this.panel5.TabIndex = 6;
			// 
			// examsbtn
			// 
			this.examsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.examsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.examsbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.examsbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.examsbtn.Image = ((System.Drawing.Image)(resources.GetObject("examsbtn.Image")));
			this.examsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.examsbtn.Location = new System.Drawing.Point(-3, 0);
			this.examsbtn.Margin = new System.Windows.Forms.Padding(0);
			this.examsbtn.Name = "examsbtn";
			this.examsbtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.examsbtn.Size = new System.Drawing.Size(219, 122);
			this.examsbtn.TabIndex = 2;
			this.examsbtn.Text = "      Questions";
			this.examsbtn.UseMnemonic = false;
			this.examsbtn.UseVisualStyleBackColor = false;
			this.examsbtn.Click += new System.EventHandler(this.examsbtn_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(0, 653);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(219, 122);
			this.button2.TabIndex = 3;
			this.button2.Text = "       Logout";
			this.button2.UseMnemonic = false;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// sidebarTransition
			// 
			this.sidebarTransition.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panelContent
			// 
			this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new System.Drawing.Point(209, 80);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(1335, 768);
			this.panelContent.TabIndex = 10;
			this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint_1);
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
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// instructorLabel
			// 
			this.instructorLabel.AutoSize = true;
			this.instructorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instructorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.instructorLabel.Location = new System.Drawing.Point(392, 20);
			this.instructorLabel.Name = "instructorLabel";
			this.instructorLabel.Size = new System.Drawing.Size(247, 41);
			this.instructorLabel.TabIndex = 4;
			this.instructorLabel.Text = "Omar Mohamed";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(202, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 41);
			this.label4.TabIndex = 5;
			this.label4.Text = "Instructor :";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.instructorLabel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1544, 80);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// MainReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1544, 848);
			this.Controls.Add(this.panelContent);
			this.Controls.Add(this.sidebar);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "MainReportsForm";
			this.Text = "MainReportsForm";
			this.Load += new System.EventHandler(this.MainReportsForm_Load);
			this.sidebar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel sidebar;
		private System.Windows.Forms.Button dashbordbtn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button studentsbtn;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button coursesbtn;
		private System.Windows.Forms.Timer sidebarTransition;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button examsbtn;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label instructorLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
	}
}