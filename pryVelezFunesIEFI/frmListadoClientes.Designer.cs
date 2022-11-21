namespace pryVelezFunesIEFI
{
    partial class frmListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.cmdSalirCliente = new System.Windows.Forms.Button();
            this.cmdConsultarCliente = new System.Windows.Forms.Button();
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.columIDSocioCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNomApellCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDireccCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columBarrioCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columActivCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTelefonoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columFechaInscripCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columSaldoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdImprimirCli = new System.Windows.Forms.Button();
            this.cmdExportarCli = new System.Windows.Forms.Button();
            this.lblCantClienteCli = new System.Windows.Forms.Label();
            this.lblPromedioCli = new System.Windows.Forms.Label();
            this.lblTotalIngresosCli = new System.Windows.Forms.Label();
            this.lblPromIngresoNom = new System.Windows.Forms.Label();
            this.lblCantClienteNom = new System.Windows.Forms.Label();
            this.lblTotalIngresoNom = new System.Windows.Forms.Label();
            this.tabBarrio = new System.Windows.Forms.TabPage();
            this.cmdImprimirBar = new System.Windows.Forms.Button();
            this.cmdExportarBar = new System.Windows.Forms.Button();
            this.GrillaBarrio = new System.Windows.Forms.DataGridView();
            this.columIDSocioBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNomApellBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDireccionBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columBarrioBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columActividadBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTelefonoBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columFechaInscripBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columSaldoBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblCantClienBar = new System.Windows.Forms.Label();
            this.lblPromedioBar = new System.Windows.Forms.Label();
            this.lblTotalIngresosBar = new System.Windows.Forms.Label();
            this.lblPromIngreNom2 = new System.Windows.Forms.Label();
            this.lblCantClienNom2 = new System.Windows.Forms.Label();
            this.lblTotalIngresoNom2 = new System.Windows.Forms.Label();
            this.cmdSalirBarrio = new System.Windows.Forms.Button();
            this.cmdConsultaBarrio = new System.Windows.Forms.Button();
            this.tabActividad = new System.Windows.Forms.TabPage();
            this.cmdImprimirAct = new System.Windows.Forms.Button();
            this.cmdExportarAct = new System.Windows.Forms.Button();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblCantCliAct = new System.Windows.Forms.Label();
            this.lblPromedioAct = new System.Windows.Forms.Label();
            this.lblTotalIngresosAct = new System.Windows.Forms.Label();
            this.lblPromIngreNom3 = new System.Windows.Forms.Label();
            this.lblCantClieNom3 = new System.Windows.Forms.Label();
            this.lblTotalIngrNom3 = new System.Windows.Forms.Label();
            this.GrillaActividad = new System.Windows.Forms.DataGridView();
            this.columIDSocioAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNomApellAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDireccionAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columBarrioAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columActividadAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTelefonoAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columFechaInscipAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columSaldoAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalirActividad = new System.Windows.Forms.Button();
            this.cmdConsultarActividad = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            this.tabOpciones.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            this.tabBarrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).BeginInit();
            this.tabActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSalirCliente
            // 
            this.cmdSalirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirCliente.Location = new System.Drawing.Point(452, 475);
            this.cmdSalirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalirCliente.Name = "cmdSalirCliente";
            this.cmdSalirCliente.Size = new System.Drawing.Size(115, 33);
            this.cmdSalirCliente.TabIndex = 5;
            this.cmdSalirCliente.Text = "Salir";
            this.cmdSalirCliente.UseVisualStyleBackColor = true;
            this.cmdSalirCliente.Click += new System.EventHandler(this.cmdSalirCliente_Click);
            // 
            // cmdConsultarCliente
            // 
            this.cmdConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarCliente.Location = new System.Drawing.Point(640, 475);
            this.cmdConsultarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultarCliente.Name = "cmdConsultarCliente";
            this.cmdConsultarCliente.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultarCliente.TabIndex = 4;
            this.cmdConsultarCliente.Text = "Consultar";
            this.cmdConsultarCliente.UseVisualStyleBackColor = true;
            this.cmdConsultarCliente.Click += new System.EventHandler(this.cmdConsultarCliente_Click);
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.tabClientes);
            this.tabOpciones.Controls.Add(this.tabBarrio);
            this.tabOpciones.Controls.Add(this.tabActividad);
            this.tabOpciones.Location = new System.Drawing.Point(1, 0);
            this.tabOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(767, 546);
            this.tabOpciones.TabIndex = 6;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.GrillaClientes);
            this.tabClientes.Controls.Add(this.cmdImprimirCli);
            this.tabClientes.Controls.Add(this.cmdExportarCli);
            this.tabClientes.Controls.Add(this.lblCantClienteCli);
            this.tabClientes.Controls.Add(this.lblPromedioCli);
            this.tabClientes.Controls.Add(this.lblTotalIngresosCli);
            this.tabClientes.Controls.Add(this.lblPromIngresoNom);
            this.tabClientes.Controls.Add(this.lblCantClienteNom);
            this.tabClientes.Controls.Add(this.lblTotalIngresoNom);
            this.tabClientes.Controls.Add(this.cmdSalirCliente);
            this.tabClientes.Controls.Add(this.cmdConsultarCliente);
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tabClientes.Size = new System.Drawing.Size(759, 517);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIDSocioCli,
            this.columNomApellCli,
            this.columDireccCli,
            this.columBarrioCli,
            this.columActivCli,
            this.columTelefonoCli,
            this.columFechaInscripCli,
            this.columSaldoCli});
            this.GrillaClientes.Location = new System.Drawing.Point(0, 0);
            this.GrillaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ReadOnly = true;
            this.GrillaClientes.RowHeadersVisible = false;
            this.GrillaClientes.RowHeadersWidth = 51;
            this.GrillaClientes.Size = new System.Drawing.Size(755, 363);
            this.GrillaClientes.TabIndex = 38;
            // 
            // columIDSocioCli
            // 
            this.columIDSocioCli.HeaderText = "ID Socio";
            this.columIDSocioCli.MinimumWidth = 6;
            this.columIDSocioCli.Name = "columIDSocioCli";
            this.columIDSocioCli.ReadOnly = true;
            this.columIDSocioCli.Width = 125;
            // 
            // columNomApellCli
            // 
            this.columNomApellCli.HeaderText = "Nombre y Apellido";
            this.columNomApellCli.MinimumWidth = 6;
            this.columNomApellCli.Name = "columNomApellCli";
            this.columNomApellCli.ReadOnly = true;
            this.columNomApellCli.Width = 125;
            // 
            // columDireccCli
            // 
            this.columDireccCli.HeaderText = "Direccion";
            this.columDireccCli.MinimumWidth = 6;
            this.columDireccCli.Name = "columDireccCli";
            this.columDireccCli.ReadOnly = true;
            this.columDireccCli.Width = 125;
            // 
            // columBarrioCli
            // 
            this.columBarrioCli.HeaderText = "Barrio";
            this.columBarrioCli.MinimumWidth = 6;
            this.columBarrioCli.Name = "columBarrioCli";
            this.columBarrioCli.ReadOnly = true;
            this.columBarrioCli.Width = 125;
            // 
            // columActivCli
            // 
            this.columActivCli.HeaderText = "Actividad";
            this.columActivCli.MinimumWidth = 6;
            this.columActivCli.Name = "columActivCli";
            this.columActivCli.ReadOnly = true;
            this.columActivCli.Width = 125;
            // 
            // columTelefonoCli
            // 
            this.columTelefonoCli.HeaderText = "Telefono";
            this.columTelefonoCli.MinimumWidth = 6;
            this.columTelefonoCli.Name = "columTelefonoCli";
            this.columTelefonoCli.ReadOnly = true;
            this.columTelefonoCli.Width = 125;
            // 
            // columFechaInscripCli
            // 
            this.columFechaInscripCli.HeaderText = "Fecha de Inscripcion";
            this.columFechaInscripCli.MinimumWidth = 6;
            this.columFechaInscripCli.Name = "columFechaInscripCli";
            this.columFechaInscripCli.ReadOnly = true;
            this.columFechaInscripCli.Width = 125;
            // 
            // columSaldoCli
            // 
            this.columSaldoCli.HeaderText = "Saldo";
            this.columSaldoCli.MinimumWidth = 6;
            this.columSaldoCli.Name = "columSaldoCli";
            this.columSaldoCli.ReadOnly = true;
            this.columSaldoCli.Width = 125;
            // 
            // cmdImprimirCli
            // 
            this.cmdImprimirCli.Enabled = false;
            this.cmdImprimirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimirCli.Location = new System.Drawing.Point(8, 374);
            this.cmdImprimirCli.Name = "cmdImprimirCli";
            this.cmdImprimirCli.Size = new System.Drawing.Size(115, 33);
            this.cmdImprimirCli.TabIndex = 35;
            this.cmdImprimirCli.Text = "Imprimir";
            this.cmdImprimirCli.UseVisualStyleBackColor = true;
            this.cmdImprimirCli.Click += new System.EventHandler(this.cmdImprimirCli_Click);
            // 
            // cmdExportarCli
            // 
            this.cmdExportarCli.Enabled = false;
            this.cmdExportarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarCli.Location = new System.Drawing.Point(294, 374);
            this.cmdExportarCli.Name = "cmdExportarCli";
            this.cmdExportarCli.Size = new System.Drawing.Size(115, 33);
            this.cmdExportarCli.TabIndex = 33;
            this.cmdExportarCli.Text = "Exportar";
            this.cmdExportarCli.UseVisualStyleBackColor = true;
            this.cmdExportarCli.Click += new System.EventHandler(this.cmdExportarCli_Click);
            // 
            // lblCantClienteCli
            // 
            this.lblCantClienteCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantClienteCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClienteCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienteCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantClienteCli.Location = new System.Drawing.Point(639, 440);
            this.lblCantClienteCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClienteCli.Name = "lblCantClienteCli";
            this.lblCantClienteCli.Size = new System.Drawing.Size(113, 25);
            this.lblCantClienteCli.TabIndex = 32;
            // 
            // lblPromedioCli
            // 
            this.lblPromedioCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromedioCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromedioCli.Location = new System.Drawing.Point(639, 409);
            this.lblPromedioCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioCli.Name = "lblPromedioCli";
            this.lblPromedioCli.Size = new System.Drawing.Size(113, 25);
            this.lblPromedioCli.TabIndex = 31;
            // 
            // lblTotalIngresosCli
            // 
            this.lblTotalIngresosCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalIngresosCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalIngresosCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresosCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalIngresosCli.Location = new System.Drawing.Point(639, 372);
            this.lblTotalIngresosCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresosCli.Name = "lblTotalIngresosCli";
            this.lblTotalIngresosCli.Size = new System.Drawing.Size(113, 25);
            this.lblTotalIngresosCli.TabIndex = 30;
            // 
            // lblPromIngresoNom
            // 
            this.lblPromIngresoNom.AutoSize = true;
            this.lblPromIngresoNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngresoNom.Location = new System.Drawing.Point(448, 409);
            this.lblPromIngresoNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromIngresoNom.Name = "lblPromIngresoNom";
            this.lblPromIngresoNom.Size = new System.Drawing.Size(177, 20);
            this.lblPromIngresoNom.TabIndex = 29;
            this.lblPromIngresoNom.Text = "Promedio de Ingresos:";
            // 
            // lblCantClienteNom
            // 
            this.lblCantClienteNom.AutoSize = true;
            this.lblCantClienteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienteNom.Location = new System.Drawing.Point(448, 445);
            this.lblCantClienteNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClienteNom.Name = "lblCantClienteNom";
            this.lblCantClienteNom.Size = new System.Drawing.Size(169, 20);
            this.lblCantClienteNom.TabIndex = 28;
            this.lblCantClienteNom.Text = "Cantidad de Clientes:";
            // 
            // lblTotalIngresoNom
            // 
            this.lblTotalIngresoNom.AutoSize = true;
            this.lblTotalIngresoNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresoNom.Location = new System.Drawing.Point(448, 372);
            this.lblTotalIngresoNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresoNom.Name = "lblTotalIngresoNom";
            this.lblTotalIngresoNom.Size = new System.Drawing.Size(143, 20);
            this.lblTotalIngresoNom.TabIndex = 27;
            this.lblTotalIngresoNom.Text = "Total de Ingresos:";
            // 
            // tabBarrio
            // 
            this.tabBarrio.Controls.Add(this.cmdImprimirBar);
            this.tabBarrio.Controls.Add(this.cmdExportarBar);
            this.tabBarrio.Controls.Add(this.GrillaBarrio);
            this.tabBarrio.Controls.Add(this.lblBarrio);
            this.tabBarrio.Controls.Add(this.lstBarrio);
            this.tabBarrio.Controls.Add(this.lblCantClienBar);
            this.tabBarrio.Controls.Add(this.lblPromedioBar);
            this.tabBarrio.Controls.Add(this.lblTotalIngresosBar);
            this.tabBarrio.Controls.Add(this.lblPromIngreNom2);
            this.tabBarrio.Controls.Add(this.lblCantClienNom2);
            this.tabBarrio.Controls.Add(this.lblTotalIngresoNom2);
            this.tabBarrio.Controls.Add(this.cmdSalirBarrio);
            this.tabBarrio.Controls.Add(this.cmdConsultaBarrio);
            this.tabBarrio.Location = new System.Drawing.Point(4, 25);
            this.tabBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.tabBarrio.Name = "tabBarrio";
            this.tabBarrio.Padding = new System.Windows.Forms.Padding(4);
            this.tabBarrio.Size = new System.Drawing.Size(759, 517);
            this.tabBarrio.TabIndex = 1;
            this.tabBarrio.Text = "Barrio";
            this.tabBarrio.UseVisualStyleBackColor = true;
            // 
            // cmdImprimirBar
            // 
            this.cmdImprimirBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimirBar.Location = new System.Drawing.Point(8, 375);
            this.cmdImprimirBar.Name = "cmdImprimirBar";
            this.cmdImprimirBar.Size = new System.Drawing.Size(115, 33);
            this.cmdImprimirBar.TabIndex = 40;
            this.cmdImprimirBar.Text = "Imprimir";
            this.cmdImprimirBar.UseVisualStyleBackColor = true;
            this.cmdImprimirBar.Click += new System.EventHandler(this.cmdImprimirBar_Click);
            // 
            // cmdExportarBar
            // 
            this.cmdExportarBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarBar.Location = new System.Drawing.Point(294, 374);
            this.cmdExportarBar.Name = "cmdExportarBar";
            this.cmdExportarBar.Size = new System.Drawing.Size(115, 33);
            this.cmdExportarBar.TabIndex = 38;
            this.cmdExportarBar.Text = "Exportar";
            this.cmdExportarBar.UseVisualStyleBackColor = true;
            this.cmdExportarBar.Click += new System.EventHandler(this.cmdExportarBar_Click);
            // 
            // GrillaBarrio
            // 
            this.GrillaBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIDSocioBar,
            this.columNomApellBar,
            this.columDireccionBar,
            this.columBarrioBar,
            this.columActividadBar,
            this.columTelefonoBar,
            this.columFechaInscripBar,
            this.columSaldoBar});
            this.GrillaBarrio.Location = new System.Drawing.Point(0, 57);
            this.GrillaBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaBarrio.Name = "GrillaBarrio";
            this.GrillaBarrio.ReadOnly = true;
            this.GrillaBarrio.RowHeadersVisible = false;
            this.GrillaBarrio.RowHeadersWidth = 51;
            this.GrillaBarrio.Size = new System.Drawing.Size(755, 306);
            this.GrillaBarrio.TabIndex = 37;
            // 
            // columIDSocioBar
            // 
            this.columIDSocioBar.HeaderText = "ID Socio";
            this.columIDSocioBar.MinimumWidth = 6;
            this.columIDSocioBar.Name = "columIDSocioBar";
            this.columIDSocioBar.ReadOnly = true;
            this.columIDSocioBar.Width = 125;
            // 
            // columNomApellBar
            // 
            this.columNomApellBar.HeaderText = "Nombre y Apellido";
            this.columNomApellBar.MinimumWidth = 6;
            this.columNomApellBar.Name = "columNomApellBar";
            this.columNomApellBar.ReadOnly = true;
            this.columNomApellBar.Width = 125;
            // 
            // columDireccionBar
            // 
            this.columDireccionBar.HeaderText = "Direccion";
            this.columDireccionBar.MinimumWidth = 6;
            this.columDireccionBar.Name = "columDireccionBar";
            this.columDireccionBar.ReadOnly = true;
            this.columDireccionBar.Width = 125;
            // 
            // columBarrioBar
            // 
            this.columBarrioBar.HeaderText = "Barrio";
            this.columBarrioBar.MinimumWidth = 6;
            this.columBarrioBar.Name = "columBarrioBar";
            this.columBarrioBar.ReadOnly = true;
            this.columBarrioBar.Width = 125;
            // 
            // columActividadBar
            // 
            this.columActividadBar.HeaderText = "Actividad";
            this.columActividadBar.MinimumWidth = 6;
            this.columActividadBar.Name = "columActividadBar";
            this.columActividadBar.ReadOnly = true;
            this.columActividadBar.Width = 125;
            // 
            // columTelefonoBar
            // 
            this.columTelefonoBar.HeaderText = "Telefono";
            this.columTelefonoBar.MinimumWidth = 6;
            this.columTelefonoBar.Name = "columTelefonoBar";
            this.columTelefonoBar.ReadOnly = true;
            this.columTelefonoBar.Width = 125;
            // 
            // columFechaInscripBar
            // 
            this.columFechaInscripBar.HeaderText = "Fecha de Inscripcion";
            this.columFechaInscripBar.MinimumWidth = 6;
            this.columFechaInscripBar.Name = "columFechaInscripBar";
            this.columFechaInscripBar.ReadOnly = true;
            this.columFechaInscripBar.Width = 125;
            // 
            // columSaldoBar
            // 
            this.columSaldoBar.HeaderText = "Saldo";
            this.columSaldoBar.MinimumWidth = 6;
            this.columSaldoBar.Name = "columSaldoBar";
            this.columSaldoBar.ReadOnly = true;
            this.columSaldoBar.Width = 125;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(3, 16);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(55, 20);
            this.lblBarrio.TabIndex = 36;
            this.lblBarrio.Text = "Barrio";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(74, 16);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(121, 24);
            this.lstBarrio.TabIndex = 35;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // lblCantClienBar
            // 
            this.lblCantClienBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantClienBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClienBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantClienBar.Location = new System.Drawing.Point(639, 440);
            this.lblCantClienBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClienBar.Name = "lblCantClienBar";
            this.lblCantClienBar.Size = new System.Drawing.Size(113, 25);
            this.lblCantClienBar.TabIndex = 32;
            // 
            // lblPromedioBar
            // 
            this.lblPromedioBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromedioBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromedioBar.Location = new System.Drawing.Point(639, 409);
            this.lblPromedioBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioBar.Name = "lblPromedioBar";
            this.lblPromedioBar.Size = new System.Drawing.Size(113, 25);
            this.lblPromedioBar.TabIndex = 31;
            // 
            // lblTotalIngresosBar
            // 
            this.lblTotalIngresosBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalIngresosBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalIngresosBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresosBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalIngresosBar.Location = new System.Drawing.Point(639, 372);
            this.lblTotalIngresosBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresosBar.Name = "lblTotalIngresosBar";
            this.lblTotalIngresosBar.Size = new System.Drawing.Size(113, 25);
            this.lblTotalIngresosBar.TabIndex = 30;
            // 
            // lblPromIngreNom2
            // 
            this.lblPromIngreNom2.AutoSize = true;
            this.lblPromIngreNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngreNom2.Location = new System.Drawing.Point(448, 409);
            this.lblPromIngreNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromIngreNom2.Name = "lblPromIngreNom2";
            this.lblPromIngreNom2.Size = new System.Drawing.Size(177, 20);
            this.lblPromIngreNom2.TabIndex = 29;
            this.lblPromIngreNom2.Text = "Promedio de Ingresos:";
            // 
            // lblCantClienNom2
            // 
            this.lblCantClienNom2.AutoSize = true;
            this.lblCantClienNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienNom2.Location = new System.Drawing.Point(448, 445);
            this.lblCantClienNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClienNom2.Name = "lblCantClienNom2";
            this.lblCantClienNom2.Size = new System.Drawing.Size(169, 20);
            this.lblCantClienNom2.TabIndex = 28;
            this.lblCantClienNom2.Text = "Cantidad de Clientes:";
            // 
            // lblTotalIngresoNom2
            // 
            this.lblTotalIngresoNom2.AutoSize = true;
            this.lblTotalIngresoNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresoNom2.Location = new System.Drawing.Point(448, 372);
            this.lblTotalIngresoNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresoNom2.Name = "lblTotalIngresoNom2";
            this.lblTotalIngresoNom2.Size = new System.Drawing.Size(143, 20);
            this.lblTotalIngresoNom2.TabIndex = 27;
            this.lblTotalIngresoNom2.Text = "Total de Ingresos:";
            // 
            // cmdSalirBarrio
            // 
            this.cmdSalirBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirBarrio.Location = new System.Drawing.Point(452, 475);
            this.cmdSalirBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalirBarrio.Name = "cmdSalirBarrio";
            this.cmdSalirBarrio.Size = new System.Drawing.Size(115, 33);
            this.cmdSalirBarrio.TabIndex = 8;
            this.cmdSalirBarrio.Text = "Salir";
            this.cmdSalirBarrio.UseVisualStyleBackColor = true;
            this.cmdSalirBarrio.Click += new System.EventHandler(this.cmdSalirBarrio_Click);
            // 
            // cmdConsultaBarrio
            // 
            this.cmdConsultaBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultaBarrio.Location = new System.Drawing.Point(640, 475);
            this.cmdConsultaBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultaBarrio.Name = "cmdConsultaBarrio";
            this.cmdConsultaBarrio.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultaBarrio.TabIndex = 7;
            this.cmdConsultaBarrio.Text = "Consultar";
            this.cmdConsultaBarrio.UseVisualStyleBackColor = true;
            this.cmdConsultaBarrio.Click += new System.EventHandler(this.cmdConsultaBarrio_Click);
            // 
            // tabActividad
            // 
            this.tabActividad.Controls.Add(this.cmdImprimirAct);
            this.tabActividad.Controls.Add(this.cmdExportarAct);
            this.tabActividad.Controls.Add(this.lblActividad);
            this.tabActividad.Controls.Add(this.lstActividad);
            this.tabActividad.Controls.Add(this.lblCantCliAct);
            this.tabActividad.Controls.Add(this.lblPromedioAct);
            this.tabActividad.Controls.Add(this.lblTotalIngresosAct);
            this.tabActividad.Controls.Add(this.lblPromIngreNom3);
            this.tabActividad.Controls.Add(this.lblCantClieNom3);
            this.tabActividad.Controls.Add(this.lblTotalIngrNom3);
            this.tabActividad.Controls.Add(this.GrillaActividad);
            this.tabActividad.Controls.Add(this.cmdSalirActividad);
            this.tabActividad.Controls.Add(this.cmdConsultarActividad);
            this.tabActividad.Location = new System.Drawing.Point(4, 25);
            this.tabActividad.Margin = new System.Windows.Forms.Padding(4);
            this.tabActividad.Name = "tabActividad";
            this.tabActividad.Padding = new System.Windows.Forms.Padding(4);
            this.tabActividad.Size = new System.Drawing.Size(759, 517);
            this.tabActividad.TabIndex = 2;
            this.tabActividad.Text = "Actividad";
            this.tabActividad.UseVisualStyleBackColor = true;
            // 
            // cmdImprimirAct
            // 
            this.cmdImprimirAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimirAct.Location = new System.Drawing.Point(8, 374);
            this.cmdImprimirAct.Name = "cmdImprimirAct";
            this.cmdImprimirAct.Size = new System.Drawing.Size(115, 33);
            this.cmdImprimirAct.TabIndex = 43;
            this.cmdImprimirAct.Text = "Imprimir";
            this.cmdImprimirAct.UseVisualStyleBackColor = true;
            this.cmdImprimirAct.Click += new System.EventHandler(this.cmdImprimirAct_Click);
            // 
            // cmdExportarAct
            // 
            this.cmdExportarAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarAct.Location = new System.Drawing.Point(294, 374);
            this.cmdExportarAct.Name = "cmdExportarAct";
            this.cmdExportarAct.Size = new System.Drawing.Size(115, 33);
            this.cmdExportarAct.TabIndex = 41;
            this.cmdExportarAct.Text = "Exportar";
            this.cmdExportarAct.UseVisualStyleBackColor = true;
            this.cmdExportarAct.Click += new System.EventHandler(this.cmdExportarAct_Click);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(3, 16);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(77, 20);
            this.lblActividad.TabIndex = 38;
            this.lblActividad.Text = "Actividad";
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(106, 16);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(121, 24);
            this.lstActividad.TabIndex = 37;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // lblCantCliAct
            // 
            this.lblCantCliAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantCliAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantCliAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCliAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantCliAct.Location = new System.Drawing.Point(639, 440);
            this.lblCantCliAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantCliAct.Name = "lblCantCliAct";
            this.lblCantCliAct.Size = new System.Drawing.Size(113, 25);
            this.lblCantCliAct.TabIndex = 22;
            // 
            // lblPromedioAct
            // 
            this.lblPromedioAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromedioAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromedioAct.Location = new System.Drawing.Point(639, 409);
            this.lblPromedioAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioAct.Name = "lblPromedioAct";
            this.lblPromedioAct.Size = new System.Drawing.Size(113, 25);
            this.lblPromedioAct.TabIndex = 21;
            // 
            // lblTotalIngresosAct
            // 
            this.lblTotalIngresosAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalIngresosAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalIngresosAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresosAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalIngresosAct.Location = new System.Drawing.Point(639, 372);
            this.lblTotalIngresosAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresosAct.Name = "lblTotalIngresosAct";
            this.lblTotalIngresosAct.Size = new System.Drawing.Size(113, 25);
            this.lblTotalIngresosAct.TabIndex = 20;
            // 
            // lblPromIngreNom3
            // 
            this.lblPromIngreNom3.AutoSize = true;
            this.lblPromIngreNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngreNom3.Location = new System.Drawing.Point(448, 409);
            this.lblPromIngreNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromIngreNom3.Name = "lblPromIngreNom3";
            this.lblPromIngreNom3.Size = new System.Drawing.Size(177, 20);
            this.lblPromIngreNom3.TabIndex = 19;
            this.lblPromIngreNom3.Text = "Promedio de Ingresos:";
            // 
            // lblCantClieNom3
            // 
            this.lblCantClieNom3.AutoSize = true;
            this.lblCantClieNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClieNom3.Location = new System.Drawing.Point(448, 445);
            this.lblCantClieNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClieNom3.Name = "lblCantClieNom3";
            this.lblCantClieNom3.Size = new System.Drawing.Size(169, 20);
            this.lblCantClieNom3.TabIndex = 18;
            this.lblCantClieNom3.Text = "Cantidad de Clientes:";
            // 
            // lblTotalIngrNom3
            // 
            this.lblTotalIngrNom3.AutoSize = true;
            this.lblTotalIngrNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngrNom3.Location = new System.Drawing.Point(448, 372);
            this.lblTotalIngrNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngrNom3.Name = "lblTotalIngrNom3";
            this.lblTotalIngrNom3.Size = new System.Drawing.Size(143, 20);
            this.lblTotalIngrNom3.TabIndex = 17;
            this.lblTotalIngrNom3.Text = "Total de Ingresos:";
            // 
            // GrillaActividad
            // 
            this.GrillaActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIDSocioAct,
            this.columNomApellAct,
            this.columDireccionAct,
            this.columBarrioAct,
            this.columActividadAct,
            this.columTelefonoAct,
            this.columFechaInscipAct,
            this.columSaldoAct});
            this.GrillaActividad.Location = new System.Drawing.Point(0, 57);
            this.GrillaActividad.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaActividad.Name = "GrillaActividad";
            this.GrillaActividad.ReadOnly = true;
            this.GrillaActividad.RowHeadersVisible = false;
            this.GrillaActividad.RowHeadersWidth = 51;
            this.GrillaActividad.Size = new System.Drawing.Size(755, 306);
            this.GrillaActividad.TabIndex = 6;
            // 
            // columIDSocioAct
            // 
            this.columIDSocioAct.HeaderText = "ID Socio";
            this.columIDSocioAct.MinimumWidth = 6;
            this.columIDSocioAct.Name = "columIDSocioAct";
            this.columIDSocioAct.ReadOnly = true;
            this.columIDSocioAct.Width = 125;
            // 
            // columNomApellAct
            // 
            this.columNomApellAct.HeaderText = "Nombre y Apellido";
            this.columNomApellAct.MinimumWidth = 6;
            this.columNomApellAct.Name = "columNomApellAct";
            this.columNomApellAct.ReadOnly = true;
            this.columNomApellAct.Width = 125;
            // 
            // columDireccionAct
            // 
            this.columDireccionAct.HeaderText = "Direccion";
            this.columDireccionAct.MinimumWidth = 6;
            this.columDireccionAct.Name = "columDireccionAct";
            this.columDireccionAct.ReadOnly = true;
            this.columDireccionAct.Width = 125;
            // 
            // columBarrioAct
            // 
            this.columBarrioAct.HeaderText = "Barrio";
            this.columBarrioAct.MinimumWidth = 6;
            this.columBarrioAct.Name = "columBarrioAct";
            this.columBarrioAct.ReadOnly = true;
            this.columBarrioAct.Width = 125;
            // 
            // columActividadAct
            // 
            this.columActividadAct.HeaderText = "Actividad";
            this.columActividadAct.MinimumWidth = 6;
            this.columActividadAct.Name = "columActividadAct";
            this.columActividadAct.ReadOnly = true;
            this.columActividadAct.Width = 125;
            // 
            // columTelefonoAct
            // 
            this.columTelefonoAct.HeaderText = "Telefono";
            this.columTelefonoAct.MinimumWidth = 6;
            this.columTelefonoAct.Name = "columTelefonoAct";
            this.columTelefonoAct.ReadOnly = true;
            this.columTelefonoAct.Width = 125;
            // 
            // columFechaInscipAct
            // 
            this.columFechaInscipAct.HeaderText = "Fecha de Inscripcion";
            this.columFechaInscipAct.MinimumWidth = 6;
            this.columFechaInscipAct.Name = "columFechaInscipAct";
            this.columFechaInscipAct.ReadOnly = true;
            this.columFechaInscipAct.Width = 125;
            // 
            // columSaldoAct
            // 
            this.columSaldoAct.HeaderText = "Saldo";
            this.columSaldoAct.MinimumWidth = 6;
            this.columSaldoAct.Name = "columSaldoAct";
            this.columSaldoAct.ReadOnly = true;
            this.columSaldoAct.Width = 125;
            // 
            // cmdSalirActividad
            // 
            this.cmdSalirActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirActividad.Location = new System.Drawing.Point(452, 475);
            this.cmdSalirActividad.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalirActividad.Name = "cmdSalirActividad";
            this.cmdSalirActividad.Size = new System.Drawing.Size(115, 33);
            this.cmdSalirActividad.TabIndex = 8;
            this.cmdSalirActividad.Text = "Salir";
            this.cmdSalirActividad.UseVisualStyleBackColor = true;
            this.cmdSalirActividad.Click += new System.EventHandler(this.cmdSalirActividad_Click);
            // 
            // cmdConsultarActividad
            // 
            this.cmdConsultarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarActividad.Location = new System.Drawing.Point(640, 475);
            this.cmdConsultarActividad.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultarActividad.Name = "cmdConsultarActividad";
            this.cmdConsultarActividad.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultarActividad.TabIndex = 7;
            this.cmdConsultarActividad.Text = "Consultar";
            this.cmdConsultarActividad.UseVisualStyleBackColor = true;
            this.cmdConsultarActividad.Click += new System.EventHandler(this.cmdConsultarActividad_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocument
            // 
            this.prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocument_PrintPage);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 545);
            this.Controls.Add(this.tabOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.tabOpciones.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            this.tabBarrio.ResumeLayout(false);
            this.tabBarrio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).EndInit();
            this.tabActividad.ResumeLayout(false);
            this.tabActividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdSalirCliente;
        private System.Windows.Forms.Button cmdConsultarCliente;
        private System.Windows.Forms.TabControl tabOpciones;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabBarrio;
        private System.Windows.Forms.Button cmdSalirBarrio;
        private System.Windows.Forms.Button cmdConsultaBarrio;
        private System.Windows.Forms.TabPage tabActividad;
        private System.Windows.Forms.DataGridView GrillaActividad;
        private System.Windows.Forms.Button cmdSalirActividad;
        private System.Windows.Forms.Button cmdConsultarActividad;
        private System.Windows.Forms.Label lblCantClienteCli;
        private System.Windows.Forms.Label lblPromedioCli;
        private System.Windows.Forms.Label lblTotalIngresosCli;
        private System.Windows.Forms.Label lblPromIngresoNom;
        private System.Windows.Forms.Label lblCantClienteNom;
        private System.Windows.Forms.Label lblTotalIngresoNom;
        private System.Windows.Forms.Label lblCantClienBar;
        private System.Windows.Forms.Label lblPromedioBar;
        private System.Windows.Forms.Label lblTotalIngresosBar;
        private System.Windows.Forms.Label lblPromIngreNom2;
        private System.Windows.Forms.Label lblCantClienNom2;
        private System.Windows.Forms.Label lblTotalIngresoNom2;
        private System.Windows.Forms.Label lblCantCliAct;
        private System.Windows.Forms.Label lblPromedioAct;
        private System.Windows.Forms.Label lblTotalIngresosAct;
        private System.Windows.Forms.Label lblPromIngreNom3;
        private System.Windows.Forms.Label lblCantClieNom3;
        private System.Windows.Forms.Label lblTotalIngrNom3;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DataGridView GrillaBarrio;
        private System.Windows.Forms.Button cmdImprimirCli;
        private System.Windows.Forms.Button cmdExportarCli;
        private System.Windows.Forms.Button cmdImprimirBar;
        private System.Windows.Forms.Button cmdExportarBar;
        private System.Windows.Forms.Button cmdImprimirAct;
        private System.Windows.Forms.Button cmdExportarAct;
        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIDSocioCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNomApellCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDireccCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columBarrioCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columActivCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTelefonoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columFechaInscripCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columSaldoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIDSocioBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNomApellBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDireccionBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columBarrioBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columActividadBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTelefonoBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columFechaInscripBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columSaldoBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIDSocioAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNomApellAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDireccionAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columBarrioAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columActividadAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTelefonoAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columFechaInscipAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columSaldoAct;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocument;
    }
}