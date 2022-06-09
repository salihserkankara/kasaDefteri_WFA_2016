namespace WindowsFormsApplication8
{
    partial class rapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database2DataSet7 = new WindowsFormsApplication8.Database2DataSet7();
            this.tabloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabloTableAdapter = new WindowsFormsApplication8.Database2DataSet5TableAdapters.tabloTableAdapter();
            this.tabloTableAdapter1 = new WindowsFormsApplication8.Database2DataSet6TableAdapters.tabloTableAdapter();
            this.tabloTableAdapter2 = new WindowsFormsApplication8.Database2DataSet7TableAdapters.tabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabloBindingSource2
            // 
            this.tabloBindingSource2.DataMember = "tablo";
            this.tabloBindingSource2.DataSource = this.database2DataSet7BindingSource;
            // 
            // database2DataSet7BindingSource
            // 
            this.database2DataSet7BindingSource.DataSource = this.Database2DataSet7;
            this.database2DataSet7BindingSource.Position = 0;
            // 
            // Database2DataSet7
            // 
            this.Database2DataSet7.DataSetName = "Database2DataSet7";
            this.Database2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "veriseti";
            reportDataSource1.Value = this.tabloBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication8.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(816, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabloTableAdapter
            // 
            this.tabloTableAdapter.ClearBeforeFill = true;
            // 
            // tabloTableAdapter1
            // 
            this.tabloTableAdapter1.ClearBeforeFill = true;
            // 
            // tabloTableAdapter2
            // 
            this.tabloTableAdapter2.ClearBeforeFill = true;
            // 
            // rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 396);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "rapor";
            this.Text = "rapor";
            this.Load += new System.EventHandler(this.rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tabloBindingSource;
        private Database2DataSet5TableAdapters.tabloTableAdapter tabloTableAdapter;
        private System.Windows.Forms.BindingSource tabloBindingSource1;
        private Database2DataSet6TableAdapters.tabloTableAdapter tabloTableAdapter1;
        private Database2DataSet7 Database2DataSet7;
        private System.Windows.Forms.BindingSource database2DataSet7BindingSource;
        private System.Windows.Forms.BindingSource tabloBindingSource2;
        private Database2DataSet7TableAdapters.tabloTableAdapter tabloTableAdapter2;
    }
}