using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AbreteSesamo
{
    class Factura
    {
        public BindingList<Item> items = new BindingList<Item>();

        public int total
        {
            get
            {
                int importeTotal = 0;
                for(int i = 0; i < items.Count(); i++)
                {
                    importeTotal += items[i].precio * items[i].cantidad;
                }
                return importeTotal;
            }
        }
    }
}