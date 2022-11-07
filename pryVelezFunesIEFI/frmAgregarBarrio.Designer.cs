namespace pryVelezFunesIEFI
{
    partial class frmAgregarBarrio
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
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.txtAgregarBarrio = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarBarrio.Location = new System.Drawing.Point(21, 34);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(55, 20);
            this.lblAgregarBarrio.TabIndex = 0;
            this.lblAgregarBarrio.Text = "Barrio";
            // 
            // txtAgregarBarrio
            // 
            this.txtAgregarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarBarrio.Location = new System.Drawing.Point(103, 31);
            this.txtAgregarBarrio.Name = "txtAgregarBarrio";
            this.txtAgregarBarrio.Size = new System.Drawing.Size(171, 27);
            this.txtAgregarBarrio.TabIndex = 1;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(164, 81);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(110, 38);
            this.cmdAgregar.TabIndex = 16;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(25, 81);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(110, 38);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // frmAgregarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 134);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtAgregarBarrio);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "frmAgregarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Barrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarBarrio;
        private System.Windows.Forms.TextBox txtAgregarBarrio;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdSalir;
    }
}