using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Sistema.Presentacion
{
    public partial class FrmMenu : Form
    {
        //atributos usuario
        public int idUsuario;
        public static string nombre;
        public string apellido;
        public string nombreTipo;
        
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FrmMenu(string n)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            nombre = n;
            //Quitar titulo del formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors   //estructura de colores
        {
            public static Color color1 = Color.FromArgb(255, 245, 157);
            public static Color color2 = Color.FromArgb(197, 225, 165);
            public static Color color3 = Color.FromArgb(129, 212, 250);
            public static Color color4 = Color.FromArgb(229, 115, 115);
            public static Color color5 = Color.FromArgb(176, 190, 197);
            public static Color color6 = Color.FromArgb(237, 187, 153);

        }
        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn !=null)
            {
                DisableButton();
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(36, 113, 163);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icono igual al inicio
                iconoactual.IconChar = currentBtn.IconChar;
                iconoactual.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if(currentBtn !=null)
            {
                currentBtn.BackColor = Color.FromArgb(21, 67, 96);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormularioHijo(Form ChildForm)
        {
            if(currentChildForm !=null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(ChildForm);
            panelEscritorio.BringToFront();
            
            ChildForm.Show();
            tituloformulario.Text = ChildForm.Text;
           
        }
       
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RGBColors.color1); //cambiar color botones
            AbrirFormularioHijo(new FrmAgregarHotel(nombre));
            

        }   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
            AbrirFormularioHijo(new FrmInicio());

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconoactual.IconChar = IconChar.Home;
            iconoactual.IconColor = Color.Aquamarine;
            tituloformulario.Text = "INICIO";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e) //panel superior
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2); //cambiar color botones
            AbrirFormularioHijo(new FrmListarHotel(nombre));
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3); //cambiar color botones
            AbrirFormularioHijo(new FrmVistaPrevia(nombre));
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4); //cambiar color botones
            AbrirFormularioHijo(new FrmEstadoCuenta(nombre));
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5); //cambiar color botones
            AbrirFormularioHijo(new FrmVerClientes(nombre));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6); //cambiar color botones
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }    
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 180)
            {
                this.tmContraerMenu.Start();
                
            }
            else if (panelMenu.Width == 60)
            {
                this.tmExpandirMenu.Start();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 180)
            {
                this.tmExpandirMenu.Stop();
                
            }
                
            else
            {
                panelMenu.Width = panelMenu.Width + 30;
                pictureBox1.Width = pictureBox1.Width + 30;
            }
                

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 60)
            {
                this.tmContraerMenu.Stop();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
               
            else
            {
                panelMenu.Width = panelMenu.Width - 30;
                pictureBox1.Width = pictureBox1.Width - 30;
            }
                
        }
        
        private void FrmMenu_Load(object sender, EventArgs e)
        {

            


            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
            AbrirFormularioHijo(new FrmInicio());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5); //cambiar color botones
            AbrirFormularioHijo(new FrmReportesGeneral());
        }
    }
}
