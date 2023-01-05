
namespace AgenciaSeguros
{
    partial class VentanaInformes
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
            this.polizasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInforme = new AgenciaSeguros.DataSetInforme();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.polizasTableAdapter = new AgenciaSeguros.DataSetInformeTableAdapters.polizasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // polizasBindingSource
            // 
            this.polizasBindingSource.DataMember = "polizas";
            this.polizasBindingSource.DataSource = this.DataSetInforme;
            // 
            // DataSetInforme
            // 
            this.DataSetInforme.DataSetName = "DataSetInforme";
            this.DataSetInforme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetInforme";
            reportDataSource1.Value = this.polizasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AgenciaSeguros.Informes.InformePolizas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // polizasTableAdapter
            // 
            this.polizasTableAdapter.ClearBeforeFill = true;
            // 
            // VentanaInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource polizasBindingSource;
        private DataSetInforme DataSetInforme;
        private DataSetInformeTableAdapters.polizasTableAdapter polizasTableAdapter;
    }
}