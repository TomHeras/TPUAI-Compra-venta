using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
   public class Pedidos
    {
        DAL.Negocio.pedidos mapper = new DAL.Negocio.pedidos();

        public string Generarcab(BE.Negocio.Pedido_Cab cab)
        {
            string fa;
            fa = mapper.Cargarcabecera(cab);

            return fa;
        }

        public string Cargardet(BE.Negocio.Pedido_det detalle)
        {
            string fa;
            fa = mapper.Cargardetalle(detalle);

            return fa;

        }

        public string editarestado(BE.Negocio.Pedido_Cab cab)
        {
            string fa;
            fa = mapper.Editarestado(cab);

            return fa;
        }

        public List<BE.Negocio.Pedido_Cab> listarcabecera()
        {
            List<BE.Negocio.Pedido_Cab> cab = mapper.listcab();
            return cab;
        }

        public List<BE.Negocio.Pedido_det> listardetalles()
        {
            List<BE.Negocio.Pedido_det> det = mapper.listdet();
            return det;
        }
    }
}
