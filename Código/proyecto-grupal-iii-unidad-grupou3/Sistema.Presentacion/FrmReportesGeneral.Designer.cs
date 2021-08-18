namespace Sistema.Presentacion
{
    partial class FrmReportesGeneral
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
            this.btnCantidadRC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCantidadRC
            // 
            this.btnCantidadRC.Location = new System.Drawing.Point(257, 58);
            this.btnCantidadRC.Name = "btnCantidadRC";
            this.btnCantidadRC.Size = new System.Drawing.Size(243, 24);
            this.btnCantidadRC.TabIndex = 0;
            this.btnCantidadRC.Text = "CANTIDAD DE RESERVAS POR CLIENTE";
            this.btnCantidadRC.UseVisualStyleBackColor = true;
            this.btnCantidadRC.Click += new System.EventHandler(this.btnCantidadRC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "RESERVAS GENERAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "RESERVAS DE UNA EMPRESA PARAMETRO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmReportesGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCantidadRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesGeneral";
            this.Text = "FrmReportesGeneral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCantidadRC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}