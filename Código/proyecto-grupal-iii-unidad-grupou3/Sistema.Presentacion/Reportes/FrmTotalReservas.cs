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
    public partial class FrmTotalReservas : Form
    {
        public FrmTotalReservas()
        {
            InitializeComponent();
        }

        private void FrmTotalReservas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte' Puede moverla o quitarla según sea necesario.
            this.USP_ReservaEmpresa_Listar_ReporteTableAdapter.Fill(this.DSGestionHoteles.USP_ReservaEmpresa_Listar_Reporte);

            this.reportViewer1.RefreshReport();
        }
    }
}
