﻿namespace Registros
{
    partial class Form_Areacuadrado8
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
            this.rbcuadrado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbcuadrado
            // 
            this.rbcuadrado.AutoSize = true;
            this.rbcuadrado.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcuadrado.Location = new System.Drawing.Point(96, 116);
            this.rbcuadrado.Name = "rbcuadrado";
            this.rbcuadrado.Size = new System.Drawing.Size(195, 28);
            this.rbcuadrado.TabIndex = 8;
            this.rbcuadrado.TabStop = true;
            this.rbcuadrado.Text = "Área del Cuadrado";
            this.rbcuadrado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "AREAS GEOMETRICAS";
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.Chocolate;
            this.btnEntry.Location = new System.Drawing.Point(41, 172);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(119, 40);
            this.btnEntry.TabIndex = 10;
            this.btnEntry.Text = "ENTRY";
            this.btnEntry.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Chocolate;
            this.btnsalir.Location = new System.Drawing.Point(250, 172);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(119, 40);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Form_Areacuadrado8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.rbcuadrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntry);
            this.Name = "Form_Areacuadrado8";
            this.Text = "Área del Cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbcuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnsalir;
    }
}