﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Bitacora
    {
        private string _nick;

        public string NickUsuario
        {
            get { return _nick; }
            set { _nick = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        //private DateTime hora;

        //public DateTime Hora
        //{
        //    get { return hora; }
        //    set { hora = value; }
        //}

        private string _desc;

        public string Descripcion//operacion
        {
            get { return _desc; }
            set { _desc = value; }
        }

        private string modulo;

        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        private string _crit;

        public string Criticidad
        {
            get { return _crit; }
            set { _crit = value; }
        }
        private int idreg;

        public int IDREG
        {
            get { return idreg; }
            set { idreg = value; }
        }

    }
}
