namespace Template
{
    partial class ReturnBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReturnListBox = new System.Windows.Forms.ListBox();
            this.LoanedListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.LoanedDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToDataGridButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MemberNRICLabel = new System.Windows.Forms.Label();
            this.MemberNRICTextBox = new System.Windows.Forms.TextBox();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LoanedDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnListBox
            // 
            this.ReturnListBox.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnListBox.FormattingEnabled = true;
            this.ReturnListBox.ItemHeight = 24;
            this.ReturnListBox.Location = new System.Drawing.Point(637, 459);
            this.ReturnListBox.Name = "ReturnListBox";
            this.ReturnListBox.Size = new System.Drawing.Size(229, 316);
            this.ReturnListBox.TabIndex = 21;
            // 
            // LoanedListBox
            // 
            this.LoanedListBox.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanedListBox.FormattingEnabled = true;
            this.LoanedListBox.ItemHeight = 24;
            this.LoanedListBox.Location = new System.Drawing.Point(336, 459);
            this.LoanedListBox.Name = "LoanedListBox";
            this.LoanedListBox.Size = new System.Drawing.Size(231, 316);
            this.LoanedListBox.TabIndex = 20;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(573, 615);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(59, 62);
            this.RemoveButton.TabIndex = 19;
            this.RemoveButton.Text = "<<";
            this.returnBookToolTip.SetToolTip(this.RemoveButton, "Click to remove book from list");
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(21, 686);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(310, 87);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Return";
            this.returnBookToolTip.SetToolTip(this.ReturnButton, "Click here to return selected books");
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // LoanedDataGridView
            // 
            this.LoanedDataGridView.AllowUserToAddRows = false;
            this.LoanedDataGridView.AllowUserToDeleteRows = false;
            this.LoanedDataGridView.AllowUserToOrderColumns = true;
            this.LoanedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoanedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LoanedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.LoanedDataGridView.Location = new System.Drawing.Point(21, 87);
            this.LoanedDataGridView.Name = "LoanedDataGridView";
            this.LoanedDataGridView.ReadOnly = true;
            this.LoanedDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoanedDataGridView.RowTemplate.Height = 50;
            this.LoanedDataGridView.RowTemplate.ReadOnly = true;
            this.LoanedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LoanedDataGridView.Size = new System.Drawing.Size(846, 307);
            this.LoanedDataGridView.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "BookTitle";
            this.Column1.HeaderText = "Book Title";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "BookID";
            this.Column2.HeaderText = "Book ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DateIssue";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Date Issued";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DateDue";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Date Due";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // AddToDataGridButton
            // 
            this.AddToDataGridButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.AddToDataGridButton.FlatAppearance.BorderSize = 0;
            this.AddToDataGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToDataGridButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToDataGridButton.ForeColor = System.Drawing.Color.White;
            this.AddToDataGridButton.Location = new System.Drawing.Point(573, 498);
            this.AddToDataGridButton.Name = "AddToDataGridButton";
            this.AddToDataGridButton.Size = new System.Drawing.Size(59, 64);
            this.AddToDataGridButton.TabIndex = 15;
            this.AddToDataGridButton.Text = ">>";
            this.returnBookToolTip.SetToolTip(this.AddToDataGridButton, "Click to add book to list");
            this.AddToDataGridButton.UseVisualStyleBackColor = false;
            this.AddToDataGridButton.Click += new System.EventHandler(this.AddToDataGridButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MemberNRICLabel);
            this.groupBox1.Controls.Add(this.MemberNRICTextBox);
            this.groupBox1.Controls.Add(this.RetrieveButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 237);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // MemberNRICLabel
            // 
            this.MemberNRICLabel.AutoSize = true;
            this.MemberNRICLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNRICLabel.ForeColor = System.Drawing.Color.White;
            this.MemberNRICLabel.Location = new System.Drawing.Point(43, 44);
            this.MemberNRICLabel.Name = "MemberNRICLabel";
            this.MemberNRICLabel.Size = new System.Drawing.Size(229, 30);
            this.MemberNRICLabel.TabIndex = 5;
            this.MemberNRICLabel.Text = "Member ID / NRIC";
            // 
            // MemberNRICTextBox
            // 
            this.MemberNRICTextBox.Location = new System.Drawing.Point(48, 76);
            this.MemberNRICTextBox.Name = "MemberNRICTextBox";
            this.MemberNRICTextBox.Size = new System.Drawing.Size(199, 47);
            this.MemberNRICTextBox.TabIndex = 6;
            this.returnBookToolTip.SetToolTip(this.MemberNRICTextBox, "Please enter the NRIC of the member");
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.RetrieveButton.FlatAppearance.BorderSize = 0;
            this.RetrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveButton.ForeColor = System.Drawing.Color.White;
            this.RetrieveButton.Location = new System.Drawing.Point(48, 154);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(198, 48);
            this.RetrieveButton.TabIndex = 0;
            this.RetrieveButton.Text = "Retrieve";
            this.returnBookToolTip.SetToolTip(this.RetrieveButton, "Click to retrieve all the books that the member has borrowed which are not yet re" +
        "turned");
            this.RetrieveButton.UseVisualStyleBackColor = false;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "LoanedListBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(632, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "ReturnListBox";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 820);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip2.Size = new System.Drawing.Size(895, 22);
            this.statusStrip2.TabIndex = 23;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(895, 842);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnListBox);
            this.Controls.Add(this.LoanedListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.LoanedDataGridView);
            this.Controls.Add(this.AddToDataGridButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReturnBook";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LoanedDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ReturnListBox;
        private System.Windows.Forms.ListBox LoanedListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.DataGridView LoanedDataGridView;
        private System.Windows.Forms.Button AddToDataGridButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MemberNRICLabel;
        private System.Windows.Forms.TextBox MemberNRICTextBox;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip returnBookToolTip;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

