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
    public partial class FrmVistaPrevia : Form
    {
        public FrmVistaPrevia(string nombre)
        {
            InitializeComponent();
            cmbhab.DataSource = ClsNegocioUsuario.DatosLogueado(nombre);
            cmbhab.DisplayMember = "id_Usuario";
            //contado = Convert.ToInt32(dgvListarP.Rows.Count);
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                string Buscar;
                Buscar = txtBusquedaP.Text;
                dgvListarP.DataSource = ClsNegocioHotel.Buscar(Buscar);
                this.TitulosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //metodo titulosgrilla
        private void TitulosGrilla()
        {
            
            dgvListarP.Columns[0].Visible = false; //columna seleccionar
            dgvListarP.Columns[1].Width = 50;
            dgvListarP.Columns[2].Width = 70;
            dgvListarP.Columns[3].Width = 80;
            dgvListarP.Columns[4].Width = 100;
            dgvListarP.Columns[5].Width = 60;
            dgvListarP.Columns[6].Width = 140;
            dgvListarP.Columns[7].Width = 90;
            dgvListarP.Columns[8].Width = 150;
            dgvListarP.Columns[9].Width = 80;



            dgvListarP.Columns[1].HeaderText = "Id";
            dgvListarP.Columns[2].HeaderText = "Nombre";
            dgvListarP.Columns[3].HeaderText = "direccion";
            dgvListarP.Columns[4].HeaderText = "Ciudad";
            dgvListarP.Columns[5].HeaderText = "Pais";
            dgvListarP.Columns[6].HeaderText = "Categoria";
            dgvListarP.Columns[7].HeaderText = "Imagen";
            dgvListarP.Columns[8].HeaderText = "Horario";
            dgvListarP.Columns[9].HeaderText = "Descripcion";
        }
        private void TitulosGrilla2()
        {

            dgvListarP.Columns[0].Visible = false; //columna seleccionar
            dgvListarP.Columns[1].Width = 50;
            dgvListarP.Columns[2].Width = 70;
            dgvListarP.Columns[3].Width = 80;
            dgvListarP.Columns[4].Width = 100;
            dgvListarP.Columns[5].Width = 60;
            dgvListarP.Columns[6].Width = 140;
            dgvListarP.Columns[7].Width = 90;
            dgvListarP.Columns[8].Width = 150;
            dgvListarP.Columns[9].Width = 80;



            dgvListarP.Columns[1].HeaderText = "Id";
            dgvListarP.Columns[2].HeaderText = "Nombre";
            dgvListarP.Columns[3].HeaderText = "direccion";
            dgvListarP.Columns[4].HeaderText = "Ciudad";
            dgvListarP.Columns[5].HeaderText = "Pais";
            dgvListarP.Columns[6].HeaderText = "Categoria";
            dgvListarP.Columns[7].HeaderText = "Imagen";
            dgvListarP.Columns[8].HeaderText = "Horario";
            dgvListarP.Columns[9].HeaderText = "Descripcion";
        }

        private void FrmVistaPrevia_Load(object sender, EventArgs e)
        {
            dgvListarP.DataSource = ClsNegocioHotel.Listar();
            this.TitulosGrilla();
            lblfecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void dgvListarP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListarP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabHabitacion.SelectedIndex = 1;   //tab de Gestionar
            cmbid.Text = Convert.ToString(dgvListarP.CurrentRow.Cells[1].Value);
            
            dataGridView2.DataSource = ClsNegocioHabitacion.ListarHabitacion(Convert.ToInt32(cmbid.Text.Trim()));
            //this.TitulosGrilla2();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListarP_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabHabitacion.SelectedIndex = 2;   //tab de Gestionar
            //lblfecha.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ssss");
            cmb.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            ClsNegocioReserva objhab = new ClsNegocioReserva();
            try
            {
                string rpta = "";
                rpta = ClsNegocioReserva.InsertarReserva(Convert.ToInt32(txtNumReserva.Text),Convert.ToInt32(cmbhab.Text), Convert.ToString(txtEstado.Text), Convert.ToDateTime(lblfecha.Text));
                if (rpta.Equals("OK"))
                {
                    //MessageBox.Show("Datos Registrado");
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



            ClsNegocioReserva obj = new ClsNegocioReserva();
            try
            {
                string rpta = "";
                rpta = ClsNegocioReserva.InsertarDetalleReserva(Convert.ToInt32(cmb.Text), Convert.ToInt32(txtNumReserva.Text));
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
    }
}
