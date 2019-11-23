using System;
using System.Windows.Forms;
using System.Data.OleDb;

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

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txtcontraseña.Clear();
            txtcedula.Focus();

            rbadministrador.Enabled = true;
            rbusuario.Enabled = true;
        }

        private void Rbadministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadministrador.Checked)
            {
                rbusuario.Enabled = false;
                lblcontraseña.Visible = true;
                txtcontraseña.Visible = true;
            }
        }

        private void Rbusuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbusuario.Checked)
            {
                rbadministrador.Enabled = false;
                lblcontraseña.Visible = true;
                txtcontraseña.Visible = true;
            }
        }

        private void Form_Registros3_Load(object sender, EventArgs e)
        {

        }

        private void btnguardarregistro_Click(object sender, EventArgs e)
        {
            string Cedula = null;
            OleDbConnection connection;
            Cedula = "Provider=SQLNCLI11;Integrated Security=SSPI";
            connection = new OleDbConnection(Cedula);

            try
            {
                connection.Open();
                MessageBox.Show(" Connection Open !");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Can not Open Connection !");
            }

            if (txtcontraseña.Text == txtcontraseña.Text)
            {
                MessageBox.Show("Su Registro Ha sido Creado Exitosamente !");
            }
            else
                MessageBox.Show("No se Creo el Registro !");
        }
    }
}
