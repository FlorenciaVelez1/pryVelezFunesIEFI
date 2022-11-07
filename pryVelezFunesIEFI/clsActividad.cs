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
    internal class clsActividad
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:VelezBaseDatosIEFI.accdb";
        private string Tabla = "Actividad";
        //Declaro de manera local las variables 
        private Int32 varCodigoAct;
        private string varActividad;
        public Int32 CodigoActividad
        {
            get { return varCodigoAct; }
            set { varCodigoAct = value; }
        }
        public string NomActividad
        {
            get { return varActividad; }
            set { varActividad = value; }
        }
        public void LlenarLst(ComboBox lstActividad)
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
            lstActividad.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            lstActividad.DisplayMember = "Actividad";
            //Dato que no se veria
            lstActividad.ValueMember = "Codigo";
            Conexion.Close();
        }
    }
}
