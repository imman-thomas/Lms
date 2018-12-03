namespace Template
{
    partial class IssueBook
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.removebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bookDetailsButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.IssueButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bookID = new System.Windows.Forms.TextBox();
            this.memberid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.memberDetailButton = new System.Windows.Forms.Button();
            this.issueBookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(201, 404);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 37);
            this.dateTimePicker2.TabIndex = 4;
            this.issueBookToolTip.SetToolTip(this.dateTimePicker2, "Choose the due date when books should be returned");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "MemberID";
            // 
            // removebutton
            // 
            this.removebutton.FlatAppearance.BorderSize = 0;
            this.removebutton.Location = new System.Drawing.Point(516, 242);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(75, 33);
            this.removebutton.TabIndex = 27;
            this.removebutton.Text = "<";
            this.issueBookToolTip.SetToolTip(this.removebutton, "Click to remove book from list");
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(56, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "BookID";
            // 
            // addbutton
            // 
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.Location = new System.Drawing.Point(516, 189);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 35);
            this.addbutton.TabIndex = 26;
            this.addbutton.Text = ">";
            this.issueBookToolTip.SetToolTip(this.addbutton, "Click to add book to list");
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Issue Date";
            // 
            // bookDetailsButton
            // 
            this.bookDetailsButton.FlatAppearance.BorderSize = 0;
            this.bookDetailsButton.Location = new System.Drawing.Point(420, 114);
            this.bookDetailsButton.Name = "bookDetailsButton";
            this.bookDetailsButton.Size = new System.Drawing.Size(55, 30);
            this.bookDetailsButton.TabIndex = 22;
            this.bookDetailsButton.Text = "...";
            this.issueBookToolTip.SetToolTip(this.bookDetailsButton, "Click to search for books by title, genre or author");
            this.bookDetailsButton.UseVisualStyleBackColor = true;
            this.bookDetailsButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(597, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 460);
            this.listBox1.TabIndex = 24;
            // 
            // IssueButton
            // 
            this.IssueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.IssueButton.FlatAppearance.BorderSize = 0;
            this.IssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueButton.ForeColor = System.Drawing.Color.White;
            this.IssueButton.Location = new System.Drawing.Point(41, 539);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(211, 71);
            this.IssueButton.TabIndex = 25;
            this.IssueButton.Text = "Issue Books";
            this.issueBookToolTip.SetToolTip(this.IssueButton, "Click to confirm issuing books");
            this.IssueButton.UseVisualStyleBackColor = false;
            this.IssueButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(56, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Due Date";
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(201, 114);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(199, 35);
            this.bookID.TabIndex = 1;
            // 
            // memberid
            // 
            this.memberid.Location = new System.Drawing.Point(201, 205);
            this.memberid.Name = "memberid";
            this.memberid.Size = new System.Drawing.Size(199, 35);
            this.memberid.TabIndex = 2;
            this.memberid.TextChanged += new System.EventHandler(this.memberid_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 37);
            this.dateTimePicker1.TabIndex = 3;
            this.issueBookToolTip.SetToolTip(this.dateTimePicker1, "Choose date of issuance");
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 810);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1168, 37);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // memberDetailButton
            // 
            this.memberDetailButton.FlatAppearance.BorderSize = 0;
            this.memberDetailButton.Location = new System.Drawing.Point(420, 204);
            this.memberDetailButton.Name = "memberDetailButton";
            this.memberDetailButton.Size = new System.Drawing.Size(55, 30);
            this.memberDetailButton.TabIndex = 29;
            this.memberDetailButton.Text = "...";
            this.issueBookToolTip.SetToolTip(this.memberDetailButton, "Click to search for members by name or NRIC\r\n");
            this.memberDetailButton.UseVisualStyleBackColor = true;
            this.memberDetailButton.Click += new System.EventHandler(this.memberDetailButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 71);
            this.button1.TabIndex = 30;
            this.button1.Text = "IssueReceipt";
            this.issueBookToolTip.SetToolTip(this.button1, "Click to confirm issuing books");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueBook
            // 
            this.AcceptButton = this.IssueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1168, 847);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memberDetailButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookDetailsButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.IssueButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.memberid);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "IssueBook";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookDetailsButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button IssueButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.TextBox memberid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button memberDetailButton;
        private System.Windows.Forms.ToolTip issueBookToolTip;
        private System.Windows.Forms.Button button1;
    }
}