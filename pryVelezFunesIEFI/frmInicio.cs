using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVelezFunesIEFI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void tsmRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente Registrar = new frmRegistrarCliente();
            Registrar.ShowDialog();
        }
        private void tsmBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente BuscarCliente = new frmBuscarCliente();
            BuscarCliente.ShowDialog();
        }
        private void tsmClientes_Click(object sender, EventArgs e)
        {
            frmListadoClientes ListadoClientes = new frmListadoClientes();
            ListadoClientes.ShowDialog();
        }
        private void tsmClientesDeudores_Click(object sender, EventArgs e)
        {

            frmListadoDeudores ListadosDeudores = new frmListadoDeudores();
            ListadosDeudores.ShowDialog();
        }
        private void tsmInformacion_Click(object sender, EventArgs e)
        {
            frmInformacionCreador InfoCreador = new frmInformacionCreador();
            InfoCreador.ShowDialog();
        }
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
