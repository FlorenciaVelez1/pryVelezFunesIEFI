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
    internal class clsInscripcion
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:VelezBaseDatosIEFI.accdb";
        private string Tabla = "Inscripcion";
        //Declaro de manera local las variables ( los campos el Add Socio)
        private DateTime varFechaInscripcion;
        private Int32 varIDSocio;
        private string varFormaPago;
        private Int32 varSaldo;
        public DateTime Fecha_Inscripcion
        {
            get { return varFechaInscripcion; }
            set { varFechaInscripcion = value; }
        }
        public Int32 Id_Socio
        {
            get { return varIDSocio; }
            set { varIDSocio = value; }
        }
        public string Forma_Pago
        {
            get { return varFormaPago; }
            set { varFormaPago = value; }
        }
        public Int32 SaldoSocio
        {
            get { return varSaldo; }
            set { varSaldo = value; }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Inscripcion ([Fecha Inscripcion], [ID Socio], [Forma de Pago], [Saldo])" +
                    "VALUES ('" + Fecha_Inscripcion + "','" + Id_Socio + "','" + Forma_Pago + "','" + SaldoSocio + "')";
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
