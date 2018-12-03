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
    public partial class MainForm : Form
    {

        //dont't change this part, this is for form moving
        bool drag = false;
        Point startpoint = new Point(0,0);
        //dont't change this part, this is for form moving

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            IssueBook form = new IssueBook();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel =
            false;
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void issuebtn_Click(object sender, EventArgs e)
        {
            //panel change start
            panelLeft.Height = issuebtn.Height;
            panelLeft.Top = issuebtn.Top;
            //panel change over
            panel2.Controls.Clear();
            IssueBook form = new IssueBook();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel =
            false;
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            //panel change start
            panelLeft.Height = returnbtn.Height;
            panelLeft.Top = returnbtn.Top;
            //panel change over
            panel2.Controls.Clear();
            ReturnBook form =new ReturnBook();
            form.FormBorderStyle = FormBorderStyle.None; 
            form.TopLevel =
            false; 
            this.panel2.Controls.Add(form);
            form.Show();



        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            //panel change start
            panelLeft.Height = bookbtn.Height;
            panelLeft.Top = bookbtn.Top;
            //panel change over
            panel2.Controls.Clear();
            MBook form = new MBook();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel =
            false;
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            //panel change start
            panelLeft.Height = memberbtn.Height;
            panelLeft.Top = memberbtn.Top;
            //panel change over
            panel2.Controls.Clear();
            MainMember form = new MainMember();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel =
            false;
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //dont't change this part, this is for form moving
            drag = true;
            startpoint = new Point(e.X, e.Y);
            //dont't change this part, this is for form moving

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //dont't change this part, this is for form moving
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startpoint.X, p.Y - startpoint.Y);
            }
            //dont't change this part, this is for form moving

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //dont't change this part, this is for form moving
            drag = false;
            startpoint = new Point(e.X, e.Y);
            //dont't change this part, this is for form moving
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            Login.Userid = "";
            this.Close();
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Alt)
            {
                issuebtn.Text = "[I]ssue Books";
                returnbtn.Text = "[R]eturn Books";
                bookbtn.Text = "Maintain [B]ooks";
                memberbtn.Text = "Maintain [M]embers";

                if (e.KeyCode == Keys.I)
                {
                    //panel change start
                    panelLeft.Height = issuebtn.Height;
                    panelLeft.Top = issuebtn.Top;
                    //panel change over
                    panel2.Controls.Clear();
                    IssueBook form = new IssueBook();
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.TopLevel =
                    false;
                    this.panel2.Controls.Add(form);
                    form.Show();
                }
                if (e.KeyCode == Keys.R)
                {
                    //panel change start
                    panelLeft.Height = returnbtn.Height;
                    panelLeft.Top = returnbtn.Top;
                    //panel change over
                    panel2.Controls.Clear();
                    ReturnBook form = new ReturnBook();
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.TopLevel =
                    false;
                    this.panel2.Controls.Add(form);
                    form.Show();
                }
                if (e.KeyCode == Keys.B)
                {
                    //panel change start
                    panelLeft.Height = bookbtn.Height;
                    panelLeft.Top = bookbtn.Top;
                    //panel change over
                    panel2.Controls.Clear();
                    MBook form = new MBook();
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.TopLevel =
                    false;
                    this.panel2.Controls.Add(form);
                    form.Show();
                }
                if (e.KeyCode == Keys.M)
                {
                    //panel change start
                    panelLeft.Height = memberbtn.Height;
                    panelLeft.Top = memberbtn.Top;
                    //panel change over
                    panel2.Controls.Clear();
                    MainMember form = new MainMember();
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.TopLevel =
                    false;
                    this.panel2.Controls.Add(form);
                    form.Show();
                }

            }




        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
                issuebtn.Text = "Issue Books";
                returnbtn.Text = "Return Books";
                bookbtn.Text = "Maintain Books";
                memberbtn.Text = "Maintain Members";
        }
    }
}
