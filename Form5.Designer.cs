namespace Registros
{
    partial class Form_Usuario5
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
            this.btnmatriz = new System.Windows.Forms.Button();
            this.btnbuscador = new System.Windows.Forms.Button();
            this.btnareacuadrado = new System.Windows.Forms.Button();
            this.btnalturatriangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmatriz
            // 
            this.btnmatriz.Location = new System.Drawing.Point(32, 119);
            this.btnmatriz.Name = "btnmatriz";
            this.btnmatriz.Size = new System.Drawing.Size(125, 52);
            this.btnmatriz.TabIndex = 0;
            this.btnmatriz.Text = "Matriz";
            this.btnmatriz.UseVisualStyleBackColor = true;
            // 
            // btnbuscador
            // 
            this.btnbuscador.Location = new System.Drawing.Point(202, 119);
            this.btnbuscador.Name = "btnbuscador";
            this.btnbuscador.Size = new System.Drawing.Size(125, 52);
            this.btnbuscador.TabIndex = 1;
            this.btnbuscador.Text = "Buscador";
            this.btnbuscador.UseVisualStyleBackColor = true;
            // 
            // btnareacuadrado
            // 
            this.btnareacuadrado.Location = new System.Drawing.Point(32, 209);
            this.btnareacuadrado.Name = "btnareacuadrado";
            this.btnareacuadrado.Size = new System.Drawing.Size(125, 52);
            this.btnareacuadrado.TabIndex = 2;
            this.btnareacuadrado.Text = "Área del Cuadrado";
            this.btnareacuadrado.UseVisualStyleBackColor = true;
            this.btnareacuadrado.Click += new System.EventHandler(this.Btnareacuadrado_Click);
            // 
            // btnalturatriangulo
            // 
            this.btnalturatriangulo.Location = new System.Drawing.Point(202, 209);
            this.btnalturatriangulo.Name = "btnalturatriangulo";
            this.btnalturatriangulo.Size = new System.Drawing.Size(125, 52);
            this.btnalturatriangulo.TabIndex = 3;
            this.btnalturatriangulo.Text = "Altura del Triangulo";
            this.btnalturatriangulo.UseVisualStyleBackColor = true;
            this.btnalturatriangulo.Click += new System.EventHandler(this.Btnalturatriangulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opción Usuario";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(264, 302);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Form_Usuario5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(351, 337);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalturatriangulo);
            this.Controls.Add(this.btnareacuadrado);
            this.Controls.Add(this.btnbuscador);
            this.Controls.Add(this.btnmatriz);
            this.Name = "Form_Usuario5";
            this.Text = "Sesión Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmatriz;
        private System.Windows.Forms.Button btnbuscador;
        private System.Windows.Forms.Button btnareacuadrado;
        private System.Windows.Forms.Button btnalturatriangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
    }
}