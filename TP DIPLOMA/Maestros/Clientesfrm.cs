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

namespace TP_DIPLOMA.Maestros
{
    public partial class Clientesfrm : Form
    {
        public Clientesfrm()
        {
            InitializeComponent();
        }
        BE.Maestros.Clientes cl = new BE.Maestros.Clientes();
        BLL.Maestros.Clientes gestorcl = new BLL.Maestros.Clientes();

        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorcl.listar();
        }

        public void limpiar()
        {
            controlUsuario1.limpiar();
            controlUsuario2.limpiar();
            controlUsuario3.limpiar();
        }

        private void Clientesfrm_Load(object sender, EventArgs e)
        {
            enlazar();
        }
        private void button1_Click(object sender, EventArgs e)//agregar
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
                BE.Maestros.Clientes tmp = new BE.Maestros.Clientes();

                tmp.Nombre = controlUsuario1.Texto;
                tmp.Direccion = controlUsuario2.Texto;
                tmp.Telefono = int.Parse(controlUsuario3.Texto);
                gestorcl.altacliente(tmp);
                MessageBox.Show("Se registro un nuevo cliente");
                enlazar();
                limpiar();
            }
        }

        private void button3_Click(object sender, EventArgs e)//Borrar
        {
            cl.Idcl = int.Parse(lblidcl.Text);
            gestorcl.bajacl(cl);
            MessageBox.Show("El cliente fue borrado");
            enlazar();
            limpiar();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cl = (BE.Maestros.Clientes)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                lblidcl.Text = cl.Idcl.ToString();
                controlUsuario1.Texto = cl.Nombre.ToString();
                controlUsuario2.Texto = cl.Direccion.ToString();
                controlUsuario3.Texto = cl.Telefono.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un cliente, Por Favor");

            }
        }

        private void button2_Click(object sender, EventArgs e)//Editar
        {
            if (controlUsuario1.Texto!="")
            {
                foreach (BE.Maestros.Clientes item in gestorcl.listar())
                {
                    try
                    {
                        if (item.Idcl==int.Parse(lblidcl.Text))
                        {
                            item.Nombre = controlUsuario1.Texto;
                            item.Direccion = controlUsuario2.Texto;
                            item.Telefono = int.Parse(controlUsuario3.Texto);

                            gestorcl.modificarcliente(item);

                            MessageBox.Show("El cliente fue modificado");

                            enlazar();
                            limpiar();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Los datos ingresados no son validos");
                    }
                }
            }
        }
    }
}
