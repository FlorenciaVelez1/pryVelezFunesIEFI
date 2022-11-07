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
    internal class clsBarrio
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:VelezBaseDatosIEFI.accdb";
        private string Tabla = "Barrio";
        //Declaro de manera local las variables
        private Int32 varCodigo;
        private string varBarrio;
        public Int32 BarrioCodigo
        {
            get { return varCodigo; }
            set { varCodigo = value; }
        }
        public string NomBarrio
        {
            get { return varBarrio; }
            set { varBarrio = value; }
        }
        public void LlenarLst(ComboBox lstBarrio)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = Tabla;
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            lstBarrio.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            lstBarrio.DisplayMember = "Barrio";
            //Dato que no se veria
            lstBarrio.ValueMember = "Codigo";
            Conexion.Close();
        }
        public void Buscar(Int32 BarrioNombre)
        {
            //Creo variable bandera para verificar que no exista el barrio
            Boolean VarBandera = false;
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
                    if (Lector.GetInt32(1) == BarrioNombre)
                    {
                            MessageBox.Show("El barrio ya existe en el sistema.");

                    }
                }
            }
            Conexion.Close();
        }
    }
}
