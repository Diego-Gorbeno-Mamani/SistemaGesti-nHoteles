namespace Sistema.Presentacion.Reportes
{
    partial class FrmReporteParametro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteParametro));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSGestionHoteles = new Sistema.Presentacion.Reportes.DSGestionHoteles();
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtBusquedaP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter = new Sistema.Presentacion.Reportes.DSGestionHotelesTableAdapters.USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter();
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter = new Sistema.Presentacion.Reportes.DSGestionHotelesTableAdapters.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGestionHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource
            // 
            this.USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource.DataMember = "USP_ReservaEmpresa_Listar_Reporte_Parametro";
            this.USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource.DataSource = this.DSGestionHoteles;
            // 
            // DSGestionHoteles
            // 
            this.DSGestionHoteles.DataSetName = "DSGestionHoteles";
            this.DSGestionHoteles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource
            // 
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource.DataMember = "USP_ReservaEmpresa_Listar_Reporte_Precio_Parametro";
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource.DataSource = this.DSGestionHoteles;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.Image")));
            this.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.Location = new System.Drawing.Point(529, 52);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(86, 31);
            this.btnBuscarP.TabIndex = 14;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtBusquedaP
            // 
            this.txtBusquedaP.Location = new System.Drawing.Point(209, 58);
            this.txtBusquedaP.Name = "txtBusquedaP";
            this.txtBusquedaP.Size = new System.Drawing.Size(284, 20);
            this.txtBusquedaP.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "REPORTE DE RESERVAS POR EMPRESA";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptReservasDeEmpresasParametro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(748, 245);
            this.reportViewer1.TabIndex = 17;
            // 
            // USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter
            // 
            this.USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter.ClearBeforeFill = true;
            // 
            // USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter
            // 
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet5";
            reportDataSource2.Value = this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptTotalPrecio.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(23, 377);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(748, 229);
            this.reportViewer2.TabIndex = 18;
            // 
            // FrmReporteParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.txtBusquedaP);
            this.Controls.Add(this.label2);
            this.Name = "FrmReporteParametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteParametro";
            this.Load += new System.EventHandler(this.FrmReporteParametro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGestionHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox txtBusquedaP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource USP_ReservaEmpresa_Listar_Reporte_ParametroBindingSource;
        private DSGestionHoteles DSGestionHoteles;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSGestionHotelesTableAdapters.USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter;
        private System.Windows.Forms.BindingSource USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroBindingSource;
        private DSGestionHotelesTableAdapters.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}