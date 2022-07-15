using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_de_Belleza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (menu1.Width == 250)
            {
                menu1.Width = 85;
            }
            else
                menu1.Width = 250;
        }

        private void iconosalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();

        }

        private void btnservicios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Servicios());
        }

        
        private void btnfactura_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Facturacion());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }
    }
}
