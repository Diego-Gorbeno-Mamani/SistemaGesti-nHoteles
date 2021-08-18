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
    public partial class FrmEstadoCuenta : Form
    {
        
        public FrmEstadoCuenta(string nombre)
        {
            InitializeComponent();
            cmbauxiliar.DataSource = ClsNegocioUsuario.DatosLogueado(nombre);
            cmbauxiliar.DisplayMember = "id_Usuario";
            txtNombre.Text = nombre;
    
        }

        private void FrmEstadoCuenta_Load(object sender, EventArgs e)
        {
            
            dgvListarP.DataSource = ClsNegocioReserva.ListarReserva(Convert.ToInt32(cmbauxiliar.Text));
            this.TitulosGrilla();
            
        }
        private void TitulosGrilla()
        {

            dgvListarP.Columns[0].Visible = false; //columna seleccionar
            dgvListarP.Columns[1].Width = 50;
            dgvListarP.Columns[2].Width = 50;
            dgvListarP.Columns[3].Width = 100;
            dgvListarP.Columns[4].Width = 100;
       


            dgvListarP.Columns[1].HeaderText = "Id";
            dgvListarP.Columns[2].HeaderText = "Id Usuario";
            dgvListarP.Columns[3].HeaderText = "Estado";
            dgvListarP.Columns[4].HeaderText = "Fecha";
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
