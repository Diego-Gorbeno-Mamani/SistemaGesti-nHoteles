namespace Sistema.Presentacion
{
    partial class FrmVistaPrevia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaPrevia));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtBusquedaP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarP = new System.Windows.Forms.DataGridView();
            this.SeleccionarP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabHabitacion = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReservar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cmbhab = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtNumReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarP)).BeginInit();
            this.tabHabitacion.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.cmbid);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HABITACIONES";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(275, 27);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(121, 21);
            this.cmbid.TabIndex = 2;
            this.cmbid.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(27, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(624, 309);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarP);
            this.tabPage1.Controls.Add(this.txtBusquedaP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvListarP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VISTA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.Image")));
            this.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.Location = new System.Drawing.Point(446, 28);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(86, 31);
            this.btnBuscarP.TabIndex = 4;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtBusquedaP
            // 
            this.txtBusquedaP.Location = new System.Drawing.Point(126, 34);
            this.txtBusquedaP.Name = "txtBusquedaP";
            this.txtBusquedaP.Size = new System.Drawing.Size(284, 20);
            this.txtBusquedaP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar :";
            // 
            // dgvListarP
            // 
            this.dgvListarP.AllowUserToAddRows = false;
            this.dgvListarP.AllowUserToDeleteRows = false;
            this.dgvListarP.AllowUserToOrderColumns = true;
            this.dgvListarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarP});
            this.dgvListarP.Location = new System.Drawing.Point(36, 91);
            this.dgvListarP.Name = "dgvListarP";
            this.dgvListarP.ReadOnly = true;
            this.dgvListarP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarP.Size = new System.Drawing.Size(624, 309);
            this.dgvListarP.TabIndex = 0;
            this.dgvListarP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarP_CellContentClick);
            this.dgvListarP.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarP_CellContentDoubleClick);
            this.dgvListarP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarP_CellDoubleClick);
            // 
            // SeleccionarP
            // 
            this.SeleccionarP.HeaderText = "Seleccionar";
            this.SeleccionarP.Name = "SeleccionarP";
            this.SeleccionarP.ReadOnly = true;
            // 
            // tabHabitacion
            // 
            this.tabHabitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabHabitacion.Controls.Add(this.tabPage1);
            this.tabHabitacion.Controls.Add(this.tabPage2);
            this.tabHabitacion.Controls.Add(this.tabPage3);
            this.tabHabitacion.Location = new System.Drawing.Point(45, 30);
            this.tabHabitacion.Name = "tabHabitacion";
            this.tabHabitacion.SelectedIndex = 0;
            this.tabHabitacion.Size = new System.Drawing.Size(697, 466);
            this.tabHabitacion.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNumReserva);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmb);
            this.tabPage3.Controls.Add(this.btnReservar);
            this.tabPage3.Controls.Add(this.cmbhab);
            this.tabPage3.Controls.Add(this.txtTipo);
            this.tabPage3.Controls.Add(this.txtCantidad);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtTotal);
            this.tabPage3.Controls.Add(this.txtEstado);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnCalculat);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblfecha);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(689, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RESERVAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReservar.AnimationHoverSpeed = 0.07F;
            this.btnReservar.AnimationSpeed = 0.03F;
            this.btnReservar.BackColor = System.Drawing.Color.Transparent;
            this.btnReservar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnReservar.BorderColor = System.Drawing.Color.Silver;
            this.btnReservar.BorderSize = 1;
            this.btnReservar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReservar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReservar.CheckedForeColor = System.Drawing.Color.White;
            this.btnReservar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReservar.CheckedImage")));
            this.btnReservar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReservar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservar.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservar.Image = null;
            this.btnReservar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReservar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReservar.Location = new System.Drawing.Point(288, 379);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnReservar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservar.OnHoverImage = null;
            this.btnReservar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReservar.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservar.Size = new System.Drawing.Size(107, 37);
            this.btnReservar.TabIndex = 65;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // cmbhab
            // 
            this.cmbhab.FormattingEnabled = true;
            this.cmbhab.Location = new System.Drawing.Point(534, 16);
            this.cmbhab.Name = "cmbhab";
            this.cmbhab.Size = new System.Drawing.Size(121, 21);
            this.cmbhab.TabIndex = 43;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(306, 137);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(107, 20);
            this.txtTipo.TabIndex = 40;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(310, 176);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(62, 20);
            this.txtCantidad.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Estado:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(306, 313);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(84, 20);
            this.txtTotal.TabIndex = 36;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(310, 213);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(62, 20);
            this.txtEstado.TabIndex = 31;
            this.txtEstado.Text = "En espera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Costo Total :";
            // 
            // btnCalculat
            // 
            this.btnCalculat.Location = new System.Drawing.Point(310, 254);
            this.btnCalculat.Name = "btnCalculat";
            this.btnCalculat.Size = new System.Drawing.Size(85, 30);
            this.btnCalculat.TabIndex = 34;
            this.btnCalculat.Text = "CALCULAR";
            this.btnCalculat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cantidad habitacion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tipo de habitacion :";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(240, 53);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(185, 25);
            this.lblfecha.TabIndex = 27;
            this.lblfecha.Text = "Fecha Reserva :";
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Location = new System.Drawing.Point(306, 99);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(43, 20);
            this.txtNumReserva.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Numero de reserva";
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(592, 53);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(38, 21);
            this.cmb.TabIndex = 3;
            this.cmb.Visible = false;
            // 
            // FrmVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 589);
            this.Controls.Add(this.tabHabitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaPrevia";
            this.Text = "Vista Previa";
            this.Load += new System.EventHandler(this.FrmVistaPrevia_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarP)).EndInit();
            this.tabHabitacion.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox txtBusquedaP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarP;
        private System.Windows.Forms.TabControl tabHabitacion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbhab;
        private Guna.UI.WinForms.GunaAdvenceButton btnReservar;
        private System.Windows.Forms.TextBox txtNumReserva;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmb;
    }
}