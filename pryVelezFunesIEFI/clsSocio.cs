using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agrego lo systems que usare en el proyecto
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace pryVelezFunesIEFI
{
    internal class clsSocio
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:VelezBaseDatosIEFI.accdb";
        private string Tabla = "Socio";
        //Declaro de manera local las variables ( los campos el Add Socio)
        private Int32 IDSocio;
        private string NombreApellido;
        private string Direccion;
        private Int32 CodigoBarrio;
        private Int32 CodigoActividad;
        private Int32 Saldo;
        private Int32 Telefono;
        public Int32 SocioID
        {
            get { return IDSocio; }
            set { IDSocio = value; }
        }
        public string Nom_Apellido
        {
            get { return NombreApellido; }
            set { NombreApellido = value; }
        }
        public string DireccionSocio
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public Int32 CodBarrio
        {
            get { return CodigoBarrio; }
            set { CodigoBarrio = value; }
        }
        public Int32 CodActividad
        {
            get { return CodigoActividad; }
            set { CodigoActividad = value; }
        }
        public Int32 SaldoSocio
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public Int32 TelefonoSocio
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Socio ([ID Socio], [Nombre y Apellido], [Direccion], [Codigo Barrio], [Codigo Actividad], [Saldo], [Telefono])" +
                    "VALUES ('" + IDSocio + "','" + Nom_Apellido + "','" + DireccionSocio + "','" + CodBarrio + "','" + CodActividad + "','" + SaldoSocio + "','" + Telefono + "')";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se han podido registrar los datos.");
            }
        }
    }

}
