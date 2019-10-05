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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltipodocumento = new System.Windows.Forms.Label();
            this.lblnumerodocumento = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtipodocumento = new System.Windows.Forms.ComboBox();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.rbadministrador = new System.Windows.Forms.RadioButton();
            this.rbusuario = new System.Windows.Forms.RadioButton();
            this.txtcontraseñaadm = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcontraseñausu = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblcontraseñaadm = new System.Windows.Forms.Label();
            this.lblcontraseñausu = new System.Windows.Forms.Label();
            this.btniniciarsesion = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haz tu Registro";
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
            // lblnumerodocumento
            // 
            this.lblnumerodocumento.AutoSize = true;
            this.lblnumerodocumento.Location = new System.Drawing.Point(49, 126);
            this.lblnumerodocumento.Name = "lblnumerodocumento";
            this.lblnumerodocumento.Size = new System.Drawing.Size(117, 13);
            this.lblnumerodocumento.TabIndex = 2;
            this.lblnumerodocumento.Text = "Número de Documento";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rol";
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
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(177, 123);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(100, 20);
            this.txtnumerodocumento.TabIndex = 8;
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
            this.rbadministrador.Location = new System.Drawing.Point(352, 124);
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
            this.rbusuario.Location = new System.Drawing.Point(522, 122);
            this.rbusuario.Name = "rbusuario";
            this.rbusuario.Size = new System.Drawing.Size(61, 17);
            this.rbusuario.TabIndex = 13;
            this.rbusuario.TabStop = true;
            this.rbusuario.Text = "Usuario";
            this.rbusuario.UseVisualStyleBackColor = true;
            this.rbusuario.CheckedChanged += new System.EventHandler(this.Rbusuario_CheckedChanged);
            // 
            // txtcontraseñaadm
            // 
            this.txtcontraseñaadm.Location = new System.Drawing.Point(352, 190);
            this.txtcontraseñaadm.Name = "txtcontraseñaadm";
            this.txtcontraseñaadm.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseñaadm.TabIndex = 14;
            this.txtcontraseñaadm.UseSystemPasswordChar = true;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Sienna;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(52, 286);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 38);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // txtcontraseñausu
            // 
            this.txtcontraseñausu.Location = new System.Drawing.Point(501, 190);
            this.txtcontraseñausu.MaxLength = 6;
            this.txtcontraseñausu.Name = "txtcontraseñausu";
            this.txtcontraseñausu.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseñausu.TabIndex = 17;
            this.txtcontraseñausu.UseSystemPasswordChar = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Sienna;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(469, 286);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 38);
            this.btnsalir.TabIndex = 19;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblcontraseñaadm
            // 
            this.lblcontraseñaadm.AutoSize = true;
            this.lblcontraseñaadm.Location = new System.Drawing.Point(369, 166);
            this.lblcontraseñaadm.Name = "lblcontraseñaadm";
            this.lblcontraseñaadm.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseñaadm.TabIndex = 20;
            this.lblcontraseñaadm.Text = "Contraseña";
            this.lblcontraseñaadm.Click += new System.EventHandler(this.Lblcontraseñaadm_Click);
            // 
            // lblcontraseñausu
            // 
            this.lblcontraseñausu.AutoSize = true;
            this.lblcontraseñausu.Location = new System.Drawing.Point(522, 166);
            this.lblcontraseñausu.Name = "lblcontraseñausu";
            this.lblcontraseñausu.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseñausu.TabIndex = 22;
            this.lblcontraseñausu.Text = "Contraseña";
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btniniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.Location = new System.Drawing.Point(191, 286);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(133, 38);
            this.btniniciarsesion.TabIndex = 23;
            this.btniniciarsesion.Text = "Iniciar Sesión";
            this.btniniciarsesion.UseVisualStyleBackColor = false;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(330, 286);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(133, 38);
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
            this.ClientSize = new System.Drawing.Size(646, 343);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.lblcontraseñausu);
            this.Controls.Add(this.lblcontraseñaadm);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtcontraseñausu);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcontraseñaadm);
            this.Controls.Add(this.rbusuario);
            this.Controls.Add(this.rbadministrador);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.cbtipodocumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblnumerodocumento);
            this.Controls.Add(this.lbltipodocumento);
            this.Controls.Add(this.label1);
            this.Name = "Form_Registros3";
            this.Text = "Tipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltipodocumento;
        private System.Windows.Forms.Label lblnumerodocumento;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbtipodocumento;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.RadioButton rbadministrador;
        private System.Windows.Forms.RadioButton rbusuario;
        private System.Windows.Forms.TextBox txtcontraseñaadm;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcontraseñausu;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblcontraseñaadm;
        private System.Windows.Forms.Label lblcontraseñausu;
        private System.Windows.Forms.Button btniniciarsesion;
        private System.Windows.Forms.Button btnlimpiar;
    }
}