using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbreteSesamo
{
    class Factura
    {
        private int _total;
        public List<Item> items = new List<Item>();

        public int total
        {
            set { this._total = value; }
            get
            {
                int importeTotal = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    importeTotal = items[i].precio * items[i].cantidad;
                }
                return importeTotal;

            }
        }


    }
}
