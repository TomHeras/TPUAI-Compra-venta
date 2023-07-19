using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Negocio
{
    public class Carrito
    {


        private int idcl;

        public int Idcl
        {
            get { return idcl; }
            set { idcl = value; }
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

        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        public Carrito( int IDcl, int IDprod, DateTime fecha,  int cantida, double costo)
        {
            //Idped = IDpedido;
            idcl = IDcl;
            Idprod = IDprod;
            Fecha = fecha;
            Cant = cantida;
            costo = Costo;
        }

        
    }
}
