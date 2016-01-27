using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolarPV
{
    public partial class designReportViewer : Form
    {
        public designReportViewer()
        {
            InitializeComponent();
        }

        private void designReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'solarpvbdDataSet.System' table. You can move, or remove it, as needed.
            this.SystemTableAdapter.Fill(this.solarpvbdDataSet.System);

            this.reportViewer1.RefreshReport();
        }
    }
}
