using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Accesos
    {
        public SqlConnection conexion = new SqlConnection();

        public string crearconeion()
        {
            var cs = new SqlConnectionStringBuilder();
            //cs.IntegratedSecurity = true;
            //cs.DataSource = ".";
            //cs.InitialCatalog = "MyCompany";
            cs.ConnectionString = @"Data Source=DESKTOP-QI5JC7C\TOOM;Initial Catalog=TPDIPLOMA;Integrated Security=True";//revisar  base de datos
            //AR2482453W1\SQLEXPRESS CAMBIAR ESTE PARA LA BASE DE DATOS DE LA NOTEBOOK
            //DESKTOP-QI5JC7C\TOOM Escritorio
            //////DESKTOP-81ATIN0\SQLEXPRESS Note MERK
            // CAMBIAR CONECTIONG STRING DE LAS COMBOBOX SINO PINCHA

            return cs.ConnectionString; 
        }

        public void abrirconexion()
        {
            conexion.ConnectionString = @"Data Source=Data Source=DESKTOP-QI5JC7C\TOOM;Initial Catalog=TPDIPLOMA;Integrated Security=True";
            conexion.Open();
        }
        public void cerrarconexion()
        {
            conexion.Close();
        }
        public DataTable Leer(string NombreProcedimiento, SqlParameter[] parametros)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = crearconeion(); // instancia de clase SQlConnection y le paso la cadena de conexion          
            sql.Open();//abre conexion
            DataTable tabla = new DataTable(); //crea nueva tabla
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.CommandText = NombreProcedimiento;
            if (parametros != null)
            {
                adaptador.SelectCommand.Parameters.AddRange(parametros);
            }
            adaptador.SelectCommand.Connection = sql;
            adaptador.Fill(tabla);
            sql.Close();
            return tabla;
        }

        public string Escribir(string NombreProcedimiento, SqlParameter[] parametros)
        {
            string mensaje;
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = crearconeion();
            sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreProcedimiento;
            cmd.Connection = sql;
            cmd.Parameters.AddRange(parametros);
            try
            {

                cmd.ExecuteNonQuery();
                mensaje = "Operación Realizada con Exito";
            }

            catch (Exception Ex)
            {
                mensaje = Ex.Message;
            }
            sql.Close();
            return mensaje;
        }

        public void ejecutarconsulta(string consulta)
        {
            cerrarconexion();
            abrirconexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = consulta;
            cmd.ExecuteNonQuery();
            cerrarconexion();
        }
        

        public DataSet EjecutarConsultaDStabla( string consulta, string tabla)
        {
            DataSet DS = new DataSet();
            SqlCommand Com = new SqlCommand();
            abrirconexion();
            DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(consulta, conexion);
            DA.Fill(DS, tabla);
            cerrarconexion();
            return DS;
        }
        public string escribir(string st, SqlParameter[] parametros)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = crearconeion();
            sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = st;
            cmd.Connection = sql;
            cmd.Parameters.AddRange(parametros);
            cmd.Parameters.Add("@returnvalue", SqlDbType.Int).Direction = ParameterDirection.Output;




            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            

            cmd.ExecuteNonQuery();
            var result = cmd.Parameters["@returnvalue"].Value;
            sql.Close();
            return result.ToString();
        }
    }
}
