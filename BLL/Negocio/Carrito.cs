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


        List<BE.compra> acotizar = new List<BE.compra>();

        public void agregaralista(BE.compra cotizar)
        {
            this.acotizar.Add(cotizar);
        }

        public List<BE.compra> ordencompra()
        {
            return this.acotizar;
        }
        public void vaciarlista()
        {
            this.acotizar = new List<BE.compra>();
        }
    }
}
