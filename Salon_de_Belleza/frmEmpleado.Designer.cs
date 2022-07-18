namespace Salon_de_Belleza
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pnlProyectar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnFacturacion);
            this.pnlMenu.Controls.Add(this.btnServicios);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(324, 513);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBarra.Location = new System.Drawing.Point(0, -5);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(1149, 43);
            this.pnlBarra.TabIndex = 2;
            // 
            // pnlProyectar
            // 
            this.pnlProyectar.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.salon;
            this.pnlProyectar.Location = new System.Drawing.Point(324, 38);
            this.pnlProyectar.Name = "pnlProyectar";
            this.pnlProyectar.Size = new System.Drawing.Size(828, 512);
            this.pnlProyectar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.exit_closethesession_close_6317__1_;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 67);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.invoice_ticket_document_icon_188744;
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(16, 297);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(284, 64);
            this.btnFacturacion.TabIndex = 14;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            this.btnServicios.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.salon_mirror_makeup_cosmetics_beauty_icon_186822__1_;
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Location = new System.Drawing.Point(16, 211);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(284, 64);
            this.btnServicios.TabIndex = 13;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.catalogo_icon_209796;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(16, 126);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(284, 64);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 549);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlProyectar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnFacturacion;
        public System.Windows.Forms.Button btnServicios;
        public System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlProyectar;
        private System.Windows.Forms.Panel pnlBarra;
    }
}