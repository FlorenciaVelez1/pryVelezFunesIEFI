namespace pryVelezFunesIEFI
{
    partial class frmBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCliente));
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.mrcInformacion = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.mskImporte = new System.Windows.Forms.MaskedTextBox();
            this.lstFormaPago = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIDSocio = new System.Windows.Forms.Label();
            this.mskIDSocio = new System.Windows.Forms.MaskedTextBox();
            this.mrcInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(194, 465);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 39);
            this.cmdCancelar.TabIndex = 97;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 510);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(108, 39);
            this.cmdSalir.TabIndex = 94;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(366, 510);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 39);
            this.cmdGuardar.TabIndex = 93;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(130, 510);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(108, 39);
            this.cmdEliminar.TabIndex = 91;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(248, 510);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(108, 39);
            this.cmdModificar.TabIndex = 92;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(334, 16);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(132, 39);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // mrcInformacion
            // 
            this.mrcInformacion.Controls.Add(this.dtpFecha);
            this.mrcInformacion.Controls.Add(this.lstBarrio);
            this.mrcInformacion.Controls.Add(this.mskImporte);
            this.mrcInformacion.Controls.Add(this.lstFormaPago);
            this.mrcInformacion.Controls.Add(this.lblImporte);
            this.mrcInformacion.Controls.Add(this.lblFormaDePago);
            this.mrcInformacion.Controls.Add(this.txtDireccion);
            this.mrcInformacion.Controls.Add(this.lblActividad);
            this.mrcInformacion.Controls.Add(this.lblFechaInscripcion);
            this.mrcInformacion.Controls.Add(this.txtNombreApellido);
            this.mrcInformacion.Controls.Add(this.lstActividad);
            this.mrcInformacion.Controls.Add(this.lblBarrio);
            this.mrcInformacion.Controls.Add(this.lblNombreYApellido);
            this.mrcInformacion.Controls.Add(this.mskTelefono);
            this.mrcInformacion.Controls.Add(this.lblTelefono);
            this.mrcInformacion.Controls.Add(this.lblDireccion);
            this.mrcInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacion.Location = new System.Drawing.Point(12, 80);
            this.mrcInformacion.Name = "mrcInformacion";
            this.mrcInformacion.Size = new System.Drawing.Size(464, 405);
            this.mrcInformacion.TabIndex = 2;
            this.mrcInformacion.TabStop = false;
            this.mrcInformacion.Text = "Informacion Cliente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(182, 213);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(171, 22);
            this.dtpFecha.TabIndex = 98;
            this.dtpFecha.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(182, 128);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(265, 28);
            this.lstBarrio.TabIndex = 4;
            // 
            // mskImporte
            // 
            this.mskImporte.Location = new System.Drawing.Point(182, 341);
            this.mskImporte.Mask = "99999999";
            this.mskImporte.Name = "mskImporte";
            this.mskImporte.Size = new System.Drawing.Size(171, 27);
            this.mskImporte.TabIndex = 8;
            this.mskImporte.TextChanged += new System.EventHandler(this.mskImporte_TextChanged);
            // 
            // lstFormaPago
            // 
            this.lstFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstFormaPago.FormattingEnabled = true;
            this.lstFormaPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.lstFormaPago.Location = new System.Drawing.Point(182, 297);
            this.lstFormaPago.Name = "lstFormaPago";
            this.lstFormaPago.Size = new System.Drawing.Size(171, 28);
            this.lstFormaPago.TabIndex = 7;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(7, 339);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(70, 20);
            this.lblImporte.TabIndex = 88;
            this.lblImporte.Text = "Importe:";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(6, 297);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(132, 20);
            this.lblFormaDePago.TabIndex = 87;
            this.lblFormaDePago.Text = "Forma De Pago:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(182, 85);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(265, 27);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(9, 171);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(82, 20);
            this.lblActividad.TabIndex = 86;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscripcion.Location = new System.Drawing.Point(13, 213);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(146, 20);
            this.lblFechaInscripcion.TabIndex = 80;
            this.lblFechaInscripcion.Text = "Fecha Inscripcion:";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreApellido.Location = new System.Drawing.Point(182, 42);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreApellido.MaxLength = 60;
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.ShortcutsEnabled = false;
            this.txtNombreApellido.Size = new System.Drawing.Size(265, 27);
            this.txtNombreApellido.TabIndex = 2;
            this.txtNombreApellido.TextChanged += new System.EventHandler(this.txtNombreApellido_TextChanged);
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Actividad",
            "Musculación",
            "Crossfit",
            "Pilates",
            "Yoga",
            "Cardio",
            "Funcional"});
            this.lstActividad.Location = new System.Drawing.Point(182, 172);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(4);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(265, 28);
            this.lstActividad.TabIndex = 5;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(13, 129);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(60, 20);
            this.lblBarrio.TabIndex = 85;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreYApellido.Location = new System.Drawing.Point(8, 45);
            this.lblNombreYApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(150, 20);
            this.lblNombreYApellido.TabIndex = 82;
            this.lblNombreYApellido.Text = "Nombre y Apellido:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(182, 254);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(171, 27);
            this.mskTelefono.TabIndex = 6;
            this.mskTelefono.ValidatingType = typeof(int);
            this.mskTelefono.TextChanged += new System.EventHandler(this.mskTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(9, 255);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 20);
            this.lblTelefono.TabIndex = 84;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(9, 87);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 83;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblIDSocio
            // 
            this.lblIDSocio.AutoSize = true;
            this.lblIDSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSocio.Location = new System.Drawing.Point(18, 23);
            this.lblIDSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDSocio.Name = "lblIDSocio";
            this.lblIDSocio.Size = new System.Drawing.Size(87, 20);
            this.lblIDSocio.TabIndex = 95;
            this.lblIDSocio.Text = "ID Socio:";
            // 
            // mskIDSocio
            // 
            this.mskIDSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIDSocio.Location = new System.Drawing.Point(148, 23);
            this.mskIDSocio.Mask = "99999999";
            this.mskIDSocio.Name = "mskIDSocio";
            this.mskIDSocio.Size = new System.Drawing.Size(171, 27);
            this.mskIDSocio.TabIndex = 1;
            this.mskIDSocio.TextChanged += new System.EventHandler(this.mskIDSocio_TextChanged);
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 565);
            this.Controls.Add(this.mskIDSocio);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.mrcInformacion);
            this.Controls.Add(this.lblIDSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.mrcInformacion.ResumeLayout(false);
            this.mrcInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox mrcInformacion;
        private System.Windows.Forms.Label lblIDSocio;
        private System.Windows.Forms.MaskedTextBox mskImporte;
        private System.Windows.Forms.ComboBox lstFormaPago;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox mskIDSocio;
    }
}