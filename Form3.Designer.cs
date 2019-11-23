using System;

namespace Registros
{
    partial class Form_Registros3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hazturegistro = new System.Windows.Forms.Label();
            this.lbltipodocumento = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.Label();
            this.cbtipodocumento = new System.Windows.Forms.ComboBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.rbadministrador = new System.Windows.Forms.RadioButton();
            this.rbusuario = new System.Windows.Forms.RadioButton();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnguardarregistro = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.btniniciarsesion = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hazturegistro
            // 
            this.hazturegistro.AutoSize = true;
            this.hazturegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hazturegistro.Location = new System.Drawing.Point(257, 35);
            this.hazturegistro.Name = "hazturegistro";
            this.hazturegistro.Size = new System.Drawing.Size(137, 24);
            this.hazturegistro.TabIndex = 0;
            this.hazturegistro.Text = "Haz tu Registro";
            // 
            // lbltipodocumento
            // 
            this.lbltipodocumento.AutoSize = true;
            this.lbltipodocumento.Location = new System.Drawing.Point(49, 90);
            this.lbltipodocumento.Name = "lbltipodocumento";
            this.lbltipodocumento.Size = new System.Drawing.Size(101, 13);
            this.lbltipodocumento.TabIndex = 1;
            this.lbltipodocumento.Text = "Tipo de Documento";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(49, 126);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(40, 13);
            this.lblcedula.TabIndex = 2;
            this.lblcedula.Text = "Cédula";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(49, 162);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(49, 197);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 4;
            this.lblapellido.Text = "Apellido";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(49, 232);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 5;
            this.lbledad.Text = "Edad";
            // 
            // rol
            // 
            this.rol.AutoSize = true;
            this.rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.Location = new System.Drawing.Point(466, 104);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(32, 16);
            this.rol.TabIndex = 6;
            this.rol.Text = "Rol";
            // 
            // cbtipodocumento
            // 
            this.cbtipodocumento.FormattingEnabled = true;
            this.cbtipodocumento.Items.AddRange(new object[] {
            "Cédula de Ciudadanía"});
            this.cbtipodocumento.Location = new System.Drawing.Point(156, 87);
            this.cbtipodocumento.Name = "cbtipodocumento";
            this.cbtipodocumento.Size = new System.Drawing.Size(121, 21);
            this.cbtipodocumento.TabIndex = 7;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(177, 123);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(177, 159);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(177, 194);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(177, 229);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 11;
            // 
            // rbadministrador
            // 
            this.rbadministrador.AutoSize = true;
            this.rbadministrador.Location = new System.Drawing.Point(363, 141);
            this.rbadministrador.Name = "rbadministrador";
            this.rbadministrador.Size = new System.Drawing.Size(88, 17);
            this.rbadministrador.TabIndex = 12;
            this.rbadministrador.TabStop = true;
            this.rbadministrador.Text = "Administrador";
            this.rbadministrador.UseVisualStyleBackColor = true;
            this.rbadministrador.CheckedChanged += new System.EventHandler(this.Rbadministrador_CheckedChanged);
            // 
            // rbusuario
            // 
            this.rbusuario.AutoSize = true;
            this.rbusuario.Location = new System.Drawing.Point(363, 183);
            this.rbusuario.Name = "rbusuario";
            this.rbusuario.Size = new System.Drawing.Size(61, 17);
            this.rbusuario.TabIndex = 13;
            this.rbusuario.TabStop = true;
            this.rbusuario.Text = "Usuario";
            this.rbusuario.UseVisualStyleBackColor = true;
            this.rbusuario.CheckedChanged += new System.EventHandler(this.Rbusuario_CheckedChanged);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(492, 182);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 14;
            // 
            // btnguardarregistro
            // 
            this.btnguardarregistro.BackColor = System.Drawing.Color.Sienna;
            this.btnguardarregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarregistro.Location = new System.Drawing.Point(52, 286);
            this.btnguardarregistro.Name = "btnguardarregistro";
            this.btnguardarregistro.Size = new System.Drawing.Size(133, 46);
            this.btnguardarregistro.TabIndex = 16;
            this.btnguardarregistro.Text = "Guardar Registro";
            this.btnguardarregistro.UseVisualStyleBackColor = false;
            this.btnguardarregistro.Click += new System.EventHandler(this.btnguardarregistro_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Sienna;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(469, 286);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 46);
            this.btnsalir.TabIndex = 19;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(510, 143);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 20;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btniniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.Location = new System.Drawing.Point(191, 286);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(133, 46);
            this.btniniciarsesion.TabIndex = 23;
            this.btniniciarsesion.Text = "Iniciar Sesión";
            this.btniniciarsesion.UseVisualStyleBackColor = false;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Sienna;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(330, 286);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(133, 46);
            this.btnlimpiar.TabIndex = 24;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Form_Registros3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(646, 363);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardarregistro);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.rbusuario);
            this.Controls.Add(this.rbadministrador);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.cbtipodocumento);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.lbltipodocumento);
            this.Controls.Add(this.hazturegistro);
            this.Name = "Form_Registros3";
            this.Text = "Registrando";
            this.Load += new System.EventHandler(this.Form_Registros3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hazturegistro;
        private System.Windows.Forms.Label lbltipodocumento;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label rol;
        private System.Windows.Forms.ComboBox cbtipodocumento;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.RadioButton rbadministrador;
        private System.Windows.Forms.RadioButton rbusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnguardarregistro;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Button btniniciarsesion;
        private System.Windows.Forms.Button btnlimpiar;
        private readonly EventHandler lblcontraseñaadministrador_Click;
    }
}