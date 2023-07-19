using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Estado
    {
        Accesos acceso = new Accesos();

        public List<BE.Negocio.Estado> listEstado()
        {
            List<BE.Negocio.Estado> estados = new List<BE.Negocio.Estado>();
            DataTable table = acceso.Leer("ListEstados", null);

            foreach (DataRow item in table.Rows)
            {

                BE.Negocio.Estado est = new BE.Negocio.Estado();
                est.Idestado = int.Parse(item["IDestado"].ToString());
                est.Descrip = item["descripcion"].ToString();
                estados.Add(est);

            }
            return estados;
        }
    }
}
