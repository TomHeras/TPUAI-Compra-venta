using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DIPLOMA.Maestros
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        BE.Maestros.Proveedores prov = new BE.Maestros.Proveedores();
        BLL.Maestros.Proveedores gestorprov = new BLL.Maestros.Proveedores();
        BLL.Maestros.Productos gestorPROD = new BLL.Maestros.Productos();

        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorprov.listrarprovs();
           
        }

        public void enlazarcombo()
        {
            comboBox1.DataSource = gestorPROD.listarprod();
        }

        public void limpiar()
        {
            controlUsuario2.limpiar();
            controlUsuario3.limpiar();
            controlUsuario4.limpiar();
        }
        private void btnagregar_Click(object sender, EventArgs e)
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

            if (ok != false)
            {
                BE.Maestros.Proveedores tmp = new BE.Maestros.Proveedores();

                tmp.Nombre = controlUsuario2.Texto;
                tmp.Direccion = controlUsuario3.Texto;
                tmp.Telefono = int.Parse(controlUsuario4.Texto);
                gestorprov.altaprov(tmp);
                MessageBox.Show("Se registro un nuevo proveedor");
                enlazar();
                limpiar();
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet15.Stock' Puede moverla o quitarla según sea necesario.
            //this.stockTableAdapter.Fill(this.tPMODELOSDataSet15.Stock);
            enlazar();
            enlazarcombo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                prov = (BE.Maestros.Proveedores)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                lblidcl.Text = prov.Idprov.ToString();
                controlUsuario2.Texto = prov.Nombre.ToString();
                controlUsuario3.Texto = prov.Direccion.ToString();
                controlUsuario4.Texto = prov.Telefono.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un proveedor, Por Favor");
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            prov.Idprov = int.Parse(lblidcl.Text);
            gestorprov.bajaprov(prov);
            MessageBox.Show("El proveedor fue eliminado");
            enlazar();
            limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (controlUsuario2.Texto!="")
            {
                foreach (BE.Maestros.Proveedores item in gestorprov.listrarprovs())
                {
                    try
                    {
                        if (item.Idprov==int.Parse(lblidcl.Text))
                        {
                            item.Nombre = controlUsuario3.Texto;
                            item.Direccion = controlUsuario2.Texto;
                            item.Telefono = int.Parse(controlUsuario4.Texto);

                            gestorprov.editarprov(item);

                            MessageBox.Show("El proveedor fue modificado");

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

        private void btnprod_prov_Click(object sender, EventArgs e)
        {
            BE.Maestros.Proveedores prov = new BE.Maestros.Proveedores();
            prov.Idprov = int.Parse(lblidcl.Text);
            prov.IDasig =int.Parse( comboBox1.SelectedValue.ToString());

            gestorprov.AsginarProd(prov);
            MessageBox.Show("El producto fue asignado al proveedor");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestorprov.serealizar();
            MessageBox.Show("La informacion fue serealizada con exito");
        }
    }
}
