namespace Salon_de_Belleza
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu1 = new System.Windows.Forms.Panel();
            this.barra = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconosalir = new System.Windows.Forms.PictureBox();
            this.iconominimizar = new System.Windows.Forms.PictureBox();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnclientes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnservicios = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnfactura = new System.Windows.Forms.Button();
            this.menu1.SuspendLayout();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconosalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menu1.Controls.Add(this.pictureBox5);
            this.menu1.Controls.Add(this.btnfactura);
            this.menu1.Controls.Add(this.pictureBox4);
            this.menu1.Controls.Add(this.btnservicios);
            this.menu1.Controls.Add(this.pictureBox3);
            this.menu1.Controls.Add(this.btnclientes);
            this.menu1.Controls.Add(this.pictureBox2);
            this.menu1.Controls.Add(this.btnusuarios);
            this.menu1.Controls.Add(this.pictureBox1);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(250, 650);
            this.menu1.TabIndex = 0;
            // 
            // barra
            // 
            this.barra.Controls.Add(this.iconominimizar);
            this.barra.Controls.Add(this.iconosalir);
            this.barra.Controls.Add(this.btnslide);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(250, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1050, 50);
            this.barra.TabIndex = 1;
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(250, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1050, 600);
            this.contenedor.TabIndex = 2;
            // 
            // btnslide
            // 
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(0, 0);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(50, 48);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconosalir
            // 
            this.iconosalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconosalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconosalir.Image = ((System.Drawing.Image)(resources.GetObject("iconosalir.Image")));
            this.iconosalir.Location = new System.Drawing.Point(1013, 3);
            this.iconosalir.Name = "iconosalir";
            this.iconosalir.Size = new System.Drawing.Size(34, 44);
            this.iconosalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconosalir.TabIndex = 0;
            this.iconosalir.TabStop = false;
            this.iconosalir.Click += new System.EventHandler(this.iconosalir_Click);
            // 
            // iconominimizar
            // 
            this.iconominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconominimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconominimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconominimizar.Image")));
            this.iconominimizar.Location = new System.Drawing.Point(973, 0);
            this.iconominimizar.Name = "iconominimizar";
            this.iconominimizar.Size = new System.Drawing.Size(34, 44);
            this.iconominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconominimizar.TabIndex = 2;
            this.iconominimizar.TabStop = false;
            this.iconominimizar.Click += new System.EventHandler(this.iconominimizar_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Location = new System.Drawing.Point(19, 115);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(231, 45);
            this.btnusuarios.TabIndex = 1;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = true;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(19, 203);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(231, 45);
            this.btnclientes.TabIndex = 3;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnservicios
            // 
            this.btnservicios.FlatAppearance.BorderSize = 0;
            this.btnservicios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnservicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnservicios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservicios.ForeColor = System.Drawing.Color.White;
            this.btnservicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnservicios.Location = new System.Drawing.Point(19, 290);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Size = new System.Drawing.Size(231, 45);
            this.btnservicios.TabIndex = 5;
            this.btnservicios.Text = "Servicios";
            this.btnservicios.UseVisualStyleBackColor = true;
            this.btnservicios.Click += new System.EventHandler(this.btnservicios_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 375);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // btnfactura
            // 
            this.btnfactura.FlatAppearance.BorderSize = 0;
            this.btnfactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfactura.ForeColor = System.Drawing.Color.White;
            this.btnfactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfactura.Location = new System.Drawing.Point(19, 375);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(231, 45);
            this.btnfactura.TabIndex = 7;
            this.btnfactura.Text = "Facturación";
            this.btnfactura.UseVisualStyleBackColor = true;
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.menu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu1.ResumeLayout(false);
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconosalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox iconominimizar;
        private System.Windows.Forms.PictureBox iconosalir;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnservicios;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnclientes;
    }
}

