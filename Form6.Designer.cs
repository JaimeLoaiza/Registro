namespace Registros
{
    partial class Form_Usuarios6
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
            this.lblusuariosregistrados = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblndocumento = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.rbusuario = new System.Windows.Forms.RadioButton();
            this.cbtipodocumento = new System.Windows.Forms.ComboBox();
            this.lblrol = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblnumerodocumento = new System.Windows.Forms.Label();
            this.lbltipodocumento = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtndocumento = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnbuscarusuario = new System.Windows.Forms.Button();
            this.btnnuevabusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusuariosregistrados
            // 
            this.lblusuariosregistrados.AutoSize = true;
            this.lblusuariosregistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuariosregistrados.Location = new System.Drawing.Point(255, 35);
            this.lblusuariosregistrados.Name = "lblusuariosregistrados";
            this.lblusuariosregistrados.Size = new System.Drawing.Size(182, 20);
            this.lblusuariosregistrados.TabIndex = 0;
            this.lblusuariosregistrados.Text = "Usuarios Registrados";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(209, 252);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 42;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblndocumento
            // 
            this.lblndocumento.AutoSize = true;
            this.lblndocumento.Location = new System.Drawing.Point(76, 252);
            this.lblndocumento.Name = "lblndocumento";
            this.lblndocumento.Size = new System.Drawing.Size(77, 13);
            this.lblndocumento.TabIndex = 41;
            this.lblndocumento.Text = "N° Documento";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(280, 342);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 45);
            this.btnsalir.TabIndex = 40;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // rbusuario
            // 
            this.rbusuario.AutoSize = true;
            this.rbusuario.Location = new System.Drawing.Point(148, 213);
            this.rbusuario.Name = "rbusuario";
            this.rbusuario.Size = new System.Drawing.Size(61, 17);
            this.rbusuario.TabIndex = 36;
            this.rbusuario.TabStop = true;
            this.rbusuario.Text = "Usuario";
            this.rbusuario.UseVisualStyleBackColor = true;
            // 
            // cbtipodocumento
            // 
            this.cbtipodocumento.FormattingEnabled = true;
            this.cbtipodocumento.Items.AddRange(new object[] {
            "Cédula de Ciudadanía",
            "Tarjeta de Identidad",
            "Cédula de Extranjería",
            "Pasaporte",
            "Registro Civil"});
            this.cbtipodocumento.Location = new System.Drawing.Point(498, 172);
            this.cbtipodocumento.Name = "cbtipodocumento";
            this.cbtipodocumento.Size = new System.Drawing.Size(121, 21);
            this.cbtipodocumento.TabIndex = 30;
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrol.Location = new System.Drawing.Point(166, 174);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(33, 20);
            this.lblrol.TabIndex = 29;
            this.lblrol.Text = "Rol";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(391, 281);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 28;
            this.lbledad.Text = "Edad";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(391, 246);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 27;
            this.lblapellido.Text = "Apellido";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(391, 211);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 26;
            this.lblnombre.Text = "Nombre";
            // 
            // lblnumerodocumento
            // 
            this.lblnumerodocumento.AutoSize = true;
            this.lblnumerodocumento.Location = new System.Drawing.Point(114, 85);
            this.lblnumerodocumento.Name = "lblnumerodocumento";
            this.lblnumerodocumento.Size = new System.Drawing.Size(117, 13);
            this.lblnumerodocumento.TabIndex = 25;
            this.lblnumerodocumento.Text = "Número de Documento";
            // 
            // lbltipodocumento
            // 
            this.lbltipodocumento.AutoSize = true;
            this.lbltipodocumento.Location = new System.Drawing.Point(391, 175);
            this.lbltipodocumento.Name = "lbltipodocumento";
            this.lbltipodocumento.Size = new System.Drawing.Size(101, 13);
            this.lbltipodocumento.TabIndex = 24;
            this.lbltipodocumento.Text = "Tipo de Documento";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(110, 109);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(129, 20);
            this.txtnumerodocumento.TabIndex = 43;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(519, 208);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 44;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(519, 243);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 45;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(519, 278);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 46;
            // 
            // txtndocumento
            // 
            this.txtndocumento.Location = new System.Drawing.Point(65, 278);
            this.txtndocumento.Name = "txtndocumento";
            this.txtndocumento.Size = new System.Drawing.Size(100, 20);
            this.txtndocumento.TabIndex = 47;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(190, 278);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 48;
            // 
            // btnbuscarusuario
            // 
            this.btnbuscarusuario.BackColor = System.Drawing.Color.Coral;
            this.btnbuscarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarusuario.Location = new System.Drawing.Point(280, 86);
            this.btnbuscarusuario.Name = "btnbuscarusuario";
            this.btnbuscarusuario.Size = new System.Drawing.Size(133, 45);
            this.btnbuscarusuario.TabIndex = 49;
            this.btnbuscarusuario.Text = "Buscar Usuario";
            this.btnbuscarusuario.UseVisualStyleBackColor = false;
            this.btnbuscarusuario.Click += new System.EventHandler(this.Btnbuscarusuario_Click);
            // 
            // btnnuevabusqueda
            // 
            this.btnnuevabusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnnuevabusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevabusqueda.Location = new System.Drawing.Point(433, 87);
            this.btnnuevabusqueda.Name = "btnnuevabusqueda";
            this.btnnuevabusqueda.Size = new System.Drawing.Size(133, 45);
            this.btnnuevabusqueda.TabIndex = 50;
            this.btnnuevabusqueda.Text = "Nueva Busqueda";
            this.btnnuevabusqueda.UseVisualStyleBackColor = false;
            this.btnnuevabusqueda.Click += new System.EventHandler(this.Btnnuevabusqueda_Click);
            // 
            // Form_Usuarios6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 408);
            this.Controls.Add(this.btnnuevabusqueda);
            this.Controls.Add(this.btnbuscarusuario);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtndocumento);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblndocumento);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.rbusuario);
            this.Controls.Add(this.cbtipodocumento);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblnumerodocumento);
            this.Controls.Add(this.lbltipodocumento);
            this.Controls.Add(this.lblusuariosregistrados);
            this.Name = "Form_Usuarios6";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Form_Usuarios6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuariosregistrados;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblndocumento;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.RadioButton rbusuario;
        private System.Windows.Forms.ComboBox cbtipodocumento;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblnumerodocumento;
        private System.Windows.Forms.Label lbltipodocumento;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtndocumento;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnbuscarusuario;
        private System.Windows.Forms.Button btnnuevabusqueda;
    }
}