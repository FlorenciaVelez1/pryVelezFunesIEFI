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
        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente Registrar = new frmRegistrarCliente();
            Registrar.ShowDialog();
        }
        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente BuscarCliente = new frmBuscarCliente();
            BuscarCliente.ShowDialog(); 
        }
        private void todosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes ListadoClientes = new frmListadoClientes();
            ListadoClientes.ShowDialog();
        }
        private void clientesDeudoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoDeudores ListadosDeudores = new frmListadoDeudores();
            ListadosDeudores.ShowDialog();
        }
        private void clientesPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesBarrio ListadoBarrio = new frmListadoClientesBarrio();
            ListadoBarrio.ShowDialog();
        }
    }
}
