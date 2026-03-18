using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Estado
    {
        DAL.Estado estado = new DAL.Estado();

        public List<BE.Negocio.Estado> listarestados()
        {
            List<BE.Negocio.Estado> est = estado.listEstado();

            return est;
        }
    }
}
