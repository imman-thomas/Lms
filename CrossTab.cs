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
    public partial class CrossTab : Form
    {
        public CrossTab()
        {
            InitializeComponent();
        }

        private void CrossTab_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();

            DataSet1TableAdapters.BooksTableAdapter ta = new DataSet1TableAdapters.BooksTableAdapter();

            ta.Fill(ds.Books);



            DataSet1 ds1 = new DataSet1();

            DataSet1TableAdapters.IssueTransTableAdapter dst = new DataSet1TableAdapters.IssueTransTableAdapter();

            dst.Fill(ds.IssueTrans);



            DataSet1 ds2 = new DataSet1();

            DataSet1TableAdapters.TransactionDetailsTableAdapter trda = new DataSet1TableAdapters.TransactionDetailsTableAdapter();

            trda.Fill(ds.TransactionDetails);



            BooksCrossTabReport cr = new BooksCrossTabReport();

            cr.SetDataSource(ds);

            crystalReportViewer2.ReportSource = cr;
        }
    }
}
