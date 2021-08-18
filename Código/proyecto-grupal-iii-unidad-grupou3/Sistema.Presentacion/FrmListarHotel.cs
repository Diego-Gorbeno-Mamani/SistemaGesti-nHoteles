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
    public partial class FrmListarHotel : Form
    {
        public int aux=24;
        public FrmListarHotel(string nombre)
        {
            InitializeComponent();
            cmbauxiliar.DataSource = ClsNegocioUsuario.DatosLogueado(nombre);
            cmbauxiliar.DisplayMember = "id_Usuario";
           
        }

        private void FrmListarHotel_Load(object sender, EventArgs e)
        {
            //FrmMenu ob = new FrmMenu();
            //aux = ob.idUsuario;
            
            dgvListarP.DataSource = ClsNegocioHotel.ListarEmpresa(Convert.ToInt32(cmbauxiliar.Text.Trim()));
            this.TitulosGrilla();

        }
        //metodo titulosgrilla
        private void TitulosGrilla()
        {
            dgvListarP.Columns[0].Width = 50; //columna seleccionar
            dgvListarP.Columns[1].Width = 70;
            dgvListarP.Columns[2].Width = 80;
            dgvListarP.Columns[3].Width = 100;
            dgvListarP.Columns[4].Width = 60;
            dgvListarP.Columns[5].Width = 140;
            dgvListarP.Columns[6].Width = 110;
            dgvListarP.Columns[7].Width = 150;
            dgvListarP.Columns[8].Width = 80;

            
            dgvListarP.Columns[0].HeaderText = "ID";
            dgvListarP.Columns[1].HeaderText = "Nombre";
            dgvListarP.Columns[2].HeaderText = "Direccion";
            dgvListarP.Columns[3].HeaderText = "Ciudad";
            dgvListarP.Columns[4].HeaderText = "Pais";
            dgvListarP.Columns[5].HeaderText = "Categoria";
            dgvListarP.Columns[6].HeaderText = "Imagen";
            dgvListarP.Columns[7].HeaderText = "Horario";
            dgvListarP.Columns[8].HeaderText = "Descripcion";

            dgvListarP.Columns[0].Name = "ID";
            dgvListarP.Columns[1].Name = "Nombre";
            dgvListarP.Columns[2].Name = "Direccion";
            dgvListarP.Columns[3].Name = "Ciudad";
            dgvListarP.Columns[4].Name = "Pais";
            dgvListarP.Columns[5].Name = "Categoria";
            dgvListarP.Columns[6].Name = "Imagen";
            dgvListarP.Columns[7].Name = "Horario";
            dgvListarP.Columns[8].Name = "Descripcion";
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                string Buscar;
                Buscar = txtBusquedaP.Text;
                dgvListarP.DataSource = ClsNegocioHotel.BuscarEmpresa(Buscar, Convert.ToInt32(cmbauxiliar.Text.Trim()));
                this.TitulosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListarP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    txtIdHotel.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["ID"].Value);
            //    txtNombreHotel.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Nombre"].Value);
            //    txtDireccion.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Direccion"].Value);
            //    TxtCiudad.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Ciudad"].Value);
            //    txtPais.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Pais"].Value);
            //    cmbCategoria.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Categoria"].Value);
            //    byte[] img = (byte[])dgvListarP.CurrentRow.Cells["Imagen"].Value;
            //    txtHorario.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Horario"].Value);
            //    rtbDescripcion.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Descripcion"].Value);
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            //    ptbImagen.Image = Image.FromStream(ms);
            //    tabControl1.SelectedIndex = 1;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Seleccione la celda");
            //}
        }

        private void dgvListarP_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdHotel.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["ID"].Value);
                txtNombreHotel.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Nombre"].Value);
                txtDireccion.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Direccion"].Value);
                TxtCiudad.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Ciudad"].Value);
                txtPais.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Pais"].Value);
                cmbCategoria.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Categoria"].Value);
                byte[] img = (byte[])dgvListarP.CurrentRow.Cells["Imagen"].Value;               
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                ptbImagen.Image = Image.FromStream(ms);
                txtHorario.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Horario"].Value);
                rtbDescripcion.Text = Convert.ToString(dgvListarP.CurrentRow.Cells["Descripcion"].Value);
                tabControl1.SelectedIndex = 1;
                txtIdHotel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione la celda");
            }
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            DialogResult rs = img.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(img.FileName);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ptbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            try
            {
                string rpta = "";
                if (txtNombreHotel.Text == string.Empty || ptbImagen.Image == null)
                {
                    MessageBox.Show("Faltan Ingresar datos en algunos campos");
                }
                else
                {
                    rpta = ClsNegocioHotel.ActualizarHotel(Convert.ToInt32(txtIdHotel.Text), txtNombreHotel.Text.Trim(), txtDireccion.Text.Trim(), TxtCiudad.Text.Trim(), txtPais.Text.Trim(), cmbCategoria.Text.Trim(), ms.GetBuffer(), txtHorario.Text.Trim(), rtbDescripcion.Text.Trim(), Convert.ToInt32(cmbauxiliar.Text));

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Se actualizo correctamente");
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
