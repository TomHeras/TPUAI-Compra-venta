using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class prov_prov
    {
        Accesos acce = new Accesos();

        public List<BE.AuxiliarRelaionarPP> provprodaux()
        {
            List<BE.AuxiliarRelaionarPP> auxiliarRelaionarPPs = new List<BE.AuxiliarRelaionarPP>();
            DataTable tabla1 = acce.Leer("traerprodprov", null);

            foreach (DataRow item in tabla1.Rows)
            {
                BE.AuxiliarRelaionarPP pp = new BE.AuxiliarRelaionarPP();
                pp.Proveedor = int.Parse(item["IDProv"].ToString());
<<<<<<< HEAD
                pp.Producto = int.Parse(item["IDProd"].ToString());
=======
                pp.Producto= int.Parse(item["IDProd"].ToString());
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8

                auxiliarRelaionarPPs.Add(pp);
            }

            return auxiliarRelaionarPPs;
        }
    }
}
