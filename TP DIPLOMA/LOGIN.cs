using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad.Singleton;
using Seguridad;

namespace TP_DIPLOMA
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
         
        }

        BE.Usuario user = new BE.Usuario();
        BLL.Usuarios gestoruser = new BLL.Usuarios();
        BLL.Bitacora gestorbitacora = new BLL.Bitacora();
        BE.Bitacora BitacoraTemp;

        
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            bool ok = true, oki = true;

            foreach (Control ctr in this.Controls)
            {
                if (ctr is ControlUsuario)
                {
                    ok = ((ControlUsuario)ctr).Validar() && ok;

                }
                if (!ok)
                {

                }

                if (ctr is CotrolPass)
                {
                    oki = ((CotrolPass)ctr).Validar() && oki;
                }
                if (!oki)
                {

                }

               

            }
            if (ok != false && oki != false)
            {
                //MessageBox.Show(gestoruser.login(controlUsuario1.Texto, cotrolPass1.Texto), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (SingletonSesion.Instancia.IsLogged())
                //{
                foreach (BE.Usuario item in gestoruser.Listar())
                {
                    if (item.Usuarios == controlUsuario1.Texto)
                    {
                        if (item.Estado == true)
                        {
                            user.Idusuario = item.Idusuario;
                            user.Nombre = item.Nombre;
                            user.Usuarios = controlUsuario1.Texto;
                            user.Password = cotrolPass1.Texto;
                            user.Estado = true;
                        }
                        else
                        {
                            user.Usuarios = controlUsuario1.Texto;
                            user.Password = cotrolPass1.Texto;
                            user.Estado = false;
                        }
                    }
                    else
                    {
                        user.Estado = true;
                    }
                }

                if (user.Estado==true)
                {
                    MessageBox.Show(gestoruser.login(controlUsuario1.Texto, cotrolPass1.Texto), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (SingletonSesion.Instancia.IsLogged())
                    {
                        Administracion adm = new Administracion();
                        adm.Show();
                        this.Hide();

                        CargarBitacora(user.Usuarios, "Inicio de sesion", "baja");
                    }
                    else
                    {
                        cont =cont +1;
                        if (cont>=3)
                        {
                            BE.userauxiliar usaux = new BE.userauxiliar();
                            usaux.Usuarios = controlUsuario1.Texto;
                            usaux.Idusuario = user.Idusuario;
                            usaux.Idioma2 = 1;
                            usaux.Password = Encriptador.Hash(user.Password);
                            usaux.Nombre = user.Nombre;
                            usaux.Estado = false;


;                           gestoruser.EditarUsuario_estado(usaux);
                            MessageBox.Show("El usario fue bloqueado por la cantidad de intentos");
                            cont = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("el usuario esta bloqueado");
                    CargarBitacora(user.Usuarios, "Inicio de sesion", "Medio");
                }
                
                
                    
               
            }
        }

        int cont = 0;

        void CargarBitacora(string Nick, string Descripcion, string Criticidad)
        {
            BitacoraTemp = new BE.Bitacora();

            BitacoraTemp.NickUsuario = Nick;
            BitacoraTemp.Fecha = DateTime.Now;
            BitacoraTemp.Descripcion = Descripcion;
            BitacoraTemp.Criticidad = Criticidad;

            gestorbitacora.InsertarBitacora(BitacoraTemp);
        }

        

    }
}
