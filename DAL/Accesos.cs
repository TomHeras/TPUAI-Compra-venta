﻿using System;
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
            cs.ConnectionString = @"Data Source=DESKTOP-QI5JC7C\TOOM;Initial Catalog=TPMODELOS;Integrated Security=True";//revisar  base de datos


            return cs.ConnectionString; 
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
            crearconeion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = consulta;
            cmd.ExecuteNonQuery();
            crearconeion();
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
