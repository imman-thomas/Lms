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
    public partial class Login : Form
    {

        Libraryentities context = new Libraryentities();
        private const String DEFAULT_TEXT = "User ID";
        private const String DEFAULT_TEXT1 = "Password";
        static string userid="";

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetDefaultText();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            Secretlbl.Visible = false;

        }
        static public string Userid
        {
            get
            {
                return userid;
            }
            set
            {
                if(value=="")
                userid = value;
            }
        }

        private void SetDefaultText()
        {
            IDtxt.Text = DEFAULT_TEXT;
            IDtxt.ForeColor = Color.Gray;
            Passtxt.PasswordChar= '\0';
            Passtxt.Text = DEFAULT_TEXT1;
            Passtxt.ForeColor = Color.Gray;
            
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logintxt_Click(object sender, EventArgs e)
        {
            Libraryentities context = new Libraryentities();
            Librarian L = context.Librarians.Where(x => x.LoginID.ToLower() == IDtxt.Text.ToLower().Trim()).FirstOrDefault();
            if(L==null)
            {
                MessageBox.Show("User Not Exist");
            }
            else
            {

            

            if(L.Password==Passtxt.Text)
            {
                MainForm M = new MainForm();
                M.Show();
                this.Hide();
                userid = L.LoginID;
            }
            else
            {
                label1.Text = "Wrong Password";
            }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            Passtxt.Text = null;
            ResetPassword RSP = new ResetPassword();
            
            RSP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IDtxt_Enter(object sender, EventArgs e)
        {
            if (IDtxt.Text == DEFAULT_TEXT)
            {
                IDtxt.Text = "";
                IDtxt.ForeColor = Color.Black;
            }
        }

        private void Passtxt_Enter(object sender, EventArgs e)
        {
            if (Passtxt.Text == DEFAULT_TEXT1)
            {
                Passtxt.Text = "";
                Passtxt.PasswordChar = '*';
                Passtxt.ForeColor = Color.Black;
            }
        }

        private void IDtxt_Leave(object sender, EventArgs e)
        {
            if(IDtxt.Text.ToLower()=="venkat")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                Secretlbl.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                Secretlbl.Visible = false;
            }
        }
    }
}
