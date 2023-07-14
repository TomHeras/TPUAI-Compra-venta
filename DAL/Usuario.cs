using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using Seguridad.Composite;
using Seguridad.MultiIdioma;

namespace DAL
{
    public class Usuario
    {

        Accesos acceso = new Accesos();

        ///////////////////////////////////  

        //para inicio de sesion
        public BE.Usuario traerumbreusuario( string user)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = acceso.crearconeion();
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("Search_User", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usu", user);
                reader = cmd.ExecuteReader();
                if (!reader.Read()) return null;
                return new BE.Usuario()
                {
                    Idusuario = int.Parse(reader["Idusu"].ToString()),
                    Usuarios = reader["Usunick"].ToString(),
                    Password = reader["Usupass"].ToString()

                };

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();
            }
        }

        //para gestion de usuarios
        public List<BE.Usuario> Listar()
        {
            List<BE.Usuario> ListaUsuarios = new List<BE.Usuario>();
            DataTable tabla = acceso.Leer("ListarUsuarios", null);

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Usuario usu = new BE.Usuario();
                usu.Idusuario = int.Parse(registro["IdUsu"].ToString());                  
                usu.Nombre= registro["UsuNom"].ToString();
                usu.Usuarios = registro["UsuNick"].ToString();
                usu.Mail = registro["UsuMail"].ToString();
                usu.Estado = bool.Parse(registro["UsuEstado"].ToString());
                usu.Baja_logica = bool.Parse(registro["Usubajal"].ToString());
                usu.UsuDVH = int.Parse(registro["UsuDVH"].ToString());
                ListaUsuarios.Add(usu);
            }

            return ListaUsuarios;
        }


        //para gestion de permisos de usuarios
      
        public void GuardarPermisos(Patente_Usuario u)
        {

            try
            {
                var cnn = new SqlConnection(acceso.crearconeion());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from Usuario_Patente where IdUsu=@Id;";
                cmd.Parameters.Add(new SqlParameter("id", u.Idusuarios));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into Usuario_Patente (IdUsu,IdPat) values (@id,@patente) "; ;
                    cmd.Parameters.Add(new SqlParameter("id", u.Idusuarios));
                    cmd.Parameters.Add(new SqlParameter("patente", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //para usuario-flia-patente
        public List<Patente_Usuario> GetAll()
        {
            var cnn = new SqlConnection(acceso.crearconeion());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from Usuarios;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<Patente_Usuario>();

            while (reader.Read())
            {
                Patente_Usuario c = new Patente_Usuario();
                c.Idusuarios = reader.GetInt32(reader.GetOrdinal("IdUsu"));
                c.Nombre = reader.GetString(reader.GetOrdinal("UsuNick"));
                lista.Add(c);
            }

            reader.Close();
            cnn.Close();
            return lista;
        }

        ///////////////////////////////////
        
        //comienzo de ABM

        public string agregarusuario(BE.Usuario usu)
        {
            string fa;
            SqlParameter[] parameters = new SqlParameter[8];

            parameters[0] = new SqlParameter("IdIdioma", usu.Idioma.Id);
            parameters[1] = new SqlParameter("Usunom", usu.Nombre);
            parameters[2] = new SqlParameter("Usunick", usu.Usuarios);
            parameters[3] = new SqlParameter("Usupass", usu.Password);
            parameters[4] = new SqlParameter("Usumail", usu.Mail);
            parameters[5] = new SqlParameter("Usuestado", usu.Estado);
            parameters[6] = new SqlParameter("Usubajal", usu.Baja_logica);
            parameters[7] = new SqlParameter("UsuDVH", usu.UsuDVH);

            fa = acceso.Escribir("Altausuario2", parameters);

            return fa;

        }

        public List<BE.userauxiliar> Listarusuarios()
        {
            //BE.Iidioma iidioma = new BE.Iidioma { Id = 0, Nombre = "", Default = true };


            List<BE.userauxiliar> ListaUsuarios = new List<BE.userauxiliar>();
            DataTable tabla = acceso.Leer("Listadeusuarios", null);
            
            
            
            foreach (DataRow registro in tabla.Rows)
            {
                var x = new Idiomas()
                {
                    Id = int.Parse(registro["IdIdioma"].ToString())
                };
                BE.Usuario usu = new BE.Usuario{};
               
                usu.Idusuario = int.Parse(registro["IdUsu"].ToString());
                usu.Idioma = x;
                usu.Nombre = registro["UsuNom"].ToString();
                usu.Usuarios = registro["UsuNick"].ToString();
                usu.Password = registro["Usupass"].ToString();
                usu.Mail = registro["UsuMail"].ToString();
                usu.Estado = bool.Parse(registro["UsuEstado"].ToString());

                BE.userauxiliar useaux = new userauxiliar();
                useaux.Idusuario = usu.Idusuario;
                useaux.Idioma2 = x.Id;
                useaux.Nombre = usu.Nombre;
                useaux.Usuarios = usu.Usuarios;
                useaux.Password = usu.Password;
                useaux.Mail = usu.Mail;
                useaux.Estado = usu.Estado;

                ListaUsuarios.Add(useaux);
            }

            return ListaUsuarios;
        }
    }
}
