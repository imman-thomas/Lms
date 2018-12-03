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
    public partial class TranReport : Form
    {
        public TranReport()
        {
            InitializeComponent();
        }

        private void TranReport_Load(object sender, EventArgs e)
        {
            DataSet2 ds = new DataSet2();
            DataSet2TableAdapters.GetReceiptTableAdapter ta = new DataSet2TableAdapters.GetReceiptTableAdapter();
            ta.Fill(ds.GetReceipt, IssueBook.TranID);

            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
