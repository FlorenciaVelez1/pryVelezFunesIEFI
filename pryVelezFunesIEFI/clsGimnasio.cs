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
    internal class clsGimnasio
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:VelezBaseDatosIEFI.accdb";
        private string Tabla = "Gimnasio";
        //Declaro de manera local las variables ( los campos el Add Socio)
        private Int32 varIDSocio;
        private string varNombreApellido;
        private string varDireccion;
        private Int32 varCodigoBarrio;
        private Int32 varCodigoActividad;
        private Int32 varTelefono;
        public Int32 SocioID
        {
            get { return varIDSocio; }
            set { varIDSocio = value; }
        }
        public string Nom_Apellido
        {
            get { return varNombreApellido; }
            set { varNombreApellido = value; }
        }
        public string DireccionSocio
        {
            get { return varDireccion; }
            set { varDireccion = value; }
        }
        public Int32 CodBarrio
        {
            get { return varCodigoBarrio; }
            set { varCodigoBarrio = value; }
        }
        public Int32 CodActividad
        {
            get { return varCodigoActividad; }
            set { varCodigoActividad = value; }
        }
        public Int32 TelefonoSocio
        {
            get { return varTelefono; }
            set { varTelefono = value; }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Gimnasio ([Nombre y Apellido], [Direccion], [Codigo Barrio], [Codigo Actividad], [Telefono])" +
                    "VALUES ('" + Nom_Apellido + "','" + DireccionSocio + "','" + CodBarrio + "','" + CodActividad + "','" + TelefonoSocio + "')";
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
        public void Buscar(string IDSocio)
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
                        if (Lector.GetString(0) == IDSocio)
                        {
                            varIDSocio = Lector.GetInt32(0);
                            varNombreApellido = Lector.GetString(1);
                            varDireccion = Lector.GetString(2);
                            varCodigoBarrio = Lector.GetInt32(3);
                            varCodigoActividad = int.Parse(Lector.GetString(4));
                            varTelefono = Lector.GetInt32(5);
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado el codigo del deportista");
            }
        }

    }

}
