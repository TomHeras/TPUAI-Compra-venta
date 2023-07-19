using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BitacoraCAbmios
    {

        private int idreg;

        public int Idregistro
        {
            get { return idreg; }
            set { idreg = value; }
        }

        private int idpedido;

        public int Idpedido
        {
            get { return idpedido; }
            set { idpedido = value; }
        }

        private string ususario;

        public string Usuario
        {
            get { return ususario; }
            set { ususario = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string modulo;

        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }


        private string operacion;

        public string Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }


        private string criticidad;

        public string Criticidad
        {
            get { return criticidad; }
            set { criticidad = value; }
        }


        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }



    
}
