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
    public partial class addnewBatt : Form
    {
        public addnewBatt()
        {
            InitializeComponent();
        }

        private void addnewBatt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Battery' table. You can move, or remove it, as needed.
            this.batteryTableAdapter.Fill(this.solarpvbdDataSet.Battery);

        }

        private void btnAddBatt_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::SolarPV.Properties.Settings.Default.solarpvbdConnectionString);

            try
            {
                string sql = "INSERT INTO Battery (BattID,BattTech,Manuefec,ModelNo,NomVolt,MaxCurrent,Capacity) values (" + txtbxBattID.Text + ",'" + txtbxBattTech.Text + "','" + txtbxBattManu.Text + "','" + txtbxBattModel.Text + "', " + txtbxVolt.Text + "," + txtbxDisCurr.Text + "," + txtbxCapacity.Text +")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("New Battery Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.batteryTableAdapter.Fill(this.solarpvbdDataSet.Battery);
             

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

        private void btnBattRefresh_Click(object sender, EventArgs e)
        {
            this.batteryTableAdapter.Fill(this.solarpvbdDataSet.Battery);
        }
    }
}
