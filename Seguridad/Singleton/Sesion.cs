using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Seguridad.MultiIdioma;

namespace Seguridad.Singleton
{
    public class Sesion
    {
        BE.IUsuario _user;
        static IList<IdiomaObserver> _observers = new List<IdiomaObserver>();
        public IUsuario Usuario
        {
            get { return _user; }
        }

        ///metodos para cerrar sesion
        public void LogIn(IUsuario usuario)
        {
            _user = usuario;
        }
        public void Logout()
        {
            _user = null;
        }
        public bool IsLogged()
        {
            return _user != null;
        }

        public void SuscribirObservador(IdiomaObserver o)
        {
            _observers.Add(o);
        }
        public void DesuscribirObservador(IdiomaObserver o)
        {
            _observers.Remove(o);
        }

        private void Notificar(Iidioma idioma)
        {
            foreach (var o in _observers)
            {
                o.UpdateLanguage(idioma);
            }
        }
        public void CambiarIdioma(Iidioma idioma)
        {
            if (_user != null)
            {
                _user.Idioma = idioma;
                Notificar(idioma);
            }
        }

    }
}
