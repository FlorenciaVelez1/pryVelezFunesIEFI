namespace pryVelezFunesIEFI
{
    partial class frmInformacionCreador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionCreador));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreCreador = new System.Windows.Forms.Label();
            this.lblApellidoCreador = new System.Windows.Forms.Label();
            this.lblCorreoCreador = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(12, 87);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 16);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombreCreador
            // 
            this.lblNombreCreador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCreador.Location = new System.Drawing.Point(74, 14);
            this.lblNombreCreador.Name = "lblNombreCreador";
            this.lblNombreCreador.Size = new System.Drawing.Size(185, 23);
            this.lblNombreCreador.TabIndex = 3;
            this.lblNombreCreador.Text = "Maria Florencia";
            // 
            // lblApellidoCreador
            // 
            this.lblApellidoCreador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellidoCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCreador.Location = new System.Drawing.Point(74, 49);
            this.lblApellidoCreador.Name = "lblApellidoCreador";
            this.lblApellidoCreador.Size = new System.Drawing.Size(185, 23);
            this.lblApellidoCreador.TabIndex = 4;
            this.lblApellidoCreador.Text = "Velez Funes";
            // 
            // lblCorreoCreador
            // 
            this.lblCorreoCreador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorreoCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoCreador.Location = new System.Drawing.Point(74, 84);
            this.lblCorreoCreador.Name = "lblCorreoCreador";
            this.lblCorreoCreador.Size = new System.Drawing.Size(185, 23);
            this.lblCorreoCreador.TabIndex = 5;
            this.lblCorreoCreador.Text = "florenciavelez8@gmail.com";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(184, 112);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmInformacionCreador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lblCorreoCreador);
            this.Controls.Add(this.lblApellidoCreador);
            this.Controls.Add(this.lblNombreCreador);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformacionCreador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Creador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreCreador;
        private System.Windows.Forms.Label lblApellidoCreador;
        private System.Windows.Forms.Label lblCorreoCreador;
        private System.Windows.Forms.Button cmdVolver;
    }
}