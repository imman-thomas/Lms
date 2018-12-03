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
    public partial class BooksChart : Form
    {
        public BooksChart()
        {
            InitializeComponent();
        }

        private void BooksChart_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();

            DataSet1TableAdapters.BooksTableAdapter ta = new DataSet1TableAdapters.BooksTableAdapter();

            ta.Fill(ds.Books);



            BooksChartReport cr = new BooksChartReport();

            cr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = cr;
        }
    }
}
