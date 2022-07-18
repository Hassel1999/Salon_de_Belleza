namespace Salon_de_Belleza
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pnlProyectar = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnFacturacion);
            this.pnlMenu.Controls.Add(this.btnServicios);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(324, 623);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBarra.Location = new System.Drawing.Point(-1, -3);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(1232, 43);
            this.pnlBarra.TabIndex = 14;
            // 
            // pnlProyectar
            // 
            this.pnlProyectar.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.salon;
            this.pnlProyectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProyectar.Location = new System.Drawing.Point(324, 40);
            this.pnlProyectar.Name = "pnlProyectar";
            this.pnlProyectar.Size = new System.Drawing.Size(907, 623);
            this.pnlProyectar.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.exit_closethesession_close_6317__1_;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(10, 546);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 67);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.invoice_ticket_document_icon_188744;
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(21, 394);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(284, 64);
            this.btnFacturacion.TabIndex = 11;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            this.btnServicios.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.salon_mirror_makeup_cosmetics_beauty_icon_186822__1_;
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Location = new System.Drawing.Point(21, 308);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(284, 64);
            this.btnServicios.TabIndex = 10;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.catalogo_icon_209796;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(21, 223);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(284, 64);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.users_theuser_6177;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(21, 135);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(284, 64);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 660);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlProyectar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnFacturacion;
        public System.Windows.Forms.Button btnServicios;
        public System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlProyectar;
        private System.Windows.Forms.Panel pnlBarra;
    }
}