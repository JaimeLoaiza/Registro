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
    public partial class Form_Areacuadrado8 : Form
    {
        public Form_Areacuadrado8()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Areacuadrado8_Load(object sender, EventArgs e)
        {
            txtresultado.Visible = false;
            txtbase.Focus();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            int Base;
            Base = Convert.ToInt32(txtbase.Text);

            int Altura;
            Altura = Convert.ToInt32(txtaltura.Text);

            double calcular;

            calcular = (Base * Altura);
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
    }
}
