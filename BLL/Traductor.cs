using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BLL
{
    public class Traductor
    {
        DAL.Idioma irepo = new DAL.Idioma();

        public Iidioma ObtenerIdiomaDefault()
        {
            return irepo.ObtenerIdiomaDefault();
        }

        public IList<Iidioma> ObtenerIdiomas()
        {
            return irepo.ObtenerIdiomas();
        }

        public IDictionary<string, ITraduccion> ObtenerTraducciones(Iidioma idioma = null)
        {
            return irepo.ObtenerTraducciones(idioma);
        }
    }
}
