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

namespace TP_DIPLOMA
{
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = gestorproveedores.listrarprovs(); // Suponiendo que listar() devuelve una lista de objetos Proveedores
            comboBox1.DisplayMember = "Nombre";  // Esto mostrará el nombre del proveedor en el ComboBox
            comboBox1.ValueMember = "ID_proveedor";    // Esto utilizará Idprov como el valor seleccionado

            // Inicializar la lista de productos aquí, después de que gestorprod esté disponible
            listaProductos = gestorprod.listar();

            // Limpiar el ComboBox de productos al inicio
            comboBox2.DataSource = null;

            // Asignar el evento para cargar los productos relacionados cuando se cambie el proveedor
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
        List<BE.Maestros.Productos> listaProductos;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { // Obtener el id del proveedor seleccionado
            int idProveedorSeleccionado = (int)comboBox1.SelectedValue;

            // Obtener los productos relacionados con ese proveedor usando LINQ
            var productosRelacionados = (from rel in gestorPP.listrarPP() // Lista de la tabla PROV_PROD
                                         join prod in listaProductos on rel.Producto equals prod.ID_producto
                                         where rel.Proveedor == idProveedorSeleccionado
                                         select new
                                         {
                                             ProductoId = prod.ID_producto,
                                             ProductoNombre = prod.ID_producto  // Cambia a la propiedad correcta del producto
                                         }).ToList();

            // Cargar los productos relacionados en el ComboBox de productos
            comboBox2.DataSource = productosRelacionados;
            comboBox2.DisplayMember = "ProductoNombre";
            comboBox2.ValueMember = "ProductoId";

        }
            BE.Maestros.Productos prod = new BE.Maestros.Productos();
        BLL.Maestros.Productos gestorprod = new BLL.Maestros.Productos();
        BE.Maestros.Proveedores proveedores = new BE.Maestros.Proveedores();
        BLL.Maestros.Proveedores gestorproveedores = new BLL.Maestros.Proveedores();
        BE.AuxiliarRelaionarPP PP = new BE.AuxiliarRelaionarPP();
        BLL.RelacionarPP gestorPP = new BLL.RelacionarPP();
        BLL.Negocio.Carrito GetCarrito = new BLL.Negocio.Carrito();
        BE.ComprasDEt detalles = new BE.ComprasDEt();
        BE.Cotizacion Cotizacion = new BE.Cotizacion();
        BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
        public void cargarprodsrelacionados()
        {
            int idprov = int.Parse(comboBox1.SelectedValue.ToString());
            foreach (BE.AuxiliarRelaionarPP item in gestorPP.listrarPP())//agregar toda la consulta en las capas, la logica es tirar un listar de todo y usar un if para cuando item.idprov sea igual al valor de la combo.
            {
                if (item.Proveedor==idprov)
                {
                    comboBox2.Items.Add(item.Producto);
                }
            }
        }
        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetCarrito.ordencompra();
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Eliminar";
            uninstallButtonColumn.Text = "Eliminar";

            int columnIndex = 0;
            if (dataGridView1.Columns["Eliminar"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            //cargarprodsrelacionados();

        }

        private void btnagregarcarrito_Click(object sender, EventArgs e)
        {
            BE.compra orden = new BE.compra(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox2.SelectedItem.ToString()), DateTime.Now, int.Parse(controlUsuario1.Texto));

            orden.Idprov = int.Parse(comboBox1.SelectedItem.ToString());
            orden.Idprod = int.Parse(comboBox2.Text);
            orden.Fecha = DateTime.Now;
            orden.Cant = int.Parse(controlUsuario1.Texto);

            GetCarrito.agregaralista(orden);

            enlazar();
            MessageBox.Show("EL producto fue agregado a la lista");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                try
                {
                    foreach (BE.compra item in GetCarrito.ordencompra())
                    {
                        GetCarrito.ordencompra().Remove(item);
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
        BLL.Bitacora GetBitacora = new BLL.Bitacora();
        public void LLenarbitacoraC()
        {
            var idreg=0;
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + detalles.ID_pedido+"','"+ SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now + "','" + "Cotizaciones', 'Generar colicitud de cotizacion',' Baja','0')";
            GetBitacora.Consultar(consulta);
            foreach (BE.Bitacora item in GetBitacora.listacambios())
            {
                 idreg = item.IDREG;
            }
            //var idreg = GetBitacora.listacambios();
            string historico = "INSERT INTO CotizacionCambios (IDRegistro,Idpedido, Idprov, Usuario, Estado, descrip, criticidad, modulo, cotizacion, FechaGen, FechaAct, FechaBitacora) values('"+idreg +"','"+ detalles.ID_pedido + "','" + Cotizacion.ID_idprov + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + "0', 'Generar colicitud de cotizacion', 'baja', 'Cotizaciones','0" + "','" + Cotizacion.Fechagen + "','" + Cotizacion.Fechaact + "','" + DateTime.Now+"')";
            GetBitacora.Consultar(historico);
        }
        private void btnfactura_Click(object sender, EventArgs e)
        {
            Cotizacion.ID_idprov = int.Parse(comboBox1.SelectedValue.ToString());
            Cotizacion.Estado = 0;
            Cotizacion.Fechaact = DateTime.Now;
            Cotizacion.Fechagen = DateTime.Now;
            Cotizacion.Cotizaciones = 0.0;

            var idpedido = int.Parse(pedidos.cotizacion(Cotizacion));
            
            try
            {
                foreach (BE.compra item in GetCarrito.ordencompra())
                {
                    detalles.ID_pedido = idpedido;
                    detalles.ID_prov= Cotizacion.ID_idprov;
                    detalles.ID_producto = item.Idprod;
                    detalles.Cantidad = item.Cant;
                    detalles.Costo = 0.0;
                    pedidos.ordencompra(detalles);

                    
                }

                GetCarrito.vaciarlista();
                LLenarbitacoraC();
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Solicitud generada exitosamente");
            comboBox1.Enabled = true;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            controlUsuario1.limpiar();
            enlazar();
        }
    }
}
