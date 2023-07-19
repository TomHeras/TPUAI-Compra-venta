using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cotizacion
    {
        private int id_pedido;

        public int ID_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        private int idprov;

        public int ID_idprov
        {
            get { return idprov; }
            set { idprov = value; }
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

        private Double cotizacionb;

        public Double Cotizaciones
        {
            get { return cotizacionb; }
            set { cotizacionb = value; }
        }

    }
}
