using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
<<<<<<< HEAD
    public class compra
=======
<<<<<<< HEAD
    public class compra
=======
   public  class compra
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
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

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
        private int dvh;

        public int DVH
        {
            get { return dvh; }
            set { dvh = value; }
        }

<<<<<<< HEAD
=======
=======
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
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
