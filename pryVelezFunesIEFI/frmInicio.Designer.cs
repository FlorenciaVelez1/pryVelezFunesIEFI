namespace pryVelezFunesIEFI
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tmsSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsmClientesDeudores = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsSistemas,
            this.tsmCliente,
            this.tsmListado});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(1057, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tmsSistemas
            // 
            this.tmsSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInformacion,
            this.tsmSalir});
            this.tmsSistemas.Name = "tmsSistemas";
            this.tmsSistemas.Size = new System.Drawing.Size(81, 24);
            this.tmsSistemas.Text = "Sistemas";
            // 
            // tsmInformacion
            // 
            this.tsmInformacion.Name = "tsmInformacion";
            this.tsmInformacion.Size = new System.Drawing.Size(229, 26);
            this.tsmInformacion.Text = "Información Creador";
            this.tsmInformacion.Click += new System.EventHandler(this.tsmInformacion_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(229, 26);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmCliente
            // 
            this.tsmCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistrarCliente,
            this.tsmBuscarCliente});
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(75, 24);
            this.tsmCliente.Text = "Clientes";
            // 
            // tsmRegistrarCliente
            // 
            this.tsmRegistrarCliente.Name = "tsmRegistrarCliente";
            this.tsmRegistrarCliente.Size = new System.Drawing.Size(224, 26);
            this.tsmRegistrarCliente.Text = "Registrar Cliente";
            this.tsmRegistrarCliente.Click += new System.EventHandler(this.tsmRegistrarCliente_Click);
            // 
            // tsmBuscarCliente
            // 
            this.tsmBuscarCliente.Name = "tsmBuscarCliente";
            this.tsmBuscarCliente.Size = new System.Drawing.Size(224, 26);
            this.tsmBuscarCliente.Text = "Buscar Cliente";
            this.tsmBuscarCliente.Click += new System.EventHandler(this.tsmBuscarCliente_Click);
            // 
            // tsmListado
            // 
            this.tsmListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClientes,
            this.tsmClientesDeudores});
            this.tsmListado.Name = "tsmListado";
            this.tsmListado.Size = new System.Drawing.Size(71, 24);
            this.tsmListado.Text = "Listado";
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(224, 26);
            this.tsmClientes.Text = "Clientes";
            this.tsmClientes.Click += new System.EventHandler(this.tsmClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::pryVelezFunesIEFI.Properties.Resources.Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tsmClientesDeudores
            // 
            this.tsmClientesDeudores.Name = "tsmClientesDeudores";
            this.tsmClientesDeudores.Size = new System.Drawing.Size(224, 26);
            this.tsmClientesDeudores.Text = "Clientes Deudores";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tmsSistemas;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmInformacion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmListado;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmClientesDeudores;
    }
}

