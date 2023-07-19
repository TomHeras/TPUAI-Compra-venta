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


        public void Consultar(string query)
        {
            Mapper.Consultar(query);
        }

        public List<BE.Bitacora> listacambios()
        {
            List<BE.Bitacora> cambios = Mapper.listarcambios();
            return cambios;
        }

        public List<BE.BitacoraCAbmios> Cambios()
        {
            List<BE.BitacoraCAbmios> cam = Mapper.Cambios();
            return cam;
        }

        public List<BE.BitacoraCAbmios> CambiosBetween()
        {
            List<BE.BitacoraCAbmios> cam = Mapper.CambiosBetween();
            return cam;
        }
    }
}
