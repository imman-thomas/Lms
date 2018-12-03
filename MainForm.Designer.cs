namespace Template
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.returnbtn = new System.Windows.Forms.Button();
            this.bookbtn = new System.Windows.Forms.Button();
            this.memberbtn = new System.Windows.Forms.Button();
            this.issuebtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainScreenToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.returnbtn);
            this.panel1.Controls.Add(this.bookbtn);
            this.panel1.Controls.Add(this.memberbtn);
            this.panel1.Controls.Add(this.issuebtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 793);
            this.panel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(302, 146);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 130);
            this.panelLeft.TabIndex = 2;
            // 
            // returnbtn
            // 
            this.returnbtn.FlatAppearance.BorderSize = 0;
            this.returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.ForeColor = System.Drawing.Color.White;
            this.returnbtn.Image = global::Template.Properties.Resources._return;
            this.returnbtn.Location = new System.Drawing.Point(-1, 279);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(312, 127);
            this.returnbtn.TabIndex = 1;
            this.returnbtn.Text = "Return Books";
            this.returnbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainScreenToolTip.SetToolTip(this.returnbtn, "Click here to return books");
            this.returnbtn.UseVisualStyleBackColor = true;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // bookbtn
            // 
            this.bookbtn.FlatAppearance.BorderSize = 0;
            this.bookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookbtn.ForeColor = System.Drawing.Color.White;
            this.bookbtn.Image = global::Template.Properties.Resources.book;
            this.bookbtn.Location = new System.Drawing.Point(-3, 432);
            this.bookbtn.Name = "bookbtn";
            this.bookbtn.Size = new System.Drawing.Size(312, 127);
            this.bookbtn.TabIndex = 1;
            this.bookbtn.Text = "Maintain Books";
            this.bookbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainScreenToolTip.SetToolTip(this.bookbtn, "Click here to find, add, update or delete book information");
            this.bookbtn.UseVisualStyleBackColor = true;
            this.bookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // memberbtn
            // 
            this.memberbtn.FlatAppearance.BorderSize = 0;
            this.memberbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberbtn.ForeColor = System.Drawing.Color.White;
            this.memberbtn.Image = global::Template.Properties.Resources.person;
            this.memberbtn.Location = new System.Drawing.Point(-3, 592);
            this.memberbtn.Name = "memberbtn";
            this.memberbtn.Size = new System.Drawing.Size(312, 127);
            this.memberbtn.TabIndex = 1;
            this.memberbtn.Text = "Maintain Members";
            this.memberbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainScreenToolTip.SetToolTip(this.memberbtn, "Click here to find, add, update or delete member information");
            this.memberbtn.UseVisualStyleBackColor = true;
            this.memberbtn.Click += new System.EventHandler(this.memberbtn_Click);
            // 
            // issuebtn
            // 
            this.issuebtn.FlatAppearance.BorderSize = 0;
            this.issuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebtn.ForeColor = System.Drawing.Color.White;
            this.issuebtn.Image = global::Template.Properties.Resources.issuebook2;
            this.issuebtn.Location = new System.Drawing.Point(-3, 146);
            this.issuebtn.Name = "issuebtn";
            this.issuebtn.Size = new System.Drawing.Size(312, 127);
            this.issuebtn.TabIndex = 1;
            this.issuebtn.Text = "Issue Books";
            this.issuebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainScreenToolTip.SetToolTip(this.issuebtn, "Click here to issue books");
            this.issuebtn.UseVisualStyleBackColor = true;
            this.issuebtn.Click += new System.EventHandler(this.issuebtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 140);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Template.Properties.Resources.Untitled_6;
            this.pictureBox1.Location = new System.Drawing.Point(28, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(194)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(20, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(67, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "O";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(107)))), ((int)(((byte)(92)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(113, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 21);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(318, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 647);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1189, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 793);
            this.panel4.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Template.Properties.Resources.logout_1185746;
            this.pictureBox2.Location = new System.Drawing.Point(43, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.mainScreenToolTip.SetToolTip(this.pictureBox2, "Click here to logout");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1335, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button issuebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button returnbtn;
        private System.Windows.Forms.Button bookbtn;
        private System.Windows.Forms.Button memberbtn;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip mainScreenToolTip;
    }
}

