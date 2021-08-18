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
    public partial class FrmLogin : Form
    {
       
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)      //LOGIN
        {          
            try
            {
                string nombre, clave;
                nombre = txtCodigo.Text.Trim();
                clave = txtClave.Text.Trim();
                
                    FrmMenu frm = new FrmMenu(nombre);                  
                   
                    frm.Show();
                    this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void gunaAdvenceButton2_Click(object sender, EventArgs e) //crear cuenta
        {
            FrmCrearCuenta frm = new FrmCrearCuenta();
            frm.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
