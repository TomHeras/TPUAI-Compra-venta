using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace DAL
{
    public class Digitos
    {
        DAL.Accesos Acceso = new DAL.Accesos();
        DAL.DV Mapper = new DAL.DV();
        long AsciiHorizontal;



        public long ObtenerAscii(string texto)
        {
            long sumaascii = 0;
            if (texto != null)
            {
                int i;
                for (i = 0; i <= texto.Length - 1; i++)
                    sumaascii += Convert.ToInt64((Strings.Asc(texto[i]).ToString()));
            }
            return sumaascii;
        }
    }
}
