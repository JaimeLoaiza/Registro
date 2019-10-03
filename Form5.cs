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
    public partial class Form_Usuario5 : Form
    {
        public Form_Usuario5()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnalturatriangulo_Click(object sender, EventArgs e)
        {
            Form_AreaTriangulo9 test = new Form_AreaTriangulo9();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Btnareacuadrado_Click(object sender, EventArgs e)
        {
            Form_ÁreaCuadrado10 test = new Form_ÁreaCuadrado10();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
