using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Negocio
{
    public class Pedido_Cab
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

        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private DateTime fechagen;

        public DateTime Fechagen
        {
            get { return fechagen; }
            set { fechagen = value; }
        }

        private DateTime fechaact;

        public DateTime Fechaact
        {
            get { return fechaact; }
            set { fechaact = value; }
        }


    }
}
