namespace SolarPV
{
    partial class designReportViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.solarpvbdDataSet = new SolarPV.solarpvbdDataSet();
            this.SystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SystemTableAdapter = new SolarPV.solarpvbdDataSetTableAdapters.SystemTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SystemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SolarPV.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(585, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // solarpvbdDataSet
            // 
            this.solarpvbdDataSet.DataSetName = "solarpvbdDataSet";
            this.solarpvbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SystemBindingSource
            // 
            this.SystemBindingSource.DataMember = "System";
            this.SystemBindingSource.DataSource = this.solarpvbdDataSet;
            // 
            // SystemTableAdapter
            // 
            this.SystemTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estimated Components for Stand alone Solar PV System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // designReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "designReportViewer";
            this.Text = "Solar PV Estimations";
            this.Load += new System.EventHandler(this.designReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SystemBindingSource;
        private solarpvbdDataSet solarpvbdDataSet;
        private solarpvbdDataSetTableAdapters.SystemTableAdapter SystemTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}