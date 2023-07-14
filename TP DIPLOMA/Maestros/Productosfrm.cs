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
    public partial class Productosfrm : Form
    {
        public Productosfrm()
        {
            InitializeComponent();
        }
        BE.Maestros.Productos prod = new BE.Maestros.Productos();
        BLL.Maestros.Productos gestprod = new BLL.Maestros.Productos();
        BE.Maestros.Precios prec = new BE.Maestros.Precios();
        BLL.Maestros.Precios gestorpec = new BLL.Maestros.Precios();
        
        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestprod.listar();
        }

        public void limpiar()
        {
            ctrlcantidad.limpiar();
            ctrlmedidas.limpiar();
            ctrltipo.limpiar();
        }
        private void Productosfrm_Load(object sender, EventArgs e)
        {
            enlazar();
        }

        private void button1_Click(object sender, EventArgs e)// agregar productos
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
            
                BE.Maestros.Productos tmp = new BE.Maestros.Productos();
                BE.Maestros.Precios tmp2 = new BE.Maestros.Precios();

                
                tmp.Medidas = double.Parse(ctrlmedidas.Texto);
                tmp.Cantidad = int.Parse(ctrlcantidad.Texto);
                tmp.Tipo = ctrltipo.Texto;
                gestprod.altaprod(tmp);
                
                
                /////// procedimiento para cargar la lista de precios
                gestprod.llenar();
                gestprod.update0();
                ///



                MessageBox.Show("El producto fue registrado  con exito!");

                enlazar();
                limpiar();
               
               

            }
        }



        private void button2_Click(object sender, EventArgs e)//borrar productos
        {
            prod.ID_producto = int.Parse(lblidprod.Text);
            gestprod.borrar_prod(prod);
            ///////
            //aca van los procedimientos de borrado para la lista de precios agregando un foreach 

            foreach (BE.Maestros.Precios prec in gestorpec.Listar_precios())
            {
                try
                {
                    if (prec.Idprod==int.Parse(lblidprod.Text))
                    {
                        gestorpec.borrar_prec(prec);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            ///
            MessageBox.Show("El producto fue borrado exitosamente!");
            enlazar();
            limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                prod = (BE.Maestros.Productos)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                lblidprod.Text = prod.ID_producto.ToString();
                ctrlmedidas.Texto = prod.Medidas.ToString();
                ctrlcantidad.Texto = prod.Cantidad.ToString();
                ctrltipo.Texto = prod.Tipo.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un producto por favor!");
            }
        }//evento para seleccionar los datos de la grilla

        private void button3_Click(object sender, EventArgs e)// evento del boton para editar productos
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

                foreach (BE.Maestros.Productos item in gestprod.listar())
                {
                    try
                    {
                        if (item.ID_producto == int.Parse(lblidprod.Text))
                        {

                            item.Medidas = double.Parse(ctrlmedidas.Texto);
                            item.Cantidad = int.Parse(ctrlcantidad.Texto);
                            item.Tipo = ctrltipo.Texto;

                            gestprod.editar_prod(item);
                            ////////
                            //aca van los procedimientos de edicion para la lista de precios agregando un foreach 
                            foreach (BE.Maestros.Precios prec in gestorpec.Listar_precios())
                            {
                                try
                                {
                                    if (prec.Idprod == int.Parse(lblidprod.Text))
                                    {
                                        prec.Medidas = item.Medidas;
                                        prec.Tipo = prec.Tipo;
                                        prec.Precio = prec.Precio;
                                        prec.Detalles = prec.Detalles;
                                        gestorpec.editar_precios(prec);
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }
                            ///

                            MessageBox.Show("El producto fue modificado exitosamente!");
                            enlazar();
                            limpiar();

                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                
                
            }
        }
    }
}
