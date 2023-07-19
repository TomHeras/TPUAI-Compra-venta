using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CAmbiosHistorico
    {
		private int IDreg;

		public int IDRegistro
		{
			get { return IDreg; }
			set { IDreg = value; }
		}

		private int IDped;

		public int IDPEdido
		{
			get { return IDped; }
			set { IDped = value; }
		}

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private int estado;

		public int Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		private double cotizar;

		public double cotizacion
		{
			get { return cotizar; }
			set { cotizar = value; }
		}

		private string usuario;

		public string Nick
		{
			get { return usuario; }
			set { usuario = value; }
		}

		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private int dhv;

		public int DVH
		{
			get { return dhv; }
			set { dhv = value; }
		}

	}
}
