using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Bitacora
    {
        Accesos Acceso = new Accesos();
        public string CargarBitacora(BE.Bitacora Bitacora)
        {
            string fa = "";
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@nick", Bitacora.NickUsuario);
            Param[1] = new SqlParameter("@fecha", Bitacora.Fecha);
            Param[2] = new SqlParameter("@operacion", Bitacora.Descripcion);
            Param[3] = new SqlParameter("@criticidad", Bitacora.Criticidad);
            Param[4] = new SqlParameter("@modulo", Bitacora.Modulo);
            fa = Acceso.Escribir("InsertarBitacora", Param);
            return fa;
        }
        public void Consultar(string query)
        {
            Acceso.ejecutarconsulta(query);
        }
        public List<BE.Bitacora> Listar()
        {
            List<BE.Bitacora> Lista = new List<BE.Bitacora>();
            DataTable Tabla = Acceso.Leer("ListarBitacora", null);
            foreach (DataRow Registro in Tabla.Rows)
            {
                BE.Bitacora Bit = new BE.Bitacora();
                Bit.NickUsuario = Registro["NickUsuario"].ToString();
                Bit.Descripcion = Registro["Operacion"].ToString();
                Bit.Fecha = DateTime.Parse(Registro["Fecha"].ToString());
                Bit.Criticidad = Registro["Criticidad"].ToString();
                Bit.Modulo = Registro["Modulo"].ToString();
<<<<<<< HEAD

=======
                
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
                Lista.Add(Bit);
            }
            return Lista;
        }


        public List<BE.Bitacora> listarcambios()
        {
            List<BE.Bitacora> lista = new List<BE.Bitacora>();
            DataTable Tabla = Acceso.Leer("ListarCambios", null);
            foreach (DataRow Registro in Tabla.Rows)
            {
                BE.Bitacora Bit = new BE.Bitacora();
                Bit.IDREG = int.Parse(Registro["Idregistro"].ToString());

                lista.Add(Bit);
            }
            return lista;
        }

<<<<<<< HEAD
        public List<BE.BitacoraCAbmios> Cambios()
=======
       public List<BE.BitacoraCAbmios> Cambios()
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
        {
            List<BE.BitacoraCAbmios> lista = new List<BE.BitacoraCAbmios>();
            DataTable tabla = Acceso.Leer("TrarBitacoraCambios", null);

            foreach (DataRow item in tabla.Rows)
            {
                BE.BitacoraCAbmios cambio = new BE.BitacoraCAbmios();

<<<<<<< HEAD
                cambio.Idregistro = int.Parse(item["Idregistro"].ToString());
=======
                cambio.Idregistro= int.Parse(item["Idregistro"].ToString());
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
                cambio.Idpedido = int.Parse(item["Idpedido"].ToString());
                cambio.Usuario = item["NickUsuario"].ToString();
                cambio.Fecha = DateTime.Parse(item["Fecha"].ToString());
                cambio.Modulo = item["Modulo"].ToString();
                cambio.Operacion = item["Operacion"].ToString();
                cambio.Criticidad = item["Criticidad"].ToString();
<<<<<<< HEAD
                cambio.Estado = int.Parse(item["Estado"].ToString());
=======
                cambio.Estado =int.Parse( item["Estado"].ToString());
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
                lista.Add(cambio);

            }

            return lista;
        }

        public List<BE.BitacoraCAbmios> CambiosBetween()
        {
            List<BE.BitacoraCAbmios> lista = new List<BE.BitacoraCAbmios>();
            DataTable tabla = Acceso.Leer("TrarBitacoraCambiosBETWEEN", null);

            foreach (DataRow item in tabla.Rows)
            {
                BE.BitacoraCAbmios cambio = new BE.BitacoraCAbmios();

                cambio.Idregistro = int.Parse(item["Idregistro"].ToString());
                cambio.Idpedido = int.Parse(item["Idpedido"].ToString());
                cambio.Usuario = item["NickUsuario"].ToString();
                cambio.Fecha = DateTime.Parse(item["Fecha"].ToString());
                cambio.Modulo = item["Modulo"].ToString();
                cambio.Operacion = item["Operacion"].ToString();
                cambio.Criticidad = item["Criticdad"].ToString();
                cambio.Estado = int.Parse(item["Estado"].ToString());
                lista.Add(cambio);

            }

            return lista;
        }
    }
}
