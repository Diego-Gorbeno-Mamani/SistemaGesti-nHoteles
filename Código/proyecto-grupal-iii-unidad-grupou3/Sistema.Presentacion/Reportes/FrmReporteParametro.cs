using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteParametro : Form
    {
        string Busqueda;
        public FrmReporteParametro()
        {
            InitializeComponent();
        }

        private void FrmReporteParametro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte_Precio_Parametro' Puede moverla o quitarla según sea necesario.
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter.Fill(this.DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte_Precio_Parametro,Busqueda);

            this.USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter.Fill(this.DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte_Parametro, Busqueda);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();

            
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            string Busqueda;
            Busqueda = txtBusquedaP.Text;
            // TODO: esta línea de código carga datos en la tabla 'DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte_Parametro' Puede moverla o quitarla según sea necesario.
            this.USP_ReservaEmpresa_Listar_Reporte_Precio_ParametroTableAdapter.Fill(this.DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte_Precio_Parametro, Busqueda);
            this.USP_ReservaEmpresa_Listar_Reporte_ParametroTableAdapter.Fill(this.DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte_Parametro, Busqueda);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
