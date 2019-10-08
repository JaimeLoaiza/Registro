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
    public partial class Form_Sesion : Form
    {
        int a = 0;
        public Form_Sesion()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btnaccederusuario_Click(object sender, EventArgs e)
        {
            if (txtcontraseñausuario.Text == "9876")
            {
                MessageBox.Show("Contraseña Correcta", "Aviso");
                Form_Usuario5 test = new Form_Usuario5();
                test.ShowDialog();
                if (test.DialogResult == DialogResult.Yes)
                {

                }
                this.Hide();
            }
            else
            {
                a = a + 1;
                if (a == 4)
                {
                    MessageBox.Show("Contraseña Incorrecta", "Aviso");
                    this.Close();
                }
            }
        }

        private void Form_Sesion_Load(object sender, EventArgs e)
        {
            rbadministrador.Enabled = true;
            rbusuario.Enabled = true;

            gbadministrador.Visible = false;
            gbusuario.Visible = false;

            btnsalir.Enabled = true;
        }

        private void Btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rbadministrador_CheckedChanged(object sender, EventArgs e)
        {
            rbusuario.Enabled = false;
            gbadministrador.Visible = true;
            gbadministrador.Enabled = true;
            gbusuario.Visible = false;
        }

        private void Rbusuario_CheckedChanged(object sender, EventArgs e)
        {
            rbadministrador.Enabled = false;
            gbadministrador.Visible = false;
            gbusuario.Enabled = true;
            gbusuario.Visible = true;
        }

        private void Btnaccederadm_Click(object sender, EventArgs e)
        {
            if (txtcontraseñaadministrador.Text == "12345")
            {
                MessageBox.Show("Contraseña Correcta", "Aviso");
                Form_Administrador4 test = new Form_Administrador4();
                test.ShowDialog();
                if (test.DialogResult == DialogResult.Yes)
                {

                }
                this.Hide();
            }
            else
            {
                a = a + 1;
                if (a == 4)
                {
                    MessageBox.Show("Contraseña Incorrecta", "Aviso");
                    this.Close();
                }
            }
        }

        private void Btnlimpiaradministrador_Click(object sender, EventArgs e)
        {
            txtcedulaadministrador.Clear();
            txtcontraseñaadministrador.Clear();
            txtcedulaadministrador.Focus();
        }

        private void Btnlimpiarusuario_Click(object sender, EventArgs e)
        {
            txtcedulausuario.Clear();
            txtcontraseñausuario.Clear();
            txtcedulausuario.Focus();
        }
    }
}
