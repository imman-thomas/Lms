namespace Template
{
    partial class BookIDGridview
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.titleradiobutton = new System.Windows.Forms.RadioButton();
            this.genreradiobutton = new System.Windows.Forms.RadioButton();
            this.authorradiobutton = new System.Windows.Forms.RadioButton();
            this.BookIDGridViewtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1031, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.BookIDGridViewtoolTip.SetToolTip(this.button1, "Click here to search");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 31);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(56, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 494);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(186, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 84);
            this.button2.TabIndex = 6;
            this.button2.Text = "OK";
            this.BookIDGridViewtoolTip.SetToolTip(this.button2, "Click to confirm selection");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(559, 746);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 84);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancel";
            this.BookIDGridViewtoolTip.SetToolTip(this.button3, "Click to return to previous screen");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // titleradiobutton
            // 
            this.titleradiobutton.AutoSize = true;
            this.titleradiobutton.Checked = true;
            this.titleradiobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleradiobutton.Location = new System.Drawing.Point(305, 135);
            this.titleradiobutton.Name = "titleradiobutton";
            this.titleradiobutton.Size = new System.Drawing.Size(84, 29);
            this.titleradiobutton.TabIndex = 2;
            this.titleradiobutton.TabStop = true;
            this.titleradiobutton.Text = "Title";
            this.BookIDGridViewtoolTip.SetToolTip(this.titleradiobutton, "Search by title");
            this.titleradiobutton.UseVisualStyleBackColor = true;
            // 
            // genreradiobutton
            // 
            this.genreradiobutton.AutoSize = true;
            this.genreradiobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genreradiobutton.Location = new System.Drawing.Point(474, 135);
            this.genreradiobutton.Name = "genreradiobutton";
            this.genreradiobutton.Size = new System.Drawing.Size(102, 29);
            this.genreradiobutton.TabIndex = 3;
            this.genreradiobutton.TabStop = true;
            this.genreradiobutton.Text = "Genre";
            this.BookIDGridViewtoolTip.SetToolTip(this.genreradiobutton, "Search by genre");
            this.genreradiobutton.UseVisualStyleBackColor = true;
            // 
            // authorradiobutton
            // 
            this.authorradiobutton.AutoSize = true;
            this.authorradiobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorradiobutton.Location = new System.Drawing.Point(628, 135);
            this.authorradiobutton.Name = "authorradiobutton";
            this.authorradiobutton.Size = new System.Drawing.Size(106, 29);
            this.authorradiobutton.TabIndex = 4;
            this.authorradiobutton.TabStop = true;
            this.authorradiobutton.Text = "Author";
            this.BookIDGridViewtoolTip.SetToolTip(this.authorradiobutton, "Search by author");
            this.authorradiobutton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 834);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1632, 37);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // BookIDGridview
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1632, 871);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.authorradiobutton);
            this.Controls.Add(this.genreradiobutton);
            this.Controls.Add(this.titleradiobutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookIDGridview";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.BookIDGridview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton titleradiobutton;
        private System.Windows.Forms.RadioButton genreradiobutton;
        private System.Windows.Forms.RadioButton authorradiobutton;
        private System.Windows.Forms.ToolTip BookIDGridViewtoolTip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}