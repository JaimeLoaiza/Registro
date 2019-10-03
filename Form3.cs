using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros
{
    public partial class Form_Registros3 : Form
    {
        public Form_Registros3()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            Form_Sesion test = new Form_Sesion();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumerodocumento.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txtcontraseñaadm.Clear();
            txtcontraseñausu.Clear();
            txtnumerodocumento.Focus();
        }

        private void Rbadministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadministrador.Checked)
            {
                rbusuario.Enabled = false;
                lblcontraseñausu.Visible = false;
                txtcontraseñausu.Visible = false;
            }
        }

        private void Rbusuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbusuario.Checked)
            {
                rbadministrador.Enabled = false;
                lblcontraseñaadm.Visible = false;
                txtcontraseñaadm.Visible = false;
            }
        }

        private void Lblcontraseñaadm_Click(object sender, EventArgs e)
        {

        }
    }
}
