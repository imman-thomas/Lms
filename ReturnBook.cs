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
    public partial class ReturnBook : Form
    {

        public ReturnBook()
        {
            InitializeComponent();
            
        }
        Libraryentities context = new Libraryentities();
        string input;
        private void RetrieveButton_Click(object sender, EventArgs e)
        {

            LoanedListBox.Items.Clear();
            ReturnListBox.Items.Clear();
            Member result = context.Members.Where(x => x.MemberNRIC.Contains(MemberNRICTextBox.Text.Trim().ToUpper()) 
            || x.MemberID.Contains(MemberNRICTextBox.Text.Trim()) ).FirstOrDefault();
            if (result is null)
            {
                MessageBox.Show("Please enter a valid MemberID / NRIC");
            }
            else
            {
                {
                    LoanedDataGridView.DataSource = context.TransactionDetails.Where
                        (x => x.BorrowStatus == "out" && (x.IssueTran.Member.MemberNRIC == MemberNRICTextBox.Text.Trim().ToUpper() 
                        || x.IssueTran.Member.MemberID == MemberNRICTextBox.Text.Trim().ToUpper())).Select
                        (y => new { y.Book.BookTitle, y.Book.BookID, y.IssueTran.DateIssue, y.IssueTran.DateDue }).OrderBy(z=>z.DateDue).ToList();

                    if (LoanedDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No loan record found for selected member");
                    }
                }


                for (int i = 0; i < LoanedDataGridView.Rows.Count; i++)
                {
                    string s = LoanedDataGridView.Rows[i].Cells[1].Value.ToString();
                    LoanedListBox.Items.Add(s);
                }

                input = MemberNRICTextBox.Text.Trim().ToUpper();
            }
        }

        private void AddToDataGridButton_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnListBox.Items.Add(LoanedListBox.SelectedItem);
                LoanedListBox.Items.Remove(LoanedListBox.SelectedItem);
            }
            catch (Exception )
            {
                statusStrip2.Visible = true;
                statusStrip2.Text = "Please select a book to return";
            }


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoanedListBox.Items.Add(ReturnListBox.SelectedItem);
                ReturnListBox.Items.Remove(ReturnListBox.SelectedItem);
            }
            catch (Exception )
            {
                statusStrip2.Visible = true;
                statusStrip2.Text = "Please select a book to remove";
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Libraryentities context = new Libraryentities();
            try
            {

                int result = 0;
                if (ReturnListBox.Items.Count != 0)
                {
                    for (int i = 0; i < ReturnListBox.Items.Count; i++)
                    {
                        string s = ReturnListBox.Items[i].ToString();

                        TransactionDetail detail = context.TransactionDetails.Where
                        (x => x.BorrowStatus == "out" && x.BookID == s && (x.IssueTran.MemberID == input || x.IssueTran.Member.MemberNRIC == input)).First();

                        Book book = context.Books.Where
                            (x => x.BookID == s).First();

                        if (book.BookLended > 0)
                        {
                            book.BookLended--;
                            result++;
                            detail.DateActualReturn = DateTime.Now.Date;
                            detail.BorrowStatus = "Returned";
                            context.SaveChanges();
                            
                        }
                        else
                        {
                            MessageBox.Show("Please check book inventory: number of books loaned out is 0");
                        }
                    }
                    if (result>0)
                    {
                        MessageBox.Show("Records Updated");
                    }


                }
                else
                {
                    statusStrip2.Visible = true;
                    statusStrip2.Text = "No books selected for return";
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Please check book inventory");
            }

            LoanedListBox.Items.Clear();
            ReturnListBox.Items.Clear();
            MemberNRICTextBox.Text = null;
            LoanedDataGridView.DataSource = null;
        }
    }
}
