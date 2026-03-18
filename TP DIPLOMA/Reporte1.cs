using BE;
using Seguridad.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DIPLOMA
{
    public partial class Reporte1 : Form
    {
        public Reporte1()
        {
            InitializeComponent();
        }

        BLL.Negocio.Pedidos gestorpedi = new BLL.Negocio.Pedidos();
        BLL.Maestros.Productos gestorprd = new BLL.Maestros.Productos();

        BLL.Traductor tradu = new BLL.Traductor();

        int cant = 0, cont = 0;
        double total = 0.0;

        private void Reporte1_Load(object sender, EventArgs e)
        {
            CalcularTotales();

            llenar();

            ProductosMasVendidos();

            ProductosAReponer();

            ConfigurarGrids();

            Autosize();

            Traducir(); // ← TRADUCCION
        }

        //--------------------------------------------
        // CALCULO DE TOTALES
        //--------------------------------------------
        public void CalcularTotales()
        {
            foreach (BE.Negocio.Pedido_det item in gestorpedi.listardetalles())
            {
                cant += item.Cantidad;
                total += item.Costo;
            }

            foreach (BE.Negocio.Pedido_Cab item in gestorpedi.listarcabecera())
            {
                cont++;
            }
        }

        //--------------------------------------------
        // LLENAR TEXTBOX
        //--------------------------------------------
        public void llenar()
        {
            textBox1.Text = cont.ToString();
            textBox2.Text = cant.ToString();
            textBox3.Text = total.ToString("C");

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        //--------------------------------------------
        // PRODUCTOS A REPONER
        //--------------------------------------------
        public void ProductosAReponer()
        {
            List<object> prds = new List<object>();

            foreach (BE.Maestros.Productos item in gestorprd.listar())
            {
                if (item.Cantidad < 1000)
                {
                    prds.Add(new
                    {
                        Producto = item.Tipo + " - " + item.Medidas,
                        Stock = item.Cantidad
                    });
                }
            }

            dataGridView1.DataSource = prds;

            if (dataGridView1.Columns.Count > 0)
            {
                try
                {
                    dataGridView1.Columns["Producto"].Name = "col_producto_reponer";
                    dataGridView1.Columns["Stock"].Name = "col_stock_reponer";
                    
                    dataGridView1.Columns["col_producto_reponer"].HeaderText = "Producto";
                    dataGridView1.Columns["col_stock_reponer"].HeaderText = "Stock";
                }
                catch (Exception)
                {

                throw;
                }

            }
            else
            {
                dataGridView1.Visible = false;
                label2.Visible=false;
            }
          



                
        }

        //--------------------------------------------
        // PRODUCTOS MAS VENDIDOS
        //--------------------------------------------
        public void ProductosMasVendidos()
        {
            Dictionary<int, int> ventasPorProducto = new Dictionary<int, int>();

            var detalles = gestorpedi.listardetalles();
            var cabeceras = gestorpedi.listarcabecera();

            foreach (var item in detalles)
            {
                var pedido = cabeceras.FirstOrDefault(p => p.ID_pedido == item.ID_pedido);

                if (pedido != null && (pedido.Estado == 1 || pedido.Estado == 2))
                {
                    if (ventasPorProducto.ContainsKey(item.ID_producto))
                        ventasPorProducto[item.ID_producto] += item.Cantidad;
                    else
                        ventasPorProducto.Add(item.ID_producto, item.Cantidad);
                }
            }

            var listaProductos = gestorprd.listar();

            var ranking = ventasPorProducto
                .OrderByDescending(x => x.Value)
                .Select(x =>
                {
                    var prod = listaProductos.FirstOrDefault(p => p.ID_producto == x.Key);

                    return new
                    {
                        Producto = prod != null ? prod.Tipo + " - " + prod.Medidas : "Producto desconocido",
                        CantidadVendida = x.Value
                    };
                })
                .ToList();

            dataGridView2.DataSource = ranking;

            dataGridView2.Columns["Producto"].Name = "col_producto_vendido";
            dataGridView2.Columns["CantidadVendida"].Name = "col_cantidad_vendida";

            dataGridView2.Columns["col_producto_vendido"].HeaderText = "Producto";
            dataGridView2.Columns["col_cantidad_vendida"].HeaderText = "Cantidad Vendida";
        }

        //--------------------------------------------
        // CONFIGURACION VISUAL
        //--------------------------------------------
        public void ConfigurarGrids()
        {
           
            dataGridView2.RowHeadersVisible = false;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
               
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["col_stock_reponer"].Value) < 0)
                {
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        //--------------------------------------------
        // AUTO AJUSTE GRID
        //--------------------------------------------
        public void Autosize()
        {
            AjustarGrid(dataGridView1);
            AjustarGrid(dataGridView2);
        }

        public void AjustarGrid(DataGridView grid)
        {
            grid.AutoResizeColumns();
            grid.AutoResizeRows();

            grid.Width = grid.RowHeadersWidth +
                         grid.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 15;

            grid.Height = grid.ColumnHeadersHeight +
                          grid.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 15;

            grid.ScrollBars = ScrollBars.None;
        }

        //--------------------------------------------
        // TRADUCCION
        //--------------------------------------------
        private void Traducir()
        {
            Iidioma idioma = null;

            if (SingletonSesion.Instancia.IsLogged())
                idioma = SingletonSesion.Instancia.Usuario.Idioma;

            var traducciones = tradu.ObtenerTraducciones(idioma);

            // TITULOS
            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;

            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;

            if (groupBox1.Tag != null && traducciones.ContainsKey(groupBox1.Tag.ToString()))
                groupBox1.Text = traducciones[groupBox1.Tag.ToString()].Texto;

            // LABELS
            if (labelVentas.Tag != null && traducciones.ContainsKey(labelVentas.Tag.ToString()))
                labelVentas.Text = traducciones[labelVentas.Tag.ToString()].Texto;

            if (labelProductos.Tag != null && traducciones.ContainsKey(labelProductos.Tag.ToString()))
                labelProductos.Text = traducciones[labelProductos.Tag.ToString()].Texto;

            if (labelTotal.Tag != null && traducciones.ContainsKey(labelTotal.Tag.ToString()))
                labelTotal.Text = traducciones[labelTotal.Tag.ToString()].Texto;

            // COLUMNAS GRID
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (traducciones.ContainsKey(col.Name))
                    col.HeaderText = traducciones[col.Name].Texto;
            }

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (traducciones.ContainsKey(col.Name))
                    col.HeaderText = traducciones[col.Name].Texto;
            }
        }
    }
}
