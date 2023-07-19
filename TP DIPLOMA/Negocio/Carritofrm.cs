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
            Combo();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        public void Combo()
        {
            comboBox1.DataSource = getcl.listar();
            comboBox2.DataSource = getprod.listarprod();
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

            txtcantidad.Clear();
        }

        BLL.Maestros.Clientes gestorcl = new BLL.Maestros.Clientes();
        BLL.Maestros.Productos gesprod = new BLL.Maestros.Productos();
        private void btnagregarcarrito_Click(object sender, EventArgs e)
        {
            
            BE.Negocio.Carrito carrito = new BE.Negocio.Carrito(int.Parse(comboBox1.SelectedIndex.ToString()), int.Parse(comboBox2.Text), DateTime.Now, int.Parse(txtcantidad.Text),double.Parse(controlUsuario2.Texto)  );
            var idcl = gestorcl.listar()[comboBox1.SelectedIndex].Idcl;

            carrito.Idcl = idcl;
            carrito.Idprod = int.Parse(comboBox2.Text);
            carrito.Fecha = DateTime.Now;
            carrito.Cant = int.Parse(txtcantidad.Text);
            
            carrito.Costo = double.Parse(controlUsuario2.Texto);

            
            GetCarrito.Agregarcarrito(carrito);
            enlazar();
            
            comboBox1.Enabled = false;
            MessageBox.Show("El producto fue agregado al carrito");
            limpiar();
        }
        double precio1;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text!="")
                {
                    foreach (BE.Maestros.Productos item in gesprod.listar())
                    {
                        precio1 = item.Precio;
                        controlUsuario2.Texto = precio1.ToString();
                    }

                    foreach (BE.Maestros.Productos item in gesprod.listar())
                    {
                        if (item.ID_producto == int.Parse(comboBox2.Text))
                        {
                            if (item.Cantidad < int.Parse(txtcantidad.Text))
                            {
                                MessageBox.Show("El producto seleccionado esta agotado");
                                btnagregarcarrito.Enabled = false;
                                btnfactura.Enabled = false;
                            }
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
        public void DigitosVerificadores()
        {
            BLL.Digitos DV = new BLL.Digitos();
            BLL.Bitacora Bi = new BLL.Bitacora();
            long dv = 0;
            dv = DV.DVH("select * from Pedidosdet where DVH = 0", "Pedidosdet");
            Bi.Consultar("update Pedidosdet set DVH='" + dv + "' where DVH = 0");
            DV.InsertarDVV("Pedidosdet", "DVH");
        }
        private void btnfactura_Click(object sender, EventArgs e)
        {
            var idcl = gestorcl.listar()[comboBox1.SelectedIndex].Idcl;
            caabecera.ID_clientes = idcl;
            caabecera.Estado = 0;
            caabecera.Fechaact = DateTime.Now;
            caabecera.Fechagen = DateTime.Now;
            caabecera.DVH = 0;
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
                    detalle.DVH = 0;
                   
                    pedidos.Cargardet(detalle);
                    //DigitosVerificadores();

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
            CargarBitacora(SingletonSesion.Instancia.Usuario.usuario, "Generacion de Facutra", "Media", "Facturas");
        }
        BLL.Bitacora gestorbitacora = new BLL.Bitacora();
        BE.Bitacora BitacoraTemp;

        void CargarBitacora(string Nick, string Descripcion, string Criticidad, string modulo)
        {
            BitacoraTemp = new BE.Bitacora();

            BitacoraTemp.NickUsuario = Nick;
            BitacoraTemp.Fecha = DateTime.Now;
            //BitacoraTemp.Hora = DateTime.Parse( DateTime.Now.ToShortTimeString());
            BitacoraTemp.Modulo = modulo;
            BitacoraTemp.Descripcion = Descripcion;
            BitacoraTemp.Criticidad = Criticidad;

            gestorbitacora.InsertarBitacora(BitacoraTemp);
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcantidad.Text != "")
                {
                    int cantidad = int.Parse(txtcantidad.Text);
                    controlUsuario2.Texto = (precio1 * cantidad).ToString();
                }
                else
                {
                    txtcantidad.Text = "0";
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
