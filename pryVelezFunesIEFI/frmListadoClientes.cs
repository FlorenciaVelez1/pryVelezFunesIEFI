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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            clsActividad LlenarLSTAct = new clsActividad();
            LlenarLSTAct.LlenarLst(lstActividad);
            clsBarrio LlenarLSTBar = new clsBarrio();
            LlenarLSTBar.LlenarLst(lstBarrio);
            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
        }
        private void cmdConsultarActividad_Click(object sender, EventArgs e)
        {
            Int32 codActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsGimnasio ConsultaAct = new clsGimnasio();
            ConsultaAct.ListarGrillaAct(GrillaActividad, codActividad);
            lblCantCliAct.Text = Convert.ToString(ConsultaAct.VarCantCliente);
            lblTotalIngresosAct.Text = Convert.ToString(ConsultaAct.VarTotalIngreso);
            lblPromedioAct.Text = Convert.ToString(((short)ConsultaAct.VarPromedio));
        }
        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividad.SelectedIndex == -1)
            {
                cmdConsultarActividad.Enabled = false;
                cmdExportarAct.Enabled = false;
                cmdImprimirAct.Enabled = false;
            }
            else
            {
                cmdConsultarActividad.Enabled = true;
                cmdExportarAct.Enabled = true;
                cmdImprimirAct.Enabled = true;
            }
        }
        private void cmdImprimirAct_Click(object sender, EventArgs e)
        {

        }
        private void cmdExportarAct_Click(object sender, EventArgs e)
        {
            Int32 CodAct = Convert.ToInt32(lstActividad.SelectedValue);
            clsGimnasio ExportarAct = new clsGimnasio();
            ExportarAct.ExportarClientesAct(CodAct);
        }
        private void cmdConsultaBarrio_Click(object sender, EventArgs e)
        {
            Int32 codBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            clsGimnasio ConsultaAct = new clsGimnasio();
            ConsultaAct.ListarGrillaBar(GrillaBar, codBarrio);
            lblCantClienBar.Text = Convert.ToString(ConsultaAct.VarCantCliente);
            lblTotalIngresosBar.Text = Convert.ToString(ConsultaAct.VarTotalIngreso);
            lblPromedioBar.Text = Convert.ToString(((short)ConsultaAct.VarPromedio));
        }
        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBarrio.SelectedIndex == -1)
            {
                cmdConsultaBarrio.Enabled = false;
                cmdImprimirBar.Enabled = false;
                cmdExportarBar.Enabled = false;
            }
            else
            {
                cmdConsultaBarrio.Enabled = true;
                cmdImprimirBar.Enabled = true;
                cmdExportarBar.Enabled = true;
            }
        }
        private void cmdConsultarCliente_Click(object sender, EventArgs e)
        {
            clsGimnasio ConsultaCli = new clsGimnasio();
            ConsultaCli.ListarGrillaClie(GrillaClientes);
            lblCantClienteCli.Text = Convert.ToString(ConsultaCli.VarCantCliente);
            lblTotalIngresosCli.Text = Convert.ToString(ConsultaCli.VarTotalIngreso);
            lblPromedioCli.Text = Convert.ToString(((short)ConsultaCli.VarPromedio));
        }

        private void cmdSalirActividad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdSalirBarrio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdExportarBar_Click(object sender, EventArgs e)
        {
            Int32 CodBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            clsGimnasio ExportarCliBarrio = new clsGimnasio();
            ExportarCliBarrio.ExportarClientesBar(CodBarrio);
        }
        private void cmdExportarCli_Click(object sender, EventArgs e)
        {
            clsGimnasio ExportarClientes = new clsGimnasio();
            ExportarClientes.ExportarClientes();
        }
    }
}
