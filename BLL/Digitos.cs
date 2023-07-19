using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;

namespace BLL
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

        public long DVH(string consulta, string tabla)
        {
            AsciiHorizontal = default(long);
            DataSet ds = new DataSet();
            ds = Acceso.EjecutarConsultaDStabla(consulta, tabla);

            for (int i = 0; i < Information.UBound(ds.Tables[0].Rows[0].ItemArray,1)-1; i++)
                try
                {
                    AsciiHorizontal += ObtenerAscii((ds.Tables[0].Rows[0].ItemArray[i]).ToString());
                }
                catch (Exception)
                {

                    throw;
                }

            return AsciiHorizontal;

        }
        public int SumaDVV(string DVH, string Tabla)
        {
            int i = 0;
            SqlConnection Conexion = new SqlConnection(@"Data Source=AR2482453W1\SQLEXPRESS;Initial Catalog=TPMODELOS;Integrated Security=True");
            Conexion.Open();
            string consulta = "Select SUM(" + DVH + ") from " + Tabla + "";
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                i = dr.GetInt32(0);
            }

            Conexion.Close();
            return i;
        }
        
        public void InsertarDVV(string tabla, string columna)
        {
            //SqlConnection Conexion = new SqlConnection(@"Data Source=AR2482453W1\SQLEXPRESS;Initial Catalog=TPMODELOS;Integrated Security=True");
            //Conexion.Open();
            //string consulta = "update DVV set DVV.DVV_SUMA =  ( select sum (" + columna + ") from " + tabla + " ) " +
            //    "where DVV.DVV_TABLA = '" + tabla.ToString() + "'";
            //SqlCommand cmd = new SqlCommand(consulta, Conexion);
            //cmd.ExecuteNonQuery();
            //Conexion.Close();
        }

        public int ConsultarDVV(string tabla)
        {
            int i = 0;
            //SqlConnection Conexion = new SqlConnection(@"Data Source=AR2482453W1\SQLEXPRESS;Initial Catalog=TPMODELOS;Integrated Security=True");
            //Conexion.Open();
            //string consulta = "select DVV_SUMA from DVV where DVV_TABLA = '" + tabla.ToString() + "'";
            //SqlCommand cmd = new SqlCommand(consulta, Conexion);
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    dr.Read();

            //    try
            //    {
            //        i = dr.GetInt32(0);
            //    }
            //    catch
            //    {
            //        i = 0;
            //    }

            //}

            //Conexion.Close();
            return i;
        }
        public void Consultar(string query)
        {
            Mapper.Consultar(query);
        }
    }
}
