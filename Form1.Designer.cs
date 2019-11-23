namespace Registros
{
    partial class Form_Inicio_Sesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnregistrate = new System.Windows.Forms.Button();
            this.btniniciosesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnregistrate
            // 
            this.btnregistrate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnregistrate.Location = new System.Drawing.Point(58, 213);
            this.btnregistrate.Name = "btnregistrate";
            this.btnregistrate.Size = new System.Drawing.Size(132, 34);
            this.btnregistrate.TabIndex = 0;
            this.btnregistrate.Text = "Registrate Aqui";
            this.btnregistrate.UseVisualStyleBackColor = false;
            this.btnregistrate.Click += new System.EventHandler(this.Btnregistrate_Click);
            // 
            // btniniciosesion
            // 
            this.btniniciosesion.BackColor = System.Drawing.SystemColors.ControlText;
            this.btniniciosesion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btniniciosesion.Location = new System.Drawing.Point(58, 106);
            this.btniniciosesion.Name = "btniniciosesion";
            this.btniniciosesion.Size = new System.Drawing.Size(132, 34);
            this.btniniciosesion.TabIndex = 1;
            this.btniniciosesion.Text = "Inicie Sesión";
            this.btniniciosesion.UseVisualStyleBackColor = false;
            this.btniniciosesion.Click += new System.EventHandler(this.Btniniciosesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sino te Haz Registrado...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido a SRJallco";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(174, 275);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Si tienes Cuenta...";
            // 
            // Form_Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(261, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciosesion);
            this.Controls.Add(this.btnregistrate);
            this.Name = "Form_Inicio_Sesion";
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.Form_Inicio_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrate;
        private System.Windows.Forms.Button btniniciosesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label3;
    }
}

