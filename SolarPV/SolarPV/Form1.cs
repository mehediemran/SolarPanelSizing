using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace SolarPV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);
            // TODO: This line of code loads data into the 'solarpvbdDataSet1.Location' table. You can move, or remove it, as needed.
            //this.locationTableAdapter.Fill(this.solarpvbdDataSet1.Location);
            // TODO: This line of code loads data into the 'solarpvbdDataSet1.Location' table. You can move, or remove it, as needed.
           // this.locationTableAdapter.Fill(this.solarpvbdDataSet1.Location);
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Location' table. You can move, or remove it, as needed.
           // this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);
            // TODO: This line of code loads data into the 'solarpvbdDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewLocation_Click(object sender, EventArgs e)
        {
            SqlConnection sqCon = new SqlConnection(global::SolarPV.Properties.Settings.Default.solarpvbdConnectionString);
            try
            {
                string sql = "INSERT INTO Location (LocationID,LocationName,Lat,Lon,Tilt,irrad_month,irrad_year) values(" + txtbxLocationID.Text + ",'" + txtbxLocationName.Text + "'," + txtbxLat.Text + "," + txtbxLon.Text + "," + txtbxAlt.Text + "," + txtbxIrradMonth.Text + "," + txtbxIrradyear.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql,sqCon);
                sqCon.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("New location added to database","Message",MessageBoxButtons.OK);

               this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.locationTableAdapter.Fill(this.solarpvbdDataSet.Location);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbxLocationID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
