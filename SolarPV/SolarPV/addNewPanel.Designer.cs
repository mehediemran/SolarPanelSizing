namespace SolarPV
{
    partial class addNewPanel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbxpanelID = new System.Windows.Forms.TextBox();
            this.txtbxPanelManu = new System.Windows.Forms.TextBox();
            this.txtbxPanelModelNo = new System.Windows.Forms.TextBox();
            this.txtbxPanelTolerance = new System.Windows.Forms.TextBox();
            this.txtbxPanelEfficiency = new System.Windows.Forms.TextBox();
            this.txtbxMaxPower = new System.Windows.Forms.TextBox();
            this.txtbxMaxVolt = new System.Windows.Forms.TextBox();
            this.txtbxOpenCV = new System.Windows.Forms.TextBox();
            this.txtbxShortCC = new System.Windows.Forms.TextBox();
            this.txtbxMaxCurrent = new System.Windows.Forms.TextBox();
            this.txtbxArea = new System.Windows.Forms.TextBox();
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.solarpvbdDataSet = new SolarPV.solarpvbdDataSet();
            this.panelTableAdapter = new SolarPV.solarpvbdDataSetTableAdapters.PanelTableAdapter();
            this.txtbxPanelTech = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxVoltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCVoltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolaranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Technology ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tolerance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Efficiency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max Power";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Max Volt at max Power";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Open Circuit voltage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Short Circuit Current";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Current at MaxPower";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Area";
            // 
            // txtbxpanelID
            // 
            this.txtbxpanelID.Location = new System.Drawing.Point(152, 30);
            this.txtbxpanelID.Name = "txtbxpanelID";
            this.txtbxpanelID.Size = new System.Drawing.Size(154, 20);
            this.txtbxpanelID.TabIndex = 13;
            // 
            // txtbxPanelManu
            // 
            this.txtbxPanelManu.Location = new System.Drawing.Point(152, 62);
            this.txtbxPanelManu.Name = "txtbxPanelManu";
            this.txtbxPanelManu.Size = new System.Drawing.Size(154, 20);
            this.txtbxPanelManu.TabIndex = 14;
            // 
            // txtbxPanelModelNo
            // 
            this.txtbxPanelModelNo.Location = new System.Drawing.Point(152, 99);
            this.txtbxPanelModelNo.Name = "txtbxPanelModelNo";
            this.txtbxPanelModelNo.Size = new System.Drawing.Size(154, 20);
            this.txtbxPanelModelNo.TabIndex = 15;
            // 
            // txtbxPanelTolerance
            // 
            this.txtbxPanelTolerance.Location = new System.Drawing.Point(152, 171);
            this.txtbxPanelTolerance.Name = "txtbxPanelTolerance";
            this.txtbxPanelTolerance.Size = new System.Drawing.Size(154, 20);
            this.txtbxPanelTolerance.TabIndex = 16;
            // 
            // txtbxPanelEfficiency
            // 
            this.txtbxPanelEfficiency.Location = new System.Drawing.Point(152, 209);
            this.txtbxPanelEfficiency.Name = "txtbxPanelEfficiency";
            this.txtbxPanelEfficiency.Size = new System.Drawing.Size(154, 20);
            this.txtbxPanelEfficiency.TabIndex = 17;
            // 
            // txtbxMaxPower
            // 
            this.txtbxMaxPower.Location = new System.Drawing.Point(509, 30);
            this.txtbxMaxPower.Name = "txtbxMaxPower";
            this.txtbxMaxPower.Size = new System.Drawing.Size(154, 20);
            this.txtbxMaxPower.TabIndex = 18;
            // 
            // txtbxMaxVolt
            // 
            this.txtbxMaxVolt.Location = new System.Drawing.Point(509, 62);
            this.txtbxMaxVolt.Name = "txtbxMaxVolt";
            this.txtbxMaxVolt.Size = new System.Drawing.Size(154, 20);
            this.txtbxMaxVolt.TabIndex = 19;
            // 
            // txtbxOpenCV
            // 
            this.txtbxOpenCV.Location = new System.Drawing.Point(509, 99);
            this.txtbxOpenCV.Name = "txtbxOpenCV";
            this.txtbxOpenCV.Size = new System.Drawing.Size(154, 20);
            this.txtbxOpenCV.TabIndex = 20;
            // 
            // txtbxShortCC
            // 
            this.txtbxShortCC.Location = new System.Drawing.Point(509, 134);
            this.txtbxShortCC.Name = "txtbxShortCC";
            this.txtbxShortCC.Size = new System.Drawing.Size(154, 20);
            this.txtbxShortCC.TabIndex = 21;
            // 
            // txtbxMaxCurrent
            // 
            this.txtbxMaxCurrent.Location = new System.Drawing.Point(509, 171);
            this.txtbxMaxCurrent.Name = "txtbxMaxCurrent";
            this.txtbxMaxCurrent.Size = new System.Drawing.Size(154, 20);
            this.txtbxMaxCurrent.TabIndex = 22;
            // 
            // txtbxArea
            // 
            this.txtbxArea.Location = new System.Drawing.Point(509, 209);
            this.txtbxArea.Name = "txtbxArea";
            this.txtbxArea.Size = new System.Drawing.Size(154, 20);
            this.txtbxArea.TabIndex = 23;
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.Location = new System.Drawing.Point(313, 250);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(121, 23);
            this.btnAddPanel.TabIndex = 24;
            this.btnAddPanel.Text = "Save new Panel";
            this.btnAddPanel.UseVisualStyleBackColor = true;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            // 
            // solarpvbdDataSet
            // 
            this.solarpvbdDataSet.DataSetName = "solarpvbdDataSet";
            this.solarpvbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTableAdapter
            // 
            this.panelTableAdapter.ClearBeforeFill = true;
            // 
            // txtbxPanelTech
            // 
            this.txtbxPanelTech.Location = new System.Drawing.Point(152, 141);
            this.txtbxPanelTech.Name = "txtbxPanelTech";
            this.txtbxPanelTech.Size = new System.Drawing.Size(154, 20);
            this.txtbxPanelTech.TabIndex = 26;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(673, 260);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.panelIDDataGridViewTextBoxColumn,
            this.manufecDataGridViewTextBoxColumn,
            this.modelNoDataGridViewTextBoxColumn,
            this.panelTechDataGridViewTextBoxColumn,
            this.maxPowerDataGridViewTextBoxColumn,
            this.maxVoltDataGridViewTextBoxColumn,
            this.oCVoltDataGridViewTextBoxColumn,
            this.sCCurrentDataGridViewTextBoxColumn,
            this.tolaranceDataGridViewTextBoxColumn,
            this.efficiencyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.panelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // panelBindingSource
            // 
            this.panelBindingSource.DataMember = "Panel";
            this.panelBindingSource.DataSource = this.solarpvbdDataSet;
            // 
            // panelIDDataGridViewTextBoxColumn
            // 
            this.panelIDDataGridViewTextBoxColumn.DataPropertyName = "PanelID";
            this.panelIDDataGridViewTextBoxColumn.HeaderText = "PanelID";
            this.panelIDDataGridViewTextBoxColumn.Name = "panelIDDataGridViewTextBoxColumn";
            // 
            // manufecDataGridViewTextBoxColumn
            // 
            this.manufecDataGridViewTextBoxColumn.DataPropertyName = "Manufec";
            this.manufecDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufecDataGridViewTextBoxColumn.Name = "manufecDataGridViewTextBoxColumn";
            // 
            // modelNoDataGridViewTextBoxColumn
            // 
            this.modelNoDataGridViewTextBoxColumn.DataPropertyName = "ModelNo";
            this.modelNoDataGridViewTextBoxColumn.HeaderText = "ModelNo";
            this.modelNoDataGridViewTextBoxColumn.Name = "modelNoDataGridViewTextBoxColumn";
            // 
            // panelTechDataGridViewTextBoxColumn
            // 
            this.panelTechDataGridViewTextBoxColumn.DataPropertyName = "PanelTech";
            this.panelTechDataGridViewTextBoxColumn.HeaderText = "Technology";
            this.panelTechDataGridViewTextBoxColumn.Name = "panelTechDataGridViewTextBoxColumn";
            // 
            // maxPowerDataGridViewTextBoxColumn
            // 
            this.maxPowerDataGridViewTextBoxColumn.DataPropertyName = "MaxPower";
            this.maxPowerDataGridViewTextBoxColumn.HeaderText = "Max Power (W)";
            this.maxPowerDataGridViewTextBoxColumn.Name = "maxPowerDataGridViewTextBoxColumn";
            // 
            // maxVoltDataGridViewTextBoxColumn
            // 
            this.maxVoltDataGridViewTextBoxColumn.DataPropertyName = "MaxVolt";
            this.maxVoltDataGridViewTextBoxColumn.HeaderText = "Max Voltlage";
            this.maxVoltDataGridViewTextBoxColumn.Name = "maxVoltDataGridViewTextBoxColumn";
            // 
            // oCVoltDataGridViewTextBoxColumn
            // 
            this.oCVoltDataGridViewTextBoxColumn.DataPropertyName = "OCVolt";
            this.oCVoltDataGridViewTextBoxColumn.HeaderText = "Open Circuit Voltage";
            this.oCVoltDataGridViewTextBoxColumn.Name = "oCVoltDataGridViewTextBoxColumn";
            // 
            // sCCurrentDataGridViewTextBoxColumn
            // 
            this.sCCurrentDataGridViewTextBoxColumn.DataPropertyName = "SCCurrent";
            this.sCCurrentDataGridViewTextBoxColumn.HeaderText = "Short Circuit Current (A)";
            this.sCCurrentDataGridViewTextBoxColumn.Name = "sCCurrentDataGridViewTextBoxColumn";
            // 
            // tolaranceDataGridViewTextBoxColumn
            // 
            this.tolaranceDataGridViewTextBoxColumn.DataPropertyName = "Tolarance";
            this.tolaranceDataGridViewTextBoxColumn.HeaderText = "Tolarance";
            this.tolaranceDataGridViewTextBoxColumn.Name = "tolaranceDataGridViewTextBoxColumn";
            // 
            // efficiencyDataGridViewTextBoxColumn
            // 
            this.efficiencyDataGridViewTextBoxColumn.DataPropertyName = "Efficiency";
            this.efficiencyDataGridViewTextBoxColumn.HeaderText = "Efficiency";
            this.efficiencyDataGridViewTextBoxColumn.Name = "efficiencyDataGridViewTextBoxColumn";
            // 
            // addNewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtbxPanelTech);
            this.Controls.Add(this.btnAddPanel);
            this.Controls.Add(this.txtbxArea);
            this.Controls.Add(this.txtbxMaxCurrent);
            this.Controls.Add(this.txtbxShortCC);
            this.Controls.Add(this.txtbxOpenCV);
            this.Controls.Add(this.txtbxMaxVolt);
            this.Controls.Add(this.txtbxMaxPower);
            this.Controls.Add(this.txtbxPanelEfficiency);
            this.Controls.Add(this.txtbxPanelTolerance);
            this.Controls.Add(this.txtbxPanelModelNo);
            this.Controls.Add(this.txtbxPanelManu);
            this.Controls.Add(this.txtbxpanelID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addNewPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Panel";
            this.Load += new System.EventHandler(this.addNewPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbxpanelID;
        private System.Windows.Forms.TextBox txtbxPanelManu;
        private System.Windows.Forms.TextBox txtbxPanelModelNo;
        private System.Windows.Forms.TextBox txtbxPanelTolerance;
        private System.Windows.Forms.TextBox txtbxPanelEfficiency;
        private System.Windows.Forms.TextBox txtbxMaxPower;
        private System.Windows.Forms.TextBox txtbxMaxVolt;
        private System.Windows.Forms.TextBox txtbxOpenCV;
        private System.Windows.Forms.TextBox txtbxShortCC;
        private System.Windows.Forms.TextBox txtbxMaxCurrent;
        private System.Windows.Forms.TextBox txtbxArea;
        private System.Windows.Forms.Button btnAddPanel;
        private solarpvbdDataSet solarpvbdDataSet;
        private solarpvbdDataSetTableAdapters.PanelTableAdapter panelTableAdapter;
        private System.Windows.Forms.TextBox txtbxPanelTech;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempCoeffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerEffDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource panelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn panelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn panelTechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxVoltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCVoltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCCurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolaranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyDataGridViewTextBoxColumn;
    }
}