namespace Template
{
    partial class MainMember
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
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addrTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.phTB = new System.Windows.Forms.TextBox();
            this.nricTB = new System.Windows.Forms.TextBox();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.UpdBTN = new System.Windows.Forms.Button();
            this.DelBTN = new System.Windows.Forms.Button();
            this.PrevBTN = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LastBTN = new System.Windows.Forms.Button();
            this.firstBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maintainMemberToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBTN.Location = new System.Drawing.Point(730, 503);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(123, 36);
            this.searchBTN.TabIndex = 15;
            this.searchBTN.Text = "Search";
            this.maintainMemberToolTip.SetToolTip(this.searchBTN, "Click to search");
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(195, 505);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(514, 31);
            this.searchTB.TabIndex = 14;
            this.maintainMemberToolTip.SetToolTip(this.searchTB, "Please enter MemberID or NRIC");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "MemberID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "NRIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(472, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(472, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 736);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 37);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(194, 12);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(234, 31);
            this.idTB.TabIndex = 1;
            this.maintainMemberToolTip.SetToolTip(this.idTB, "MemberID is numeric");
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(194, 103);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(234, 31);
            this.nameTB.TabIndex = 2;
            // 
            // addrTB
            // 
            this.addrTB.Location = new System.Drawing.Point(642, 299);
            this.addrTB.Name = "addrTB";
            this.addrTB.Size = new System.Drawing.Size(354, 31);
            this.addrTB.TabIndex = 7;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(642, 205);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(354, 31);
            this.mailTB.TabIndex = 6;
            // 
            // phTB
            // 
            this.phTB.Location = new System.Drawing.Point(642, 103);
            this.phTB.Name = "phTB";
            this.phTB.Size = new System.Drawing.Size(354, 31);
            this.phTB.TabIndex = 5;
            this.maintainMemberToolTip.SetToolTip(this.phTB, "Phone number is numeric only");
            // 
            // nricTB
            // 
            this.nricTB.Location = new System.Drawing.Point(194, 203);
            this.nricTB.Name = "nricTB";
            this.nricTB.Size = new System.Drawing.Size(234, 31);
            this.nricTB.TabIndex = 3;
            this.maintainMemberToolTip.SetToolTip(this.nricTB, "NRIC starts and ends with an alphabet");
            // 
            // CreateBTN
            // 
            this.CreateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.CreateBTN.FlatAppearance.BorderSize = 0;
            this.CreateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBTN.ForeColor = System.Drawing.Color.White;
            this.CreateBTN.Location = new System.Drawing.Point(194, 423);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(211, 43);
            this.CreateBTN.TabIndex = 9;
            this.CreateBTN.Text = "Create Member";
            this.maintainMemberToolTip.SetToolTip(this.CreateBTN, "Click to add new member to database");
            this.CreateBTN.UseVisualStyleBackColor = false;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // UpdBTN
            // 
            this.UpdBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.UpdBTN.FlatAppearance.BorderSize = 0;
            this.UpdBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdBTN.ForeColor = System.Drawing.Color.White;
            this.UpdBTN.Location = new System.Drawing.Point(415, 423);
            this.UpdBTN.Name = "UpdBTN";
            this.UpdBTN.Size = new System.Drawing.Size(211, 43);
            this.UpdBTN.TabIndex = 10;
            this.UpdBTN.Text = "Update Member";
            this.maintainMemberToolTip.SetToolTip(this.UpdBTN, "Click to update current member");
            this.UpdBTN.UseVisualStyleBackColor = false;
            this.UpdBTN.Click += new System.EventHandler(this.UpdBTN_Click);
            // 
            // DelBTN
            // 
            this.DelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.DelBTN.FlatAppearance.BorderSize = 0;
            this.DelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBTN.ForeColor = System.Drawing.Color.White;
            this.DelBTN.Location = new System.Drawing.Point(642, 423);
            this.DelBTN.Name = "DelBTN";
            this.DelBTN.Size = new System.Drawing.Size(211, 43);
            this.DelBTN.TabIndex = 11;
            this.DelBTN.Text = "Delete Member";
            this.maintainMemberToolTip.SetToolTip(this.DelBTN, "Click to delete current member");
            this.DelBTN.UseVisualStyleBackColor = false;
            this.DelBTN.Click += new System.EventHandler(this.DelBTN_Click);
            // 
            // PrevBTN
            // 
            this.PrevBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.PrevBTN.FlatAppearance.BorderSize = 0;
            this.PrevBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBTN.ForeColor = System.Drawing.Color.White;
            this.PrevBTN.Location = new System.Drawing.Point(27, 423);
            this.PrevBTN.Name = "PrevBTN";
            this.PrevBTN.Size = new System.Drawing.Size(143, 43);
            this.PrevBTN.TabIndex = 8;
            this.PrevBTN.Text = "<";
            this.maintainMemberToolTip.SetToolTip(this.PrevBTN, "Click to view previous member in list");
            this.PrevBTN.UseVisualStyleBackColor = false;
            this.PrevBTN.Click += new System.EventHandler(this.PrevBTN_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(870, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 43);
            this.button6.TabIndex = 12;
            this.button6.Text = ">";
            this.maintainMemberToolTip.SetToolTip(this.button6, "Click to view next member in list");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LastBTN
            // 
            this.LastBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.LastBTN.FlatAppearance.BorderSize = 0;
            this.LastBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastBTN.ForeColor = System.Drawing.Color.White;
            this.LastBTN.Location = new System.Drawing.Point(870, 504);
            this.LastBTN.Name = "LastBTN";
            this.LastBTN.Size = new System.Drawing.Size(143, 43);
            this.LastBTN.TabIndex = 16;
            this.LastBTN.Text = ">>";
            this.maintainMemberToolTip.SetToolTip(this.LastBTN, "Click to view last member in list");
            this.LastBTN.UseVisualStyleBackColor = false;
            this.LastBTN.Click += new System.EventHandler(this.LastBTN_Click);
            // 
            // firstBTN
            // 
            this.firstBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.firstBTN.FlatAppearance.BorderSize = 0;
            this.firstBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstBTN.ForeColor = System.Drawing.Color.White;
            this.firstBTN.Location = new System.Drawing.Point(27, 503);
            this.firstBTN.Name = "firstBTN";
            this.firstBTN.Size = new System.Drawing.Size(143, 43);
            this.firstBTN.TabIndex = 13;
            this.firstBTN.Text = "<<";
            this.maintainMemberToolTip.SetToolTip(this.firstBTN, "Click to view first member in list");
            this.firstBTN.UseVisualStyleBackColor = false;
            this.firstBTN.Click += new System.EventHandler(this.firstBTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 299);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 31);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // MainMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1073, 773);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.firstBTN);
            this.Controls.Add(this.LastBTN);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.PrevBTN);
            this.Controls.Add(this.DelBTN);
            this.Controls.Add(this.UpdBTN);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.addrTB);
            this.Controls.Add(this.nricTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.phTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMember";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.MainMember_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox addrTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.TextBox phTB;
        private System.Windows.Forms.TextBox nricTB;
        private System.Windows.Forms.Button CreateBTN;
        private System.Windows.Forms.Button UpdBTN;
        private System.Windows.Forms.Button DelBTN;
        private System.Windows.Forms.Button PrevBTN;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button LastBTN;
        private System.Windows.Forms.Button firstBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolTip maintainMemberToolTip;
    }
}