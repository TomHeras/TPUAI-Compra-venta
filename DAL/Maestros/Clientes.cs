using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Maestros
{
    public class Clientes
    {
        Accesos acces = new Accesos();

        public List<BE.Maestros.Clientes> listar()
        {
            List<BE.Maestros.Clientes> cli = new List<BE.Maestros.Clientes>();

            DataTable tabla1 = acces.Leer("Listarclientes", null);

            foreach (DataRow registro in tabla1.Rows)
            {
                BE.Maestros.Clientes cl =new BE.Maestros.Clientes();
                cl.Idcl= int.Parse(registro["ID_clientes"].ToString());
                cl.Nombre = registro["Nombre"].ToString();
                cl.Direccion = registro["Direccion"].ToString();
                cl.Telefono = int.Parse(registro["Telefono"].ToString());
                cli.Add(cl);
            }

            return cli;
        }

        public string agregar(BE.Maestros.Clientes cliente)
        {
            string fa ;

            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@nombre", cliente.Nombre);
            parametros[1] = new SqlParameter("@direccion", cliente.Direccion);
            parametros[2] = new SqlParameter("@telefono", cliente.Telefono);
          
            fa = acces.Escribir("altacliente", parametros);
            return fa;
        }

        public string modificarcliente(BE.Maestros.Clientes cliente)
        {
            string fa ;
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@ID_cliente", cliente.Idcl);
            parametros[1] = new SqlParameter("@nombre", cliente.Nombre);
            parametros[2] = new SqlParameter("@direccion", cliente.Direccion);
            parametros[3] = new SqlParameter("@telefono", cliente.Telefono);
            fa = acces.Escribir("Editarcliente", parametros);

            return fa;
        }

        public string bajacliente(BE.Maestros.Clientes cliente)
        {
            string fa ;
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@ID_clientes", cliente.Idcl);
            fa = acces.Escribir("Bajaclientes", parametros);
            return fa;
        }
    }
}
