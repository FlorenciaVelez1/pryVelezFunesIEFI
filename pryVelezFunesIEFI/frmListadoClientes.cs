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
            ConsultaAct.ListarGrilla(GrillaActividad, codActividad);
            lblCantCliAct.Text = Convert.ToString(ConsultaAct.VarCantCliente);
            lblTotalIngresosAct.Text = Convert.ToString(ConsultaAct.VarTotalIngreso);
            lblPromedioAct.Text = Convert.ToString(ConsultaAct.VarPromedio);
        }
        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividad.SelectedIndex == -1)
            {
                cmdConsultarActividad.Enabled = false;
            }
            else
            {
                cmdConsultarActividad.Enabled=true;
            }
        }
        private void cmdImprimirAct_Click(object sender, EventArgs e)
        {

        }
        private void cmdExportarAct_Click(object sender, EventArgs e)
        {
            Int32 CodAct = Convert.ToInt32(lstActividad.SelectedValue);
            clsGimnasio ExportarAct = new clsGimnasio();
            ExportarAct.ExportarClientes(CodAct);
        }
    }
}
