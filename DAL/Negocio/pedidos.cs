using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Negocio
{
    public class pedidos
    {
        Accesos acces = new Accesos();

        public string Cargarcabecera(BE.Negocio.Pedido_Cab cab)
        {
            string idpedido;

            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@Idcliente", cab.ID_clientes);
            parametros[1] = new SqlParameter("@estado",cab.Estado);
            parametros[2] = new SqlParameter("@fechagen",cab.Fechagen);
            parametros[3] = new SqlParameter("@fechaact", cab.Fechaact);

            idpedido = acces.escribir("cargarcabecera", parametros); 

            return idpedido;
        }

        public string Cargardetalle(BE.Negocio.Pedido_det detalle)
        {
            string fa;

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@Idpedido",detalle.ID_pedido);
            parametros[1] = new SqlParameter("@Idcliente",detalle.ID_clientes);
            parametros[2] = new SqlParameter("@Idproducto",detalle.ID_producto);
            parametros[3] = new SqlParameter("@cantidad",detalle.Cantidad);
            parametros[4] = new SqlParameter("@costo",detalle.Costo);

            fa = acces.Escribir("cargardetalle", parametros);

            return fa;
        }

        public string Editarestado(BE.Negocio.Pedido_Cab cab)
        {
            string fa;

            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Idpedido", cab.ID_pedido);
            parameters[1] = new SqlParameter("@estado", cab.Estado);
            parameters[2] = new SqlParameter("@fechacam", cab.Fechaact);

            fa = acces.Escribir("modificarestado", parameters);

            return fa;
        }
        
        public List<BE.Negocio.Pedido_Cab> listcab()
        {
            List<BE.Negocio.Pedido_Cab> cablist = new List<BE.Negocio.Pedido_Cab>();

            DataTable tabla1 = acces.Leer("listarcabecera", null);

            foreach (DataRow registro in tabla1.Rows)
            {
                BE.Negocio.Pedido_Cab cab = new BE.Negocio.Pedido_Cab();
                cab.ID_pedido = int.Parse(registro["ID_pedido"].ToString());
                cab.ID_clientes = int.Parse(registro["ID_clientes"].ToString());
                cab.Estado = int.Parse(registro["estado"].ToString());
                cab.Fechagen = DateTime.Parse(registro["fechagen"].ToString());
                cab.Fechaact = DateTime.Parse(registro["fechaact"].ToString());
                cablist.Add(cab);

                
            }
            return cablist;
        }
        public List<BE.Negocio.Pedido_det> listdet()
        { 
            List<BE.Negocio.Pedido_det> detlist = new List<BE.Negocio.Pedido_det>();
            DataTable tabla1 = acces.Leer("listardetalles", null);

            foreach (DataRow registro in tabla1.Rows)
            {
                BE.Negocio.Pedido_det detalle = new BE.Negocio.Pedido_det();
                detalle.ID_pedido = int.Parse(registro["ID_pedido"].ToString());
                detalle.ID_clientes = int.Parse(registro["ID_clientes"].ToString());
                detalle.ID_producto = int.Parse(registro["ID_producto"].ToString());
                detalle.Cantidad = int.Parse(registro["Cantidad"].ToString());
                detalle.Costo = double.Parse(registro["costo"].ToString());
                detlist.Add(detalle);

                
            }
            return detlist;
        }
    }
}
