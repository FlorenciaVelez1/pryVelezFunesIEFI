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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionCreadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDeudoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusConexion = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionCreadorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // informacionCreadorToolStripMenuItem
            // 
            this.informacionCreadorToolStripMenuItem.Name = "informacionCreadorToolStripMenuItem";
            this.informacionCreadorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.informacionCreadorToolStripMenuItem.Text = "Información Creador";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosClientesToolStripMenuItem,
            this.clientesDeudoresToolStripMenuItem1,
            this.clientesPorBarrioToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // todosLosClientesToolStripMenuItem
            // 
            this.todosLosClientesToolStripMenuItem.Name = "todosLosClientesToolStripMenuItem";
            this.todosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosLosClientesToolStripMenuItem.Text = "Todos los Clientes";
            // 
            // clientesDeudoresToolStripMenuItem1
            // 
            this.clientesDeudoresToolStripMenuItem1.Name = "clientesDeudoresToolStripMenuItem1";
            this.clientesDeudoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesDeudoresToolStripMenuItem1.Text = "Clientes Deudores";
            // 
            // clientesPorBarrioToolStripMenuItem
            // 
            this.clientesPorBarrioToolStripMenuItem.Name = "clientesPorBarrioToolStripMenuItem";
            this.clientesPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesPorBarrioToolStripMenuItem.Text = "Clientes por Barrio";
            // 
            // StatusConexion
            // 
            this.StatusConexion.Location = new System.Drawing.Point(0, 301);
            this.StatusConexion.Name = "StatusConexion";
            this.StatusConexion.Size = new System.Drawing.Size(422, 22);
            this.StatusConexion.TabIndex = 1;
            this.StatusConexion.Text = "statusStrip1";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 323);
            this.Controls.Add(this.StatusConexion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionCreadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusConexion;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDeudoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesPorBarrioToolStripMenuItem;
    }
}

