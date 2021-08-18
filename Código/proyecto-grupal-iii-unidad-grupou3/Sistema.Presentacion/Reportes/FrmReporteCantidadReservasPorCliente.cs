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
    public partial class FrmReporteCantidadReservasPorCliente : Form
    {
        public FrmReporteCantidadReservasPorCliente()
        {
            InitializeComponent();
        }

        private void FrmReporteCantidadReservasPorCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSGestionHoteles.USP_Reserva_Cantidad' Puede moverla o quitarla según sea necesario.
            this.USP_Reserva_CantidadTableAdapter.Fill(this.DSGestionHoteles.USP_Reserva_Cantidad);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
