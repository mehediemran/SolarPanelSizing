namespace SolarPV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxLocationID = new System.Windows.Forms.TextBox();
            this.txtbxLocationName = new System.Windows.Forms.TextBox();
            this.btnAddNewLocation = new System.Windows.Forms.Button();
            this.txtbxLat = new System.Windows.Forms.TextBox();
            this.txtbxLon = new System.Windows.Forms.TextBox();
            this.txtbxAlt = new System.Windows.Forms.TextBox();
            this.txtbxIrradMonth = new System.Windows.Forms.TextBox();
            this.txtbxIrradyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irradmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irradyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solarpvbdDataSet = new SolarPV.solarpvbdDataSet();
            this.locationTableAdapter = new SolarPV.solarpvbdDataSetTableAdapters.LocationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location Name";
            // 
            // txtbxLocationID
            // 
            this.txtbxLocationID.Location = new System.Drawing.Point(116, 50);
            this.txtbxLocationID.Name = "txtbxLocationID";
            this.txtbxLocationID.Size = new System.Drawing.Size(155, 20);
            this.txtbxLocationID.TabIndex = 2;
            this.txtbxLocationID.TextChanged += new System.EventHandler(this.txtbxLocationID_TextChanged);
            // 
            // txtbxLocationName
            // 
            this.txtbxLocationName.Location = new System.Drawing.Point(116, 89);
            this.txtbxLocationName.Name = "txtbxLocationName";
            this.txtbxLocationName.Size = new System.Drawing.Size(155, 20);
            this.txtbxLocationName.TabIndex = 3;
            // 
            // btnAddNewLocation
            // 
            this.btnAddNewLocation.Location = new System.Drawing.Point(116, 156);
            this.btnAddNewLocation.Name = "btnAddNewLocation";
            this.btnAddNewLocation.Size = new System.Drawing.Size(135, 23);
            this.btnAddNewLocation.TabIndex = 4;
            this.btnAddNewLocation.Text = "Save New Location";
            this.btnAddNewLocation.UseVisualStyleBackColor = true;
            this.btnAddNewLocation.Click += new System.EventHandler(this.btnAddNewLocation_Click);
            // 
            // txtbxLat
            // 
            this.txtbxLat.Location = new System.Drawing.Point(355, 49);
            this.txtbxLat.Name = "txtbxLat";
            this.txtbxLat.Size = new System.Drawing.Size(100, 20);
            this.txtbxLat.TabIndex = 6;
            this.txtbxLat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbxLon
            // 
            this.txtbxLon.Location = new System.Drawing.Point(355, 90);
            this.txtbxLon.Name = "txtbxLon";
            this.txtbxLon.Size = new System.Drawing.Size(100, 20);
            this.txtbxLon.TabIndex = 7;
            this.txtbxLon.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbxAlt
            // 
            this.txtbxAlt.Location = new System.Drawing.Point(355, 125);
            this.txtbxAlt.Name = "txtbxAlt";
            this.txtbxAlt.Size = new System.Drawing.Size(100, 20);
            this.txtbxAlt.TabIndex = 8;
            this.txtbxAlt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbxIrradMonth
            // 
            this.txtbxIrradMonth.Location = new System.Drawing.Point(564, 49);
            this.txtbxIrradMonth.Name = "txtbxIrradMonth";
            this.txtbxIrradMonth.Size = new System.Drawing.Size(100, 20);
            this.txtbxIrradMonth.TabIndex = 9;
            // 
            // txtbxIrradyear
            // 
            this.txtbxIrradyear.Location = new System.Drawing.Point(564, 101);
            this.txtbxIrradyear.Name = "txtbxIrradyear";
            this.txtbxIrradyear.Size = new System.Drawing.Size(100, 20);
            this.txtbxIrradyear.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Altitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Irradiance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Insolation ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Insolation = Power * Time / Area";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Irradiance = Power / Area";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationIDDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.latDataGridViewTextBoxColumn,
            this.lonDataGridViewTextBoxColumn,
            this.tiltDataGridViewTextBoxColumn,
            this.irradmonthDataGridViewTextBoxColumn,
            this.irradyearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.locationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "LocationID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location ID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "Location Name";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            // 
            // latDataGridViewTextBoxColumn
            // 
            this.latDataGridViewTextBoxColumn.DataPropertyName = "Lat";
            this.latDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latDataGridViewTextBoxColumn.Name = "latDataGridViewTextBoxColumn";
            // 
            // lonDataGridViewTextBoxColumn
            // 
            this.lonDataGridViewTextBoxColumn.DataPropertyName = "Lon";
            this.lonDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.lonDataGridViewTextBoxColumn.Name = "lonDataGridViewTextBoxColumn";
            // 
            // tiltDataGridViewTextBoxColumn
            // 
            this.tiltDataGridViewTextBoxColumn.DataPropertyName = "Tilt";
            this.tiltDataGridViewTextBoxColumn.HeaderText = "Tilt angle";
            this.tiltDataGridViewTextBoxColumn.Name = "tiltDataGridViewTextBoxColumn";
            // 
            // irradmonthDataGridViewTextBoxColumn
            // 
            this.irradmonthDataGridViewTextBoxColumn.DataPropertyName = "irrad_month";
            this.irradmonthDataGridViewTextBoxColumn.HeaderText = "Insolation best";
            this.irradmonthDataGridViewTextBoxColumn.Name = "irradmonthDataGridViewTextBoxColumn";
            // 
            // irradyearDataGridViewTextBoxColumn
            // 
            this.irradyearDataGridViewTextBoxColumn.DataPropertyName = "irrad_year";
            this.irradyearDataGridViewTextBoxColumn.HeaderText = "Inolation (yearly average)";
            this.irradyearDataGridViewTextBoxColumn.Name = "irradyearDataGridViewTextBoxColumn";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.solarpvbdDataSet;
            // 
            // solarpvbdDataSet
            // 
            this.solarpvbdDataSet.DataSetName = "solarpvbdDataSet";
            this.solarpvbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxIrradyear);
            this.Controls.Add(this.txtbxIrradMonth);
            this.Controls.Add(this.txtbxAlt);
            this.Controls.Add(this.txtbxLon);
            this.Controls.Add(this.txtbxLat);
            this.Controls.Add(this.btnAddNewLocation);
            this.Controls.Add(this.txtbxLocationName);
            this.Controls.Add(this.txtbxLocationID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Location";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxLocationID;
        private System.Windows.Forms.TextBox txtbxLocationName;
        private System.Windows.Forms.Button btnAddNewLocation;
        private System.Windows.Forms.TextBox txtbxLat;
        private System.Windows.Forms.TextBox txtbxLon;
        private System.Windows.Forms.TextBox txtbxAlt;
        private System.Windows.Forms.TextBox txtbxIrradMonth;
        private System.Windows.Forms.TextBox txtbxIrradyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private solarpvbdDataSet solarpvbdDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private solarpvbdDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irradmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irradyearDataGridViewTextBoxColumn;
    }
}

