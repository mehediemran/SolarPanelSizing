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
    public partial class systemDetails : Form
    {
        public systemDetails()
        {
            InitializeComponent();
        }

        private void systemDetails_Load(object sender, EventArgs e)
        {
            housenumberTextBox.Text = Convert.ToString(GlobalVariables.housenumber);
            //designIDTextBox.Text = (GlobalVariables);
                locationTextBox.Text=Convert.ToString(GlobalVariables.ChosenLocation);
                irradTextBox.Text=Convert.ToString(GlobalVariables.ChosenLocationIrrad);
                totKwattTextBox.Text = Convert.ToString(GlobalVariables.totKwatt);
                panelModelTextBox.Text=Convert.ToString(GlobalVariables.ChosenPanelModel);
                noPanelTextBox.Text=Convert.ToString(GlobalVariables.noPanel);
                pnelPowTextBox.Text=Convert.ToString(GlobalVariables.chosenpnelPow);
                pnelVoltTextBox.Text=Convert.ToString(GlobalVariables.chosenpnelVolt);
                pnelCurrentTextBox.Text=Convert.ToString(GlobalVariables.chosenpnelCurrent);
                battModelTextBox.Text = Convert.ToString(GlobalVariables.ChosenBattModel);
                noofBattTextBox.Text=Convert.ToString(GlobalVariables.noofBatt);
                battVoltTextBox.Text=Convert.ToString(GlobalVariables.chosenBattVolt);
                battAHTextBox.Text =Convert.ToString(GlobalVariables.chosenBattAH);
                battCurrentTextBox.Text=Convert.ToString(GlobalVariables.chosenBattCurrent);
                daysTextBox.Text=Convert.ToString(GlobalVariables.days);
                wattHourReqTextBox.Text=Convert.ToString(GlobalVariables.wattHourRequire);
                battbankAHTextBox.Text=Convert.ToString(GlobalVariables.battbankAH);
                housenumberTextBox.Text = Convert.ToString(GlobalVariables.housenumber);
        }
    }
}
