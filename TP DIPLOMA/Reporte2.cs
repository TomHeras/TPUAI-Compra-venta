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
using Seguridad;
using Seguridad.Composite;
using Seguridad.MultiIdioma;


namespace TP_DIPLOMA
{
    public partial class Reporte2 : Form
    {
        public Reporte2()
        {
            InitializeComponent();
        }

        BE.PedidoReport coti=new BE.PedidoReport();
        BLL.Traductor tradu = new BLL.Traductor();
        private void Reporte2_Load(object sender, EventArgs e)
        {

            ReporteCompras();
            dataGridView1.Columns["Cotizacion"].Visible = false;
           



            var pedidos = gestor.ReporteCompras(); // List<PedidoDTO>

            // 1) Sumar una cotización por cada IDPedido
            decimal totalCotizaciones = pedidos
                .GroupBy(p => p.IDPedido)                     // agrupa por pedido
                .Select(g => g.Select(x => x.Cotizacion)
                              .Distinct()
                              .First())                        // toma una cotización del pedido
                .Sum();


            txtgastado.Text= totalCotizaciones.ToString();

            

            Traducir();
        }


        BLL.Negocio.Pedidos gestor = new BLL.Negocio.Pedidos();

        private void ReporteCompras()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.ReporteCompras();
            dataGridView1.Columns["IDPedido"].Name = "nro_pedido";
            dataGridView1.Columns["Proveedor"].Name = "nroProv";
            dataGridView1.Columns["Tipo"].Name = "Tipo";
            dataGridView1.Columns["Medidas"].Name = "Medida";
            dataGridView1.Columns["Cantidad"].Name = "cant";
            dataGridView1.Columns["Estado"].Name = "estado";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                coti= (BE.PedidoReport)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtpedido.Text = coti.IDPedido.ToString();
                textBox3.Text=(coti.Cotizacion.ToString());

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idped = int.Parse(txtpedido.Text);


            var filtrados = gestor.ReporteCompras()
                                      .Where(p => p.IDPedido == idped)
                                      .Select(p => (decimal?)p.Cotizacion)
                                      .Distinct()
                                      .FirstOrDefault()
                                      ;

            textBox3 .Text = filtrados.ToString();

        }

        public void Traducir()
        {
            Iidioma idioma = null;

            if (SingletonSesion.Instancia.IsLogged())
                idioma = SingletonSesion.Instancia.Usuario.Idioma;

            var traducciones = tradu.ObtenerTraducciones(idioma);

            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;

            if (lblgastado.Tag != null && traducciones.ContainsKey(lblgastado.Tag.ToString()))
                lblgastado.Text = traducciones[lblgastado.Tag.ToString()].Texto;

            if (label3.Tag != null && traducciones.ContainsKey(label3.Tag.ToString()))
                label3.Text = traducciones[label3.Tag.ToString()].Texto;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (traducciones.ContainsKey(col.Name))
                    col.HeaderText = traducciones[col.Name].Texto;
            }



        }
    }
}
