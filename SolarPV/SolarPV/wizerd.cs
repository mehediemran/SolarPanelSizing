using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolarPV
{
    public partial class wizerd : Form
    {
        public wizerd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            energyCalculation energyCalc = new energyCalculation();
            energyCalc.ShowDialog();

        }

        private void wizerd_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.watt > 0)
            {
                txtbxReqEnergy.Text = Convert.ToString(GlobalVariables.watt);
            }
            else {
                txtbxReqEnergy.Text = "0";
            }

            if (GlobalVariables.totKwatt > 0)
            {
                txtbxReqEnergyKW.Text = Convert.ToString(GlobalVariables.totKwatt);
            }
            else {
                txtbxReqEnergyKW.Text = "0";
            }
            


            txtbxderate.Text = "75";
           // txtbxAutonomy.Text = "3";
            txtbxBattDischarge.Text = "50";

            cboDays.SelectedIndex = 0;

            txtbxReqWattHour.Text = Convert.ToString(GlobalVariables.watt);

            txtbxBattDischarge.Text = "50";
            cboSystemBattVolt.SelectedIndex = 0;

            
            

            // TODO: This line of code loads data into the 'solarpvbdDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Battery' table. You can move, or remove it, as needed.
            this.batteryTableAdapter.Fill(this.solarpvbdDataSet.Battery);
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Panel' table. You can move, or remove it, as needed.
            this.panelTableAdapter.Fill(this.solarpvbdDataSet.Panel);
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);

            /*   if (GlobalVariables.totKwatt > 0)
               {

                   txtbxReqEnergy.Text = Convert.ToString(GlobalVariables.watt);
                   txtbxReqEnergyKW.Text = Convert.ToString(GlobalVariables.totKwatt);
               }*/
                loadLocations();
                loadPanels();

           }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshReqEng_Click(object sender, EventArgs e)
        {
            txtbxReqEnergy.Text = Convert.ToString(GlobalVariables.watt);
           txtbxReqEnergyKW.Text = Convert.ToString(GlobalVariables.totKwatt);

         }

        private void loadLocations() {

            SqlConnection sqCon = new SqlConnection(global::SolarPV.Properties.Settings.Default.solarpvbdConnectionString);
            try
            {

                string sql = "SELECT LocationID,LocationName,irrad_month,irrad_year FROM Location";
                
                SqlCommand exeSql = new SqlCommand(sql, sqCon);
                
                sqCon.Open();

                SqlDataReader reader;
                reader = exeSql.ExecuteReader();
                DataTable locaTable = new DataTable();
                locaTable.Columns.Add("LocationID", typeof(int));
                locaTable.Columns.Add("LocationName", typeof(string));
                locaTable.Columns.Add("irrad_month", typeof(decimal));
                locaTable.Columns.Add("irrad_year", typeof(decimal)); 
                //locaTable.Columns.Add("LocationName", typeof(string));

                locaTable.Load(reader);

                cboLocation.ValueMember = "irrad_year";
                cboLocation.DisplayMember = "LocationName";
                cboLocation.DataSource = locaTable;
                               
                //MessageBox.Show("New location added to database", "Message", MessageBoxButtons.OK);
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                sqCon.Close();
            }
            cboLocation.SelectedIndex = -1;
        
        }

        private void loadPanels()
        {

            SqlConnection sqCon = new SqlConnection(global::SolarPV.Properties.Settings.Default.solarpvbdConnectionString);
            try
            {

                string sql = "SELECT PanelID,ModelNo,PanelTech,MaxPower,MaxVolt,OCVolt,SCCurrent FROM Panel";

                SqlCommand exeSql = new SqlCommand(sql, sqCon);

                sqCon.Open();

                SqlDataReader reader;
                reader = exeSql.ExecuteReader();
                DataTable panelTable = new DataTable();
                panelTable.Columns.Add("PanelID", typeof(int));
                panelTable.Columns.Add("ModelNo", typeof(string));
                panelTable.Columns.Add("PanelTech", typeof(string));
                panelTable.Columns.Add("MaxPower", typeof(decimal));
                panelTable.Columns.Add("MaxVolt", typeof(decimal));
                panelTable.Columns.Add("OCVolt", typeof(decimal));
                panelTable.Columns.Add("SCCurrent", typeof(decimal));

                //locaTable.Columns.Add("LocationName", typeof(string));

                panelTable.Load(reader);

                cboSolarPanel.DisplayMember = "ModelNo";
                cboSolarPanel.ValueMember = "MaxVolt";
                cboSolarPanel.DataSource = panelTable;

                        

                //MessageBox.Show("New location added to database", "Message", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                sqCon.Close();
            }
            cboSolarPanel.SelectedIndex = -1;

        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxirrad.Text = Convert.ToString(cboLocation.SelectedValue);
        }

        private void wizerd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LocadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            
                DataGridViewRow rowloc =this.LocadataGridView.Rows[e.RowIndex];

                txtbxLocationGrid.Text = rowloc.Cells["locationName"].Value.ToString(); //locationNameDataGridViewTextBoxColumn
                txtbxirradGrid.Text = rowloc.Cells["irradyearDataGridViewTextBoxColumn"].Value.ToString();
                
                GlobalVariables.ChosenLocation =  Convert.ToString(txtbxLocationGrid.Text);
                GlobalVariables.ChosenLocationIrrad = Convert.ToString(txtbxirradGrid.Text);

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cboSolarPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaneldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow rowpan = this.PaneldataGridView.Rows[e.RowIndex];

                txtbxPanelModel.Text = rowpan.Cells["modelNoDataGridViewTextBoxColumn"].Value.ToString();
                txtbxPanelMxPow.Text = rowpan.Cells["maxPowerDataGridViewTextBoxColumn"].Value.ToString();
                txtbxPanelMxVolt.Text = rowpan.Cells["maxVoltDataGridViewTextBoxColumn"].Value.ToString();
                txtbxPanelCurrent.Text = rowpan.Cells["sCCurrentDataGridViewTextBoxColumn"].Value.ToString();
                
                GlobalVariables.ChosenPanelModel = Convert.ToString(txtbxPanelModel.Text);

              //  string panelpower = txtbxPanelMxPow.Text;

                GlobalVariables.chosenpnelPow = double.Parse(txtbxPanelMxPow.Text);
                GlobalVariables.chosenpnelVolt = double.Parse(txtbxPanelMxVolt.Text);



            }
        }

        

        private void BattdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow rowbatt = this.BattdataGridView.Rows[e.RowIndex];

                txtbxBattMxVol.Text = rowbatt.Cells["nomVoltDataGridViewTextBoxColumn"].Value.ToString();
                txtbxBattModel.Text = rowbatt.Cells["modelNoDataGridViewTextBoxColumn1"].Value.ToString();
                txtbxBattCap.Text = rowbatt.Cells["capacityDataGridViewTextBoxColumn"].Value.ToString();
                txtbxBattMaxCurrent.Text = rowbatt.Cells["maxCurrentDataGridViewTextBoxColumn"].Value.ToString();

                GlobalVariables.ChosenBattModel = rowbatt.Cells["modelNoDataGridViewTextBoxColumn1"].Value.ToString();
                GlobalVariables.chosenBattVolt = double.Parse(txtbxBattMxVol.Text);
                GlobalVariables.chosenBattAH = double.Parse(txtbxBattCap.Text);


            }

        }

        private void btnCalcRE_Click(object sender, EventArgs e)
        {
            Double reqEng, insolation,consum;

            if ((txtbxirradGrid.Text != "") && (txtbxReqEnergyKW.Text != ""))
            {

                insolation = Convert.ToDouble(txtbxirradGrid.Text);
                consum = Convert.ToDouble(txtbxReqEnergyKW.Text);
                reqEng = consum / insolation;
                txtbxCalcRE.Text = Convert.ToString(reqEng);
            }
            else
            {
                MessageBox.Show("Power Concumption annd/or Insolation is unavailable");
            }
        }

        private void btnDerate_Click(object sender, EventArgs e)
        {
            Double reqEng, deratefactor, derateRE;

            if ((txtbxderate.Text != "") && (txtbxCalcRE.Text != ""))
            {

                reqEng = Convert.ToDouble(txtbxCalcRE.Text);
                deratefactor = Convert.ToDouble(txtbxderate.Text);
                derateRE = reqEng / (deratefactor/100);
                txtbxCalcderate.Text = Convert.ToString(derateRE);
            }
            else
            {
                MessageBox.Show("Required Power and/or de-rate factor is unavailable");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numberofpanels;
            double numofpan;
            double derateArraySize;
            double panelpower;

            if (txtbxCalcderate.Text != "") {

                if(txtbxPanelMxPow.Text != ""){

                    panelpower = Convert.ToDouble(txtbxPanelMxPow.Text);
                    derateArraySize = Convert.ToDouble(txtbxCalcderate.Text);
                    numofpan = (derateArraySize *1000)/panelpower;
                    numberofpanels =(int)Math.Ceiling(numofpan);
                    GlobalVariables.noPanel = numberofpanels;
                    txtbxNoPanelReq.Text = Convert.ToString(numberofpanels);
                }
                else{
                            MessageBox.Show("Nominal Panel Power (watt) is unavailable");
                }
            }
            else{
                        MessageBox.Show("De-rated Array size is unavailable");
            }
        }

        private void btncalcBattAH_Click(object sender, EventArgs e)
        {
            double BattMulFac;
            double dayautonomy;
            double dischargeper;
            double battCapAH;
            double watthHourReq;
            double systemVolt;
            double numberofBatt;
            int totBatt;
            double battcap;

           // if (cboDays.SelectedValue) { 

            dayautonomy = Convert.ToDouble(cboDays.SelectedItem);
            watthHourReq=Convert.ToDouble(txtbxReqWattHour.Text);
            systemVolt = Convert.ToDouble(txtbxBattMxVol.Text);
            battcap = Convert.ToDouble(txtbxBattCap.Text);
         //   }
            if (txtbxBattDischarge.Text != "")
            {
                dischargeper = Convert.ToDouble(txtbxBattDischarge.Text);
            }

            else {
                dischargeper = 50;
            }

            BattMulFac = 100 / dischargeper;
            battCapAH =Math.Ceiling((watthHourReq*BattMulFac)/systemVolt);
            GlobalVariables.battbankAH = battCapAH;
            txtbxBattCapAH.Text = Convert.ToString(battCapAH);

            numberofBatt = Math.Ceiling(battCapAH / battcap);
            totBatt = (int)numberofBatt;
            GlobalVariables.noofBatt = totBatt;
            txtbxNoBatt.Text = Convert.ToString(numberofBatt);

 

        }

        private void cboDays_SelectedIndexChanged(object sender, EventArgs e)
        {
           double dayautonomy;
           double watthHReq;

           dayautonomy = Convert.ToDouble(cboDays.SelectedItem);
           watthHReq = GlobalVariables.watt * dayautonomy;
           GlobalVariables.wattHourRequire = watthHReq;
           GlobalVariables.days = dayautonomy;
           txtbxReqWattHour.Text = Convert.ToString(watthHReq);

        }

        private void btnNexttoprint_Click(object sender, EventArgs e)
        {
            designReportViewer estimation1 = new designReportViewer();
            estimation1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtbxBattMaxCurrent.Text == "") {
                txtbxBattMaxCurrent.Text = "0";
            }
            
            if ((txtbxDesignName.Text == "")&&(txtbxDesignID.Text==""))
            {
                MessageBox.Show("A design name is required");
            }
            else {
                SqlConnection sqCon = new SqlConnection(global::SolarPV.Properties.Settings.Default.solarpvbdConnectionString);
                try
                {
                    string sql = "INSERT INTO System (designID,designName,location,irrad,totKwatt,panelModel,noPanel,pnelPow,pnelVolt,pnelCurrent,battModel,noofBatt,battVolt,battAH,battCurrent,days,wattHourReq,battbankAH) values(" + txtbxDesignID.Text + ",'" + txtbxDesignName.Text + "','" + txtbxLocationGrid.Text + "'," + txtbxirradGrid.Text + "," + txtbxReqEnergyKW.Text + ",'" + txtbxPanelModel.Text + "'," + txtbxNoPanelReq.Text + "," + txtbxPanelMxPow.Text + "," + txtbxPanelMxVolt.Text+ "," + txtbxPanelCurrent.Text + ",'" + txtbxBattModel.Text + "'," + txtbxNoBatt.Text + "," + txtbxBattMxVol.Text + "," + txtbxBattCap.Text + "," + txtbxBattMaxCurrent.Text + "," + cboDays.SelectedItem + "," + txtbxReqWattHour.Text + "," + txtbxBattCapAH.Text + ")";
                    SqlCommand exeSql = new SqlCommand(sql, sqCon);
                    sqCon.Open();
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("New Design estimations added to database", "Message", MessageBoxButtons.OK);

                  //  this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    sqCon.Close();
                }
            
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

       
    }
}
