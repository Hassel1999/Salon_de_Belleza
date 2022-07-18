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
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBarra.Location = new System.Drawing.Point(-2, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(936, 31);
            this.pnlBarra.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Salon_de_Belleza.Properties.Resources.salon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 502);
            this.panel1.TabIndex = 9;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLogin.Controls.Add(this.btnSalir);
            this.pnlLogin.Controls.Add(this.btnIngresar);
            this.pnlLogin.Controls.Add(this.txtContraseña);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(561, 31);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(372, 447);
            this.pnlLogin.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(215, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 39);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_2);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(110, 290);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 39);
            this.btnIngresar.TabIndex = 30;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_2);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(191, 209);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '°';
            this.txtContraseña.Size = new System.Drawing.Size(139, 28);
            this.txtContraseña.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(191, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '°';
            this.txtUsuario.Size = new System.Drawing.Size(139, 28);
            this.txtUsuario.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 475);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
    }
}

