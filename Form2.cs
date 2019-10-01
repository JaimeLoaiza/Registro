﻿using System;
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
    public partial class Form_Triangulo2 : Form
    {
        public Form_Triangulo2()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Triangulo2_Load(object sender, EventArgs e)
        {

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
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txtbase.Focus();
        }
    }
}
