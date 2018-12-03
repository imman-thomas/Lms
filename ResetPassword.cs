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
    public partial class ResetPassword : Form
    {
        private const String DEFAULT_TEXT = "Password";
        private const String DEFAULT_TEXT1 = "What is your favorite animal?";
        private const String DEFAULT_TEXT2 = "User ID";

        Libraryentities context = new Libraryentities();

        public ResetPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetDefaultText();


        }
        private void SetDefaultText()
        {
            textBox2.Text = DEFAULT_TEXT;
            textBox2.ForeColor = Color.Gray;
            textBox1.Text = DEFAULT_TEXT2;
            textBox1.ForeColor = Color.Gray;
            textBox3.Text = DEFAULT_TEXT1;
            textBox3.ForeColor = Color.Gray;
        }
         

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == DEFAULT_TEXT2)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == DEFAULT_TEXT)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            if (textBox3.Text == DEFAULT_TEXT1)
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                Librarian L = context.Librarians.Where(x => x.LoginID.ToLower() == textBox1.Text.ToLower().Trim()).FirstOrDefault();
                if (L != null)
                {
                    if (L.SecurityAns.ToLower() == textBox3.Text.ToLower().Trim())
                    {
                        L.Password = textBox2.Text;
                        context.SaveChanges();
                    MessageBox.Show("Successful!");
                    this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Security Question is not correct");
                    }
                }
                else
                {
                    MessageBox.Show("Librarian ID doesn't exit");
                }
            
           
        }
    }
}
