using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Template
{
    public partial class MainMember : Form
    {
        Member m;
        int posn;

        Libraryentities context = new Libraryentities();
        public MainMember()
        {
            InitializeComponent();
            posn = 1000;
        }

        private void MainMember_Load(object sender, EventArgs e)
        {

            PopTB();

        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {


            int finalnum = GetLastDataNum();

            m = new Member();

            m.MemberID = (finalnum+1).ToString();

            try
            {
                SaveTB();
                context.Members.Add(m);
                context.SaveChanges();
                MessageBox.Show(m.MemberID + " " + m.MemberName + "\n" + "Successfully Created");

                toolStripStatusLabel1.Text = "Member Successfully Created";

                //jump to last record Will

                //Will!!!!!!!!!!!!!!!!!!!!!!!
                posn = GetLastDataNum();
                PopTB();

            }
            catch (IdenticalID)
            {
                MessageBox.Show("Same NRIC Not Allowed");
            }
            catch (IdenticalEmailException)
            {
                MessageBox.Show("Same Email Address Not Allowed");
            }




        }

        private int GetLastDataNum()
        {
            int num = int.Parse(context.Members.OrderByDescending(x=>x.MemberID).First().MemberID);
            return num;
        }

        private void PopTB()

        {
            bool check = true;
            Member mem = null;
            while (check)
            {
                var q = from member in context.Members
                        where member.MemberID == posn.ToString()
                        select member;

                mem = q.FirstOrDefault();
                if (mem == null)
                {
                    posn++;
                }
                else
                {
                    break;
                }
            }


            idTB.Text = mem.MemberID;

            nameTB.Text = mem.MemberName;

            nricTB.Text = mem.MemberNRIC;

            mailTB.Text = mem.MemberEmail;

            phTB.Text = mem.MemberPhone.ToString();

            dateTimePicker1.Text = mem.MemberDoB.ToString();

            addrTB.Text = mem.MemberAddr;

            int finalnum = GetLastDataNum();

            if (posn == 1000)
            {
                toolStripStatusLabel1.Text = "First Record MemberID: " + " " + mem.MemberID;
            }
            else if (posn == finalnum)
            {
                toolStripStatusLabel1.Text = "Last Record MemberID: " + " " + mem.MemberID;
            }
            else
            {
                toolStripStatusLabel1.Text = "MemberID: " + " " + mem.MemberID;
            }

        }



        private void SaveTB()

        {

            m.MemberName = nameTB.Text;

            m.MemberNRIC = nricTB.Text;

            Member temp = context.Members.Where(x => x.MemberNRIC == nricTB.Text).FirstOrDefault();
            if (temp != null)
            {
                throw new IdenticalID();
            }

            m.MemberEmail = mailTB.Text;
            Member temp1 = context.Members.Where(x => x.MemberEmail == mailTB.Text).FirstOrDefault();
            if (temp1 != null)
            {
                throw new IdenticalEmailException();
            }

            m.MemberPhone = int.Parse(phTB.Text);

            m.MemberDoB = dateTimePicker1.Value.Date;

            m.MemberAddr = addrTB.Text;



        }

        private void UpdBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from Member in context.Members
                        where Member.MemberID == idTB.Text
                        select Member;
                Member m = q.First();
                m.MemberID = idTB.Text;
                m.MemberName = nameTB.Text;
                m.MemberNRIC = nricTB.Text;
                Member temp = context.Members.Where(x => x.MemberNRIC == m.MemberNRIC && x.MemberID != m.MemberID).FirstOrDefault();
                if (temp != null)
                {
                    throw new IdenticalID();
                }
                m.MemberEmail = mailTB.Text;
                Member temp1 = context.Members.Where(x => x.MemberEmail == m.MemberEmail && x.MemberID != m.MemberID).FirstOrDefault();
                if (temp1 != null)
                {
                    throw new IdenticalEmailException();
                }
                m.MemberPhone = int.Parse(phTB.Text);

                m.MemberDoB = dateTimePicker1.Value.Date;
                m.MemberAddr = addrTB.Text;
                context.SaveChanges();
                MessageBox.Show("MemberID:" + " " + m.MemberID + " " + "\n" + "Updated");
                toolStripStatusLabel1.Text = "Member Updated";
            }
            catch (IdenticalID)
            {
                MessageBox.Show("Same NRIC Not Allowed");
            }
            catch (IdenticalEmailException)
            {
                MessageBox.Show("Same Email Address Not Allowed");
            }





        }
        //Will!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void DelBTN_Click(object sender, EventArgs e)
        {
            var q = from member in context.Members
                    where member.MemberID == idTB.Text
                    select member;
            Member m = q.First();

            var q1 = from issuetran in context.IssueTrans
                     where issuetran.MemberID == m.MemberID
                     select issuetran;
            IssueTran it = q1.FirstOrDefault();

            if (it == null)
            {
                context.Members.Remove(m);
                MessageBox.Show("Member Deleted");

                context.SaveChanges();
                posn--;
                minusRetrieve();
            }

            else
            {

                MessageBox.Show(m.MemberID + " " + m.MemberName + "\n" + "Deletion not allowed \n " +
                    "Because he has transaction records");
                toolStripStatusLabel1.Text = "Member not Deleted";
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (posn < GetLastDataNum())
            {
                posn = posn + 1;

                PopTB();

            }

        }

        private void PrevBTN_Click(object sender, EventArgs e)
        {
            if (posn > 1000)
            {
                posn = posn - 1;
                minusRetrieve();
            }

        }

        private void minusRetrieve()
        {

            Member mem = null;
            while (true)
            {
                var q = from member in context.Members
                        where member.MemberID == posn.ToString()
                        select member;

                mem = q.FirstOrDefault();
                if (mem == null)
                {
                    posn--;
                }
                else
                {
                    break;
                }
            }


            idTB.Text = mem.MemberID;

            nameTB.Text = mem.MemberName;

            nricTB.Text = mem.MemberNRIC;

            mailTB.Text = mem.MemberEmail;

            phTB.Text = mem.MemberPhone.ToString();

            dateTimePicker1.Text = mem.MemberDoB.ToString();

            addrTB.Text = mem.MemberAddr;

            int finalnum = GetLastDataNum();

            if (posn == 1000)
            {
                toolStripStatusLabel1.Text = "First Record MemberID: " + " " + mem.MemberID;
            }
            else if (posn == finalnum)
            {
                toolStripStatusLabel1.Text = "Last Record MemberID: " + " " + mem.MemberID;
            }
            else
            {
                toolStripStatusLabel1.Text = "MemberID: " + " " + mem.MemberID;
            }
        }

        private void LastBTN_Click(object sender, EventArgs e)
        {


            posn = GetLastDataNum();

            PopTB();
        }

        private void firstBTN_Click(object sender, EventArgs e)
        {


            posn = 1000;

            PopTB();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {


            Member z = context.Members.Where(x => x.MemberID.ToLower() == searchTB.Text.ToLower().Trim()
            || x.MemberNRIC.ToLower() == searchTB.Text.ToLower().Trim()).FirstOrDefault();

            if (z == null)
            {

                MessageBox.Show("Member not found!");

                toolStripStatusLabel1.Text = ("Error!" + " " + "Member not found!");

            }
            else
            {
                idTB.Text = z.MemberID;

                nameTB.Text = z.MemberName;

                nricTB.Text = z.MemberNRIC;

                mailTB.Text = z.MemberEmail;

                phTB.Text = z.MemberPhone.ToString();

                dateTimePicker1.Text = z.MemberDoB.ToString();

                addrTB.Text = z.MemberAddr;

                int finalnum = GetLastDataNum();

                if (posn == 1000)
                {
                    toolStripStatusLabel1.Text = "First Record MemberID: " + " " + z.MemberID;
                }
                else if (posn == finalnum)
                {
                    toolStripStatusLabel1.Text = "Last Record MemberID: " + " " + z.MemberID;
                }
                else
                {
                    toolStripStatusLabel1.Text = "MemberID: " + " " + z.MemberID;
                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = Convert.ToDateTime("1918-01-01");
        }
    }
    class IdenticalID : ApplicationException
    {
        public IdenticalID() : base() { }
        public IdenticalID(string message) : base(message) { }


    }
}

