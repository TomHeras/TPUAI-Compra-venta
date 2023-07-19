using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PedidoReport
    {

        public int IDPedido { get; set; }
        public string Proveedor { get; set; }
        public string Tipo { get; set; }
        public string Medidas { get; set; }
        public int Cantidad { get; set; }
        public decimal Cotizacion { get; set; }
        public string Estado { get; set; }

    }
}
