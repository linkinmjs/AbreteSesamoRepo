using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace AbreteSesamo
{
    class AccesoDatos
    {
        private OleDbCommand _comando;
        private OleDbDataReader _dr;
        private string _cadenaConexion; //= "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\AbreteSesamo.mdb; User Id = admin; Password =;";
        private OleDbConnection _conexion;
        private DataTable _dt;

        public DataTable dt
        {
            set { _dt = value; }
            get { return _dt; }
        }

        public OleDbCommand comando
        {
            set { _comando = value; }
            get { return _comando; }
        }

        public OleDbDataReader dr
        {
            set { _dr = value; }
            get { return _dr; }
        }

        public string cadenaConexion
        {
            set { _cadenaConexion = value; }
            get { return _cadenaConexion; }
        }

        public OleDbConnection conexion
        {
            set { _conexion = value; }
            get { return _conexion; }
        }



        public AccesoDatos(string cadenaConexion)
        {
            //cadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\AbreteSesamo.mdb; User Id = admin; Password =;";
            conexion = new OleDbConnection(cadenaConexion);
            comando = new OleDbCommand();
        }

        public void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            conexion.Close();
        }

        public DataTable llenarListas()
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = "select ID_Item, DES_Item, Precio, ID_Categoria from ITEMS";
            dt.Load(comando.ExecuteReader());

            return dt;
        }

        public DataTable obtenerMonto(string nombreItem)
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = "select Precio from ITEMS where DES_Item = " + nombreItem;
            dt.Load(comando.ExecuteReader());

            return dt;
        }

         
    }

}
