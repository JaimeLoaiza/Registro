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
    public partial class Form_AreaTriangulo9 : Form
    {
        public Form_AreaTriangulo9()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            int Base;
            Base = Convert.ToInt32(txtbase.Text);

            int Altura;
            Altura = Convert.ToInt32(txtaltura.Text);

            double calcular;

            calcular = (Base * Altura) / 2;
            txtresultado.Text = Convert.ToString(calcular);

            txtbase.Clear();
            txtaltura.Clear();
            txtresultado.Visible = true;
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txtbase.Focus();
            txtresultado.Visible = false;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AreaTriangulo9_Load(object sender, EventArgs e)
        {
            txtresultado.Visible = false;
            txtbase.Focus();
        }
    }
}
