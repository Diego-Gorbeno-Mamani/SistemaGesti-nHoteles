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
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
            //cmbUsuario.Items.Add("Cliente");
            //cmbUsuario.Items.Add("Empresa");

            //cmbDocumento.Items.Add("Dni");
            //cmbDocumento.Items.Add("CI");
            //cmbDocumento.Items.Add("Pasaporte");
            llenarCombo();
            llearTipoDocumento();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
        decimal numeros;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            int auxusu = 0;
            int auxdoc = 0;
            try
            {
                string rpta = "";
                if (cmbUsuario.Text == string.Empty)
                {
                    MessageBox.Show("faltan datos");
                }
                else
                {
                    //if(cmbUsuario.Text=="Cliente")
                    //{
                    //    auxusu=1;
                    //}
                    //if (cmbUsuario.Text == "Empresa")
                    //{
                    //    auxusu = 2;
                    //}
                    //if(cmbDocumento.Text=="Dni")
                    //{
                    //    auxdoc = 1;
                    //}
                    //if (cmbDocumento.Text == "CI")
                    //{
                    //    auxdoc = 2;
                    //}
                    //if (cmbDocumento.Text == "Pasaporte")
                    //{
                    //    auxdoc = 3;
                    //}
                    if (txtID.Text == "")
                    {
                        errorProvider1.SetError(txtID, "Debe llenar el campo");
                        //  txtID.Focus;
                        return;
                    }
                    errorProvider1.SetError(txtID, "");

                    if (txtApellido.Text == "")
                    {
                        errorProvider1.SetError(txtApellido, "Debe llenar el campo");
                        //  txtID.Focus;
                        return;
                    }
                    errorProvider1.SetError(txtApellido, "");

                    if (txtTelefono.Text == "")
                    {
                        errorProvider1.SetError(txtTelefono, "Debe llenar el campo");
                        //  txtID.Focus;
                        return;
                    }
                    errorProvider1.SetError(txtTelefono, "");

                    if (txtDireccion.Text == "")
                    {
                        errorProvider1.SetError(txtDireccion, "Debe llenar el campo");
                        //  txtID.Focus;
                        return;
                    }
                    errorProvider1.SetError(txtDireccion, "");

                    if (txtClave.Text == "")
                    {
                        errorProvider1.SetError(txtClave, "Debe llenar el campo");
                        //  txtID.Focus;
                        return;
                    }
                    errorProvider1.SetError(txtClave, "");

                    if (txtNDocumento.Text == "")
                    {
                        errorProvider1.SetError(txtNDocumento, "Debe llenar el campo");
                        //  txtID.Focus;
                        return;
                    }
                    errorProvider1.SetError(txtNDocumento, "");

                    if (txtClave.Text.Length < 5)
                    {
                        errorProvider1.SetError(txtClave, "clave de 6 digitos");
                        return;
                    }
                    errorProvider1.SetError(txtClave, "");

                    //solo numeros 

                    if (!decimal.TryParse(txtNDocumento.Text, out numeros))
                    {
                        errorProvider1.SetError(txtNDocumento, "solo numeros");
                        txtNDocumento.Focus();
                        return;
                    }

                    if (!decimal.TryParse(txtTelefono.Text, out numeros))
                    {
                        errorProvider1.SetError(txtTelefono, "solo numeros");
                        txtTelefono.Focus();
                        return;
                    }

                    int idtipusu = (int)cmbUsuario.SelectedValue;
                    int idtipodoc = (int)cmbDocumento.SelectedValue;
                    rpta = ClsNegocioUsuario.InsertarUsuario(idtipusu, idtipodoc, txtID.Text.Trim(), txtApellido.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim(), txtClave.Text.Trim(), txtNDocumento.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Usuario Registrado");
                        FrmLogin frm = new FrmLogin();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                        FrmLogin frm = new FrmLogin();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtNDocumento.Enabled = true;
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                txtID.Clear();
                errorProvider1.SetError(txtID, "Solo letras  ");
                txtID.Clear();

                return;

            }
            errorProvider1.SetError(txtID, "");
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo letras");
                txtApellido.Clear();

                return;

            }
            errorProvider1.SetError(txtApellido, "");
        }

        //Limpiar textbox
        private void limpiar()
        {
            txtID.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtClave.Clear();
            txtNDocumento.Clear();
        }

        //Metodo llenar combo tipo usuario
        private void llenarCombo()
        {
            // throw new NotImplementedException();
            cmbUsuario.DataSource = ClsNegTipoUsuario.ListaTipo();
            cmbUsuario.DisplayMember = "nombre_tipo_usuario";
            cmbUsuario.ValueMember = "id_tipo_usuario";
            cmbUsuario.Items.Remove("Administrador");

        }
        //Metodo llenar combo documento
        private void llearTipoDocumento()
        {
            cmbDocumento.DataSource = ClsNegTipoDocumento.ListaTipoDocumento();
            cmbDocumento.DisplayMember = "nombre_tipo_documento";
            cmbDocumento.ValueMember = "id_tipo_documento";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
