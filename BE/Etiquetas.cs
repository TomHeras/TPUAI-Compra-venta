using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Etiquetas
    {
        private string nombre_etiqueta;

        public string Nombre_Etiqueta
        {
            get { return nombre_etiqueta; }
            set { nombre_etiqueta = value; }
        }

        private string traduccion;

        public string Traduccion
        {
            get { return traduccion; }
            set { traduccion = value; }
        }

    }
}
