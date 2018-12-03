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
    public partial class BooksListForm : Form
    {
        public BooksListForm()
        {
            InitializeComponent();
        }

        private void BooksListForm_Load(object sender, EventArgs e)
        {
            Libraryentities context = new Libraryentities();

            var d = from x in context.Books

                    select new

                    {

                        x.BookID,

                        x.BookTitle,

                        x.Author,

                        x.BookGenre,

                    };

            BookListReport cr = new BookListReport();

            cr.SetDataSource(d);

            crystalReportViewer1.ReportSource = cr;
        }
    }
}
