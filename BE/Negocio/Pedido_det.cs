using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Negocio
{
    public class Pedido_det
    {

        private int id_pedido;

        public int ID_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        private int id_clientes;

        public int ID_clientes
        {
            get { return id_clientes; }
            set { id_clientes = value; }
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
            get { return cantidad; }
            set { cantidad = value; }
        }

        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        private int dvh;

        public int DVH
        {
            get { return dvh; }
            set { dvh = value; }
        }


    }
}
