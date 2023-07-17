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
using Seguridad.MultiIdioma;

namespace TP_DIPLOMA
{
    public partial class ABMusuarios : Form
    {
        public ABMusuarios()
        {
            InitializeComponent();
        }

        BE.Usuario user = new BE.Usuario();
        BLL.Usuarios gestorusuarios = new BLL.Usuarios();
        BE.userauxiliar usaux = new BE.userauxiliar();
        BLL.idioma gestoridiom = new BLL.idioma();
        
        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorusuarios.Listadeusu();
        }

        public void limpiar()
        {
            controlUsuario1.limpiar();
            controlUsuario2.limpiar();
            controlUsuario3.limpiar();
            controlUsuario4.limpiar();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void ABMusuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet7.Idioma' Puede moverla o quitarla según sea necesario.
            this.idiomaTableAdapter.Fill(this.tPMODELOSDataSet7.Idioma);
            enlazar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usaux = (BE.userauxiliar)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            lblidcl.Text = usaux.Idusuario.ToString();
            controlUsuario1.Texto = usaux.Nombre.ToString();
            controlUsuario2.Texto = usaux.Usuarios.ToString();
            controlUsuario3.Texto = usaux.Password.ToString();
            controlUsuario4.Texto = usaux.Mail.ToString();            
            comboBox1.Text = usaux.Idioma2.ToString();
            if (usaux.Estado==true)
            {
                comboBox2.Text = "Activo";
            }
            else
            {
                comboBox2.Text = "Bloqueado";
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is ControlUsuario)
                {
                    ok = ((ControlUsuario)ctr).Validar() && ok;

                }
                if (!ok)
                {

                }


            }

            if (ok!=false)
            {
                try
                {                                                                 

                            user.Idioma = new Idiomas()
                            {
                                Id = comboBox1.SelectedIndex+1
                            };
                            user.Usuarios = controlUsuario2.Texto;
                            user.Nombre = controlUsuario1.Texto;
                            var pass = controlUsuario3.Texto;
                            user.Password = Encriptador.Hash(pass);
                            user.Mail = controlUsuario4.Texto;
                            user.Estado = bool.Parse(comboBox2.SelectedIndex.ToString());
                            user.Baja_logica = false;
                            user.UsuDVH = 1;

                    foreach (BE.userauxiliar item in gestorusuarios.Listadeusu())
                    {
                        if (controlUsuario2.Texto==item.Usuarios.ToString())
                        {
                            lblidcl.Text = item.Idusuario.ToString();
                        }
                    }

                    if (lblidcl.Text== ".................")
                    {
                        gestorusuarios.crearusuario(user);
                        MessageBox.Show("El usuario fue creado con exito!");

                        limpiar();
                        enlazar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede crear el usuario porque este ya existe");
                    }
                            

                            
                        
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (BE.userauxiliar item in gestorusuarios.Listadeusu())
            {
                if (lblidcl.Text==item.Idusuario.ToString())
                {
                    item.Nombre = controlUsuario1.Texto;
                    item.Usuarios = controlUsuario2.Texto;
                    item.Password = Encriptador.Hash(controlUsuario3.Texto);
                    item.Mail = controlUsuario4.Texto;
                    item.Idioma2 = comboBox1.SelectedIndex + 1;
                    try
                    {
                        if (comboBox2.SelectedItem.ToString() == "Activo")
                        {
                            item.Estado = true;
                        }
                        else
                        {
                            item.Estado = false;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    gestorusuarios.EditarUsuario_estado(item);
                    MessageBox.Show("El usuario fue modificado con exito");

                    limpiar();
                    enlazar();
                }
            }
        }
    }
}
