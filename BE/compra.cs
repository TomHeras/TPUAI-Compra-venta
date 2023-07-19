using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class compra
    {
        private int idprov;

        public int Idprov
        {
            get { return idprov; }
            set { idprov = value; }
        }


        private int idprod;

        public int Idprod
        {
            get { return idprod; }
            set { idprod = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int cantidad;

        public int Cant
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public compra(int IDprov, int IDprod, DateTime fecha, int cantida)
        {
            idprov = IDprov;
            Idprod = IDprod;
            Fecha = fecha;
            Cant = cantida;
        }
    }
}
