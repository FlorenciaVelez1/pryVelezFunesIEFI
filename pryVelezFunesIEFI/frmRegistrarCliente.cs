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
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpieza()
        {
            mskIDSocio.Text = "";
            txtNombreApellido.Text = "";
            txtDireccion.Text = "";
            txtBarrio.Text = "";
            lstActividad.SelectedIndex = -1;
            mskTelefono.Text = "";
            mskFecha.Text = "";
            lstFormaPago.SelectedIndex = -1;
            mskImporte.Text = "";
            mskIDSocio.Focus();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Conexion = new OleDbConnection();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                string Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:VelezBaseDatosIEFI.accdb";
                Conexion = new OleDbConnection(Ruta);
                Conexion.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido conectar a la base de datos");
            }
            cmdRegistrar.Enabled = false;
        }
        private void cmdRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
