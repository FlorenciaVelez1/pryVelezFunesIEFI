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
            this.tsmSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSistemas,
            this.tsmCliente,
            this.tsmListado});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(835, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmSistemas
            // 
            this.tsmSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInformacion,
            this.tsmSalir});
            this.tsmSistemas.Name = "tsmSistemas";
            this.tsmSistemas.Size = new System.Drawing.Size(81, 24);
            this.tsmSistemas.Text = "Sistemas";
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
            this.tsmRegistrarCliente.Size = new System.Drawing.Size(201, 26);
            this.tsmRegistrarCliente.Text = "Registrar Cliente";
            this.tsmRegistrarCliente.Click += new System.EventHandler(this.tsmRegistrarCliente_Click);
            // 
            // tsmBuscarCliente
            // 
            this.tsmBuscarCliente.Name = "tsmBuscarCliente";
            this.tsmBuscarCliente.Size = new System.Drawing.Size(201, 26);
            this.tsmBuscarCliente.Text = "Buscar Cliente";
            this.tsmBuscarCliente.Click += new System.EventHandler(this.tsmBuscarCliente_Click);
            // 
            // tsmListado
            // 
            this.tsmListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClientes});
            this.tsmListado.Name = "tsmListado";
            this.tsmListado.Size = new System.Drawing.Size(71, 24);
            this.tsmListado.Text = "Listado";
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(144, 26);
            this.tsmClientes.Text = "Clientes";
            this.tsmClientes.Click += new System.EventHandler(this.tsmClientes_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryVelezFunesIEFI.Properties.Resources.gimfondo;
            this.ClientSize = new System.Drawing.Size(835, 626);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmSistemas;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmInformacion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmListado;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
    }
}

