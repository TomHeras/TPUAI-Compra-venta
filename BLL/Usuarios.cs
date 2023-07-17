using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguridad.Singleton;
using Seguridad.Composite;
using Seguridad;


namespace BLL
{
    public class Usuarios
    {
        BE.Usuario user = new BE.Usuario();
        DAL.Usuario Mapper = new DAL.Usuario();

        public string login(string usu, string pass)
        {
            if (SingletonSesion.Instancia.IsLogged())
                throw new Exception("ya hay una sesion iniciada");
            var a = Mapper.traerumbreusuario(usu);
            if (a == null)
                return ("no existe el usuario");
            if (!Encriptador.Hash(pass).Equals(a.Password))
                return ("contraseña incorrecta");
            else
            {
                SingletonSesion.Instancia.LogIn(a);
                return ("Inicio de Sesion Exitoso");
            }

        }

        public void Logout()
        {
            if (!SingletonSesion.Instancia.IsLogged())
                throw new Exception("No hay sesión iniciada"); //doble validación, anulo en boton en formulario y valido en la bll
            SingletonSesion.Instancia.Logout();
        }


        public List<BE.Usuario> Listar()
        {
            List<BE.Usuario> listausu = Mapper.Listar();
            return listausu;
        }

        public List<BE.userauxiliar> Listadeusu()
        {
            List<BE.userauxiliar> listausu = Mapper.Listarusuarios();
            return listausu;
        }
        public void GuardarPermisos(Patente_Usuario u)
        {
            Mapper.GuardarPermisos(u);
        }
        public List<Patente_Usuario> GetAll()
        {
            return Mapper.GetAll();
        }

        public string crearusuario(BE.Usuario user)
        {
            string fa;

            fa = Mapper.agregarusuario(user);

            return fa;
        }


        public string CambiarContraseña(BE.userauxiliar userpas)
        {
            string fa;
            fa = Mapper.CambiarContraseña(userpas);

            return fa;
        }

        public string EditarUsuario_estado(BE.userauxiliar user)
        {
            string fa;
            fa = Mapper.EditarEstado(user);

            return fa;
        }
    }
}
