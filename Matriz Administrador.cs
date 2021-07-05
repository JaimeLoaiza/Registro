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
    public partial class Matriz_Administrador : Form
    {
        public Matriz_Administrador()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            int tabla = int.Parse(txttabladel.Text);
            int hasta = int.Parse(txthastadel.Text);
            int resultado;

            for (int i = 0; i <= hasta; i++)
            {
                resultado = tabla * i;
                MULTIPLICACIÓN.Items.Add(tabla + "x" + i + "=" + resultado);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txthastadel.Clear();
            txttabladel.Clear();

            txttabladel.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
