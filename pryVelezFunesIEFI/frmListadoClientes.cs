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
            clsGimnasio GrillaLlenar = new clsGimnasio();
            GrillaLlenar.ListarGrilla(GrillaActividad, codActividad);
        }
    }
}
