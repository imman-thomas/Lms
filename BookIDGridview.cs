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
    public partial class BookIDGridview : Form
    {
        private string dgselected;
        public BookIDGridview()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = null;
        }

        public string Dgselected
        {
            get { return dgselected; }
            set { dgselected = value; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Libraryentities context = new Libraryentities();
            //int rowIndex = e.RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[rowIndex];
            //dgselected = Convert.ToString(row.Cells[0].Value);
            

        }

        private void BookIDGridview_Load(object sender, EventArgs e)
        {
            
            Libraryentities context = new Libraryentities();
            List<Book> lst = context.Books.ToList();
            dataGridView1.DataSource = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ischecked1, ischecked2, ischecked3;
            ischecked1 = titleradiobutton.Checked;
            ischecked2 = genreradiobutton.Checked;
            ischecked3 = authorradiobutton.Checked;
            if (ischecked1)
            {
                if (textBox1.Text.Trim() != "")
                {
                    Libraryentities context = new Libraryentities();
                    List<Book> b = context.Books.Where(x => x.BookTitle.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = b.ToList();
                 }
                else
                {
                    toolStripStatusLabel1.Text = "Type the Book Title";
                }

            }
            // Checking for Genre

            if (ischecked2)
            {
                if (textBox1.Text.Trim() != "")
                {
                    Libraryentities context = new Libraryentities();
                    List<Book> b = context.Books.Where(x => x.BookGenre.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = b.ToList();
                }
                else
                {
                    toolStripStatusLabel1.Text = "Type the Genre Title";
                }

            }

            // Checking for Author

            if (ischecked3)
            {
                if (textBox1.Text.Trim() != "")
                {
                    Libraryentities context = new Libraryentities();
                    List<Book> b = context.Books.Where(x => x.Author.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = b.ToList();
                }
                else
                {
                    toolStripStatusLabel1.Text = "Type the Book Author Name";
                }

            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgselected = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
