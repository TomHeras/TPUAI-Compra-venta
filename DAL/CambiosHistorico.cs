using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CambiosHistorico
    {
        Accesos Acceso = new Accesos();


        //public List<BE.CAmbiosHistorico> listar()
        //{

        //    List<BE.CAmbiosHistorico> Historico = new List<BE.CAmbiosHistorico>();
        //    DataTable Tabla = Acceso.Leer("ListarHistorico", null);
        //    foreach (DataRow item in Tabla.Rows)
        //    {
        //        BE.CAmbiosHistorico CH = new BE.CAmbiosHistorico();

        //        CH.IDPEdido= int.Parse(item["IDPedido"].ToString());
        //        CH.Tipo = item["Tipo"].ToString();
        //        CH.Estado = int.Parse(item["Estado"].ToString());

        //    }
        //}

        public List<BE.CAmbiosHistorico> ListarHistorico(int idpedido)
        {
            List<BE.CAmbiosHistorico> lista = new List<BE.CAmbiosHistorico>();

            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@idpedido", idpedido);

            DataTable tabla = Acceso.Leer("ListarHistoricoPedido", Param);

            foreach (DataRow registro in tabla.Rows)
            {
                BE.CAmbiosHistorico ch = new BE.CAmbiosHistorico();

                ch.IDPEdido= int.Parse(registro["IDPedido"].ToString());
                ch.Tipo = registro["Tipo"].ToString();
                ch.Estado = int.Parse(registro["Estado"].ToString());
                ch.Nick = registro["Usuario"].ToString();
                ch.Fecha = DateTime.Parse(registro["Fecha"].ToString());

                lista.Add(ch);
            }

            return lista;
        }

        public int ObtenerEstadoAnterior(int idpedido)
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@idpedido", idpedido);

            DataTable tabla = Acceso.Leer("OEstadoAnterior", Param);

            if (tabla.Rows.Count > 0)
            {
                return int.Parse(tabla.Rows[0]["Estado"].ToString());
            }
            else
            {
                return 0; // no hay historial
            }
        }
    }
}
