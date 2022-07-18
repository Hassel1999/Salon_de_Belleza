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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
            this.Hide();
        }
        private void abrirSubForm(object miniform)
        {
            if (this.pnlProyectar.Controls.Count > 0)
                this.pnlProyectar.Controls.RemoveAt(0);
            Form subform = miniform as Form;
            subform.TopLevel = false;
            subform.Dock = DockStyle.Fill;
            this.pnlProyectar.Controls.Add(subform);
            this.pnlProyectar.Tag = subform;
            subform.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirSubForm(new frmInicial());
        }
    }
}
