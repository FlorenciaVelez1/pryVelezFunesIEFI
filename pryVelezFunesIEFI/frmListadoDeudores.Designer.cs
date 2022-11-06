namespace pryVelezFunesIEFI
{
    partial class frmListadoDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeudores));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblInfoPromedioCliente = new System.Windows.Forms.Label();
            this.lblInfoCantCliente = new System.Windows.Forms.Label();
            this.lblInfoTotalDeuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(595, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(318, 452);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(115, 33);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(495, 452);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(314, 340);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(128, 20);
            this.lblTotalDeuda.TabIndex = 5;
            this.lblTotalDeuda.Text = "Total de Deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.Location = new System.Drawing.Point(314, 374);
            this.lblCantidadClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(169, 20);
            this.lblCantidadClientes.TabIndex = 6;
            this.lblCantidadClientes.Text = "Cantidad de Clientes:";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDeuda.Location = new System.Drawing.Point(314, 407);
            this.lblPromedioDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(162, 20);
            this.lblPromedioDeuda.TabIndex = 7;
            this.lblPromedioDeuda.Text = "Promedio de Deuda:";
            // 
            // lblInfoPromedioCliente
            // 
            this.lblInfoPromedioCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfoPromedioCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfoPromedioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPromedioCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoPromedioCliente.Location = new System.Drawing.Point(496, 407);
            this.lblInfoPromedioCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoPromedioCliente.Name = "lblInfoPromedioCliente";
            this.lblInfoPromedioCliente.Size = new System.Drawing.Size(113, 25);
            this.lblInfoPromedioCliente.TabIndex = 10;
            // 
            // lblInfoCantCliente
            // 
            this.lblInfoCantCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfoCantCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfoCantCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCantCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoCantCliente.Location = new System.Drawing.Point(496, 374);
            this.lblInfoCantCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoCantCliente.Name = "lblInfoCantCliente";
            this.lblInfoCantCliente.Size = new System.Drawing.Size(113, 25);
            this.lblInfoCantCliente.TabIndex = 9;
            // 
            // lblInfoTotalDeuda
            // 
            this.lblInfoTotalDeuda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfoTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfoTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTotalDeuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoTotalDeuda.Location = new System.Drawing.Point(496, 335);
            this.lblInfoTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoTotalDeuda.Name = "lblInfoTotalDeuda";
            this.lblInfoTotalDeuda.Size = new System.Drawing.Size(113, 25);
            this.lblInfoTotalDeuda.TabIndex = 8;
            // 
            // frmListadoDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 501);
            this.Controls.Add(this.lblInfoPromedioCliente);
            this.Controls.Add(this.lblInfoCantCliente);
            this.Controls.Add(this.lblInfoTotalDeuda);
            this.Controls.Add(this.lblPromedioDeuda);
            this.Controls.Add(this.lblCantidadClientes);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes Deudores";
            this.Load += new System.EventHandler(this.frmListadoDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblInfoPromedioCliente;
        private System.Windows.Forms.Label lblInfoCantCliente;
        private System.Windows.Forms.Label lblInfoTotalDeuda;
    }
}