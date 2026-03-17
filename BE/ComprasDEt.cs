using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ComprasDEt
    {
        private int id_pedido;

        public int ID_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        private int id_prov;
<<<<<<< HEAD
        private int dvh;

        public int DVH
        {
            get { return dvh; }
            set { dvh = value; }
        }
=======
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8

        public int ID_prov
        {
            get { return id_prov; }
            set { id_prov = value; }
        }


        private int id_producto;

        public int ID_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        private int cantidad;

        public int Cantidad
        {
<<<<<<< HEAD
            get { return cantidad; }
=======
            get     { return cantidad; }
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            set { cantidad = value; }
        }

        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
    }
}
