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
    public partial class Preciosfrm : Form
    {
        public Preciosfrm()
        {
            InitializeComponent();
        }

        BE.Maestros.Precios prec = new BE.Maestros.Precios();
        BE.Maestros.Productos prod = new BE.Maestros.Productos();

        BLL.Maestros.Precios gestorprec = new BLL.Maestros.Precios();
        BLL.Maestros.Productos GetProductos = new BLL.Maestros.Productos();

        public void cargar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=gestorprec.Listar_precios();
        }
        
        public void limpiar()
        {
            controlUsuario1.limpiar();
            controlUsuario2.limpiar();
            controlUsuario3.limpiar();
        }
        private void Preciosfrm_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                prec = (BE.Maestros.Precios)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                
                controlUsuario3.Texto= prec.Idprod.ToString();
                controlUsuario1.Texto = prec.Detalles.ToString();
                controlUsuario2.Texto = prec.Precio.ToString();
            }
            catch (Exception)
            {

                throw;
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
                foreach (BE.Maestros.Precios item in gestorprec.Listar_precios())
                {
                    try
                    {
                        if (item.Idprod==int.Parse(controlUsuario3.Texto))
                        {
                            item.Detalles = controlUsuario1.Texto;
                            item.Precio = double.Parse(controlUsuario2.Texto);
                            item.Medidas = item.Medidas;
                            item.Tipo = item.Tipo;

                            gestorprec.editar_precios(item);

                            MessageBox.Show("El articulo fue modificado exitosamente");
                            cargar();
                            limpiar();
                        }
                    }
                    catch (Exception)
                    {

                      
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestorprec.aumento();
            MessageBox.Show("Se aumento un 8%");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
