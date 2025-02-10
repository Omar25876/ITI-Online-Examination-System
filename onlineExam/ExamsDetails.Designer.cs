namespace WindowsFormsApp
{
    partial class ExamsDetails
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.myLabel = new System.Windows.Forms.Label();
			this.nextbtn = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.timer = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// myLabel
			// 
			this.myLabel.AutoSize = true;
			this.myLabel.BackColor = System.Drawing.Color.Transparent;
			this.myLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myLabel.ForeColor = System.Drawing.Color.Black;
			this.myLabel.Location = new System.Drawing.Point(31, 26);
			this.myLabel.Name = "myLabel";
			this.myLabel.Size = new System.Drawing.Size(90, 39);
			this.myLabel.TabIndex = 8;
			this.myLabel.Text = "label";
			this.myLabel.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// nextbtn
			// 
			this.nextbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextbtn.Location = new System.Drawing.Point(1323, 606);
			this.nextbtn.Name = "nextbtn";
			this.nextbtn.Size = new System.Drawing.Size(119, 44);
			this.nextbtn.TabIndex = 9;
			this.nextbtn.Text = "Next";
			this.nextbtn.UseVisualStyleBackColor = true;
			this.nextbtn.Click += new System.EventHandler(this.button2_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.Color.Black;
			this.radioButton1.Location = new System.Drawing.Point(29, 30);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(52, 40);
			this.radioButton1.TabIndex = 10;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "a";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.Color.Black;
			this.radioButton2.Location = new System.Drawing.Point(30, 94);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(53, 40);
			this.radioButton2.TabIndex = 11;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "b";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.Color.Black;
			this.radioButton3.Location = new System.Drawing.Point(30, 151);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(51, 40);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "c";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton4.ForeColor = System.Drawing.Color.Black;
			this.radioButton4.Location = new System.Drawing.Point(30, 207);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(53, 40);
			this.radioButton4.TabIndex = 13;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "d";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(36, 606);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 44);
			this.button1.TabIndex = 14;
			this.button1.Text = "Previous";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.myLabel);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1300, 96);
			this.panel1.TabIndex = 15;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.radioButton1);
			this.panel2.Controls.Add(this.radioButton2);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Location = new System.Drawing.Point(39, 138);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1291, 443);
			this.panel2.TabIndex = 16;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// timer
			// 
			this.timer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.timer.AutoSize = true;
			this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timer.Location = new System.Drawing.Point(688, 618);
			this.timer.Name = "timer";
			this.timer.Size = new System.Drawing.Size(66, 26);
			this.timer.TabIndex = 17;
			this.timer.Text = "00:00";
			this.timer.Click += new System.EventHandler(this.timer_Click);
			// 
			// ExamsDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1484, 742);
			this.Controls.Add(this.timer);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nextbtn);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ExamsDetails";
			this.Text = "Screen";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timer;
    }
}

