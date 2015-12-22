using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbreteSesamo
{
    class Funcionalidades
    {
        private int monto;

        public int pMonto
        {
            set { monto = value; }
            get { return monto; }
        }


        public Funcionalidades()
        {
            monto = 0;
        }

        //public int Sumar(int monto)
        //{
        //    this.Sumar = monto;
        //}

        public override string ToString()
        {
            return "$ " + monto;
        }


        




    }
}
