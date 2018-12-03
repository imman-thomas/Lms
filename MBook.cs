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
    public partial class MBook : Form
    {
        Libraryentities context = new Libraryentities();

        int pos;
        static string searchtext;
        public MBook()
        {
            InitializeComponent();
            pos = 10000000;
        }
        static public string Searchtext
        {
            get
            {
                return searchtext;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void RetrieveMinus()
        {

            Book b = null;
            while (true)
            {
                var q = from book in context.Books
                        where book.BookID.Substring(1, 8) == pos.ToString()
                        select book;
                b = q.FirstOrDefault();
                if (b != null)
                {
                    break;
                }
                else
                {
                    pos--;
                }
            }



            BookIDtxt.Text = b.BookID;
            Titletxt.Text = b.BookTitle;
            GenreCombo.Text = b.BookGenre;
            Sectiontxt.Text = b.BookSection;
            instocktxt.Text = b.BookInStock.ToString();
            Loantxt.Text = b.BookLended.ToString();
            Authortxt.Text = b.Author;


            int finalnum = GetLastDataNumber();
            if (pos == 10000000)
            {
                toolStripStatusLabel1.Text = "First Record " + pos.ToString();
            }
            else if (pos == finalnum)
            {
                toolStripStatusLabel1.Text = "Last Record " + pos.ToString();
            }
            else
            {
                toolStripStatusLabel1.Text = "Record: " + pos.ToString();
            }

        }
        private void RetrieveADD()
        {

            Book b = null;
            while (true)
            {
                var q = from book in context.Books
                        where book.BookID.Substring(1, 8) == pos.ToString()
                        select book;
                b = q.FirstOrDefault();
                if (b != null)
                {
                    break;
                }
                else
                {
                    pos++;
                }
            }



            BookIDtxt.Text = b.BookID;
            Titletxt.Text = b.BookTitle;
            GenreCombo.Text = b.BookGenre;
            Sectiontxt.Text = b.BookSection;
            instocktxt.Text = b.BookInStock.ToString();
            Loantxt.Text = b.BookLended.ToString();
            Authortxt.Text = b.Author;


            int finalnum = GetLastDataNumber();
            if (pos == 10000000)
            {
                toolStripStatusLabel1.Text = "First Record " + pos.ToString();
            }
            else if (pos == finalnum)
            {
                toolStripStatusLabel1.Text = "Last Record " + pos.ToString();
            }
            else
            {
                toolStripStatusLabel1.Text = "Record: " + pos.ToString();
            }

        }
        public int GetLastDataNumber()
        {
            Libraryentities context = new Libraryentities();
            int num = int.Parse(context.Books.OrderByDescending(x => x.BookID).First().BookID.Substring(1, 8));
            return num;
        }

        private void MBook_Load(object sender, EventArgs e)
        {
            RetrieveADD();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pos > 10000000)
            {
                pos--;
                RetrieveMinus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pos < GetLastDataNumber())
            {
                pos++;
                RetrieveADD();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = GetLastDataNumber();
            pos = num;
            RetrieveADD();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pos = 10000000;
            RetrieveADD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookID = "B" + (GetLastDataNumber() + 1).ToString();
            b.BookTitle = Titletxt.Text;

            b.BookGenre = GenreCombo.Text;
            b.BookSection = Sectiontxt.Text;
            b.BookInStock = int.Parse(instocktxt.Text);
            b.BookLended = 0;
            b.Author = Authortxt.Text;

            context.Books.Add(b);
            context.SaveChanges();
            pos = GetLastDataNumber();

            RetrieveADD();
            toolStripStatusLabel1.Text = "Successful!";
            MessageBox.Show("Successful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book b = context.Books.Where(x => x.BookID == "B" + pos.ToString()).First();

            b.BookTitle = Titletxt.Text;

            b.BookGenre = GenreCombo.Text;
            b.BookSection = Sectiontxt.Text;
            b.BookInStock = int.Parse(instocktxt.Text);

            b.Author = Authortxt.Text;

            context.SaveChanges();
            MessageBox.Show("Successful");

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (context.Books.Where(x => x.BookID == "B" + pos.ToString()).Count() != 0)
            {
                Book b = context.Books.Where(x => x.BookID == "B" + pos.ToString()).First();
                TransactionDetail td = context.TransactionDetails.Where(x => x.BookID == b.BookID).FirstOrDefault();
                if (td == null)
                {
                    context.Books.Remove(b);

                    context.SaveChanges();

                    MessageBox.Show("Successful");
                    pos = GetLastDataNumber();
                    RetrieveADD();

                }
                else
                {
                    MessageBox.Show("Cannot delete this record because it has trasaction history");
                }


            }
            //else
            //{
            //    MessageBox.Show("");
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BookidRadioBtn.Checked == true)
            {


                Book b = context.Books.Where(x => x.BookID.ToLower().Trim() == Searchtxt.Text.ToLower().Trim()).FirstOrDefault();

                if (b == null)
                {
                    MessageBox.Show("Book Not Found");
                    toolStripStatusLabel1.Text = "Book ID Not Found";

                }
                else
                {
                    pos = int.Parse(b.BookID.Substring(1, 8));
                    RetrieveADD();
                }
            }
            else if (TitleRadiobtn.Checked == true)
            {
                searchtext = Searchtxt.Text;
                Book b = context.Books.Where(x => x.BookTitle.ToLower().Trim().Contains(searchtext.ToLower().Trim())).FirstOrDefault();
                if (b != null)
                {
                    SearchbyTitle S = new SearchbyTitle();
                    DialogResult r = S.ShowDialog();
                    if (r == DialogResult.OK)
                    {

                        pos = int.Parse(SearchbyTitle.SelectStr.Substring(1, 8));
                        RetrieveADD();

                    }

                }
                else
                {
                    MessageBox.Show("Book Not Found");
                    toolStripStatusLabel1.Text = "Book ID Not Found";
                }


            }
            else
            {
                searchtext = Searchtxt.Text;
                Book b = context.Books.Where(x => x.BookGenre.ToLower().Contains(searchtext.Trim().ToLower())).FirstOrDefault();

                if (b != null)
                {

                    searchbygenre S = new searchbygenre();
                    DialogResult r = S.ShowDialog();
                    if (r == DialogResult.OK)
                    {

                        pos = int.Parse(searchbygenre.SelectStr.Substring(1, 8));
                        RetrieveADD();



                    }
                }
                else
                {
                    MessageBox.Show("Book Not Found");
                    toolStripStatusLabel1.Text = "Book ID Not Found";
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            BooksListForm blm = new BooksListForm();
            blm.ShowDialog();
         
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            BooksChart bc = new BooksChart();
            bc.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CrossTab ct = new CrossTab();
            ct.ShowDialog();
        }
    }
}
