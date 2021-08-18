namespace Sistema.Presentacion.Reportes
{
    partial class FrmTotalReservas
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
            this.DSGestionHoteles = new Sistema.Presentacion.Reportes.DSGestionHoteles();
            this.USP_ReservaEmpresa_Listar_ReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_ReservaEmpresa_Listar_ReporteTableAdapter = new Sistema.Presentacion.Reportes.DSGestionHotelesTableAdapters.USP_ReservaEmpresa_Listar_ReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSGestionHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReservaEmpresa_Listar_ReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSTotalReservas";
            reportDataSource2.Value = this.USP_ReservaEmpresa_Listar_ReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.TotalReservas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSGestionHoteles
            // 
            this.DSGestionHoteles.DataSetName = "DSGestionHoteles";
            this.DSGestionHoteles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_ReservaEmpresa_Listar_ReporteBindingSource
            // 
            this.USP_ReservaEmpresa_Listar_ReporteBindingSource.DataMember = "USP_ReservaEmpresa_Listar_Reporte";
            this.USP_ReservaEmpresa_Listar_ReporteBindingSource.DataSource = this.DSGestionHoteles;
            // 
            // USP_ReservaEmpresa_Listar_ReporteTableAdapter
            // 
            this.USP_ReservaEmpresa_Listar_ReporteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTotalReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmTotalReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTotalReservas";
            this.Load += new System.EventHandler(this.FrmTotalReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSGestionHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReservaEmpresa_Listar_ReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_ReservaEmpresa_Listar_ReporteBindingSource;
        private DSGestionHoteles DSGestionHoteles;
        private DSGestionHotelesTableAdapters.USP_ReservaEmpresa_Listar_ReporteTableAdapter USP_ReservaEmpresa_Listar_ReporteTableAdapter;
    }
}