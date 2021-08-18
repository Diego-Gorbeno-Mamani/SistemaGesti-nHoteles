using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmReportesGeneral : Form
    {
        public FrmReportesGeneral()
        {
            InitializeComponent();
        }

        private void btnCantidadRC_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteCantidadReservasPorCliente Reporte = new Reportes.FrmReporteCantidadReservasPorCliente();
            Reporte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmTotalReservas Reporte = new Reportes.FrmTotalReservas();
            Reporte.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteParametro Reporte = new Reportes.FrmReporteParametro();
            Reporte.ShowDialog();
        }
    }
}
