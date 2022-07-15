using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario") 
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void btningresar_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor= Color.Gray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
            }

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Usuario";
                txtpass.ForeColor = Color.Gray;
            }
        }
    }
}
