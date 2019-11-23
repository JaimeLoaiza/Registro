using System;
using System.Windows.Forms;

namespace Registros
{
    public partial class Form_Usuarios6 : Form
    {
        public Form_Usuarios6()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Usuarios6_Load(object sender, EventArgs e)
        {
            lblnumerodocumento.Enabled = true;
            txtnumerodocumento.Enabled = true;
            btnbuscarusuario.Enabled = true;

            lbltipodocumento.Visible = false;
            lbltipodocumento.Enabled = false;
            cbtipodocumento.Visible = false;
            cbtipodocumento.Enabled = false;
            lblnombre.Visible = false;
            lblnombre.Enabled = false;
            txtnombre.Visible = false;
            txtnombre.Enabled = false;
            lblapellido.Visible = false;
            lblapellido.Enabled = false;
            txtapellido.Visible = false;
            txtapellido.Enabled = false;
            lbledad.Visible = false;
            lbledad.Enabled = false;
            txtedad.Visible = false;
            txtedad.Enabled = false;
            lblrol.Visible = false;
            lblrol.Enabled = false;
            rbusuario.Visible = false;
            rbusuario.Enabled = false;
            lblndocumento.Visible = false;
            lblndocumento.Enabled = false;
            txtndocumento.Visible = false;
            txtndocumento.Enabled = false;
            lblcontraseña.Visible = false;
            lblcontraseña.Enabled = false;
            txtcontraseña.Visible = false;
            txtcontraseña.Enabled = false;
            txtndocumento.Visible = false;
            txtndocumento.Enabled = false;

            btnnuevabusqueda.Visible = false;
            btnnuevabusqueda.Enabled = false;

            btnsalir.Enabled = true;
        }

        private void Btnbuscarusuario_Click(object sender, EventArgs e)
        {
            lblnumerodocumento.Visible = false;
            txtnumerodocumento.Visible = false;
            btnbuscarusuario.Visible = false;

            lbltipodocumento.Visible = true;
            lbltipodocumento.Enabled = false;
            cbtipodocumento.Visible = true;
            cbtipodocumento.Enabled = false;
            lblnombre.Visible = true;
            lblnombre.Enabled = false;
            txtnombre.Visible = true;
            txtnombre.Enabled = false;
            lblapellido.Visible = true;
            lblapellido.Enabled = false;
            txtapellido.Visible = true;
            txtapellido.Enabled = false;
            lbledad.Visible = true;
            lbledad.Enabled = false;
            txtedad.Visible = true;
            txtedad.Enabled = false;
            lblrol.Visible = true;
            lblrol.Enabled = false;
            rbusuario.Visible = true;
            rbusuario.Enabled = false;
            lblndocumento.Visible = true;
            lblndocumento.Enabled = false;
            txtndocumento.Visible = true;
            txtndocumento.Enabled = false;
            lblcontraseña.Visible = true;
            lblcontraseña.Enabled = false;
            txtcontraseña.Visible = true;
            txtcontraseña.Enabled = false;
            txtndocumento.Visible = true;
            txtndocumento.Enabled = false;

            btnnuevabusqueda.Visible = true;
            btnnuevabusqueda.Enabled = true;

            btnsalir.Enabled = true;
        }

        private void Btnnuevabusqueda_Click(object sender, EventArgs e)
        {
            lblnumerodocumento.Enabled = true;
            lblnumerodocumento.Visible = true;
            txtnumerodocumento.Enabled = true;
            txtnumerodocumento.Visible = true;
            txtnumerodocumento.Clear();
            txtnumerodocumento.Focus();
            btnbuscarusuario.Enabled = true;
            btnbuscarusuario.Visible = true;

            lbltipodocumento.Visible = false;
            lbltipodocumento.Enabled = false;
            cbtipodocumento.Visible = false;
            cbtipodocumento.Enabled = false;
            lblnombre.Visible = false;
            lblnombre.Enabled = false;
            txtnombre.Visible = false;
            txtnombre.Enabled = false;
            lblapellido.Visible = false;
            lblapellido.Enabled = false;
            txtapellido.Visible = false;
            txtapellido.Enabled = false;
            lbledad.Visible = false;
            lbledad.Enabled = false;
            txtedad.Visible = false;
            txtedad.Enabled = false;
            lblrol.Visible = false;
            lblrol.Enabled = false;
            rbusuario.Visible = false;
            rbusuario.Enabled = false;
            lblndocumento.Visible = false;
            lblndocumento.Enabled = false;
            txtndocumento.Visible = false;
            txtndocumento.Enabled = false;
            lblcontraseña.Visible = false;
            lblcontraseña.Enabled = false;
            txtcontraseña.Visible = false;
            txtcontraseña.Enabled = false;
            txtndocumento.Visible = false;
            txtndocumento.Enabled = false;

            btnnuevabusqueda.Visible = false;
            btnnuevabusqueda.Enabled = false;

            btnsalir.Enabled = true;
        }
    }
}
