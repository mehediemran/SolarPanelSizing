using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace SolarPV
{
    public partial class addNewPanel : Form
    {
        public addNewPanel()
        {
            InitializeComponent();
        }

        private void addNewPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Panel' table. You can move, or remove it, as needed.
            this.panelTableAdapter.Fill(this.solarpvbdDataSet.Panel);

        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            /*
            int panelID = Convert.ToInt16(txtbxpanelID.Text);
            string panelManu = txtbxPanelManu.Text;
            string panelModel= txtbxPanelModelNo.Text;
            string panelTech = txtbxPanelTech.Text;
            double maxPower = Convert.ToDouble(txtbxMaxPower.Text);
            double maxVolt = Convert.ToDouble(txtbxMaxVolt.Text);
            
            +","+txtbxOpenCV.Text+","+txtbxShortCC.Text+","+txtbxPanelTempCoeff.Text+","+txtbxPanelEfficiency.Text+","+txtbxPanelTolerance.Text+","+txtbxPanelEfficiency.Text+
            */

            SqlConnection cn = new SqlConnection(global::SolarPV.Properties.Settings.Default.solarpvbdConnectionString);

            try
            {
                string sql = "INSERT INTO Panel (PanelID, Manufec,ModelNo,PanelTech,MaxPower,MaxVolt,OCVolt,SCCurrent,MaxCurrent,Area,Tolarance,Efficiency) values (" + txtbxpanelID.Text + ",'" + txtbxPanelManu.Text + "','" + txtbxPanelModelNo.Text + "','" + txtbxPanelTech.Text + "', " + txtbxMaxPower.Text + "," + txtbxMaxVolt.Text + "," + txtbxOpenCV.Text + "," + txtbxShortCC.Text + "," + txtbxMaxCurrent.Text + "," + txtbxArea.Text + "," + txtbxPanelTolerance.Text + "," + txtbxPanelEfficiency.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("New Panel Added","Message",MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                
                this.panelTableAdapter.Fill(this.solarpvbdDataSet.Panel);
                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            finally 
            {
                cn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.panelTableAdapter.Fill(this.solarpvbdDataSet.Panel);

        }
    }
}
