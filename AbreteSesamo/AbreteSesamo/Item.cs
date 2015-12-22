using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbreteSesamo
{
    class Item
    {
        private int _id, _cantidad, _precio;
        private string _nombre;

        public int id
        {
            set { this._id = value; }
            get { return this._id; }
        }
        public int cantidad
        {
            set { this._cantidad = value; }
            get { return this._cantidad; }
        }
        public int precio
        {
            set { this._precio = value; }
            get { return this._precio; }
        }
        public string nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }

        //propiedad para formatear la forma en que se visualizan las cosas por pantalla

        public string render
        {
            get { return this.nombre + " x" + this.cantidad; }
        }



    }
}
