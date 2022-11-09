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
        private string varFechaInscripcion;
        private Int32 varIDSocio;
        private string varFormaPago;
        private decimal varSaldo;
        public string Fecha_Inscripcion
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
        public decimal SaldoSocio
        {
            get { return varSaldo; }
            set { varSaldo = value; }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Inscripcion ([ID Socio],[Fecha Inscripcion], [Forma de Pago], [Saldo])" +
                    "VALUES ('" + Id_Socio + "','" + Fecha_Inscripcion + "','" + Forma_Pago + "','" + SaldoSocio + "')";
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
        public void Buscar(Int32 IDSocio)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Recibe el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay filas que leer entra en el "si"
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(1) == IDSocio)
                        {
                            Fecha_Inscripcion =Lector.GetDateTime(0).ToString("dd/MM/yyyy");
                            Id_Socio = Lector.GetInt32(1);
                            Forma_Pago = Lector.GetString(2);
                            SaldoSocio = Lector.GetDecimal (3);
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado el ID del socio");
            }
        }
        public void Modificar(Int32 IDSOCIO)
        {
            try
            {
                string Sql = "UPDATE Inscripcion SET [Fecha Inscripcion]= " + Fecha_Inscripcion + ", [Forma de Pago]= '" + Forma_Pago + "', [Saldo]=" + SaldoSocio + " WHERE [ID Socio] = " + IDSOCIO + "";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();

            }
            catch(Exception)
            {
                MessageBox.Show("No se ha podido modificar la informacion.");
            }
        }
        public void Eliminar(Int32 IDSOCIO)
        {
            try
            {
                string Sql = "DELETE FROM Gimnasio WHERE (" + IDSOCIO + "= [ID Socio])";
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
                MessageBox.Show("No se ha podido eliminar el cliente completamente");
            }
        }
    }
}
