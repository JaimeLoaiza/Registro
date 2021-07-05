namespace Registros
{
    partial class Form_Familia7
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
            this.lblfamilia = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblparentesco = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.DISPLAY = new System.Windows.Forms.ListBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtparentesco = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfamilia
            // 
            this.lblfamilia.AutoSize = true;
            this.lblfamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamilia.Location = new System.Drawing.Point(92, 29);
            this.lblfamilia.Name = "lblfamilia";
            this.lblfamilia.Size = new System.Drawing.Size(191, 20);
            this.lblfamilia.TabIndex = 0;
            this.lblfamilia.Text = "REGISTRO FAMILIAR";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(12, 85);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblparentesco
            // 
            this.lblparentesco.AutoSize = true;
            this.lblparentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparentesco.Location = new System.Drawing.Point(12, 128);
            this.lblparentesco.Name = "lblparentesco";
            this.lblparentesco.Size = new System.Drawing.Size(71, 13);
            this.lblparentesco.TabIndex = 2;
            this.lblparentesco.Text = "Parentesco";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(12, 172);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(36, 13);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "Edad";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(214, 72);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(137, 30);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(214, 108);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(137, 30);
            this.btnconsultar.TabIndex = 5;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(214, 144);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(137, 30);
            this.btnactualizar.TabIndex = 6;
            this.btnactualizar.Text = "Modificar/Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(214, 180);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(137, 30);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // DISPLAY
            // 
            this.DISPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISPLAY.FormattingEnabled = true;
            this.DISPLAY.ItemHeight = 16;
            this.DISPLAY.Location = new System.Drawing.Point(15, 227);
            this.DISPLAY.Name = "DISPLAY";
            this.DISPLAY.Size = new System.Drawing.Size(336, 196);
            this.DISPLAY.TabIndex = 8;
            this.DISPLAY.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 82);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtparentesco
            // 
            this.txtparentesco.Location = new System.Drawing.Point(89, 125);
            this.txtparentesco.Name = "txtparentesco";
            this.txtparentesco.Size = new System.Drawing.Size(100, 20);
            this.txtparentesco.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(89, 169);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 11;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Thistle;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(221, 444);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(137, 30);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Form_Familia7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(370, 486);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtparentesco);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.DISPLAY);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblparentesco);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblfamilia);
            this.Name = "Form_Familia7";
            this.Text = "Familia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblparentesco;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ListBox DISPLAY;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtparentesco;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnsalir;
    }
}