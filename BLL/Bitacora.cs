using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Bitacora
    {
        DAL.Bitacora Mapper = new DAL.Bitacora();

        public string InsertarBitacora(BE.Bitacora Bt)
        {
            return Mapper.CargarBitacora(Bt);
        }
        public List<BE.Bitacora> Listar()
        {
            List<BE.Bitacora> Lista = Mapper.Listar();
            return Lista;
        }

        
    }
}
