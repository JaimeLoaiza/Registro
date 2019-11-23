namespace Registros
{
    partial class Form_Buscador9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Buscador9));
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbnuevo = new System.Windows.Forms.ToolStripButton();
            this.btsalir = new System.Windows.Forms.Button();
            this.dgvusuarios1 = new System.Windows.Forms.DataGridView();
            this.lbedad = new System.Windows.Forms.Label();
            this.lbapellido = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.txtedad1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnbuscar.Location = new System.Drawing.Point(41, 377);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(204, 54);
            this.btnbuscar.TabIndex = 23;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconsultar.BackgroundImage")));
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnconsultar.Location = new System.Drawing.Point(253, 377);
            this.btnconsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(204, 54);
            this.btnconsultar.TabIndex = 22;
            this.btnconsultar.Text = "CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnuevo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(724, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbnuevo
            // 
            this.tsbnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbnuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbnuevo.Image")));
            this.tsbnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnuevo.Name = "tsbnuevo";
            this.tsbnuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbnuevo.Text = "toolStripButton1";
            this.tsbnuevo.ToolTipText = "Ingresar Nuevo Usuario";
            // 
            // btsalir
            // 
            this.btsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsalir.BackgroundImage")));
            this.btsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir.ForeColor = System.Drawing.Color.GhostWhite;
            this.btsalir.Location = new System.Drawing.Point(465, 377);
            this.btsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(204, 54);
            this.btsalir.TabIndex = 20;
            this.btsalir.Text = "SALIR";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // dgvusuarios1
            // 
            this.dgvusuarios1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvusuarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios1.Location = new System.Drawing.Point(341, 112);
            this.dgvusuarios1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvusuarios1.Name = "dgvusuarios1";
            this.dgvusuarios1.Size = new System.Drawing.Size(328, 225);
            this.dgvusuarios1.TabIndex = 19;
            // 
            // lbedad
            // 
            this.lbedad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbedad.AutoSize = true;
            this.lbedad.BackColor = System.Drawing.Color.Transparent;
            this.lbedad.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.ForeColor = System.Drawing.Color.Indigo;
            this.lbedad.Location = new System.Drawing.Point(38, 216);
            this.lbedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(47, 19);
            this.lbedad.TabIndex = 15;
            this.lbedad.Text = "Edad";
            // 
            // lbapellido
            // 
            this.lbapellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbapellido.AutoSize = true;
            this.lbapellido.BackColor = System.Drawing.Color.Transparent;
            this.lbapellido.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellido.ForeColor = System.Drawing.Color.Indigo;
            this.lbapellido.Location = new System.Drawing.Point(37, 182);
            this.lbapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(76, 19);
            this.lbapellido.TabIndex = 14;
            this.lbapellido.Text = "Apellido";
            // 
            // lbnombre
            // 
            this.lbnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnombre.AutoSize = true;
            this.lbnombre.BackColor = System.Drawing.Color.Transparent;
            this.lbnombre.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.Indigo;
            this.lbnombre.Location = new System.Drawing.Point(38, 146);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(75, 19);
            this.lbnombre.TabIndex = 13;
            this.lbnombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(278, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "BUSCAR";
            // 
            // txtnombre1
            // 
            this.txtnombre1.Location = new System.Drawing.Point(148, 145);
            this.txtnombre1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(160, 21);
            this.txtnombre1.TabIndex = 24;
            // 
            // txtapellido1
            // 
            this.txtapellido1.Location = new System.Drawing.Point(148, 181);
            this.txtapellido1.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(160, 21);
            this.txtapellido1.TabIndex = 25;
            // 
            // txtedad1
            // 
            this.txtedad1.Location = new System.Drawing.Point(148, 215);
            this.txtedad1.Margin = new System.Windows.Forms.Padding(4);
            this.txtedad1.Name = "txtedad1";
            this.txtedad1.Size = new System.Drawing.Size(160, 21);
            this.txtedad1.TabIndex = 26;
            // 
            // Form_Buscador9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 472);
            this.Controls.Add(this.txtedad1);
            this.Controls.Add(this.txtapellido1);
            this.Controls.Add(this.txtnombre1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.dgvusuarios1);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Buscador9";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form_Buscador9_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbnuevo;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.DataGridView dgvusuarios1;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.TextBox txtedad1;
    }
}