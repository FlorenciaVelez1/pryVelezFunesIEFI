﻿using System;
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
            txtNombreApellido.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            mskTelefono.Text = "";
            mskFecha.Text = "";
            lstFormaPago.SelectedIndex = -1;
            mskImporte.Text = "";
            txtNombreApellido.Focus();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            //Lleno las lst con la info que hay en los add
            clsBarrio CompletarLstBarrio = new clsBarrio();
            CompletarLstBarrio.LlenarLst(lstBarrio);
            clsActividad CompletarLstAct = new clsActividad();
            CompletarLstAct.LlenarLst(lstActividad);
            //Cancelo el cmdRegistrar
            cmdRegistrar.Enabled = false;
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
            clsGimnasio RegistroCliente = new clsGimnasio();
            RegistroCliente.Nom_Apellido = txtNombreApellido.Text;
            RegistroCliente.DireccionSocio = txtDireccion.Text;
            RegistroCliente.TelefonoSocio = Convert.ToInt32(mskTelefono.Text);
            RegistroCliente.CodBarrio = Convert.ToInt32( lstBarrio.SelectedValue);
            RegistroCliente.CodActividad = Convert.ToInt32(lstActividad.SelectedValue);
            RegistroCliente.Agregar();
            //Llamo la clase inscripcion para agregar los datos
            clsInscripcion AgregadoInformacion = new clsInscripcion();
            AgregadoInformacion.Fecha_Inscripcion = Convert.ToDateTime(mskFecha.Text);
            AgregadoInformacion.Forma_Pago = Convert.ToString(lstFormaPago.SelectedItem);
            AgregadoInformacion.SaldoSocio = Convert.ToInt32(mskImporte.Text);
            AgregadoInformacion.Agregar();
            Limpieza();
        }
        private void cmdAgregarBarrio_Click(object sender, EventArgs e)
        {
            frmAgregarBarrio AgregarBarrio = new frmAgregarBarrio();
            AgregarBarrio.ShowDialog();
        }
        private void Chequeo()
        {
            if (txtNombreApellido.Text != "" & txtDireccion.Text != "" & lstBarrio.SelectedIndex >= 0 & lstActividad.SelectedIndex >= 0 & mskTelefono.Text != "" & mskFecha.Text != "" & lstFormaPago.SelectedIndex >= 0 & mskImporte.Text != "")
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;
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
        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskTelefono_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskFecha_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void lstFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskImporte_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
    }

}
