namespace Registros
{
    partial class Form_Sesion
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
            this.lblcedulausuario = new System.Windows.Forms.Label();
            this.lblcontraseñausuario = new System.Windows.Forms.Label();
            this.txtcedulausuario = new System.Windows.Forms.TextBox();
            this.txtcontraseñausuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaccederusuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbadministrador = new System.Windows.Forms.GroupBox();
            this.btnaccederadministrador = new System.Windows.Forms.Button();
            this.txtcontraseñaadministrador = new System.Windows.Forms.TextBox();
            this.btnlimpiaradministrador = new System.Windows.Forms.Button();
            this.txtcedulaadministrador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcedulaadministrador = new System.Windows.Forms.Label();
            this.lblcontraseñaadministrador = new System.Windows.Forms.Label();
            this.gbusuario = new System.Windows.Forms.GroupBox();
            this.btnlimpiarusuario = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.rbadministrador = new System.Windows.Forms.RadioButton();
            this.rbusuario = new System.Windows.Forms.RadioButton();
            this.gbadministrador.SuspendLayout();
            this.gbusuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcedulausuario
            // 
            this.lblcedulausuario.AutoSize = true;
            this.lblcedulausuario.Location = new System.Drawing.Point(17, 84);
            this.lblcedulausuario.Name = "lblcedulausuario";
            this.lblcedulausuario.Size = new System.Drawing.Size(46, 13);
            this.lblcedulausuario.TabIndex = 0;
            this.lblcedulausuario.Text = "Cédula";
            this.lblcedulausuario.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblcontraseñausuario
            // 
            this.lblcontraseñausuario.AutoSize = true;
            this.lblcontraseñausuario.Location = new System.Drawing.Point(17, 120);
            this.lblcontraseñausuario.Name = "lblcontraseñausuario";
            this.lblcontraseñausuario.Size = new System.Drawing.Size(71, 13);
            this.lblcontraseñausuario.TabIndex = 1;
            this.lblcontraseñausuario.Text = "Contraseña";
            // 
            // txtcedulausuario
            // 
            this.txtcedulausuario.Location = new System.Drawing.Point(93, 81);
            this.txtcedulausuario.Name = "txtcedulausuario";
            this.txtcedulausuario.Size = new System.Drawing.Size(100, 20);
            this.txtcedulausuario.TabIndex = 2;
            // 
            // txtcontraseñausuario
            // 
            this.txtcontraseñausuario.Location = new System.Drawing.Point(93, 117);
            this.txtcontraseñausuario.MaxLength = 6;
            this.txtcontraseñausuario.Name = "txtcontraseñausuario";
            this.txtcontraseñausuario.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseñausuario.TabIndex = 3;
            this.txtcontraseñausuario.UseSystemPasswordChar = true;
            this.txtcontraseñausuario.TextChanged += new System.EventHandler(this.Txtcontraseña_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese";
            // 
            // btnaccederusuario
            // 
            this.btnaccederusuario.BackColor = System.Drawing.Color.BlueViolet;
            this.btnaccederusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaccederusuario.Location = new System.Drawing.Point(93, 170);
            this.btnaccederusuario.Name = "btnaccederusuario";
            this.btnaccederusuario.Size = new System.Drawing.Size(100, 31);
            this.btnaccederusuario.TabIndex = 5;
            this.btnaccederusuario.Text = "Acceder";
            this.btnaccederusuario.UseVisualStyleBackColor = false;
            this.btnaccederusuario.Click += new System.EventHandler(this.Btnaccederusuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione su Rol";
            // 
            // gbadministrador
            // 
            this.gbadministrador.Controls.Add(this.btnaccederadministrador);
            this.gbadministrador.Controls.Add(this.txtcontraseñaadministrador);
            this.gbadministrador.Controls.Add(this.btnlimpiaradministrador);
            this.gbadministrador.Controls.Add(this.txtcedulaadministrador);
            this.gbadministrador.Controls.Add(this.label5);
            this.gbadministrador.Controls.Add(this.lblcedulaadministrador);
            this.gbadministrador.Controls.Add(this.lblcontraseñaadministrador);
            this.gbadministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbadministrador.Location = new System.Drawing.Point(28, 116);
            this.gbadministrador.Name = "gbadministrador";
            this.gbadministrador.Size = new System.Drawing.Size(271, 265);
            this.gbadministrador.TabIndex = 10;
            this.gbadministrador.TabStop = false;
            this.gbadministrador.Text = "ADMINISTRADOR";
            // 
            // btnaccederadministrador
            // 
            this.btnaccederadministrador.BackColor = System.Drawing.Color.BlueViolet;
            this.btnaccederadministrador.ForeColor = System.Drawing.Color.White;
            this.btnaccederadministrador.Location = new System.Drawing.Point(91, 170);
            this.btnaccederadministrador.Name = "btnaccederadministrador";
            this.btnaccederadministrador.Size = new System.Drawing.Size(100, 31);
            this.btnaccederadministrador.TabIndex = 21;
            this.btnaccederadministrador.Text = "Acceder";
            this.btnaccederadministrador.UseVisualStyleBackColor = false;
            this.btnaccederadministrador.Click += new System.EventHandler(this.Btnaccederadm_Click);
            // 
            // txtcontraseñaadministrador
            // 
            this.txtcontraseñaadministrador.Location = new System.Drawing.Point(91, 117);
            this.txtcontraseñaadministrador.Name = "txtcontraseñaadministrador";
            this.txtcontraseñaadministrador.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseñaadministrador.TabIndex = 20;
            this.txtcontraseñaadministrador.UseSystemPasswordChar = true;
            // 
            // btnlimpiaradministrador
            // 
            this.btnlimpiaradministrador.Location = new System.Drawing.Point(173, 227);
            this.btnlimpiaradministrador.Name = "btnlimpiaradministrador";
            this.btnlimpiaradministrador.Size = new System.Drawing.Size(92, 32);
            this.btnlimpiaradministrador.TabIndex = 9;
            this.btnlimpiaradministrador.Text = "Limpiar";
            this.btnlimpiaradministrador.UseVisualStyleBackColor = true;
            this.btnlimpiaradministrador.Click += new System.EventHandler(this.Btnlimpiaradministrador_Click);
            // 
            // txtcedulaadministrador
            // 
            this.txtcedulaadministrador.Location = new System.Drawing.Point(91, 81);
            this.txtcedulaadministrador.Name = "txtcedulaadministrador";
            this.txtcedulaadministrador.Size = new System.Drawing.Size(100, 20);
            this.txtcedulaadministrador.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingrese";
            // 
            // lblcedulaadministrador
            // 
            this.lblcedulaadministrador.AutoSize = true;
            this.lblcedulaadministrador.Location = new System.Drawing.Point(15, 84);
            this.lblcedulaadministrador.Name = "lblcedulaadministrador";
            this.lblcedulaadministrador.Size = new System.Drawing.Size(46, 13);
            this.lblcedulaadministrador.TabIndex = 11;
            this.lblcedulaadministrador.Text = "Cédula";
            // 
            // lblcontraseñaadministrador
            // 
            this.lblcontraseñaadministrador.AutoSize = true;
            this.lblcontraseñaadministrador.Location = new System.Drawing.Point(15, 120);
            this.lblcontraseñaadministrador.Name = "lblcontraseñaadministrador";
            this.lblcontraseñaadministrador.Size = new System.Drawing.Size(71, 13);
            this.lblcontraseñaadministrador.TabIndex = 12;
            this.lblcontraseñaadministrador.Text = "Contraseña";
            // 
            // gbusuario
            // 
            this.gbusuario.Controls.Add(this.btnlimpiarusuario);
            this.gbusuario.Controls.Add(this.lblcedulausuario);
            this.gbusuario.Controls.Add(this.lblcontraseñausuario);
            this.gbusuario.Controls.Add(this.txtcedulausuario);
            this.gbusuario.Controls.Add(this.txtcontraseñausuario);
            this.gbusuario.Controls.Add(this.label3);
            this.gbusuario.Controls.Add(this.btnaccederusuario);
            this.gbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbusuario.Location = new System.Drawing.Point(334, 116);
            this.gbusuario.Name = "gbusuario";
            this.gbusuario.Size = new System.Drawing.Size(271, 265);
            this.gbusuario.TabIndex = 0;
            this.gbusuario.TabStop = false;
            this.gbusuario.Text = "USUARIO";
            // 
            // btnlimpiarusuario
            // 
            this.btnlimpiarusuario.Location = new System.Drawing.Point(173, 227);
            this.btnlimpiarusuario.Name = "btnlimpiarusuario";
            this.btnlimpiarusuario.Size = new System.Drawing.Size(92, 32);
            this.btnlimpiarusuario.TabIndex = 10;
            this.btnlimpiarusuario.Text = "Limpiar";
            this.btnlimpiarusuario.UseVisualStyleBackColor = true;
            this.btnlimpiarusuario.Click += new System.EventHandler(this.Btnlimpiarusuario_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(508, 408);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 30);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click_1);
            // 
            // rbadministrador
            // 
            this.rbadministrador.AutoSize = true;
            this.rbadministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbadministrador.Location = new System.Drawing.Point(37, 82);
            this.rbadministrador.Name = "rbadministrador";
            this.rbadministrador.Size = new System.Drawing.Size(109, 20);
            this.rbadministrador.TabIndex = 12;
            this.rbadministrador.TabStop = true;
            this.rbadministrador.Text = "Administrador";
            this.rbadministrador.UseVisualStyleBackColor = true;
            this.rbadministrador.CheckedChanged += new System.EventHandler(this.Rbadministrador_CheckedChanged);
            // 
            // rbusuario
            // 
            this.rbusuario.AutoSize = true;
            this.rbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbusuario.Location = new System.Drawing.Point(526, 82);
            this.rbusuario.Name = "rbusuario";
            this.rbusuario.Size = new System.Drawing.Size(73, 20);
            this.rbusuario.TabIndex = 13;
            this.rbusuario.TabStop = true;
            this.rbusuario.Text = "Usuario";
            this.rbusuario.UseVisualStyleBackColor = true;
            this.rbusuario.CheckedChanged += new System.EventHandler(this.Rbusuario_CheckedChanged);
            // 
            // Form_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.rbusuario);
            this.Controls.Add(this.rbadministrador);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.gbusuario);
            this.Controls.Add(this.gbadministrador);
            this.Controls.Add(this.label1);
            this.Name = "Form_Sesion";
            this.Text = "Sesión";
            this.Load += new System.EventHandler(this.Form_Sesion_Load);
            this.gbadministrador.ResumeLayout(false);
            this.gbadministrador.PerformLayout();
            this.gbusuario.ResumeLayout(false);
            this.gbusuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcedulausuario;
        private System.Windows.Forms.Label lblcontraseñausuario;
        private System.Windows.Forms.TextBox txtcedulausuario;
        private System.Windows.Forms.TextBox txtcontraseñausuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaccederusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbadministrador;
        private System.Windows.Forms.TextBox txtcontraseñaadministrador;
        private System.Windows.Forms.Button btnlimpiaradministrador;
        private System.Windows.Forms.TextBox txtcedulaadministrador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcedulaadministrador;
        private System.Windows.Forms.Label lblcontraseñaadministrador;
        private System.Windows.Forms.GroupBox gbusuario;
        private System.Windows.Forms.Button btnlimpiarusuario;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.RadioButton rbadministrador;
        private System.Windows.Forms.RadioButton rbusuario;
        private System.Windows.Forms.Button btnaccederadministrador;
    }
}