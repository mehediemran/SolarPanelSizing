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
    public partial class FinalReport : Form
    {
        public FinalReport()
        {
            InitializeComponent();
        }

        private void systemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.systemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.solarpvbdDataSet);

        }

        private void systemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.systemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.solarpvbdDataSet);

        }

        private void FinalReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'solarpvbdDataSet.System' table. You can move, or remove it, as needed.
         //   this.systemTableAdapter.Fill(this.solarpvbdDataSet.System);

        }

        private void systemBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
