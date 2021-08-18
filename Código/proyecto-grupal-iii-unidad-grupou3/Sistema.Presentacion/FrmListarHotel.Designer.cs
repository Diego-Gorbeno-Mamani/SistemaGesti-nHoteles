namespace Sistema.Presentacion
{
    partial class FrmListarHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarHotel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtBusquedaP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarP = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbauxiliar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdHotel = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtPais = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCiudad = new Guna.UI.WinForms.GunaTextBox();
            this.btnActualizar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorario = new Guna.UI.WinForms.GunaTextBox();
            this.txtDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreHotel = new Guna.UI.WinForms.GunaTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarP)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(51, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 493);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(651, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoteles";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.Image")));
            this.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.Location = new System.Drawing.Point(423, 26);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(86, 31);
            this.btnBuscarP.TabIndex = 11;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtBusquedaP
            // 
            this.txtBusquedaP.Location = new System.Drawing.Point(103, 32);
            this.txtBusquedaP.Name = "txtBusquedaP";
            this.txtBusquedaP.Size = new System.Drawing.Size(284, 20);
            this.txtBusquedaP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar :";
            // 
            // dgvListarP
            // 
            this.dgvListarP.AllowUserToAddRows = false;
            this.dgvListarP.AllowUserToDeleteRows = false;
            this.dgvListarP.AllowUserToOrderColumns = true;
            this.dgvListarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarP.Location = new System.Drawing.Point(33, 81);
            this.dgvListarP.Name = "dgvListarP";
            this.dgvListarP.ReadOnly = true;
            this.dgvListarP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarP.Size = new System.Drawing.Size(586, 346);
            this.dgvListarP.TabIndex = 7;
            this.dgvListarP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarP_CellContentClick);
            this.dgvListarP.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarP_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtIdHotel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmbCategoria);
            this.tabPage2.Controls.Add(this.rtbDescripcion);
            this.tabPage2.Controls.Add(this.txtPais);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TxtCiudad);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.ptbImagen);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtHorario);
            this.tabPage2.Controls.Add(this.txtDireccion);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtNombreHotel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbauxiliar
            // 
            this.cmbauxiliar.Enabled = false;
            this.cmbauxiliar.FormattingEnabled = true;
            this.cmbauxiliar.Location = new System.Drawing.Point(565, 12);
            this.cmbauxiliar.Name = "cmbauxiliar";
            this.cmbauxiliar.Size = new System.Drawing.Size(121, 21);
            this.cmbauxiliar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Id Hotel";
            // 
            // txtIdHotel
            // 
            this.txtIdHotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdHotel.BaseColor = System.Drawing.Color.White;
            this.txtIdHotel.BorderColor = System.Drawing.Color.Silver;
            this.txtIdHotel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdHotel.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdHotel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdHotel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdHotel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtIdHotel.Location = new System.Drawing.Point(190, 45);
            this.txtIdHotel.Name = "txtIdHotel";
            this.txtIdHotel.PasswordChar = '\0';
            this.txtIdHotel.SelectedText = "";
            this.txtIdHotel.Size = new System.Drawing.Size(160, 30);
            this.txtIdHotel.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(190, 240);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(160, 21);
            this.cmbCategoria.TabIndex = 88;
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(190, 322);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(160, 96);
            this.rtbDescripcion.TabIndex = 87;
            this.rtbDescripcion.Text = "";
            // 
            // txtPais
            // 
            this.txtPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPais.BaseColor = System.Drawing.Color.White;
            this.txtPais.BorderColor = System.Drawing.Color.Silver;
            this.txtPais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPais.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPais.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPais.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtPais.Location = new System.Drawing.Point(190, 193);
            this.txtPais.Name = "txtPais";
            this.txtPais.PasswordChar = '\0';
            this.txtPais.SelectedText = "";
            this.txtPais.Size = new System.Drawing.Size(160, 30);
            this.txtPais.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Pais";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Ciudad";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCiudad.BaseColor = System.Drawing.Color.White;
            this.TxtCiudad.BorderColor = System.Drawing.Color.Silver;
            this.TxtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCiudad.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtCiudad.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtCiudad.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCiudad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtCiudad.Location = new System.Drawing.Point(190, 157);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.PasswordChar = '\0';
            this.TxtCiudad.SelectedText = "";
            this.TxtCiudad.Size = new System.Drawing.Size(160, 30);
            this.TxtCiudad.TabIndex = 83;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar.AnimationHoverSpeed = 0.07F;
            this.btnActualizar.AnimationSpeed = 0.03F;
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnActualizar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnActualizar.CheckedForeColor = System.Drawing.Color.White;
            this.btnActualizar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.CheckedImage")));
            this.btnActualizar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnActualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnActualizar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Image = null;
            this.btnActualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnActualizar.Location = new System.Drawing.Point(436, 283);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnActualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActualizar.OnHoverImage = null;
            this.btnActualizar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnActualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnActualizar.Size = new System.Drawing.Size(112, 37);
            this.btnActualizar.TabIndex = 82;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagen.Location = new System.Drawing.Point(377, 45);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(222, 216);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 81;
            this.ptbImagen.TabStop = false;
            this.ptbImagen.Click += new System.EventHandler(this.ptbImagen_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Descripcion";
            // 
            // txtHorario
            // 
            this.txtHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorario.BaseColor = System.Drawing.Color.White;
            this.txtHorario.BorderColor = System.Drawing.Color.Silver;
            this.txtHorario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHorario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHorario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHorario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtHorario.Location = new System.Drawing.Point(190, 274);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.PasswordChar = '\0';
            this.txtHorario.SelectedText = "";
            this.txtHorario.Size = new System.Drawing.Size(160, 30);
            this.txtHorario.TabIndex = 79;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BaseColor = System.Drawing.Color.White;
            this.txtDireccion.BorderColor = System.Drawing.Color.Silver;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.Location = new System.Drawing.Point(190, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(160, 30);
            this.txtDireccion.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Horario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Nombre de Hotel";
            // 
            // txtNombreHotel
            // 
            this.txtNombreHotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreHotel.BaseColor = System.Drawing.Color.White;
            this.txtNombreHotel.BorderColor = System.Drawing.Color.Silver;
            this.txtNombreHotel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreHotel.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreHotel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombreHotel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreHotel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtNombreHotel.Location = new System.Drawing.Point(190, 81);
            this.txtNombreHotel.Name = "txtNombreHotel";
            this.txtNombreHotel.PasswordChar = '\0';
            this.txtNombreHotel.SelectedText = "";
            this.txtNombreHotel.Size = new System.Drawing.Size(160, 30);
            this.txtNombreHotel.TabIndex = 74;
            // 
            // FrmListarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 589);
            this.Controls.Add(this.cmbauxiliar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarHotel";
            this.Text = "Listar Hotel";
            this.Load += new System.EventHandler(this.FrmListarHotel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox txtBusquedaP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbauxiliar;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtIdHotel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private Guna.UI.WinForms.GunaTextBox txtPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox TxtCiudad;
        private Guna.UI.WinForms.GunaAdvenceButton btnActualizar;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtHorario;
        private Guna.UI.WinForms.GunaTextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtNombreHotel;
    }
}