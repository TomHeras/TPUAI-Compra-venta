using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Maestros
{
    public class Clientes
    {
        private int idcl;

        public int Idcl
        {
            get { return idcl; }
            set { idcl = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private int dvh;

        public int DVH
        {
            get { return dvh; }
            set { dvh = value; }
        }

    }
}
