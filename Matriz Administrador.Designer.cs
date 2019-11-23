namespace Registros
{
    partial class Matriz_Administrador
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
            this.lbltabladel = new System.Windows.Forms.Label();
            this.lblhastadel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttabladel = new System.Windows.Forms.TextBox();
            this.txthastadel = new System.Windows.Forms.TextBox();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltabladel
            // 
            this.lbltabladel.AutoSize = true;
            this.lbltabladel.Location = new System.Drawing.Point(42, 94);
            this.lbltabladel.Name = "lbltabladel";
            this.lbltabladel.Size = new System.Drawing.Size(65, 13);
            this.lbltabladel.TabIndex = 0;
            this.lbltabladel.Text = "TABLA DEL";
            // 
            // lblhastadel
            // 
            this.lblhastadel.AutoSize = true;
            this.lblhastadel.Location = new System.Drawing.Point(170, 94);
            this.lblhastadel.Name = "lblhastadel";
            this.lblhastadel.Size = new System.Drawing.Size(59, 13);
            this.lblhastadel.TabIndex = 1;
            this.lblhastadel.Text = "HASTA EL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TABLA DE MULTIPLICAR DEL 1 AL 12";
            // 
            // txttabladel
            // 
            this.txttabladel.Location = new System.Drawing.Point(25, 120);
            this.txttabladel.Name = "txttabladel";
            this.txttabladel.Size = new System.Drawing.Size(100, 20);
            this.txttabladel.TabIndex = 3;
            // 
            // txthastadel
            // 
            this.txthastadel.Location = new System.Drawing.Point(150, 120);
            this.txthastadel.Name = "txthastadel";
            this.txthastadel.Size = new System.Drawing.Size(100, 20);
            this.txthastadel.TabIndex = 4;
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(150, 230);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(115, 36);
            this.btnmultiplicar.TabIndex = 5;
            this.btnmultiplicar.Text = "MULTIPLICAR";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(29, 214);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(29, 269);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 341);
            this.dataGridView1.TabIndex = 9;
            // 
            // Matriz_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.txthastadel);
            this.Controls.Add(this.txttabladel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhastadel);
            this.Controls.Add(this.lbltabladel);
            this.Name = "Matriz_Administrador";
            this.Text = "Matriz_Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltabladel;
        private System.Windows.Forms.Label lblhastadel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttabladel;
        private System.Windows.Forms.TextBox txthastadel;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}