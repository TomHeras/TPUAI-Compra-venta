using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Maestros
{
    public class Precios
    {
        private int idprod;

        public int Idprod
        {
            get { return idprod; }
            set { idprod = value; }
        }

        private string detalles;

        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private double medidas;

        public double Medidas
        {
            get { return medidas; }
            set { medidas = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
