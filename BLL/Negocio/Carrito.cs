using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class Carrito
    {

        List<BE.Negocio.Carrito> pedidos = new List<BE.Negocio.Carrito>();



        public void Agregarcarrito(BE.Negocio.Carrito pedis)
        {

            this.pedidos.Add(pedis);
        }



        public List<BE.Negocio.Carrito> lista()
        {
            return this.pedidos;
        }
        
        public void vaciarcarrito()
        {
             this.pedidos= new List<BE.Negocio.Carrito>();
        }
    }
}
