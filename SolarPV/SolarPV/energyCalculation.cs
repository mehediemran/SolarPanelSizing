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
        
    public partial class energyCalculation : Form
    {


        public energyCalculation()
        {
            InitializeComponent();
        }

        private void energyCalculation_Load(object sender, EventArgs e)
        {
                    Dictionary<string,Int16> AirCon = new Dictionary<string,Int16>();
                    AirCon.Add("AirCon Small",1000);
                    AirCon.Add("AirCon Medium", 2300);
                    AirCon.Add("AirCon Large", 3200);

                    AirCon.Add("AirCooler Portable", 150);
                    AirCon.Add("AirCoole Fixed", 600);

                    cboAircon1.DataSource = new BindingSource(AirCon, null);
                    cboAircon1.DisplayMember = "Key";
                    cboAircon1.ValueMember = "Value";

                    txtbxWatt1.Text = cboAircon1.SelectedValue.ToString();

                    cboAircon2.DataSource = new BindingSource(AirCon, null);
                    cboAircon2.DisplayMember = "Key";
                    cboAircon2.ValueMember = "Value";
                    
                    txtbxWatt2.Text = cboAircon2.SelectedValue.ToString();



                    Dictionary<string, Int16> heater = new Dictionary<string, Int16>();
                    heater.Add("S Heater Oil", 1000);
                    heater.Add("M Heater Oil", 1500);
                    heater.Add("L Heater Oil", 2000);

                    heater.Add("S Heater Fan", 600);
                    heater.Add("M Heater Fan", 1200);
                    heater.Add("L Heater Fan", 1500);

                    cboHeater1.DataSource = new BindingSource(heater, null);
                    cboHeater1.DisplayMember = "Key";
                    cboHeater1.ValueMember = "Value";

                    txtbxWatt3.Text = cboHeater1.SelectedValue.ToString();


                    Dictionary<string, Int16> Fan = new Dictionary<string, Int16>();
                    Fan.Add("Fan Exhaust ", 40);
                    Fan.Add("Fan Celling ", 100);
                    Fan.Add("Fan Padestal ", 80);

                    cbofan1.DataSource = new BindingSource(Fan, null);
                    cbofan1.DisplayMember = "Key";
                    cbofan1.ValueMember = "Value";

                    txtbxWatt4.Text = cbofan1.SelectedValue.ToString();

                    Dictionary<string, Int16> light = new Dictionary<string, Int16>();
                    light.Add("Light CLF 11", 11);
                    light.Add("Light CLF 20", 20);

                    light.Add("Light Incandescent 25", 11);
                    light.Add("Light Incandescent 60", 60);
                    light.Add("Light Incandescent 100", 100);

                    cboLight1.DataSource = new BindingSource(light, null);
                    cboLight1.DisplayMember = "Key";
                    cboLight1.ValueMember = "Value";

                    txtbxWatt5.Text = cboLight1.SelectedValue.ToString();

                    cboLight2.DataSource = new BindingSource(light, null);
                    cboLight2.DisplayMember = "Key";
                    cboLight2.ValueMember = "Value";

                    txtbxWatt6.Text = cboLight2.SelectedValue.ToString();

                    Dictionary<string, Int16> freezer = new Dictionary<string, Int16>();
                    freezer.Add("Freezer 200Ltr", 100);
                    freezer.Add("Freezer 300Ltr", 150);
                    freezer.Add("Freezer 450Ltr", 230);

                    cboFrezer.DataSource = new BindingSource(freezer, null);
                    cboFrezer.DisplayMember = "Key";
                    cboFrezer.ValueMember = "Value";

                    txtbxWatt7.Text = cboFrezer.SelectedValue.ToString();


                    Dictionary<string, Int16> Vacuum = new Dictionary<string, Int16>();
                    Vacuum.Add("Vacuum Portable ", 1100);
                    Vacuum.Add("Vacuum Ducted ", 1500);
                    Vacuum.Add("Vacuum Portable large ", 2000);


                    cboVaccum.DataSource = new BindingSource(Vacuum, null);
                    cboVaccum.DisplayMember = "Key";
                    cboVaccum.ValueMember = "Value";

                    txtbxWatt8.Text = cboVaccum.SelectedValue.ToString();

                    Dictionary<string, Int16> Oven = new Dictionary<string, Int16>();

                    Oven.Add("Oven Large", 1800);
                    Oven.Add("Oven Small ", 2400);
                  
                    Oven.Add("Microwave oven 750 Watts", 1300);
                    Oven.Add("Microwave oven Convection", 1600);

                    cboOven1.DataSource = new BindingSource(Oven, null);
                    cboOven1.DisplayMember = "Key";
                    cboOven1.ValueMember = "Value";

                    txtbxWatt9.Text = cboOven1.SelectedValue.ToString();

                    cboOven2.DataSource = new BindingSource(Oven, null);
                    cboOven2.DisplayMember = "Key";
                    cboOven2.ValueMember = "Value";

                    txtbxWatt10.Text = cboOven2.SelectedValue.ToString();

                    Dictionary<string, Int16> Television = new Dictionary<string, Int16>();
                    Television.Add("Television CRT", 150);
                    Television.Add("Television LCD", 200);
                    Television.Add("Television Plasma", 330);

                    cboTB.DataSource = new BindingSource(Television, null);
                    cboTB.DisplayMember = "Key";
                    cboTB.ValueMember = "Value";

                    txtbxWatt11.Text = cboTB.SelectedValue.ToString();

                    Dictionary<string, Int16> InfoTech = new Dictionary<string, Int16>();
                    InfoTech.Add("Computer", 100);
                    InfoTech.Add("Computer-Printer", 300);
                    InfoTech.Add("WiFi", 10);

                    cboComp1.DataSource = new BindingSource(InfoTech, null);
                    cboComp1.DisplayMember = "Key";
                    cboComp1.ValueMember = "Value";

                    txtbxWatt12.Text = cboComp1.SelectedValue.ToString();

                    cboComp2.DataSource = new BindingSource(InfoTech, null);
                    cboComp2.DisplayMember = "Key";
                    cboComp2.ValueMember = "Value";

                    txtbxWatt13.Text = cboComp2.SelectedValue.ToString();

                    Dictionary<string, Int16> Washing = new Dictionary<string, Int16>();
                    Washing.Add("Washing machine Auto", 900);
                    Washing.Add("Washing machine small", 500);
            
                    cboWash.DataSource = new BindingSource(Washing, null);
                    cboWash.DisplayMember = "Key";
                    cboWash.ValueMember = "Value";

                    txtbxWatt14.Text = cboWash.SelectedValue.ToString();

                    Dictionary<string, Int16> hotwater = new Dictionary<string, Int16>();
                    hotwater.Add("Water heater Instantaneous ", 1300);
                    hotwater.Add("Water heater Quick recovery", 2400);

                    cbohotwater.DataSource = new BindingSource(hotwater, null);
                    cbohotwater.DisplayMember = "Key";
                    cbohotwater.ValueMember = "Value";

                    txtbxWatt15.Text = cbohotwater.SelectedValue.ToString();



                    Dictionary<string, Int16> kitchenApp = new Dictionary<string, Int16>();

                    kitchenApp.Add("Toaster", 600);
                    kitchenApp.Add("Food mixer", 135);
                    kitchenApp.Add("Dishwasher", 2400);

                    cboMisc1.DataSource = new BindingSource(kitchenApp, null);
                    cboMisc1.DisplayMember = "Key";
                    cboMisc1.ValueMember = "Value";

                    txtbxWatt16.Text = cboMisc1.SelectedValue.ToString();

                    cboMisc2.DataSource = new BindingSource(kitchenApp, null);
                    cboMisc2.DisplayMember = "Key";
                    cboMisc2.ValueMember = "Value";

                    txtbxWatt17.Text = cboMisc2.SelectedValue.ToString();

                    Dictionary<string, Int16> misAppl = new Dictionary<string, Int16>();
                    misAppl.Add("Hair dryer", 100);
                    misAppl.Add("Swiming pool pump", 1000);

                   

                    cboMisc3.DataSource = new BindingSource(misAppl, null);
                    cboMisc3.DisplayMember = "Key";
                    cboMisc3.ValueMember = "Value";

                    txtbxWatt18.Text = cboMisc3.SelectedValue.ToString();

                    cboMisc4.DataSource = new BindingSource(misAppl, null);
                    cboMisc4.DisplayMember = "Key";

                    cboMisc4.ValueMember = "Value";

                    txtbxWatt19.Text = cboMisc4.SelectedValue.ToString();

            //textbox for number of items default to 1
                    textBox1.Text = "1";
                    textBox2.Text = "1";
                    textBox3.Text = "1";
                    textBox4.Text = "1";

                    textBox5.Text = "1";
                    textBox6.Text = "1";
                    textBox7.Text = "1";
                    textBox8.Text = "1";

                    textBox9.Text = "1";
                    textBox10.Text = "1";
                    textBox11.Text = "1";
                    textBox12.Text = "1";

                    textBox13.Text = "1";
                    textBox14.Text = "1";
                    textBox15.Text = "1";
                    textBox16.Text = "1";

                    textBox17.Text = "1";
                    textBox18.Text = "1";
                    textBox19.Text = "1";

            //textbox for number of hours default to 1
                    txtbxhour1.Text = "1";
                    txtbxhour2.Text = "1";
                    txtbxhour3.Text = "1";
                    txtbxhour4.Text = "1";
                    txtbxhour5.Text = "1";
                    txtbxhour6.Text = "1";
                    txtbxhour7.Text = "1";
                    txtbxhour8.Text = "1";
                    txtbxhour9.Text = "1";
                    txtbxhour10.Text = "1";
                    txtbxhour11.Text = "1";
                    txtbxhour12.Text = "1";
                    txtbxhour13.Text = "1";
                    txtbxhour14.Text = "1";
                    txtbxhour15.Text = "1";
                    txtbxhour16.Text = "1";
                    txtbxhour17.Text = "1";
                    txtbxhour18.Text = "1";
                    txtbxhour19.Text = "1";
            // default value for number of houses

                    txtbxNoHouse.Text = "1";
                    

            //calculate individual power at form load
            /*
                    int[] intwatt = new int[19];
                    string[] strwatt = new string[19];

                    int[] totalwatt = new int[19];
                    int sum=0;
                    
                    int[] inthour = new int[19];
                    string[] strhour = new string[19];


                    int[] intnumber = new int[19];
                    string[] strnumber = new string[19];
                

                    strwatt[0] = txtbxWatt1.Text;
                    intwatt[0] = Convert.ToInt16(strwatt[0]);
                    
                    strhour[0] = txtbxhour1.Text;
                    inthour[0] = Convert.ToInt16(strhour[0]);

                    strnumber[0] = textBox1.Text;
                    intnumber[0] = Convert.ToInt16(strhour[0]);
                    totalwatt[0]=intwatt[0]*intnumber[0]*inthour[0];

                    sum = sum + totalwatt[0];

                    txtbxTotWatt1.Text = Convert.ToString(totalwatt[0]);


                    //adding second 

                    strwatt[1] = txtbxWatt2.Text;
                    intwatt[1] = Convert.ToInt16(strwatt[1]);

                    strhour[1] = txtbxhour2.Text;
                    inthour[1] = Convert.ToInt16(strhour[1]);

                    strnumber[1] = textBox2.Text;
                    intnumber[1] = Convert.ToInt16(strhour[1]);
                    totalwatt[1] = intwatt[1] * intnumber[1] * inthour[1];

                    sum = sum + totalwatt[1];

                    txtbxTotWatt2.Text = Convert.ToString(totalwatt[1]);

                    //adding third 

                    strwatt[2] = txtbxWatt3.Text;
                    intwatt[2] = Convert.ToInt16(strwatt[2]);

                    strhour[2] = txtbxhour3.Text;
                    inthour[2] = Convert.ToInt16(strhour[2]);

                    strnumber[2] = textBox3.Text;
                    intnumber[2] = Convert.ToInt16(strhour[2]);
                    totalwatt[2] = intwatt[2] * intnumber[2] * inthour[2];

                    sum = sum + totalwatt[2];

                    txtbxTotWatt3.Text = Convert.ToString(totalwatt[2]);

                    //adding fourth 

                    strwatt[3] = txtbxWatt4.Text;
                    intwatt[3] = Convert.ToInt16(strwatt[3]);

                    strhour[3] = txtbxhour4.Text;
                    inthour[3] = Convert.ToInt16(strhour[3]);

                    strnumber[3] = textBox4.Text;
                    intnumber[3] = Convert.ToInt16(strhour[3]);
                    totalwatt[3] = intwatt[3] * intnumber[3] * inthour[3];

                    sum = sum + totalwatt[3];

                    txtbxTotWatt4.Text = Convert.ToString(totalwatt[3]);

                    //adding fifth 

                    strwatt[4] = txtbxWatt5.Text;
                    intwatt[4] = Convert.ToInt16(strwatt[4]);

                    strhour[4] = txtbxhour5.Text;
                    inthour[4] = Convert.ToInt16(strhour[4]);

                    strnumber[4] = textBox5.Text;
                    intnumber[4] = Convert.ToInt16(strhour[4]);
                    totalwatt[4] = intwatt[4] * intnumber[4] * inthour[4];

                    sum = sum + totalwatt[4];

                    txtbxTotWatt5.Text = Convert.ToString(totalwatt[4]);
                   
                    //adding 6th 

                    strwatt[5] = txtbxWatt6.Text;
                    intwatt[5] = Convert.ToInt16(strwatt[5]);

                    strhour[5] = txtbxhour6.Text;
                    inthour[5] = Convert.ToInt16(strhour[5]);

                    strnumber[5] = textBox6.Text;
                    intnumber[5] = Convert.ToInt16(strhour[5]);
                    totalwatt[5] = intwatt[5] * intnumber[5] * inthour[5];

                    sum = sum + totalwatt[5];

                    txtbxTotWatt6.Text = Convert.ToString(totalwatt[5]);

                    //adding 7th 

                    strwatt[6] = txtbxWatt7.Text;
                    intwatt[6] = Convert.ToInt16(strwatt[6]);

                    strhour[6] = txtbxhour7.Text;
                    inthour[6] = Convert.ToInt16(strhour[6]);

                    strnumber[6] = textBox7.Text;
                    intnumber[6] = Convert.ToInt16(strhour[6]);
                    totalwatt[6] = intwatt[6] * intnumber[6] * inthour[6];

                    sum = sum + totalwatt[6];

                    txtbxTotWatt7.Text = Convert.ToString(totalwatt[6]);

                    //adding 8th 

                    strwatt[7] = txtbxWatt8.Text;
                    intwatt[7] = Convert.ToInt16(strwatt[7]);

                    strhour[7] = txtbxhour8.Text;
                    inthour[7] = Convert.ToInt16(strhour[7]);

                    strnumber[7] = textBox8.Text;
                    intnumber[7] = Convert.ToInt16(strhour[7]);
                    totalwatt[7] = intwatt[7] * intnumber[7] * inthour[7];

                    sum = sum + totalwatt[7];

                    txtbxTotWatt8.Text = Convert.ToString(totalwatt[7]);

                    //adding 9th 

                    strwatt[8] = txtbxWatt9.Text;
                    intwatt[8] = Convert.ToInt16(strwatt[8]);

                    strhour[8] = txtbxhour9.Text;
                    inthour[8] = Convert.ToInt16(strhour[8]);

                    strnumber[8] = textBox9.Text;
                    intnumber[8] = Convert.ToInt16(strhour[8]);
                    totalwatt[8] = intwatt[8] * intnumber[8] * inthour[8];

                    sum = sum + totalwatt[8];

                    txtbxTotWatt9.Text = Convert.ToString(totalwatt[8]);

                    //adding 10th 

                    strwatt[9] = txtbxWatt10.Text;
                    intwatt[9] = Convert.ToInt16(strwatt[9]);

                    strhour[9] = txtbxhour10.Text;
                    inthour[9] = Convert.ToInt16(strhour[9]);

                    strnumber[9] = textBox10.Text;
                    intnumber[9] = Convert.ToInt16(strhour[9]);
                    totalwatt[9] = intwatt[9] * intnumber[9] * inthour[9];

                    sum = sum + totalwatt[9];

                    txtbxTotWatt10.Text = Convert.ToString(totalwatt[9]);

                    //adding 11th 

                    strwatt[10] = txtbxWatt11.Text;
                    intwatt[10] = Convert.ToInt16(strwatt[10]);

                    strhour[10] = txtbxhour11.Text;
                    inthour[10] = Convert.ToInt16(strhour[10]);

                    strnumber[10] = textBox11.Text;
                    intnumber[10] = Convert.ToInt16(strhour[10]);
                    totalwatt[10] = intwatt[10] * intnumber[10] * inthour[10];

                    sum = sum + totalwatt[10];

                    txtbxTotWatt11.Text = Convert.ToString(totalwatt[10]);

                    //adding 12th 

                    strwatt[11] = txtbxWatt12.Text;
                    intwatt[11] = Convert.ToInt16(strwatt[11]);

                    strhour[11] = txtbxhour12.Text;
                    inthour[11] = Convert.ToInt16(strhour[11]);

                    strnumber[11] = textBox12.Text;
                    intnumber[11] = Convert.ToInt16(strhour[11]);
                    totalwatt[11] = intwatt[11] * intnumber[11] * inthour[11];

                    sum = sum + totalwatt[11];

                    txtbxTotWatt12.Text = Convert.ToString(totalwatt[11]);

                    //adding 13th 

                    strwatt[12] = txtbxWatt13.Text;
                    intwatt[12] = Convert.ToInt16(strwatt[12]);

                    strhour[12] = txtbxhour13.Text;
                    inthour[12] = Convert.ToInt16(strhour[12]);

                    strnumber[12] = textBox13.Text;
                    intnumber[12] = Convert.ToInt16(strhour[12]);
                    totalwatt[12] = intwatt[12] * intnumber[12] * inthour[12];

                    sum = sum + totalwatt[12];

                    txtbxTotWatt13.Text = Convert.ToString(totalwatt[12]);

                    //adding 14 th 

                    strwatt[13] = txtbxWatt14.Text;
                    intwatt[13] = Convert.ToInt16(strwatt[13]);

                    strhour[13] = txtbxhour14.Text;
                    inthour[13] = Convert.ToInt16(strhour[13]);

                    strnumber[13] = textBox14.Text;
                    intnumber[13] = Convert.ToInt16(strhour[13]);
                    totalwatt[13] = intwatt[13] * intnumber[13] * inthour[13];

                    sum = sum + totalwatt[13];

                    txtbxTotWatt14.Text = Convert.ToString(totalwatt[13]);

                    //adding 15 th 

                    strwatt[14] = txtbxWatt15.Text;
                    intwatt[14] = Convert.ToInt16(strwatt[14]);

                    strhour[14] = txtbxhour15.Text;
                    inthour[14] = Convert.ToInt16(strhour[14]);

                    strnumber[14] = textBox15.Text;
                    intnumber[14] = Convert.ToInt16(strhour[14]);
                    totalwatt[14] = intwatt[14] * intnumber[14] * inthour[14];

                    sum = sum + totalwatt[14];

                    txtbxTotWatt15.Text = Convert.ToString(totalwatt[14]);

                    //adding 16 th 

                    strwatt[15] = txtbxWatt16.Text;
                    intwatt[15] = Convert.ToInt16(strwatt[15]);

                    strhour[15] = txtbxhour16.Text;
                    inthour[15] = Convert.ToInt16(strhour[15]);

                    strnumber[15] = textBox16.Text;
                    intnumber[15] = Convert.ToInt16(strhour[15]);
                    totalwatt[15] = intwatt[15] * intnumber[15] * inthour[15];

                    sum = sum + totalwatt[15];

                    txtbxTotWatt16.Text = Convert.ToString(totalwatt[15]);

                    //adding 17 th 

                    strwatt[16] = txtbxWatt17.Text;
                    intwatt[16] = Convert.ToInt16(strwatt[16]);

                    strhour[16] = txtbxhour17.Text;
                    inthour[16] = Convert.ToInt16(strhour[16]);

                    strnumber[16] = textBox17.Text;
                    intnumber[16] = Convert.ToInt16(strhour[16]);
                    totalwatt[16] = intwatt[16] * intnumber[16] * inthour[16];

                    sum = sum + totalwatt[16];

                    txtbxTotWatt17.Text = Convert.ToString(totalwatt[16]);

                    //adding 18 th 

                    strwatt[17] = txtbxWatt18.Text;
                    intwatt[17] = Convert.ToInt16(strwatt[17]);

                    strhour[17] = txtbxhour18.Text;
                    inthour[17] = Convert.ToInt16(strhour[17]);

                    strnumber[17] = textBox18.Text;
                    intnumber[17] = Convert.ToInt16(strhour[17]);
                    totalwatt[17] = intwatt[17] * intnumber[17] * inthour[17];

                    sum = sum + totalwatt[17];

                    txtbxTotWatt18.Text = Convert.ToString(totalwatt[17]);

                    //adding 19 th 

                    strwatt[18] = txtbxWatt19.Text;
                    intwatt[18] = Convert.ToInt16(strwatt[18]);

                    strhour[18] = txtbxhour19.Text;
                    inthour[18] = Convert.ToInt16(strhour[18]);

                    strnumber[18] = textBox19.Text;
                    intnumber[18] = Convert.ToInt16(strhour[18]);
                    totalwatt[18] = intwatt[18] * intnumber[18] * inthour[18];

                    sum = sum + totalwatt[18];

                    txtbxTotWatt19.Text = Convert.ToString(totalwatt[18]);
            */


        }


        private void txtbxWatt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAircon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt1.Text = cboAircon1.SelectedValue.ToString();
        }

        private void cboAircon2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt2.Text = cboAircon2.SelectedValue.ToString();
        }

        private void cboHeater1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt3.Text = cboHeater1.SelectedValue.ToString();
        }

        private void cbofan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt4.Text = cbofan1.SelectedValue.ToString();
        }

        private void cboLight1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt5.Text = cboLight1.SelectedValue.ToString();
        }

        private void cboLight2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt6.Text = cboLight2.SelectedValue.ToString();
        }

        private void cboFrezer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt7.Text = cboFrezer.SelectedValue.ToString();
        }

        private void cboVaccum_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt8.Text = cboVaccum.SelectedValue.ToString();
        }

        private void cboOven1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt9.Text = cboOven1.SelectedValue.ToString();
        }

        private void cboOven2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt10.Text = cboOven2.SelectedValue.ToString();
        }

        private void cboTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt11.Text = cboTB.SelectedValue.ToString();
        }

        private void cboComp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt12.Text = cboComp1.SelectedValue.ToString();
        }

        private void cboComp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt13.Text = cboComp2.SelectedValue.ToString();
        }

        private void cboWash_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt14.Text = cboWash.SelectedValue.ToString();
        }

        private void cbohotwater_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt15.Text = cbohotwater.SelectedValue.ToString();
        }

        private void cboMisc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt16.Text = cboMisc1.SelectedValue.ToString();
        }

        private void cboMisc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt17.Text = cboMisc2.SelectedValue.ToString();
        }

        private void cboMisc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt18.Text = cboMisc3.SelectedValue.ToString();
        }

        private void cboMisc4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxWatt19.Text = cboMisc4.SelectedValue.ToString();
        }
        
        private void updateTable() { //change decimal point for hours, change int16

            //calculate individual power at form load

            int[] intwatt = new int[19];
            string[] strwatt = new string[19];

            int[] totalwatt = new int[19];
            int sum = 0;

            int[] inthour = new int[19];
            string[] strhour = new string[19];


            int[] intnumber = new int[19];
            string[] strnumber = new string[19];


            strwatt[0] = txtbxWatt1.Text;
            intwatt[0] = Convert.ToInt16(strwatt[0]);

            strhour[0] = txtbxhour1.Text;
            inthour[0] = Convert.ToInt16(strhour[0]);

            strnumber[0] = textBox1.Text;
            intnumber[0] = Convert.ToInt16(strnumber[0]);
            totalwatt[0] = intwatt[0] * intnumber[0] * inthour[0];

            sum = sum + totalwatt[0];

            txtbxTotWatt1.Text = Convert.ToString(totalwatt[0]);


            //adding second 

            strwatt[1] = txtbxWatt2.Text;
            intwatt[1] = Convert.ToInt16(strwatt[1]);

            strhour[1] = txtbxhour2.Text;
            inthour[1] = Convert.ToInt16(strhour[1]);

            strnumber[1] = textBox2.Text;
            intnumber[1] = Convert.ToInt16(strnumber[1]);
            totalwatt[1] = intwatt[1] * intnumber[1] * inthour[1];

            sum = sum + totalwatt[1];

            txtbxTotWatt2.Text = Convert.ToString(totalwatt[1]);

            //adding third 

            strwatt[2] = txtbxWatt3.Text;
            intwatt[2] = Convert.ToInt16(strwatt[2]);

            strhour[2] = txtbxhour3.Text;
            inthour[2] = Convert.ToInt16(strhour[2]);

            strnumber[2] = textBox3.Text;
            intnumber[2] = Convert.ToInt16(strnumber[2]);
            totalwatt[2] = intwatt[2] * intnumber[2] * inthour[2];

            sum = sum + totalwatt[2];

            txtbxTotWatt3.Text = Convert.ToString(totalwatt[2]);

            //adding fourth 

            strwatt[3] = txtbxWatt4.Text;
            intwatt[3] = Convert.ToInt16(strwatt[3]);

            strhour[3] = txtbxhour4.Text;
            inthour[3] = Convert.ToInt16(strhour[3]);

            strnumber[3] = textBox4.Text;
            intnumber[3] = Convert.ToInt16(strnumber[3]);
            totalwatt[3] = intwatt[3] * intnumber[3] * inthour[3];

            sum = sum + totalwatt[3];

            txtbxTotWatt4.Text = Convert.ToString(totalwatt[3]);

            //adding fifth 

            strwatt[4] = txtbxWatt5.Text;
            intwatt[4] = Convert.ToInt16(strwatt[4]);

            strhour[4] = txtbxhour5.Text;
            inthour[4] = Convert.ToInt16(strhour[4]);

            strnumber[4] = textBox5.Text;
            intnumber[4] = Convert.ToInt16(strnumber[4]);
            totalwatt[4] = intwatt[4] * intnumber[4] * inthour[4];

            sum = sum + totalwatt[4];

            txtbxTotWatt5.Text = Convert.ToString(totalwatt[4]);

            //adding 6th 

            strwatt[5] = txtbxWatt6.Text;
            intwatt[5] = Convert.ToInt16(strwatt[5]);

            strhour[5] = txtbxhour6.Text;
            inthour[5] = Convert.ToInt16(strhour[5]);

            strnumber[5] = textBox6.Text;
            intnumber[5] = Convert.ToInt16(strnumber[5]);
            totalwatt[5] = intwatt[5] * intnumber[5] * inthour[5];

            sum = sum + totalwatt[5];

            txtbxTotWatt6.Text = Convert.ToString(totalwatt[5]);

            //adding 7th 

            strwatt[6] = txtbxWatt7.Text;
            intwatt[6] = Convert.ToInt16(strwatt[6]);

            strhour[6] = txtbxhour7.Text;
            inthour[6] = Convert.ToInt16(strhour[6]);

            strnumber[6] = textBox7.Text;
            intnumber[6] = Convert.ToInt16(strnumber[6]);
            totalwatt[6] = intwatt[6] * intnumber[6] * inthour[6];

            sum = sum + totalwatt[6];

            txtbxTotWatt7.Text = Convert.ToString(totalwatt[6]);

            //adding 8th 

            strwatt[7] = txtbxWatt8.Text;
            intwatt[7] = Convert.ToInt16(strwatt[7]);

            strhour[7] = txtbxhour8.Text;
            inthour[7] = Convert.ToInt16(strhour[7]);

            strnumber[7] = textBox8.Text;
            intnumber[7] = Convert.ToInt16(strnumber[7]);
            totalwatt[7] = intwatt[7] * intnumber[7] * inthour[7];

            sum = sum + totalwatt[7];

            txtbxTotWatt8.Text = Convert.ToString(totalwatt[7]);

            //adding 9th 

            strwatt[8] = txtbxWatt9.Text;
            intwatt[8] = Convert.ToInt16(strwatt[8]);

            strhour[8] = txtbxhour9.Text;
            inthour[8] = Convert.ToInt16(strhour[8]);

            strnumber[8] = textBox9.Text;
            intnumber[8] = Convert.ToInt16(strnumber[8]);
            totalwatt[8] = intwatt[8] * intnumber[8] * inthour[8];

            sum = sum + totalwatt[8];

            txtbxTotWatt9.Text = Convert.ToString(totalwatt[8]);

            //adding 10th 

            strwatt[9] = txtbxWatt10.Text;
            intwatt[9] = Convert.ToInt16(strwatt[9]);

            strhour[9] = txtbxhour10.Text;
            inthour[9] = Convert.ToInt16(strhour[9]);

            strnumber[9] = textBox10.Text;
            intnumber[9] = Convert.ToInt16(strnumber[9]);
            totalwatt[9] = intwatt[9] * intnumber[9] * inthour[9];

            sum = sum + totalwatt[9];

            txtbxTotWatt10.Text = Convert.ToString(totalwatt[9]);

            //adding 11th 

            strwatt[10] = txtbxWatt11.Text;
            intwatt[10] = Convert.ToInt16(strwatt[10]);

            strhour[10] = txtbxhour11.Text;
            inthour[10] = Convert.ToInt16(strhour[10]);

            strnumber[10] = textBox11.Text;
            intnumber[10] = Convert.ToInt16(strnumber[10]);
            totalwatt[10] = intwatt[10] * intnumber[10] * inthour[10];

            sum = sum + totalwatt[10];

            txtbxTotWatt11.Text = Convert.ToString(totalwatt[10]);

            //adding 12th 

            strwatt[11] = txtbxWatt12.Text;
            intwatt[11] = Convert.ToInt16(strwatt[11]);

            strhour[11] = txtbxhour12.Text;
            inthour[11] = Convert.ToInt16(strhour[11]);

            strnumber[11] = textBox12.Text;
            intnumber[11] = Convert.ToInt16(strnumber[11]);
            totalwatt[11] = intwatt[11] * intnumber[11] * inthour[11];

            sum = sum + totalwatt[11];

            txtbxTotWatt12.Text = Convert.ToString(totalwatt[11]);

            //adding 13th 

            strwatt[12] = txtbxWatt13.Text;
            intwatt[12] = Convert.ToInt16(strwatt[12]);

            strhour[12] = txtbxhour13.Text;
            inthour[12] = Convert.ToInt16(strhour[12]);

            strnumber[12] = textBox13.Text;
            intnumber[12] = Convert.ToInt16(strnumber[12]);
            totalwatt[12] = intwatt[12] * intnumber[12] * inthour[12];

            sum = sum + totalwatt[12];

            txtbxTotWatt13.Text = Convert.ToString(totalwatt[12]);

            //adding 14 th 

            strwatt[13] = txtbxWatt14.Text;
            intwatt[13] = Convert.ToInt16(strwatt[13]);

            strhour[13] = txtbxhour14.Text;
            inthour[13] = Convert.ToInt16(strhour[13]);

            strnumber[13] = textBox14.Text;
            intnumber[13] = Convert.ToInt16(strnumber[13]);
            totalwatt[13] = intwatt[13] * intnumber[13] * inthour[13];

            sum = sum + totalwatt[13];

            txtbxTotWatt14.Text = Convert.ToString(totalwatt[13]);

            //adding 15 th 

            strwatt[14] = txtbxWatt15.Text;
            intwatt[14] = Convert.ToInt16(strwatt[14]);

            strhour[14] = txtbxhour15.Text;
            inthour[14] = Convert.ToInt16(strhour[14]);

            strnumber[14] = textBox15.Text;
            intnumber[14] = Convert.ToInt16(strnumber[14]);
            totalwatt[14] = intwatt[14] * intnumber[14] * inthour[14];

            sum = sum + totalwatt[14];

            txtbxTotWatt15.Text = Convert.ToString(totalwatt[14]);

            //adding 16 th 

            strwatt[15] = txtbxWatt16.Text;
            intwatt[15] = Convert.ToInt16(strwatt[15]);

            strhour[15] = txtbxhour16.Text;
            inthour[15] = Convert.ToInt16(strhour[15]);

            strnumber[15] = textBox16.Text;
            intnumber[15] = Convert.ToInt16(strnumber[15]);
            totalwatt[15] = intwatt[15] * intnumber[15] * inthour[15];

            sum = sum + totalwatt[15];

            txtbxTotWatt16.Text = Convert.ToString(totalwatt[15]);

            //adding 17 th 

            strwatt[16] = txtbxWatt17.Text;
            intwatt[16] = Convert.ToInt16(strwatt[16]);

            strhour[16] = txtbxhour17.Text;
            inthour[16] = Convert.ToInt16(strhour[16]);

            strnumber[16] = textBox17.Text;
            intnumber[16] = Convert.ToInt16(strnumber[16]);
            totalwatt[16] = intwatt[16] * intnumber[16] * inthour[16];

            sum = sum + totalwatt[16];

            txtbxTotWatt17.Text = Convert.ToString(totalwatt[16]);

            //adding 18 th 

            strwatt[17] = txtbxWatt18.Text;
            intwatt[17] = Convert.ToInt16(strwatt[17]);

            strhour[17] = txtbxhour18.Text;
            inthour[17] = Convert.ToInt16(strhour[17]);

            strnumber[17] = textBox18.Text;
            intnumber[17] = Convert.ToInt16(strnumber[17]);
            totalwatt[17] = intwatt[17] * intnumber[17] * inthour[17];

            sum = sum + totalwatt[17];

            txtbxTotWatt18.Text = Convert.ToString(totalwatt[17]);

            //adding 19 th 

            strwatt[18] = txtbxWatt19.Text;
            intwatt[18] = Convert.ToInt16(strwatt[18]);

            strhour[18] = txtbxhour19.Text;
            inthour[18] = Convert.ToInt16(strhour[18]);

            strnumber[18] = textBox19.Text;
            intnumber[18] = Convert.ToInt16(strnumber[18]);
            totalwatt[18] = intwatt[18] * intnumber[18] * inthour[18];

            sum = sum + totalwatt[18];

            txtbxTotWatt19.Text = Convert.ToString(totalwatt[18]);

        //    txtbxTotPower.Text = Convert.ToString(sum);
           // GlobalVariables.totKwatt = Convert.ToDouble(Convert.ToDecimal(sum) / 1000);
            GlobalVariables.watt = Convert.ToDouble(sum);
            GlobalVariables.totKwatt = GlobalVariables.watt / 1000;
        
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            updateTable();
            txtbxTotPower.Text = Convert.ToString(GlobalVariables.watt);
          //  txtbxReq = Convert.ToString(GlobalVariables.totKwatt);
            
        }

        private void btnMulHouse_Click(object sender, EventArgs e)
        {
            
            
            if (txtbxNoHouse.Text != "")
            {
                GlobalVariables.housenumber = Convert.ToInt32(txtbxNoHouse.Text);
            }
            else
                GlobalVariables.housenumber = 1;

            double singleWatt = Convert.ToDouble(txtbxTotPower.Text);
            double mulwatt = GlobalVariables.housenumber * singleWatt;

            if (GlobalVariables.housenumber > 1)
            {
                txtbxmulhouse.Text = Convert.ToString(mulwatt);
                GlobalVariables.watt = Convert.ToDouble(mulwatt);
                GlobalVariables.totKwatt = GlobalVariables.watt / 1000;
            }
            else
            {
                txtbxmulhouse.Text = Convert.ToString(singleWatt);
                GlobalVariables.watt = Convert.ToDouble(singleWatt);
                GlobalVariables.totKwatt = GlobalVariables.watt / 1000;
            }
        }

        private void energyCalculation_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                    

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
