using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RelacionarPP
    {
        DAL.Accesos mapper = new DAL.Accesos();
        DAL.prov_prov mapperpp = new DAL.prov_prov();

        public void Consulta(string query)
        {
            mapper.ejecutarconsulta(query);
        }

        public List<BE.AuxiliarRelaionarPP> listrarPP()
        {
            List<BE.AuxiliarRelaionarPP> prov = mapperpp.provprodaux();
            return prov;
        }
    }
}
