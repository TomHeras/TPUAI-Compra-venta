using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguridad.MultiIdioma;
using BE;
using Seguridad;

namespace BLL
{
   public class idioma
    {

        DAL.Idioma repoidioma = new DAL.Idioma();
        public string InsertarIdioma(Idiomas id)
        {
            return repoidioma.InsertarIdioma(id);
        }
        public int ObtenerTraduccion(string n)
        {
            return repoidioma.ObtenerTraduccion(n);
        }
        public string EditarTraduccion(string t, string n, int i)
        {
            return repoidioma.EditarTraduccion(t, n, i);
        }
        public List<Etiquetas> ObtenerEyT(string nombre)
        {
            return repoidioma.ObtenerEtiquetasYTraduccion(nombre);
        }

        public string InsertarEtiquetas(int idI, int idE, string t)
        {
            return repoidioma.InsertarE(idI, idE, t);
        }

        public List<Etiqueta> GetAllEtiquetas()
        {
            return repoidioma.GetAllEtiquetas();
        }
    }
}
