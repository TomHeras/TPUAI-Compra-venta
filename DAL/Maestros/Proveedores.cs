using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Maestros
{
    public class Proveedores
    {
        Accesos acceso = new Accesos();

        public List<BE.Maestros.Proveedores> listar()
        {
            List<BE.Maestros.Proveedores> prov = new List<BE.Maestros.Proveedores>();
            DataTable tabla1 = acceso.Leer("ListarProv", null);

            foreach (DataRow registro in tabla1.Rows)
            {
                BE.Maestros.Proveedores prove = new BE.Maestros.Proveedores();
                prove.Idprov = int.Parse(registro["ID_proveedor"].ToString());
                prove.Nombre = registro["Nombre"].ToString();
                prove.Direccion = registro["Direccion"].ToString();
                prove.Telefono = int.Parse(registro["Telefono"].ToString());
                prov.Add(prove);
            }

            return prov;
        }

        public string agregar(BE.Maestros.Proveedores prov)
        {
            string fa;
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@nombre", prov.Nombre);
            parametros[1] = new SqlParameter("@direccion", prov.Direccion);
            parametros[2] = new SqlParameter("@telefono", prov.Telefono);
            parametros[3] = new SqlParameter("@DVH", prov.DDVH);
            fa = acceso.Escribir("AltaProv", parametros);

            return fa;
        }

        public string editarprov(BE.Maestros.Proveedores prov)
        {
            string fa;
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@IDprov", prov.Idprov);
            parametros[1] = new SqlParameter("@nombre", prov.Nombre);
            parametros[2] = new SqlParameter("@direccion", prov.Direccion);
            parametros[3] = new SqlParameter("@telefono", prov.Telefono);
            fa = acceso.Escribir("EditarProv", parametros);

            return fa;
        }

        public string BajaProv(BE.Maestros.Proveedores prov)
        {
            string fa;
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@IDprov", prov.Idprov);
            fa = acceso.Escribir("BajaProv", parametros);
            return fa;
        }


        public string Asignar(BE.Maestros.Proveedores prov)
        {
            string fa;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@prov", prov.Idprov);
            parametros[1] = new SqlParameter("@prod", prov.IDasig);

            fa = acceso.Escribir("AsignarPROV_PROD", parametros);

            return fa;
        }


        public void XML()
        {
            DataSet DS = new DataSet();
            acceso.abrirconexion();
            SqlDataAdapter DA = new SqlDataAdapter("ListarProv", acceso.conexion);
            DA.Fill(DS, "proveedores");
            acceso.cerrarconexion();
            DS.WriteXml("C:/Facultad/proveedores.xml");
        }
    }
}
