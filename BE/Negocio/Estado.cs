using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Negocio
{
   public class Estado
    {
        private int idestado;

        public int Idestado
        {
            get { return idestado; }
            set { idestado = value; }
        }

        private string descrip;

        public string Descrip
        {
            get { return descrip; }
            set { descrip = value; }
        }

    }
}
