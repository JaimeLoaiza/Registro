using System;
using System.Windows.Forms;

namespace Registros
{
    public partial class Form_Inicio_Sesion : Form
    {
        public Form_Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void Btniniciosesion_Click(object sender, EventArgs e)
        {
            Form_Sesion test = new Form_Sesion();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnregistrate_Click(object sender, EventArgs e)
        {
            Form_Registros3 test = new Form_Registros3();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Inicio_Sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
