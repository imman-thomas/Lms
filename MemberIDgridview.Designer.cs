namespace Template
{
    partial class MemberIDgridview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nricradiobutton = new System.Windows.Forms.RadioButton();
            this.nameradiobutton = new System.Windows.Forms.RadioButton();
            this.MemberIDToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(39, 175);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 494);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(933, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.MemberIDToolTip.SetToolTip(this.button1, "Click to search by name or NRIC");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(569, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.MemberIDToolTip.SetToolTip(this.button3, "Click Cancel to return to previous screen");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(244, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.MemberIDToolTip.SetToolTip(this.button2, "Click OK to confirm selection");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nricradiobutton
            // 
            this.nricradiobutton.AutoSize = true;
            this.nricradiobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nricradiobutton.Location = new System.Drawing.Point(484, 123);
            this.nricradiobutton.Name = "nricradiobutton";
            this.nricradiobutton.Size = new System.Drawing.Size(93, 29);
            this.nricradiobutton.TabIndex = 3;
            this.nricradiobutton.Text = "NRIC";
            this.nricradiobutton.UseVisualStyleBackColor = true;
            // 
            // nameradiobutton
            // 
            this.nameradiobutton.AutoSize = true;
            this.nameradiobutton.Checked = true;
            this.nameradiobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameradiobutton.Location = new System.Drawing.Point(305, 123);
            this.nameradiobutton.Name = "nameradiobutton";
            this.nameradiobutton.Size = new System.Drawing.Size(99, 29);
            this.nameradiobutton.TabIndex = 2;
            this.nameradiobutton.TabStop = true;
            this.nameradiobutton.Text = "Name";
            this.nameradiobutton.UseVisualStyleBackColor = true;
            // 
            // MemberIDgridview
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1771, 871);
            this.Controls.Add(this.nricradiobutton);
            this.Controls.Add(this.nameradiobutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberIDgridview";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.MemberIDgridview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton nricradiobutton;
        private System.Windows.Forms.RadioButton nameradiobutton;
        private System.Windows.Forms.ToolTip MemberIDToolTip;
    }
}