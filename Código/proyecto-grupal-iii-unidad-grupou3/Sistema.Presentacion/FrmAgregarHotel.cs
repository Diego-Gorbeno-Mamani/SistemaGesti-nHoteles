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
    public partial class FrmAgregarHotel : Form
    {
        public static string nombrehotel;
        public int idusu;
        public int ayudita;
        public FrmAgregarHotel(string nombre)
        {
            InitializeComponent();
            cmbauxiliar.DataSource = ClsNegocioUsuario.DatosLogueado(nombre);
            cmbauxiliar.DisplayMember = "id_Usuario";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FrmAgregarHabitaciones frm = new FrmAgregarHabitaciones();
            //frm.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ptbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            ClsNegocioHotel objh = new ClsNegocioHotel();
            try
            {
                string rpta = "";
                if (ptbImagen.Image == null)
                {
                    MessageBox.Show("Faltan Datos");
                }
                else
                {
                    rpta = ClsNegocioHotel.AgregarHotel(txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), txtPais.Text.Trim(), CmbCategoria.Text.Trim(), ms.GetBuffer(), txtHorario.Text.Trim(), rtbDescripcion.Text.Trim(), Convert.ToInt32(cmbauxiliar.Text.Trim()));
                    nombrehotel = txtNombre.Text;
                    FrmAgregarHabitaciones frmhabi = new FrmAgregarHabitaciones(nombrehotel);
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Usuario Registrado");
                        frmhabi.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            DialogResult rs = img.ShowDialog();
            if(rs == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
            }
        }

        private void FrmAgregarHotel_Load(object sender, EventArgs e)
        {
           
            //te.Text = Convert.ToString(idusu);
      
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
