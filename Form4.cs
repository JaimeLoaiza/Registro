using System;
using System.Windows.Forms;

namespace Registros
{
    public partial class Form_Administrador4 : Form
    {
        public Form_Administrador4()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnusuarios_Click(object sender, EventArgs e)
        {
            Form_Usuarios6 test = new Form_Usuarios6();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnareacuadrado_Click(object sender, EventArgs e)
        {
            Form_Areacuadrado8 test = new Form_Areacuadrado8();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnfamilia_Click(object sender, EventArgs e)
        {
            Form_Familia7 test = new Form_Familia7();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnalturatriangulo_Click(object sender, EventArgs e)
        {
            Form_Triangulo2 test = new Form_Triangulo2();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnbuscador_Click(object sender, EventArgs e)
        {
            Form_Buscador9 test = new Form_Buscador9();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void btnmatriz_Click(object sender, EventArgs e)
        {
            Matriz_Administrador test = new Matriz_Administrador();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
