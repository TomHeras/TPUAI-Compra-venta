﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Seguridad.MultiIdioma
{
   public class Traduccion:ITraduccion
    {
        public IEtiqueta Etiqueta { get; set; }
        public string Texto { get; set; }
    }
}
