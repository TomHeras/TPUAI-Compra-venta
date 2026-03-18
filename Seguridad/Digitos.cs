using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class Digitos
    {
        public int ConvertToAscii(string input)
        {
            int asciiValueSum = 0;

            // Recorre cada carácter de la cadena y suma su valor ASCII
            foreach (char c in input)
            {
                asciiValueSum += (int)c;
            }

            return asciiValueSum;
        }

    }
}
