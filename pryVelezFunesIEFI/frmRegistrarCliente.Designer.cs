namespace pryVelezFunesIEFI
{
    partial class frmRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarCliente));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcInformacion = new System.Windows.Forms.GroupBox();
            this.mskIDSocio = new System.Windows.Forms.MaskedTextBox();
            this.lblIDSocio = new System.Windows.Forms.Label();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.cmdAgregarBarrio = new System.Windows.Forms.Button();
            this.mskImporte = new System.Windows.Forms.MaskedTextBox();
            this.lstFormaPago = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.mrcInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 430);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(110, 38);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // mrcInformacion
            // 
            this.mrcInformacion.Controls.Add(this.mskIDSocio);
            this.mrcInformacion.Controls.Add(this.lblIDSocio);
            this.mrcInformacion.Controls.Add(this.lstBarrio);
            this.mrcInformacion.Controls.Add(this.cmdAgregarBarrio);
            this.mrcInformacion.Controls.Add(this.mskImporte);
            this.mrcInformacion.Controls.Add(this.lstFormaPago);
            this.mrcInformacion.Controls.Add(this.lblImporte);
            this.mrcInformacion.Controls.Add(this.lblFormaDePago);
            this.mrcInformacion.Controls.Add(this.mskFecha);
            this.mrcInformacion.Controls.Add(this.label1);
            this.mrcInformacion.Controls.Add(this.txtDireccion);
            this.mrcInformacion.Controls.Add(this.lblActividad);
            this.mrcInformacion.Controls.Add(this.txtNombreApellido);
            this.mrcInformacion.Controls.Add(this.lstActividad);
            this.mrcInformacion.Controls.Add(this.lblBarrio);
            this.mrcInformacion.Controls.Add(this.lblNombreYApellido);
            this.mrcInformacion.Controls.Add(this.mskTelefono);
            this.mrcInformacion.Controls.Add(this.lblTelefono);
            this.mrcInformacion.Controls.Add(this.lblDireccion);
            this.mrcInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacion.Location = new System.Drawing.Point(12, 12);
            this.mrcInformacion.Name = "mrcInformacion";
            this.mrcInformacion.Size = new System.Drawing.Size(414, 412);
            this.mrcInformacion.TabIndex = 0;
            this.mrcInformacion.TabStop = false;
            this.mrcInformacion.Text = "Informacion Cliente";
            // 
            // mskIDSocio
            // 
            this.mskIDSocio.Location = new System.Drawing.Point(186, 31);
            this.mskIDSocio.Margin = new System.Windows.Forms.Padding(4);
            this.mskIDSocio.Mask = "000000000";
            this.mskIDSocio.Name = "mskIDSocio";
            this.mskIDSocio.Size = new System.Drawing.Size(174, 27);
            this.mskIDSocio.TabIndex = 73;
            this.mskIDSocio.ValidatingType = typeof(int);
            // 
            // lblIDSocio
            // 
            this.lblIDSocio.AutoSize = true;
            this.lblIDSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSocio.Location = new System.Drawing.Point(12, 38);
            this.lblIDSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDSocio.Name = "lblIDSocio";
            this.lblIDSocio.Size = new System.Drawing.Size(73, 20);
            this.lblIDSocio.TabIndex = 72;
            this.lblIDSocio.Text = "ID Socio";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(186, 164);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(174, 28);
            this.lstBarrio.TabIndex = 3;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // cmdAgregarBarrio
            // 
            this.cmdAgregarBarrio.Location = new System.Drawing.Point(366, 164);
            this.cmdAgregarBarrio.Name = "cmdAgregarBarrio";
            this.cmdAgregarBarrio.Size = new System.Drawing.Size(36, 28);
            this.cmdAgregarBarrio.TabIndex = 71;
            this.cmdAgregarBarrio.Text = "+";
            this.cmdAgregarBarrio.UseVisualStyleBackColor = true;
            this.cmdAgregarBarrio.Click += new System.EventHandler(this.cmdAgregarBarrio_Click);
            // 
            // mskImporte
            // 
            this.mskImporte.Location = new System.Drawing.Point(186, 371);
            this.mskImporte.Mask = "99999";
            this.mskImporte.Name = "mskImporte";
            this.mskImporte.Size = new System.Drawing.Size(132, 27);
            this.mskImporte.TabIndex = 8;
            this.mskImporte.ValidatingType = typeof(int);
            this.mskImporte.TextChanged += new System.EventHandler(this.mskImporte_TextChanged);
            // 
            // lstFormaPago
            // 
            this.lstFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstFormaPago.FormattingEnabled = true;
            this.lstFormaPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.lstFormaPago.Location = new System.Drawing.Point(186, 332);
            this.lstFormaPago.Name = "lstFormaPago";
            this.lstFormaPago.Size = new System.Drawing.Size(132, 28);
            this.lstFormaPago.TabIndex = 7;
            this.lstFormaPago.SelectedIndexChanged += new System.EventHandler(this.lstFormaPago_SelectedIndexChanged);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(21, 377);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(70, 20);
            this.lblImporte.TabIndex = 70;
            this.lblImporte.Text = "Importe:";
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(20, 334);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(132, 20);
            this.lblFormaDePago.TabIndex = 69;
            this.lblFormaDePago.Text = "Forma De Pago:";
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(186, 291);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(132, 27);
            this.mskFecha.TabIndex = 6;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            this.mskFecha.TextChanged += new System.EventHandler(this.mskFecha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Inscripcion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(186, 121);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(216, 27);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(16, 205);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(82, 20);
            this.lblActividad.TabIndex = 67;
            this.lblActividad.Text = "Actividad:";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreApellido.Location = new System.Drawing.Point(186, 78);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreApellido.MaxLength = 50;
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.ShortcutsEnabled = false;
            this.txtNombreApellido.Size = new System.Drawing.Size(216, 27);
            this.txtNombreApellido.TabIndex = 1;
            this.txtNombreApellido.TextChanged += new System.EventHandler(this.txtNombreApellido_TextChanged);
            this.txtNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreApellido_KeyPress);
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
            this.lstActividad.Location = new System.Drawing.Point(186, 202);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(4);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(174, 28);
            this.lstActividad.TabIndex = 4;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(16, 164);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(60, 20);
            this.lblBarrio.TabIndex = 66;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreYApellido.Location = new System.Drawing.Point(12, 78);
            this.lblNombreYApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(150, 20);
            this.lblNombreYApellido.TabIndex = 62;
            this.lblNombreYApellido.Text = "Nombre y Apellido:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(186, 246);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(132, 27);
            this.mskTelefono.TabIndex = 5;
            this.mskTelefono.ValidatingType = typeof(int);
            this.mskTelefono.TextChanged += new System.EventHandler(this.mskTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(20, 248);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 20);
            this.lblTelefono.TabIndex = 65;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 121);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 64;
            this.lblDireccion.Text = "Direccion:";
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(165, 430);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(110, 38);
            this.cmdLimpiar.TabIndex = 10;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(318, 430);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(110, 38);
            this.cmdRegistrar.TabIndex = 11;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 494);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.mrcInformacion);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cliente";
            this.Load += new System.EventHandler(this.frmRegistrarCliente_Load);
            this.mrcInformacion.ResumeLayout(false);
            this.mrcInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.GroupBox mrcInformacion;
        private System.Windows.Forms.MaskedTextBox mskImporte;
        private System.Windows.Forms.ComboBox lstFormaPago;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Button cmdAgregarBarrio;
        private System.Windows.Forms.MaskedTextBox mskIDSocio;
        private System.Windows.Forms.Label lblIDSocio;
    }
}