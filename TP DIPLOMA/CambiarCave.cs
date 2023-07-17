using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad;
using Seguridad.Singleton;

namespace TP_DIPLOMA
{
    public partial class CambiarCave : Form
    {
        public CambiarCave()
        {
            InitializeComponent();
        }

        BE.Usuario user = new BE.Usuario();
        BLL.Usuarios gestorusuarios = new BLL.Usuarios();
        
        int id=0;
        private void CambiarCave_Load(object sender, EventArgs e)
        {
            
            if (SingletonSesion.Instancia.IsLogged())
            {
                id = SingletonSesion.Instancia.Usuario.idusuario;
            }
        }

        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (BE.userauxiliar item in gestorusuarios.Listadeusu())
            {
                if (item.Idusuario==id)
                {
                    if (item.Password==Encriptador.Hash(textBox1.Text))
                    {
                        if (textBox2.Text==textBox3.Text)
                        {
                            item.Password = Encriptador.Hash(textBox3.Text);

                            gestorusuarios.CambiarContraseña(item);

                            MessageBox.Show("La contraseña fue cambiada con exito!");

                            limpiar();
                        }
                    }
                    
                }
            }
        }
    }
}
