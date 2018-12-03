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
    public partial class IssueBook : Form
    {
        private int count=0;
        private int maintainTran = 0;
        static string tranID;
        public IssueBook()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = null;
        }
        static public string TranID
        {
            get
            {
                return tranID;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try

            {

                Libraryentities context = new Libraryentities();

                string a = bookID.Text;

                
                Book b = context.Books.Where(x => x.BookID == a).First();

                if (b.BookLended < b.BookInStock)

                {

                    count = 0;
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString().Equals(bookID.Text))
                        {
                            
                            count++;
                        }
                    }
                    if (count < b.BookInStock - b.BookLended)
                    {
                        listBox1.Items.Add(bookID.Text);

                    }
                }

                else

                {

                    MessageBox.Show("Not in Stock");

                }


            }

            catch

            {

                MessageBox.Show("As the BookID entered is InValid Try BookId- Details for Selection");
            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = 0;
            BookIDGridview BForm = new BookIDGridview();
            BForm.StartPosition = FormStartPosition.CenterParent;
            DialogResult r = BForm.ShowDialog();

            if(DialogResult.OK==r)
            {
                bookID.Text = BForm.Dgselected;
            }
            
            




        }

        private void button4_Click(object sender, EventArgs e)
        {
            MemberIDgridview MForm = new MemberIDgridview();
            DialogResult r = MForm.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            count = count - 1;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int rememberTran = 0;


            Libraryentities context = new Libraryentities();
            int num1 = context.TransactionDetails.Count();

            if (listBox1.Items.Count > 0)
            {
                //Libraryentities context = new Libraryentities();
                Member m = context.Members.Where(x => x.MemberID.Contains(memberid.Text.Trim())).FirstOrDefault();
                if (m is null)
                {
                    MessageBox.Show("Enter Valid MemberID");
                }
                else if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
                {
                    MessageBox.Show("Enter Valid Date");
                }
                else
                {
                    int count = listBox1.Items.Count;
                    IssueTran it = new IssueTran();

                    it.DateDue = dateTimePicker2.Value.Date;

                    it.DateIssue = dateTimePicker1.Value.Date;

                    it.MemberID = memberid.Text;

                    it.LoginID = Login.Userid;

                    int num = context.IssueTrans.Count() + 1;

                    it.TransactionID = "A" + num.ToString();
                    tranID = "A" + num.ToString();

                    context.IssueTrans.Add(it);
                    context.SaveChanges();

                    for (int i = 0; i < count; i++)

                    {

                        string a = listBox1.Items[i].ToString();

                        //   label5.Text = listBox1.Items[i].ToString();

                        Book b = context.Books.Where(x => x.BookID == a).First();

                        if (b.BookLended < b.BookInStock)
                        {

                            b.BookLended = b.BookLended + 1;

                            // Updating IssueTran Table

                            //IssueTran it = new IssueTran();

                            //it.DateDue = dateTimePicker2.Value.Date;

                            //it.DateIssue = dateTimePicker1.Value.Date;

                            //it.MemberID = memberid.Text;

                            //it.LoginID = Login.Userid;

                            //int num = context.IssueTrans.Count() + 1;

                            //it.TransactionID = "A" + num.ToString();


                            //context.IssueTrans.Add(it);

                            //Updating Transaction Details

                            TransactionDetail td = new TransactionDetail();

                            td.BookID = b.BookID;


                            num1 = context.TransactionDetails.Count() + 1;
                            if (rememberTran == 0)
                            {
                                maintainTran = maintainTran + 1;
                                num1 = num1 - maintainTran;

                            }
                            td.TransactionID = "A" + num.ToString();
                            td.DateActualReturn = null;
                            td.BorrowStatus = "out";
                            context.TransactionDetails.Add(td);
                            context.SaveChanges();


                        }





                        toolStripStatusLabel1.Text = "Books Issued Try Another Order";

                    }
                    //IssueTran it = new IssueTran();

                    //it.DateDue = dateTimePicker2.Value.Date;

                    //it.DateIssue = dateTimePicker1.Value.Date;

                    //it.MemberID = memberid.Text;

                    //it.LoginID = Login.Userid;

                    //int num = context.IssueTrans.Count() + 1;

                    //it.TransactionID = "A" + num1.ToString();


                    //context.IssueTrans.Add(it);
                    //context.SaveChanges();
                    MessageBox.Show("Book Issued");
                    listBox1.Items.Clear();
                    bookID.Text = null;
                    memberid.Text = null;
                }

            }
            else { toolStripStatusLabel1.Text = "Kindly enter the Book to the List"; }
        }

        private void memberDetailButton_Click(object sender, EventArgs e)
        {
            MemberIDgridview mIDdgv = new MemberIDgridview();
            mIDdgv.StartPosition = FormStartPosition.CenterParent;

            DialogResult r = mIDdgv.ShowDialog();

            if (DialogResult.OK == r)
            {
                memberid.Text = mIDdgv.MemberID;
            }
        }

        private void memberid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IssueBook.tranID!=null)
            {
                TranReport tr = new TranReport();
                tr.ShowDialog();
            }
          
        }
    }
}
