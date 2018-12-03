using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class MemberIDgridview : Form
    {
        private string memberID;
        public MemberIDgridview()
        {
            InitializeComponent();
        }

        public string MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        private void MemberIDgridview_Load(object sender, EventArgs e)
        {
            
            Libraryentities context = new Libraryentities();
            List<Member> lst = context.Members.ToList();
            dataGridView1.DataSource = lst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memberID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                bool ischecked1, ischecked2;
                ischecked1 = nameradiobutton.Checked;
                ischecked2 = nricradiobutton.Checked;
                if (ischecked1)
                {
                    Libraryentities context = new Libraryentities();
                    List<Member> b = context.Members.Where(x => x.MemberName.Contains(textBox1.Text.Trim())).ToList();
                    dataGridView1.DataSource = b.ToList();
                }
               else if (ischecked2)
                {
                    Libraryentities context = new Libraryentities();
                    List<Member> b = context.Members.Where(x => x.MemberNRIC.Contains(textBox1.Text.Trim())).ToList();
                    dataGridView1.DataSource = b.ToList();
                }
                else
                {
                    MessageBox.Show("Enter Value in TextBox");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            memberID = Convert.ToString(row.Cells[0].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
