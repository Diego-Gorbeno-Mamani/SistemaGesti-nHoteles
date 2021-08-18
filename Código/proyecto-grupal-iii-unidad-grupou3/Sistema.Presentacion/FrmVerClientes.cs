using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmVerClientes : Form
    {
        public FrmVerClientes(string nombre)
        {
            InitializeComponent();
            cmbauxiliar.DataSource = ClsNegocioUsuario.DatosLogueado(nombre);
            cmbauxiliar.DisplayMember = "id_Usuario";

        }

        private void FrmVerClientes_Load(object sender, EventArgs e)
        {
            dgvListarP.DataSource = ClsNegocioReserva.ListarReservaEmpresa(Convert.ToInt32(cmbauxiliar.Text));
            this.TitulosGrilla();
        }

        private void TitulosGrilla()
        {

            dgvListarP.Columns[0].Visible = false; //columna seleccionar
            dgvListarP.Columns[1].Width = 50;
            dgvListarP.Columns[2].Width = 80;
            dgvListarP.Columns[3].Width = 100;
            dgvListarP.Columns[4].Width = 100;
            dgvListarP.Columns[5].Width = 50;
            dgvListarP.Columns[6].Width = 50;
            dgvListarP.Columns[7].Width = 100;
            dgvListarP.Columns[8].Width = 100;



            dgvListarP.Columns[1].HeaderText = "Id Reserva";
            dgvListarP.Columns[2].HeaderText = "Estado";
            dgvListarP.Columns[3].HeaderText = "nombre hotel";
            dgvListarP.Columns[4].HeaderText = "tipo habitacion";
            dgvListarP.Columns[5].HeaderText = "Disponibilidad";
            dgvListarP.Columns[6].HeaderText = "Precio";
            dgvListarP.Columns[7].HeaderText = "Nombre cliente";
            dgvListarP.Columns[8].HeaderText = "Fecha";

        }
    }
}
