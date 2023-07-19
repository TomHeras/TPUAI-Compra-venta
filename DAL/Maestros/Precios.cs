using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Maestros
{
   public class Precios
    {
        Accesos acces = new Accesos();

        public string alta(BE.Maestros.Precios prec)
        {
            string fa ;
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("@ID_producto", prec.Idprod);
            parametros[1] = new SqlParameter("@detalles", prec.Detalles);
            parametros[2] = new SqlParameter("@precio", prec.Precio);
            parametros[3] = new SqlParameter("@medidas", prec.Medidas);
            parametros[4] = new SqlParameter("@tipo", prec.Tipo);
            parametros[5] = new SqlParameter("@DVH", prec.DVH);
            fa = acces.Escribir("altaprecio", parametros);
            return fa;
        }
        public string baja(BE.Maestros.Precios prec)
        {
            string fa;
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@Id_producto", prec.Idprod);
            fa = acces.Escribir("bajaprecio", parametros);
            return fa;
        }

        public string editarprecio(BE.Maestros.Precios prec)
        {
            string fa ;
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@Id_producto", prec.Idprod);
            parametros[1] = new SqlParameter("@detalles", prec.Detalles);
            parametros[2] = new SqlParameter("@precio", prec.Precio);
            parametros[3] = new SqlParameter("@medidas", prec.Medidas);
            parametros[4] = new SqlParameter("@Tipo", prec.Tipo);
            fa = acces.Escribir("Editarprecio", parametros);
            return fa;
        }

        public List<BE.Maestros.Precios> listaprecios()
        {
            List<BE.Maestros.Precios> precios = new List<BE.Maestros.Precios>();
            DataTable tabla = acces.Leer("listarprecios", null);

            foreach (DataRow registro in tabla.Rows)
            {

                BE.Maestros.Precios precio = new BE.Maestros.Precios();
                precio.Idprod= int.Parse(registro["ID_producto"].ToString());
                precio.Detalles = registro["detalles"].ToString();                
                precio.Precio = double.Parse(registro["Precio"].ToString());
                precio.Medidas = double.Parse(registro["medidas"].ToString());
                precio.Tipo= registro["Tipo"].ToString();
                precios.Add(precio);

            }

            return precios;
        }

        public void transaccion()
        {
            SqlConnection CN = new SqlConnection(@"Data Source=DESKTOP-QI5JC7C\TOOM;Initial Catalog=TPMODELOS;Integrated Security=True");
            CN.Open();

            SqlTransaction TR;

            SqlCommand CM;

            TR = CN.BeginTransaction();

            try
            {
                CM = new SqlCommand("UPDATE Precios SET precio = (precio *(1.08))", CN);

                CM.Transaction = TR;

                CM.ExecuteNonQuery();

                TR.Commit();


            }

            catch (Exception Ex)
            {
                TR.Rollback();

            }
            CN.Close();


        }
    }
}
