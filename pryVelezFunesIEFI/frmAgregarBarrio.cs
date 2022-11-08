using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pryVelezFunesIEFI
{
    public partial class frmAgregarBarrio : Form
    {
        public frmAgregarBarrio()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsBarrio AgregarBarrio = new clsBarrio();
            AgregarBarrio.Buscar(txtAgregarBarrio.Text);
            if (AgregarBarrio.NomBarrio == txtAgregarBarrio.Text)
            {
                MessageBox.Show("El Barrio ya se encuentra registrado.");
                txtAgregarBarrio.Text = "";
            }
            else
            {
                MessageBox.Show("Se ha cargado correctamente el nuevo Barrio.");
                txtAgregarBarrio.Text = "";
            }
        }
        private void txtAgregarBarrio_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarBarrio.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
    }
}
