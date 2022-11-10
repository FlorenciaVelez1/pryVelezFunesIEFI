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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDSOCIO = Convert.ToInt32(mskIDSocio.Text);
            //Llamo las clases para poder llenar los txt,msk y lst con la informacion correspondiente
            clsGimnasio BuscarCliente = new clsGimnasio();
            BuscarCliente.Buscar(IDSOCIO);
            clsInscripcion InformacionInscripcion = new clsInscripcion();
            InformacionInscripcion.Buscar(IDSOCIO);
            clsBarrio BarrioConsulta = new clsBarrio();
            BarrioConsulta.BuscarBarrio(BuscarCliente.CodBarrio);
            clsActividad ActConsulta = new clsActividad();
            ActConsulta.BuscarActividad(BuscarCliente.CodActividad);
            if (BuscarCliente.SocioID != IDSOCIO)
            {
                MessageBox.Show("El ID de Socio ingresado no se encuentra en la base de datos.");
            }
            else
            {
                txtNombreApellido.Text = BuscarCliente.Nom_Apellido;
                txtDireccion.Text = BuscarCliente.DireccionSocio;
                lstActividad.Text = Convert.ToString(ActConsulta.NomActividad);
                lstBarrio.Text = Convert.ToString(BarrioConsulta.NomBarrio);
                mskTelefono.Text = Convert.ToString(BuscarCliente.TelefonoSocio);
                lstFormaPago.Text = InformacionInscripcion.Forma_Pago;
                mskImporte.Text = Convert.ToString(InformacionInscripcion.SaldoSocio);
                dtpFecha.Text = Convert.ToString(InformacionInscripcion.Fecha_Inscripcion);
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdGuardar.Enabled = true;
                cmdModificar.Enabled = true;
                NoEditarTXT();
            }
        }
        private void NoEditarTXT()
        {
            txtNombreApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            lstBarrio.Enabled = false;
            lstActividad.Enabled = false;
            mskTelefono.ReadOnly = true;
            lstFormaPago.Enabled = false;
            mskImporte.ReadOnly = true;
            dtpFecha.Enabled = false;
        }
        private void Limpiar()
        {
            //Limpio los txt y lst
            mskIDSocio.Text = "";
            txtNombreApellido.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            mskTelefono.Text = "";
            lstFormaPago.SelectedIndex = -1;
            mskImporte.Text = "";
            dtpFecha.Text = "";
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            NoEditarTXT();
            mskIDSocio.Focus();
        }
        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdCancelar.Visible = false;
            NoEditarTXT();
            mskIDSocio.Focus();
            //Lleno las lst con la info que hay en los add
            clsBarrio CompletarLstBarrio = new clsBarrio();
            CompletarLstBarrio.LlenarLst(lstBarrio);
            clsActividad CompletarLstAct = new clsActividad();
            CompletarLstAct.LlenarLst(lstActividad);
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no uso
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdGuardar.Enabled = true;
            cmdCancelar.Visible = true;
            //Desabilito mskIdSocio
            mskIDSocio.ReadOnly = true;
            //Habilito los txt, msk y lst
            txtNombreApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            lstBarrio.Enabled = true;
            lstActividad.Enabled = true;
            mskTelefono.ReadOnly = false;
            lstFormaPago.Enabled = true;
            mskImporte.ReadOnly = false;
            dtpFecha.Enabled = true;
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            NoEditarTXT();
            //habilito  o no los botones
            cmdEliminar.Enabled = true;
            cmdModificar.Enabled = true;
            cmdBuscar.Enabled = true;
            cmdGuardar.Enabled = false;
            cmdCancelar.Visible = false;
            mskIDSocio.ReadOnly=false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int SocioID = Convert.ToInt32(mskIDSocio.Text);
            clsGimnasio ModificarCliente = new clsGimnasio();
            ModificarCliente.Nom_Apellido = txtNombreApellido.Text;
            ModificarCliente.DireccionSocio = txtDireccion.Text;
            ModificarCliente.CodBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            ModificarCliente.CodActividad = Convert.ToInt32(lstActividad.SelectedValue);
            ModificarCliente.TelefonoSocio = Convert.ToInt32(mskTelefono.Text);
            ModificarCliente.Modificar(SocioID);
            clsInscripcion ModificarInscripcion = new clsInscripcion();
            ModificarInscripcion.Fecha_Inscripcion = dtpFecha.Text;
            ModificarInscripcion.Forma_Pago = lstFormaPago.Text;
            ModificarInscripcion.SaldoSocio = Convert.ToDecimal(mskImporte.Text);
            ModificarInscripcion.Modificar(SocioID);
            MessageBox.Show("La informacion ha sido modificada exitosamente.");
            Limpiar();
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 IDSOCIO = Convert.ToInt32(mskIDSocio.Text);
            clsGimnasio EliminarCliente = new clsGimnasio();
            EliminarCliente.Eliminar(IDSOCIO);
            clsInscripcion EliminarInscripcion = new clsInscripcion();
            EliminarInscripcion.Eliminar(IDSOCIO);
            MessageBox.Show("Datos borrados con exito");
            Limpiar();
        }
        private void mskIDSocio_TextChanged(object sender, EventArgs e)
        {
            if (mskIDSocio.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }
        private void Chequeo()
        {
            if (txtNombreApellido.Text != "" & txtDireccion.Text != "" & mskTelefono.Text != "" & mskImporte.Text != ""  )
            {
                cmdGuardar.Enabled = true ;
            }
            else
            {
                cmdGuardar.Enabled= false;
            }
        }
        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskImporte_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskTelefono_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
    }
}
