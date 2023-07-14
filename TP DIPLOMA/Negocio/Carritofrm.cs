using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DIPLOMA.Negocio
{
    public partial class Carritofrm : Form
    {
        public Carritofrm()
        {
            InitializeComponent();
        }
        
        BLL.Negocio.Carrito GetCarrito = new BLL.Negocio.Carrito();
        BE.Maestros.Precios precio = new BE.Maestros.Precios();
        BLL.Maestros.Precios gestorprecio = new BLL.Maestros.Precios();

        BLL.Maestros.Clientes getcl = new BLL.Maestros.Clientes();
        BLL.Maestros.Productos getprod = new BLL.Maestros.Productos();
        private void Carritofrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet4.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.tPMODELOSDataSet4.Clientes);

            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet3.Stock' Puede moverla o quitarla según sea necesario.
            this.stockTableAdapter.Fill(this.tPMODELOSDataSet3.Stock);
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet2.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tPMODELOSDataSet2.Clientes);
            //foreach (var item in getcl.listar())
            //{
            //    comboBox1.Items.Add(item);
            //}
            //foreach (var item in getprod.listar())
            //{
            //    comboBox2.Items.Add(item);
            //}
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetCarrito.lista();
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Eliminar";
            uninstallButtonColumn.Text = "Eliminar";
            
            int columnIndex = 0;
            if (dataGridView1.Columns["Eliminar"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
        }

        public void limpiar()
        {
            

        }

        BLL.Maestros.Clientes gestorcl = new BLL.Maestros.Clientes();
        BLL.Maestros.Productos gesprod = new BLL.Maestros.Productos();
        private void btnagregarcarrito_Click(object sender, EventArgs e)
        {
            
            BE.Negocio.Carrito carrito = new BE.Negocio.Carrito(int.Parse(comboBox1.SelectedIndex.ToString()), int.Parse(comboBox2.Text), DateTime.Now, int.Parse(controlUsuario1.Texto),double.Parse(controlUsuario2.Texto)  );
            var idcl = gestorcl.listar()[comboBox1.SelectedIndex].Idcl;

            carrito.Idcl = idcl;
            carrito.Idprod = int.Parse(comboBox2.Text);
            carrito.Fecha = DateTime.Now;
            carrito.Cant = int.Parse(controlUsuario1.Texto);
            carrito.Costo = carrito.Cant * int.Parse(controlUsuario2.Texto);

            
            GetCarrito.Agregarcarrito(carrito);
            enlazar();
            
            comboBox1.Enabled = false;
            MessageBox.Show("El producto fue agregado al carrito");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (BE.Maestros.Precios item in gestorprecio.Listar_precios())
                {
                    if (item.Idprod == int.Parse(comboBox2.Text))
                    {
                        
                        double aux = 0;
                        aux = item.Precio;
                        controlUsuario2.Texto = aux.ToString();
                       
                    }
                }

                foreach (BE.Maestros.Productos item in gesprod.listar())
                {
                    if (item.ID_producto==int.Parse(comboBox2.Text))
                    {
                        if (item.Cantidad<int.Parse(controlUsuario1.Texto))
                        {
                            MessageBox.Show("El producto seleccionado esta agotado");
                            btnagregarcarrito.Enabled = false;
                            btnfactura.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                try
                {
                    foreach (BE.Negocio.Carrito item in GetCarrito.lista())
                    {
                        GetCarrito.lista().Remove(item);
                        enlazar();
                        MessageBox.Show("El producto fue eliminado del carrito");
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }

        BE.Negocio.Pedido_Cab caabecera = new BE.Negocio.Pedido_Cab();
        BE.Negocio.Pedido_det detalle = new BE.Negocio.Pedido_det();

        BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
        private void btnfactura_Click(object sender, EventArgs e)
        {
            var idcl = gestorcl.listar()[comboBox1.SelectedIndex].Idcl;
            caabecera.ID_clientes = idcl;
            caabecera.Estado = 0;
            caabecera.Fechaact = DateTime.Now;
            caabecera.Fechagen = DateTime.Now;

            //pedidos.Generarcab(caabecera);
            var idpedido = int.Parse(pedidos.Generarcab(caabecera));

            try
            {
                foreach (BE.Negocio.Carrito item in GetCarrito.lista())
                {


                    detalle.ID_pedido = idpedido;
                    detalle.ID_clientes = caabecera.ID_clientes;
                    detalle.ID_producto = item.Idprod;
                    detalle.Cantidad = item.Cant;
                    detalle.Costo = item.Costo;

                    pedidos.Cargardet(detalle);
                    

                }

                GetCarrito.vaciarcarrito();
            }
            catch (Exception)
            {

                throw;
            }
            foreach (BE.Maestros.Productos item in gesprod.listar())
            {
                if (item.ID_producto == detalle.ID_producto)
                {
                    item.Cantidad = item.Cantidad - detalle.Cantidad;
                    item.Medidas = item.Medidas;
                    item.Tipo = item.Tipo;

                    gesprod.editar_prod(item);
                }
            }

            MessageBox.Show("Factura generada exitosamente");
            enlazar();

        }
    }
}
