namespace Sistema.Presentacion.Reportes
{
    partial class FrmReporteCantidadReservasPorCliente
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
            this.USP_Reserva_CantidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSGestionHoteles = new Sistema.Presentacion.Reportes.DSGestionHoteles();
            this.USP_Reserva_CantidadTableAdapter = new Sistema.Presentacion.Reportes.DSGestionHotelesTableAdapters.USP_Reserva_CantidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reserva_CantidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGestionHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSCantidadReservasPorCliente";
            reportDataSource2.Value = this.USP_Reserva_CantidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptCantidadReservasDeUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // USP_Reserva_CantidadBindingSource
            // 
            this.USP_Reserva_CantidadBindingSource.DataMember = "USP_Reserva_Cantidad";
            this.USP_Reserva_CantidadBindingSource.DataSource = this.DSGestionHoteles;
            // 
            // DSGestionHoteles
            // 
            this.DSGestionHoteles.DataSetName = "DSGestionHoteles";
            this.DSGestionHoteles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Reserva_CantidadTableAdapter
            // 
            this.USP_Reserva_CantidadTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCantidadReservasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCantidadReservasPorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteCantidadReservasPorCliente";
            this.Load += new System.EventHandler(this.FrmReporteCantidadReservasPorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reserva_CantidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGestionHoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Reserva_CantidadBindingSource;
        private DSGestionHoteles DSGestionHoteles;
        private DSGestionHotelesTableAdapters.USP_Reserva_CantidadTableAdapter USP_Reserva_CantidadTableAdapter;
    }
}