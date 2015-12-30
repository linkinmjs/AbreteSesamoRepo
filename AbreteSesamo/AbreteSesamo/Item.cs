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
        private int _precio = 0;
        private int _cantidad;
        private int _categoria;

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
        public int categoria
        {
            set { this._categoria = value; }
            get { return this._categoria; }
        }



        public Item Copy()
        {
            return (Item)this.MemberwiseClone();
        }

        

        // Propiedad para formatear la forma en que se muestra el item por pantalla
        public string render
        {
            get
            {
                return this.nombre + " x" + this.cantidad;

            }

        }

        public string renderCategoria
        {
            get
            {
                return this.categoria == 0 ? "Trabajo" : "Insumo";

            }

        }
        #endregion

    }
}
