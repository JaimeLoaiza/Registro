namespace Registros
{
    partial class Form_Administrador4
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
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnfamilia = new System.Windows.Forms.Button();
            this.btnmatriz = new System.Windows.Forms.Button();
            this.btnbuscador = new System.Windows.Forms.Button();
            this.btnareacuadrado = new System.Windows.Forms.Button();
            this.btnalturatriangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnusuarios
            // 
            this.btnusuarios.Location = new System.Drawing.Point(37, 107);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(105, 37);
            this.btnusuarios.TabIndex = 0;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = true;
            this.btnusuarios.Click += new System.EventHandler(this.Btnusuarios_Click);
            // 
            // btnfamilia
            // 
            this.btnfamilia.Location = new System.Drawing.Point(187, 107);
            this.btnfamilia.Name = "btnfamilia";
            this.btnfamilia.Size = new System.Drawing.Size(105, 37);
            this.btnfamilia.TabIndex = 1;
            this.btnfamilia.Text = "Familia";
            this.btnfamilia.UseVisualStyleBackColor = true;
            this.btnfamilia.Click += new System.EventHandler(this.Btnfamilia_Click);
            // 
            // btnmatriz
            // 
            this.btnmatriz.Location = new System.Drawing.Point(37, 173);
            this.btnmatriz.Name = "btnmatriz";
            this.btnmatriz.Size = new System.Drawing.Size(105, 37);
            this.btnmatriz.TabIndex = 2;
            this.btnmatriz.Text = "Matriz";
            this.btnmatriz.UseVisualStyleBackColor = true;
            // 
            // btnbuscador
            // 
            this.btnbuscador.Location = new System.Drawing.Point(187, 173);
            this.btnbuscador.Name = "btnbuscador";
            this.btnbuscador.Size = new System.Drawing.Size(105, 37);
            this.btnbuscador.TabIndex = 3;
            this.btnbuscador.Text = "Buscador";
            this.btnbuscador.UseVisualStyleBackColor = true;
            // 
            // btnareacuadrado
            // 
            this.btnareacuadrado.Location = new System.Drawing.Point(37, 237);
            this.btnareacuadrado.Name = "btnareacuadrado";
            this.btnareacuadrado.Size = new System.Drawing.Size(105, 38);
            this.btnareacuadrado.TabIndex = 4;
            this.btnareacuadrado.Text = "Área del Cuadrado";
            this.btnareacuadrado.UseVisualStyleBackColor = true;
            this.btnareacuadrado.Click += new System.EventHandler(this.Btnareacuadrado_Click);
            // 
            // btnalturatriangulo
            // 
            this.btnalturatriangulo.Location = new System.Drawing.Point(187, 237);
            this.btnalturatriangulo.Name = "btnalturatriangulo";
            this.btnalturatriangulo.Size = new System.Drawing.Size(105, 38);
            this.btnalturatriangulo.TabIndex = 5;
            this.btnalturatriangulo.Text = "Altura del Triangulo";
            this.btnalturatriangulo.UseVisualStyleBackColor = true;
            this.btnalturatriangulo.Click += new System.EventHandler(this.Btnalturatriangulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opción Administrador";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightSalmon;
            this.btnsalir.Location = new System.Drawing.Point(223, 316);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(90, 33);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Form_Administrador4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(325, 361);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalturatriangulo);
            this.Controls.Add(this.btnareacuadrado);
            this.Controls.Add(this.btnbuscador);
            this.Controls.Add(this.btnmatriz);
            this.Controls.Add(this.btnfamilia);
            this.Controls.Add(this.btnusuarios);
            this.Name = "Form_Administrador4";
            this.Text = "Sesion Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btnfamilia;
        private System.Windows.Forms.Button btnmatriz;
        private System.Windows.Forms.Button btnbuscador;
        private System.Windows.Forms.Button btnareacuadrado;
        private System.Windows.Forms.Button btnalturatriangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
    }
}