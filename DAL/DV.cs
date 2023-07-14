using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DV
    {
        Accesos acceso = new Accesos();



        public void Consultar(string query)
        {
            acceso.ejecutarconsulta(query);
        }
    }
}
