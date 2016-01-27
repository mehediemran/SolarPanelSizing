namespace SolarPV
{
    partial class addnewBatt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxBattID = new System.Windows.Forms.TextBox();
            this.txtbxBattManu = new System.Windows.Forms.TextBox();
            this.txtbxBattModel = new System.Windows.Forms.TextBox();
            this.txtbxBattTech = new System.Windows.Forms.TextBox();
            this.txtbxVolt = new System.Windows.Forms.TextBox();
            this.txtbxDisCurr = new System.Windows.Forms.TextBox();
            this.btnAddBatt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.batteryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solarpvbdDataSet = new SolarPV.solarpvbdDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxCapacity = new System.Windows.Forms.TextBox();
            this.btnBattRefresh = new System.Windows.Forms.Button();
            this.batteryTableAdapter = new SolarPV.solarpvbdDataSetTableAdapters.BatteryTableAdapter();
            this.battIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battTechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manuefecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVoltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Battery Type ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namufacturer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Battery Tech/ Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Volt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Current";
            // 
            // txtbxBattID
            // 
            this.txtbxBattID.Location = new System.Drawing.Point(172, 37);
            this.txtbxBattID.Name = "txtbxBattID";
            this.txtbxBattID.Size = new System.Drawing.Size(152, 20);
            this.txtbxBattID.TabIndex = 6;
            // 
            // txtbxBattManu
            // 
            this.txtbxBattManu.Location = new System.Drawing.Point(172, 81);
            this.txtbxBattManu.Name = "txtbxBattManu";
            this.txtbxBattManu.Size = new System.Drawing.Size(152, 20);
            this.txtbxBattManu.TabIndex = 7;
            // 
            // txtbxBattModel
            // 
            this.txtbxBattModel.Location = new System.Drawing.Point(172, 129);
            this.txtbxBattModel.Name = "txtbxBattModel";
            this.txtbxBattModel.Size = new System.Drawing.Size(152, 20);
            this.txtbxBattModel.TabIndex = 8;
            // 
            // txtbxBattTech
            // 
            this.txtbxBattTech.Location = new System.Drawing.Point(517, 37);
            this.txtbxBattTech.Name = "txtbxBattTech";
            this.txtbxBattTech.Size = new System.Drawing.Size(152, 20);
            this.txtbxBattTech.TabIndex = 9;
            // 
            // txtbxVolt
            // 
            this.txtbxVolt.Location = new System.Drawing.Point(517, 81);
            this.txtbxVolt.Name = "txtbxVolt";
            this.txtbxVolt.Size = new System.Drawing.Size(152, 20);
            this.txtbxVolt.TabIndex = 10;
            // 
            // txtbxDisCurr
            // 
            this.txtbxDisCurr.Location = new System.Drawing.Point(517, 131);
            this.txtbxDisCurr.Name = "txtbxDisCurr";
            this.txtbxDisCurr.Size = new System.Drawing.Size(152, 20);
            this.txtbxDisCurr.TabIndex = 11;
            // 
            // btnAddBatt
            // 
            this.btnAddBatt.Location = new System.Drawing.Point(391, 176);
            this.btnAddBatt.Name = "btnAddBatt";
            this.btnAddBatt.Size = new System.Drawing.Size(140, 23);
            this.btnAddBatt.TabIndex = 12;
            this.btnAddBatt.Text = "Add New Battery";
            this.btnAddBatt.UseVisualStyleBackColor = true;
            this.btnAddBatt.Click += new System.EventHandler(this.btnAddBatt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.battIDDataGridViewTextBoxColumn,
            this.battTechDataGridViewTextBoxColumn,
            this.manuefecDataGridViewTextBoxColumn,
            this.modelNoDataGridViewTextBoxColumn,
            this.nomVoltDataGridViewTextBoxColumn,
            this.maxCurrentDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.batteryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // batteryBindingSource
            // 
            this.batteryBindingSource.DataMember = "Battery";
            this.batteryBindingSource.DataSource = this.solarpvbdDataSet;
            // 
            // solarpvbdDataSet
            // 
            this.solarpvbdDataSet.DataSetName = "solarpvbdDataSet";
            this.solarpvbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Capacity";
            // 
            // txtbxCapacity
            // 
            this.txtbxCapacity.Location = new System.Drawing.Point(172, 173);
            this.txtbxCapacity.Name = "txtbxCapacity";
            this.txtbxCapacity.Size = new System.Drawing.Size(152, 20);
            this.txtbxCapacity.TabIndex = 15;
            // 
            // btnBattRefresh
            // 
            this.btnBattRefresh.Location = new System.Drawing.Point(675, 200);
            this.btnBattRefresh.Name = "btnBattRefresh";
            this.btnBattRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnBattRefresh.TabIndex = 16;
            this.btnBattRefresh.Text = "Refresh";
            this.btnBattRefresh.UseVisualStyleBackColor = true;
            this.btnBattRefresh.Click += new System.EventHandler(this.btnBattRefresh_Click);
            // 
            // batteryTableAdapter
            // 
            this.batteryTableAdapter.ClearBeforeFill = true;
            // 
            // battIDDataGridViewTextBoxColumn
            // 
            this.battIDDataGridViewTextBoxColumn.DataPropertyName = "BattID";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.battIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.battIDDataGridViewTextBoxColumn.HeaderText = "Battery ID";
            this.battIDDataGridViewTextBoxColumn.Name = "battIDDataGridViewTextBoxColumn";
            this.battIDDataGridViewTextBoxColumn.Width = 62;
            // 
            // battTechDataGridViewTextBoxColumn
            // 
            this.battTechDataGridViewTextBoxColumn.DataPropertyName = "BattTech";
            this.battTechDataGridViewTextBoxColumn.HeaderText = "Technology";
            this.battTechDataGridViewTextBoxColumn.Name = "battTechDataGridViewTextBoxColumn";
            // 
            // manuefecDataGridViewTextBoxColumn
            // 
            this.manuefecDataGridViewTextBoxColumn.DataPropertyName = "Manuefec";
            this.manuefecDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manuefecDataGridViewTextBoxColumn.Name = "manuefecDataGridViewTextBoxColumn";
            // 
            // modelNoDataGridViewTextBoxColumn
            // 
            this.modelNoDataGridViewTextBoxColumn.DataPropertyName = "ModelNo";
            this.modelNoDataGridViewTextBoxColumn.HeaderText = "ModelNo";
            this.modelNoDataGridViewTextBoxColumn.Name = "modelNoDataGridViewTextBoxColumn";
            // 
            // nomVoltDataGridViewTextBoxColumn
            // 
            this.nomVoltDataGridViewTextBoxColumn.DataPropertyName = "NomVolt";
            this.nomVoltDataGridViewTextBoxColumn.HeaderText = "Nominal Voltage (vol)";
            this.nomVoltDataGridViewTextBoxColumn.Name = "nomVoltDataGridViewTextBoxColumn";
            this.nomVoltDataGridViewTextBoxColumn.Width = 104;
            // 
            // maxCurrentDataGridViewTextBoxColumn
            // 
            this.maxCurrentDataGridViewTextBoxColumn.DataPropertyName = "MaxCurrent";
            this.maxCurrentDataGridViewTextBoxColumn.HeaderText = "Max Current (A)";
            this.maxCurrentDataGridViewTextBoxColumn.Name = "maxCurrentDataGridViewTextBoxColumn";
            this.maxCurrentDataGridViewTextBoxColumn.Width = 94;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity (AH)";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 89;
            // 
            // addnewBatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 392);
            this.Controls.Add(this.btnBattRefresh);
            this.Controls.Add(this.txtbxCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddBatt);
            this.Controls.Add(this.txtbxDisCurr);
            this.Controls.Add(this.txtbxVolt);
            this.Controls.Add(this.txtbxBattTech);
            this.Controls.Add(this.txtbxBattModel);
            this.Controls.Add(this.txtbxBattManu);
            this.Controls.Add(this.txtbxBattID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "addnewBatt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Battery";
            this.Load += new System.EventHandler(this.addnewBatt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxBattID;
        private System.Windows.Forms.TextBox txtbxBattManu;
        private System.Windows.Forms.TextBox txtbxBattModel;
        private System.Windows.Forms.TextBox txtbxBattTech;
        private System.Windows.Forms.TextBox txtbxVolt;
        private System.Windows.Forms.TextBox txtbxDisCurr;
        private System.Windows.Forms.Button btnAddBatt;
        private solarpvbdDataSet solarpvbdDataSet;
        private solarpvbdDataSetTableAdapters.BatteryTableAdapter batteryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxCapacity;
        private System.Windows.Forms.Button btnBattRefresh;
        private System.Windows.Forms.BindingSource batteryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn battIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn battTechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manuefecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVoltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
    }
}