namespace Servicios
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Black;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtuser.Location = new System.Drawing.Point(117, 254);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(187, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "Usuario";
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            // 
            // btningresar
            // 
            this.btningresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btningresar.Location = new System.Drawing.Point(160, 349);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(104, 27);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Leave += new System.EventHandler(this.btningresar_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Black;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtpass.Location = new System.Drawing.Point(117, 290);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(187, 20);
            this.txtpass.TabIndex = 8;
            this.txtpass.Text = "Contraseña";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(437, 532);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtuser);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpass;
    }
}

