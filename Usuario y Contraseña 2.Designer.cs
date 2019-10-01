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
            this.lblcedulausu = new System.Windows.Forms.Label();
            this.lblcontraseñausu = new System.Windows.Forms.Label();
            this.txtcedulausu = new System.Windows.Forms.TextBox();
            this.txtcontraseñausu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaccederusu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbadministrador = new System.Windows.Forms.GroupBox();
            this.txtcontraseñaadm = new System.Windows.Forms.TextBox();
            this.btnlimpiaradm = new System.Windows.Forms.Button();
            this.txtcedulaadm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcedulaadm = new System.Windows.Forms.Label();
            this.lblcontraseñaadm = new System.Windows.Forms.Label();
            this.gbusuario = new System.Windows.Forms.GroupBox();
            this.btnlimpiarusu = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.rbadministrador = new System.Windows.Forms.RadioButton();
            this.rbusuario = new System.Windows.Forms.RadioButton();
            this.btnaccederadm = new System.Windows.Forms.Button();
            this.gbadministrador.SuspendLayout();
            this.gbusuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcedulausu
            // 
            this.lblcedulausu.AutoSize = true;
            this.lblcedulausu.Location = new System.Drawing.Point(17, 84);
            this.lblcedulausu.Name = "lblcedulausu";
            this.lblcedulausu.Size = new System.Drawing.Size(46, 13);
            this.lblcedulausu.TabIndex = 0;
            this.lblcedulausu.Text = "Cédula";
            this.lblcedulausu.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblcontraseñausu
            // 
            this.lblcontraseñausu.AutoSize = true;
            this.lblcontraseñausu.Location = new System.Drawing.Point(17, 120);
            this.lblcontraseñausu.Name = "lblcontraseñausu";
            this.lblcontraseñausu.Size = new System.Drawing.Size(71, 13);
            this.lblcontraseñausu.TabIndex = 1;
            this.lblcontraseñausu.Text = "Contraseña";
            // 
            // txtcedulausu
            // 
            this.txtcedulausu.Location = new System.Drawing.Point(93, 81);
            this.txtcedulausu.Name = "txtcedulausu";
            this.txtcedulausu.Size = new System.Drawing.Size(100, 20);
            this.txtcedulausu.TabIndex = 2;
            // 
            // txtcontraseñausu
            // 
            this.txtcontraseñausu.Location = new System.Drawing.Point(93, 117);
            this.txtcontraseñausu.MaxLength = 6;
            this.txtcontraseñausu.Name = "txtcontraseñausu";
            this.txtcontraseñausu.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseñausu.TabIndex = 3;
            this.txtcontraseñausu.UseSystemPasswordChar = true;
            this.txtcontraseñausu.TextChanged += new System.EventHandler(this.Txtcontraseña_TextChanged);
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
            // btnaccederusu
            // 
            this.btnaccederusu.BackColor = System.Drawing.Color.BlueViolet;
            this.btnaccederusu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaccederusu.Location = new System.Drawing.Point(93, 170);
            this.btnaccederusu.Name = "btnaccederusu";
            this.btnaccederusu.Size = new System.Drawing.Size(100, 31);
            this.btnaccederusu.TabIndex = 5;
            this.btnaccederusu.Text = "Acceder";
            this.btnaccederusu.UseVisualStyleBackColor = false;
            this.btnaccederusu.Click += new System.EventHandler(this.Btnaccederusu_Click);
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
            this.gbadministrador.Controls.Add(this.btnaccederadm);
            this.gbadministrador.Controls.Add(this.txtcontraseñaadm);
            this.gbadministrador.Controls.Add(this.btnlimpiaradm);
            this.gbadministrador.Controls.Add(this.txtcedulaadm);
            this.gbadministrador.Controls.Add(this.label5);
            this.gbadministrador.Controls.Add(this.lblcedulaadm);
            this.gbadministrador.Controls.Add(this.lblcontraseñaadm);
            this.gbadministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbadministrador.Location = new System.Drawing.Point(28, 116);
            this.gbadministrador.Name = "gbadministrador";
            this.gbadministrador.Size = new System.Drawing.Size(271, 265);
            this.gbadministrador.TabIndex = 10;
            this.gbadministrador.TabStop = false;
            this.gbadministrador.Text = "ADMINISTRADOR";
            // 
            // txtcontraseñaadm
            // 
            this.txtcontraseñaadm.Location = new System.Drawing.Point(91, 117);
            this.txtcontraseñaadm.Name = "txtcontraseñaadm";
            this.txtcontraseñaadm.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseñaadm.TabIndex = 20;
            this.txtcontraseñaadm.UseSystemPasswordChar = true;
            // 
            // btnlimpiaradm
            // 
            this.btnlimpiaradm.Location = new System.Drawing.Point(173, 227);
            this.btnlimpiaradm.Name = "btnlimpiaradm";
            this.btnlimpiaradm.Size = new System.Drawing.Size(92, 32);
            this.btnlimpiaradm.TabIndex = 9;
            this.btnlimpiaradm.Text = "Limpiar";
            this.btnlimpiaradm.UseVisualStyleBackColor = true;
            this.btnlimpiaradm.Click += new System.EventHandler(this.Btnlimpiaradm_Click);
            // 
            // txtcedulaadm
            // 
            this.txtcedulaadm.Location = new System.Drawing.Point(91, 81);
            this.txtcedulaadm.Name = "txtcedulaadm";
            this.txtcedulaadm.Size = new System.Drawing.Size(100, 20);
            this.txtcedulaadm.TabIndex = 19;
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
            // lblcedulaadm
            // 
            this.lblcedulaadm.AutoSize = true;
            this.lblcedulaadm.Location = new System.Drawing.Point(15, 84);
            this.lblcedulaadm.Name = "lblcedulaadm";
            this.lblcedulaadm.Size = new System.Drawing.Size(46, 13);
            this.lblcedulaadm.TabIndex = 11;
            this.lblcedulaadm.Text = "Cédula";
            // 
            // lblcontraseñaadm
            // 
            this.lblcontraseñaadm.AutoSize = true;
            this.lblcontraseñaadm.Location = new System.Drawing.Point(15, 120);
            this.lblcontraseñaadm.Name = "lblcontraseñaadm";
            this.lblcontraseñaadm.Size = new System.Drawing.Size(71, 13);
            this.lblcontraseñaadm.TabIndex = 12;
            this.lblcontraseñaadm.Text = "Contraseña";
            // 
            // gbusuario
            // 
            this.gbusuario.Controls.Add(this.btnlimpiarusu);
            this.gbusuario.Controls.Add(this.lblcedulausu);
            this.gbusuario.Controls.Add(this.lblcontraseñausu);
            this.gbusuario.Controls.Add(this.txtcedulausu);
            this.gbusuario.Controls.Add(this.txtcontraseñausu);
            this.gbusuario.Controls.Add(this.label3);
            this.gbusuario.Controls.Add(this.btnaccederusu);
            this.gbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbusuario.Location = new System.Drawing.Point(334, 116);
            this.gbusuario.Name = "gbusuario";
            this.gbusuario.Size = new System.Drawing.Size(271, 265);
            this.gbusuario.TabIndex = 0;
            this.gbusuario.TabStop = false;
            this.gbusuario.Text = "USUARIO";
            // 
            // btnlimpiarusu
            // 
            this.btnlimpiarusu.Location = new System.Drawing.Point(173, 227);
            this.btnlimpiarusu.Name = "btnlimpiarusu";
            this.btnlimpiarusu.Size = new System.Drawing.Size(92, 32);
            this.btnlimpiarusu.TabIndex = 10;
            this.btnlimpiarusu.Text = "Limpiar";
            this.btnlimpiarusu.UseVisualStyleBackColor = true;
            this.btnlimpiarusu.Click += new System.EventHandler(this.Btnlimpiarusu_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(497, 410);
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
            // btnaccederadm
            // 
            this.btnaccederadm.BackColor = System.Drawing.Color.BlueViolet;
            this.btnaccederadm.ForeColor = System.Drawing.Color.White;
            this.btnaccederadm.Location = new System.Drawing.Point(91, 170);
            this.btnaccederadm.Name = "btnaccederadm";
            this.btnaccederadm.Size = new System.Drawing.Size(100, 31);
            this.btnaccederadm.TabIndex = 21;
            this.btnaccederadm.Text = "Acceder";
            this.btnaccederadm.UseVisualStyleBackColor = false;
            this.btnaccederadm.Click += new System.EventHandler(this.Btnaccederadm_Click);
            // 
            // Form_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(628, 451);
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

        private System.Windows.Forms.Label lblcedulausu;
        private System.Windows.Forms.Label lblcontraseñausu;
        private System.Windows.Forms.TextBox txtcedulausu;
        private System.Windows.Forms.TextBox txtcontraseñausu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaccederusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbadministrador;
        private System.Windows.Forms.TextBox txtcontraseñaadm;
        private System.Windows.Forms.Button btnlimpiaradm;
        private System.Windows.Forms.TextBox txtcedulaadm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcedulaadm;
        private System.Windows.Forms.Label lblcontraseñaadm;
        private System.Windows.Forms.GroupBox gbusuario;
        private System.Windows.Forms.Button btnlimpiarusu;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.RadioButton rbadministrador;
        private System.Windows.Forms.RadioButton rbusuario;
        private System.Windows.Forms.Button btnaccederadm;
    }
}