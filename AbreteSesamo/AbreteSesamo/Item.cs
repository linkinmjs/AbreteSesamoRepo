using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbreteSesamo
{
    class Item
    {
        private int _id;
        private String _nombre;
        private int _precio;
        private int _cantidad;

        #region Properties
        public int id
        {
            set { this._id = value; }
            get { return this._id; }
        }

        public String nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }

        public int precio
        {
            set { this._precio = value; }
            get { return this._precio; }
        }

        public int cantidad
        {
            set { this._cantidad = value; }
            get { return this._cantidad; }
        }

        // Propiedad para formatear la forma en que se muestra el item por pantalla
        public String render
        {
            get { return this.nombre + " x" + this.cantidad; }
        }
        #endregion
    }
}
