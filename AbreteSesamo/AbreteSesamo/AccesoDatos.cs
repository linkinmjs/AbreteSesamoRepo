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
        private OleDbCommand comando;
        private OleDbDataReader dr;
        private string cadenaConexion; //= "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\\AbreteSesamo.mdb; User Id = admin; Password =;";
        private OleDbConnection conexion;
        private DataTable dt;

        public DataTable pDt
        {
            set { dt = value; }
            get { return dt; }
        }

        public OleDbCommand pComando
        {
            set { comando = value; }
            get { return comando; }
        }

        public OleDbDataReader pDr
        {
            set { dr = value; }
            get { return dr; }
        }

        public string pCadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public OleDbConnection pConexion
        {
            set { conexion = value; }
            get { return conexion; }
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

        public DataTable llenarListas(string categoria)
        {
            //categoria 0 = actividades / 1 = insumo
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = "select ID_Item, DES_Item, Precio from ITEMS where ID_Categoria = " + categoria;
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
