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



    public partial class searchbygenre : Form
    {
        Libraryentities context = new Libraryentities();
        static string select;

        public searchbygenre()
        {
            InitializeComponent();
        }

        static public string SelectStr
        {
            get
            {
                return select;
            }
        }

        private void searchbygenre_Load(object sender, EventArgs e)
        {
            
            var q = from book in context.Books
                    where book.BookGenre.ToLower().Contains(MBook.Searchtext.ToLower())
                    select book;

            dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
