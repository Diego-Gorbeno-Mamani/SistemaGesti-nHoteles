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
    public partial class FrmAgregarHabitaciones : Form
    {
        public static string nombrehotel;
        public FrmAgregarHabitaciones(string nombre)
        {
            InitializeComponent();
            cmbIdHotel.DataSource = ClsNegocioHotel.DatosIdHotel(nombre);
            cmbIdHotel.ValueMember = "id_hotel";
        }

    


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int aux = 0;
            aux = cmbTipos.SelectedIndex + 1;
            ClsNegocioHabitacion objhab = new ClsNegocioHabitacion();
            try
            {
                string rpta = "";
                rpta = ClsNegocioHabitacion.AgregarHabitacion(Convert.ToInt32(cmbIdHotel.Text), aux, Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(txtPrecio.Text), cmbDisponibilidad.Text, rtbDescripcion.Text);
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Datos Registrado");
                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAgregarHabitaciones_Load(object sender, EventArgs e)
        {
            cmbTipos.DataSource = ClsNegocioHabitacion.CargarTipos();
            cmbTipos.DisplayMember = "tipo_nombre_habitacion";
            cmbTipos.ValueMember = "id_tipo_habitacion";
        }
    }
}
