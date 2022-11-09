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
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.lblCantClienteCli = new System.Windows.Forms.Label();
            this.lblPromIngreCli = new System.Windows.Forms.Label();
            this.lbIngreClientT = new System.Windows.Forms.Label();
            this.lblPromIngresoNom = new System.Windows.Forms.Label();
            this.lblCantClienteNom = new System.Windows.Forms.Label();
            this.lblTotalIngresoNom = new System.Windows.Forms.Label();
            this.lblPromDeudaClient = new System.Windows.Forms.Label();
            this.lblTotalDeudaClien = new System.Windows.Forms.Label();
            this.lblPromedioDeudNom = new System.Windows.Forms.Label();
            this.lblTotalDeudaNom = new System.Windows.Forms.Label();
            this.tabBarrio = new System.Windows.Forms.TabPage();
            this.lblCantClienBar = new System.Windows.Forms.Label();
            this.lblPromIngreBar = new System.Windows.Forms.Label();
            this.lblTotalIngreBar = new System.Windows.Forms.Label();
            this.lblPromIngreNom2 = new System.Windows.Forms.Label();
            this.lblCantClienNom2 = new System.Windows.Forms.Label();
            this.lblTotalIngresoNom2 = new System.Windows.Forms.Label();
            this.lblPromDeuBar = new System.Windows.Forms.Label();
            this.lblTotalDeuBar = new System.Windows.Forms.Label();
            this.lblPromDeudaNom2 = new System.Windows.Forms.Label();
            this.lblTotalDeudaNom2 = new System.Windows.Forms.Label();
            this.GrillaBarrio = new System.Windows.Forms.DataGridView();
            this.cmdSalirBarrio = new System.Windows.Forms.Button();
            this.cmdConsultaBarrio = new System.Windows.Forms.Button();
            this.tabActividad = new System.Windows.Forms.TabPage();
            this.lblCantCliAct = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblPromIngreNom3 = new System.Windows.Forms.Label();
            this.lblCantClieNom3 = new System.Windows.Forms.Label();
            this.lblTotalIngrNom3 = new System.Windows.Forms.Label();
            this.lblPromDeuAct = new System.Windows.Forms.Label();
            this.lblTotalDeuAct = new System.Windows.Forms.Label();
            this.lblPromDeuNom3 = new System.Windows.Forms.Label();
            this.lblTotalDeuNom3 = new System.Windows.Forms.Label();
            this.GrillaActividad = new System.Windows.Forms.DataGridView();
            this.cmdSalirActividad = new System.Windows.Forms.Button();
            this.cmdConsultarActividad = new System.Windows.Forms.Button();
            this.lblCantDeuAct = new System.Windows.Forms.Label();
            this.lblCantDeuNom3 = new System.Windows.Forms.Label();
            this.lblCantDeuBar = new System.Windows.Forms.Label();
            this.lblCantDeuNom2 = new System.Windows.Forms.Label();
            this.lblCantDeuCli = new System.Windows.Forms.Label();
            this.lblCantDeuNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabBarrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).BeginInit();
            this.tabActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Location = new System.Drawing.Point(4, 8);
            this.GrillaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.RowHeadersWidth = 51;
            this.GrillaClientes.Size = new System.Drawing.Size(608, 351);
            this.GrillaClientes.TabIndex = 3;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(4, 479);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(115, 33);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(494, 479);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabBarrio);
            this.tabControl1.Controls.Add(this.tabActividad);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 560);
            this.tabControl1.TabIndex = 6;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.lblCantDeuCli);
            this.tabClientes.Controls.Add(this.lblCantDeuNom);
            this.tabClientes.Controls.Add(this.lblCantClienteCli);
            this.tabClientes.Controls.Add(this.lblPromIngreCli);
            this.tabClientes.Controls.Add(this.lbIngreClientT);
            this.tabClientes.Controls.Add(this.lblPromIngresoNom);
            this.tabClientes.Controls.Add(this.lblCantClienteNom);
            this.tabClientes.Controls.Add(this.lblTotalIngresoNom);
            this.tabClientes.Controls.Add(this.lblPromDeudaClient);
            this.tabClientes.Controls.Add(this.lblTotalDeudaClien);
            this.tabClientes.Controls.Add(this.lblPromedioDeudNom);
            this.tabClientes.Controls.Add(this.lblTotalDeudaNom);
            this.tabClientes.Controls.Add(this.GrillaClientes);
            this.tabClientes.Controls.Add(this.cmdSalir);
            this.tabClientes.Controls.Add(this.cmdConsultar);
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tabClientes.Size = new System.Drawing.Size(615, 531);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // lblCantClienteCli
            // 
            this.lblCantClienteCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantClienteCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClienteCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienteCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantClienteCli.Location = new System.Drawing.Point(494, 439);
            this.lblCantClienteCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClienteCli.Name = "lblCantClienteCli";
            this.lblCantClienteCli.Size = new System.Drawing.Size(113, 25);
            this.lblCantClienteCli.TabIndex = 32;
            // 
            // lblPromIngreCli
            // 
            this.lblPromIngreCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromIngreCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromIngreCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngreCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromIngreCli.Location = new System.Drawing.Point(494, 406);
            this.lblPromIngreCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromIngreCli.Name = "lblPromIngreCli";
            this.lblPromIngreCli.Size = new System.Drawing.Size(113, 25);
            this.lblPromIngreCli.TabIndex = 31;
            // 
            // lbIngreClientT
            // 
            this.lbIngreClientT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIngreClientT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIngreClientT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreClientT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbIngreClientT.Location = new System.Drawing.Point(494, 367);
            this.lbIngreClientT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIngreClientT.Name = "lbIngreClientT";
            this.lbIngreClientT.Size = new System.Drawing.Size(113, 25);
            this.lbIngreClientT.TabIndex = 30;
            // 
            // lblPromIngresoNom
            // 
            this.lblPromIngresoNom.AutoSize = true;
            this.lblPromIngresoNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngresoNom.Location = new System.Drawing.Point(312, 411);
            this.lblPromIngresoNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromIngresoNom.Name = "lblPromIngresoNom";
            this.lblPromIngresoNom.Size = new System.Drawing.Size(168, 20);
            this.lblPromIngresoNom.TabIndex = 29;
            this.lblPromIngresoNom.Text = "Promedio de Ingreso:";
            // 
            // lblCantClienteNom
            // 
            this.lblCantClienteNom.AutoSize = true;
            this.lblCantClienteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienteNom.Location = new System.Drawing.Point(312, 444);
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
            this.lblTotalIngresoNom.Location = new System.Drawing.Point(312, 372);
            this.lblTotalIngresoNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresoNom.Name = "lblTotalIngresoNom";
            this.lblTotalIngresoNom.Size = new System.Drawing.Size(143, 20);
            this.lblTotalIngresoNom.TabIndex = 27;
            this.lblTotalIngresoNom.Text = "Total de Ingresos:";
            // 
            // lblPromDeudaClient
            // 
            this.lblPromDeudaClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromDeudaClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeudaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeudaClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromDeudaClient.Location = new System.Drawing.Point(183, 406);
            this.lblPromDeudaClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeudaClient.Name = "lblPromDeudaClient";
            this.lblPromDeudaClient.Size = new System.Drawing.Size(113, 25);
            this.lblPromDeudaClient.TabIndex = 26;
            // 
            // lblTotalDeudaClien
            // 
            this.lblTotalDeudaClien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalDeudaClien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudaClien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeudaClien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeudaClien.Location = new System.Drawing.Point(183, 367);
            this.lblTotalDeudaClien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeudaClien.Name = "lblTotalDeudaClien";
            this.lblTotalDeudaClien.Size = new System.Drawing.Size(113, 25);
            this.lblTotalDeudaClien.TabIndex = 25;
            // 
            // lblPromedioDeudNom
            // 
            this.lblPromedioDeudNom.AutoSize = true;
            this.lblPromedioDeudNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDeudNom.Location = new System.Drawing.Point(1, 406);
            this.lblPromedioDeudNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioDeudNom.Name = "lblPromedioDeudNom";
            this.lblPromedioDeudNom.Size = new System.Drawing.Size(162, 20);
            this.lblPromedioDeudNom.TabIndex = 24;
            this.lblPromedioDeudNom.Text = "Promedio de Deuda:";
            // 
            // lblTotalDeudaNom
            // 
            this.lblTotalDeudaNom.AutoSize = true;
            this.lblTotalDeudaNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeudaNom.Location = new System.Drawing.Point(1, 372);
            this.lblTotalDeudaNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeudaNom.Name = "lblTotalDeudaNom";
            this.lblTotalDeudaNom.Size = new System.Drawing.Size(128, 20);
            this.lblTotalDeudaNom.TabIndex = 23;
            this.lblTotalDeudaNom.Text = "Total de Deuda:";
            // 
            // tabBarrio
            // 
            this.tabBarrio.Controls.Add(this.lblCantDeuBar);
            this.tabBarrio.Controls.Add(this.lblCantDeuNom2);
            this.tabBarrio.Controls.Add(this.lblCantClienBar);
            this.tabBarrio.Controls.Add(this.lblPromIngreBar);
            this.tabBarrio.Controls.Add(this.lblTotalIngreBar);
            this.tabBarrio.Controls.Add(this.lblPromIngreNom2);
            this.tabBarrio.Controls.Add(this.lblCantClienNom2);
            this.tabBarrio.Controls.Add(this.lblTotalIngresoNom2);
            this.tabBarrio.Controls.Add(this.lblPromDeuBar);
            this.tabBarrio.Controls.Add(this.lblTotalDeuBar);
            this.tabBarrio.Controls.Add(this.lblPromDeudaNom2);
            this.tabBarrio.Controls.Add(this.lblTotalDeudaNom2);
            this.tabBarrio.Controls.Add(this.GrillaBarrio);
            this.tabBarrio.Controls.Add(this.cmdSalirBarrio);
            this.tabBarrio.Controls.Add(this.cmdConsultaBarrio);
            this.tabBarrio.Location = new System.Drawing.Point(4, 25);
            this.tabBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.tabBarrio.Name = "tabBarrio";
            this.tabBarrio.Padding = new System.Windows.Forms.Padding(4);
            this.tabBarrio.Size = new System.Drawing.Size(615, 531);
            this.tabBarrio.TabIndex = 1;
            this.tabBarrio.Text = "Barrio";
            this.tabBarrio.UseVisualStyleBackColor = true;
            // 
            // lblCantClienBar
            // 
            this.lblCantClienBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantClienBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClienBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClienBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantClienBar.Location = new System.Drawing.Point(494, 439);
            this.lblCantClienBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClienBar.Name = "lblCantClienBar";
            this.lblCantClienBar.Size = new System.Drawing.Size(113, 25);
            this.lblCantClienBar.TabIndex = 32;
            // 
            // lblPromIngreBar
            // 
            this.lblPromIngreBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromIngreBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromIngreBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngreBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromIngreBar.Location = new System.Drawing.Point(494, 406);
            this.lblPromIngreBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromIngreBar.Name = "lblPromIngreBar";
            this.lblPromIngreBar.Size = new System.Drawing.Size(113, 25);
            this.lblPromIngreBar.TabIndex = 31;
            // 
            // lblTotalIngreBar
            // 
            this.lblTotalIngreBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalIngreBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalIngreBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngreBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalIngreBar.Location = new System.Drawing.Point(494, 367);
            this.lblTotalIngreBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngreBar.Name = "lblTotalIngreBar";
            this.lblTotalIngreBar.Size = new System.Drawing.Size(113, 25);
            this.lblTotalIngreBar.TabIndex = 30;
            // 
            // lblPromIngreNom2
            // 
            this.lblPromIngreNom2.AutoSize = true;
            this.lblPromIngreNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngreNom2.Location = new System.Drawing.Point(312, 411);
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
            this.lblCantClienNom2.Location = new System.Drawing.Point(312, 444);
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
            this.lblTotalIngresoNom2.Location = new System.Drawing.Point(312, 372);
            this.lblTotalIngresoNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngresoNom2.Name = "lblTotalIngresoNom2";
            this.lblTotalIngresoNom2.Size = new System.Drawing.Size(143, 20);
            this.lblTotalIngresoNom2.TabIndex = 27;
            this.lblTotalIngresoNom2.Text = "Total de Ingresos:";
            // 
            // lblPromDeuBar
            // 
            this.lblPromDeuBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromDeuBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromDeuBar.Location = new System.Drawing.Point(183, 406);
            this.lblPromDeuBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuBar.Name = "lblPromDeuBar";
            this.lblPromDeuBar.Size = new System.Drawing.Size(113, 25);
            this.lblPromDeuBar.TabIndex = 26;
            // 
            // lblTotalDeuBar
            // 
            this.lblTotalDeuBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalDeuBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuBar.Location = new System.Drawing.Point(183, 367);
            this.lblTotalDeuBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuBar.Name = "lblTotalDeuBar";
            this.lblTotalDeuBar.Size = new System.Drawing.Size(113, 25);
            this.lblTotalDeuBar.TabIndex = 25;
            // 
            // lblPromDeudaNom2
            // 
            this.lblPromDeudaNom2.AutoSize = true;
            this.lblPromDeudaNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeudaNom2.Location = new System.Drawing.Point(1, 406);
            this.lblPromDeudaNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeudaNom2.Name = "lblPromDeudaNom2";
            this.lblPromDeudaNom2.Size = new System.Drawing.Size(162, 20);
            this.lblPromDeudaNom2.TabIndex = 24;
            this.lblPromDeudaNom2.Text = "Promedio de Deuda:";
            // 
            // lblTotalDeudaNom2
            // 
            this.lblTotalDeudaNom2.AutoSize = true;
            this.lblTotalDeudaNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeudaNom2.Location = new System.Drawing.Point(1, 372);
            this.lblTotalDeudaNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeudaNom2.Name = "lblTotalDeudaNom2";
            this.lblTotalDeudaNom2.Size = new System.Drawing.Size(128, 20);
            this.lblTotalDeudaNom2.TabIndex = 23;
            this.lblTotalDeudaNom2.Text = "Total de Deuda:";
            // 
            // GrillaBarrio
            // 
            this.GrillaBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBarrio.Location = new System.Drawing.Point(4, 53);
            this.GrillaBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaBarrio.Name = "GrillaBarrio";
            this.GrillaBarrio.RowHeadersWidth = 51;
            this.GrillaBarrio.Size = new System.Drawing.Size(608, 306);
            this.GrillaBarrio.TabIndex = 6;
            // 
            // cmdSalirBarrio
            // 
            this.cmdSalirBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirBarrio.Location = new System.Drawing.Point(5, 477);
            this.cmdSalirBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalirBarrio.Name = "cmdSalirBarrio";
            this.cmdSalirBarrio.Size = new System.Drawing.Size(115, 33);
            this.cmdSalirBarrio.TabIndex = 8;
            this.cmdSalirBarrio.Text = "Salir";
            this.cmdSalirBarrio.UseVisualStyleBackColor = true;
            // 
            // cmdConsultaBarrio
            // 
            this.cmdConsultaBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultaBarrio.Location = new System.Drawing.Point(496, 477);
            this.cmdConsultaBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultaBarrio.Name = "cmdConsultaBarrio";
            this.cmdConsultaBarrio.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultaBarrio.TabIndex = 7;
            this.cmdConsultaBarrio.Text = "Consultar";
            this.cmdConsultaBarrio.UseVisualStyleBackColor = true;
            // 
            // tabActividad
            // 
            this.tabActividad.Controls.Add(this.lblCantDeuAct);
            this.tabActividad.Controls.Add(this.lblCantDeuNom3);
            this.tabActividad.Controls.Add(this.lblCantCliAct);
            this.tabActividad.Controls.Add(this.label21);
            this.tabActividad.Controls.Add(this.label22);
            this.tabActividad.Controls.Add(this.lblPromIngreNom3);
            this.tabActividad.Controls.Add(this.lblCantClieNom3);
            this.tabActividad.Controls.Add(this.lblTotalIngrNom3);
            this.tabActividad.Controls.Add(this.lblPromDeuAct);
            this.tabActividad.Controls.Add(this.lblTotalDeuAct);
            this.tabActividad.Controls.Add(this.lblPromDeuNom3);
            this.tabActividad.Controls.Add(this.lblTotalDeuNom3);
            this.tabActividad.Controls.Add(this.GrillaActividad);
            this.tabActividad.Controls.Add(this.cmdSalirActividad);
            this.tabActividad.Controls.Add(this.cmdConsultarActividad);
            this.tabActividad.Location = new System.Drawing.Point(4, 25);
            this.tabActividad.Margin = new System.Windows.Forms.Padding(4);
            this.tabActividad.Name = "tabActividad";
            this.tabActividad.Padding = new System.Windows.Forms.Padding(4);
            this.tabActividad.Size = new System.Drawing.Size(615, 531);
            this.tabActividad.TabIndex = 2;
            this.tabActividad.Text = "Actividad";
            this.tabActividad.UseVisualStyleBackColor = true;
            // 
            // lblCantCliAct
            // 
            this.lblCantCliAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantCliAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantCliAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCliAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantCliAct.Location = new System.Drawing.Point(495, 442);
            this.lblCantCliAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantCliAct.Name = "lblCantCliAct";
            this.lblCantCliAct.Size = new System.Drawing.Size(113, 25);
            this.lblCantCliAct.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(495, 409);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 25);
            this.label21.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(495, 370);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 25);
            this.label22.TabIndex = 20;
            // 
            // lblPromIngreNom3
            // 
            this.lblPromIngreNom3.AutoSize = true;
            this.lblPromIngreNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromIngreNom3.Location = new System.Drawing.Point(313, 414);
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
            this.lblCantClieNom3.Location = new System.Drawing.Point(313, 447);
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
            this.lblTotalIngrNom3.Location = new System.Drawing.Point(313, 375);
            this.lblTotalIngrNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngrNom3.Name = "lblTotalIngrNom3";
            this.lblTotalIngrNom3.Size = new System.Drawing.Size(143, 20);
            this.lblTotalIngrNom3.TabIndex = 17;
            this.lblTotalIngrNom3.Text = "Total de Ingresos:";
            // 
            // lblPromDeuAct
            // 
            this.lblPromDeuAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromDeuAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromDeuAct.Location = new System.Drawing.Point(184, 409);
            this.lblPromDeuAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuAct.Name = "lblPromDeuAct";
            this.lblPromDeuAct.Size = new System.Drawing.Size(113, 25);
            this.lblPromDeuAct.TabIndex = 16;
            // 
            // lblTotalDeuAct
            // 
            this.lblTotalDeuAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalDeuAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuAct.Location = new System.Drawing.Point(184, 370);
            this.lblTotalDeuAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuAct.Name = "lblTotalDeuAct";
            this.lblTotalDeuAct.Size = new System.Drawing.Size(113, 25);
            this.lblTotalDeuAct.TabIndex = 14;
            // 
            // lblPromDeuNom3
            // 
            this.lblPromDeuNom3.AutoSize = true;
            this.lblPromDeuNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuNom3.Location = new System.Drawing.Point(2, 409);
            this.lblPromDeuNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuNom3.Name = "lblPromDeuNom3";
            this.lblPromDeuNom3.Size = new System.Drawing.Size(162, 20);
            this.lblPromDeuNom3.TabIndex = 13;
            this.lblPromDeuNom3.Text = "Promedio de Deuda:";
            // 
            // lblTotalDeuNom3
            // 
            this.lblTotalDeuNom3.AutoSize = true;
            this.lblTotalDeuNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuNom3.Location = new System.Drawing.Point(2, 375);
            this.lblTotalDeuNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuNom3.Name = "lblTotalDeuNom3";
            this.lblTotalDeuNom3.Size = new System.Drawing.Size(128, 20);
            this.lblTotalDeuNom3.TabIndex = 11;
            this.lblTotalDeuNom3.Text = "Total de Deuda:";
            // 
            // GrillaActividad
            // 
            this.GrillaActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaActividad.Location = new System.Drawing.Point(3, 57);
            this.GrillaActividad.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaActividad.Name = "GrillaActividad";
            this.GrillaActividad.RowHeadersWidth = 51;
            this.GrillaActividad.Size = new System.Drawing.Size(608, 306);
            this.GrillaActividad.TabIndex = 6;
            // 
            // cmdSalirActividad
            // 
            this.cmdSalirActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirActividad.Location = new System.Drawing.Point(9, 483);
            this.cmdSalirActividad.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalirActividad.Name = "cmdSalirActividad";
            this.cmdSalirActividad.Size = new System.Drawing.Size(115, 33);
            this.cmdSalirActividad.TabIndex = 8;
            this.cmdSalirActividad.Text = "Salir";
            this.cmdSalirActividad.UseVisualStyleBackColor = true;
            // 
            // cmdConsultarActividad
            // 
            this.cmdConsultarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarActividad.Location = new System.Drawing.Point(493, 483);
            this.cmdConsultarActividad.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultarActividad.Name = "cmdConsultarActividad";
            this.cmdConsultarActividad.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultarActividad.TabIndex = 7;
            this.cmdConsultarActividad.Text = "Consultar";
            this.cmdConsultarActividad.UseVisualStyleBackColor = true;
            // 
            // lblCantDeuAct
            // 
            this.lblCantDeuAct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantDeuAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantDeuAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDeuAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantDeuAct.Location = new System.Drawing.Point(184, 442);
            this.lblCantDeuAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantDeuAct.Name = "lblCantDeuAct";
            this.lblCantDeuAct.Size = new System.Drawing.Size(113, 25);
            this.lblCantDeuAct.TabIndex = 24;
            // 
            // lblCantDeuNom3
            // 
            this.lblCantDeuNom3.AutoSize = true;
            this.lblCantDeuNom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDeuNom3.Location = new System.Drawing.Point(2, 442);
            this.lblCantDeuNom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantDeuNom3.Name = "lblCantDeuNom3";
            this.lblCantDeuNom3.Size = new System.Drawing.Size(158, 20);
            this.lblCantDeuNom3.TabIndex = 23;
            this.lblCantDeuNom3.Text = "Cantidad Deudores:";
            // 
            // lblCantDeuBar
            // 
            this.lblCantDeuBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantDeuBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantDeuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDeuBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantDeuBar.Location = new System.Drawing.Point(183, 440);
            this.lblCantDeuBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantDeuBar.Name = "lblCantDeuBar";
            this.lblCantDeuBar.Size = new System.Drawing.Size(113, 25);
            this.lblCantDeuBar.TabIndex = 34;
            // 
            // lblCantDeuNom2
            // 
            this.lblCantDeuNom2.AutoSize = true;
            this.lblCantDeuNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDeuNom2.Location = new System.Drawing.Point(4, 440);
            this.lblCantDeuNom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantDeuNom2.Name = "lblCantDeuNom2";
            this.lblCantDeuNom2.Size = new System.Drawing.Size(158, 20);
            this.lblCantDeuNom2.TabIndex = 33;
            this.lblCantDeuNom2.Text = "Cantidad Deudores:";
            // 
            // lblCantDeuCli
            // 
            this.lblCantDeuCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantDeuCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantDeuCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDeuCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantDeuCli.Location = new System.Drawing.Point(182, 440);
            this.lblCantDeuCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantDeuCli.Name = "lblCantDeuCli";
            this.lblCantDeuCli.Size = new System.Drawing.Size(113, 25);
            this.lblCantDeuCli.TabIndex = 34;
            // 
            // lblCantDeuNom
            // 
            this.lblCantDeuNom.AutoSize = true;
            this.lblCantDeuNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDeuNom.Location = new System.Drawing.Point(0, 440);
            this.lblCantDeuNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantDeuNom.Name = "lblCantDeuNom";
            this.lblCantDeuNom.Size = new System.Drawing.Size(158, 20);
            this.lblCantDeuNom.TabIndex = 33;
            this.lblCantDeuNom.Text = "Cantidad Deudores:";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 544);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.tabBarrio.ResumeLayout(false);
            this.tabBarrio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).EndInit();
            this.tabActividad.ResumeLayout(false);
            this.tabActividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabBarrio;
        private System.Windows.Forms.DataGridView GrillaBarrio;
        private System.Windows.Forms.Button cmdSalirBarrio;
        private System.Windows.Forms.Button cmdConsultaBarrio;
        private System.Windows.Forms.TabPage tabActividad;
        private System.Windows.Forms.DataGridView GrillaActividad;
        private System.Windows.Forms.Button cmdSalirActividad;
        private System.Windows.Forms.Button cmdConsultarActividad;
        private System.Windows.Forms.Label lblCantClienteCli;
        private System.Windows.Forms.Label lblPromIngreCli;
        private System.Windows.Forms.Label lbIngreClientT;
        private System.Windows.Forms.Label lblPromIngresoNom;
        private System.Windows.Forms.Label lblCantClienteNom;
        private System.Windows.Forms.Label lblTotalIngresoNom;
        private System.Windows.Forms.Label lblPromDeudaClient;
        private System.Windows.Forms.Label lblTotalDeudaClien;
        private System.Windows.Forms.Label lblPromedioDeudNom;
        private System.Windows.Forms.Label lblTotalDeudaNom;
        private System.Windows.Forms.Label lblCantClienBar;
        private System.Windows.Forms.Label lblPromIngreBar;
        private System.Windows.Forms.Label lblTotalIngreBar;
        private System.Windows.Forms.Label lblPromIngreNom2;
        private System.Windows.Forms.Label lblCantClienNom2;
        private System.Windows.Forms.Label lblTotalIngresoNom2;
        private System.Windows.Forms.Label lblPromDeuBar;
        private System.Windows.Forms.Label lblTotalDeuBar;
        private System.Windows.Forms.Label lblPromDeudaNom2;
        private System.Windows.Forms.Label lblTotalDeudaNom2;
        private System.Windows.Forms.Label lblCantCliAct;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblPromIngreNom3;
        private System.Windows.Forms.Label lblCantClieNom3;
        private System.Windows.Forms.Label lblTotalIngrNom3;
        private System.Windows.Forms.Label lblPromDeuAct;
        private System.Windows.Forms.Label lblTotalDeuAct;
        private System.Windows.Forms.Label lblPromDeuNom3;
        private System.Windows.Forms.Label lblTotalDeuNom3;
        private System.Windows.Forms.Label lblCantDeuCli;
        private System.Windows.Forms.Label lblCantDeuNom;
        private System.Windows.Forms.Label lblCantDeuBar;
        private System.Windows.Forms.Label lblCantDeuNom2;
        private System.Windows.Forms.Label lblCantDeuAct;
        private System.Windows.Forms.Label lblCantDeuNom3;
    }
}