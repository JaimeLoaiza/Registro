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
    }
}
