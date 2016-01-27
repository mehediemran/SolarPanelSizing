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
    public partial class mainMenue : Form
    {
        public mainMenue()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 addLocationForm = new Form1();
            addLocationForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewPanel addPanelForm = new addNewPanel();
            addPanelForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addnewBatt addBattForm = new addnewBatt();
            addBattForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wizerd wizerd = new wizerd();
            wizerd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            energyCalculation energyCalc = new energyCalculation();
            energyCalc.ShowDialog();
        }
        /*private void btnEnergyCalc_Click(object sender, EventArgs e)
        {
            energyCalculation energyCalc = new energyCalculation();
            energyCalc.ShowDialog();
        }*/
    }
}
