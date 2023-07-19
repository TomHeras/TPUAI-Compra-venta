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
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }
        BLL.Negocio.Pedidos gestorped = new BLL.Negocio.Pedidos();


        private void Ordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet19.estados' Puede moverla o quitarla según sea necesario.
            //this.estadosTableAdapter.Fill(this.tPMODELOSDataSet19.estados);
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet18.traercotizaciones' Puede moverla o quitarla según sea necesario.
            //this.traercotizacionesTableAdapter.Fill(this.tPMODELOSDataSet18.traercotizaciones);
            //// TODO: esta línea de código carga datos en la tabla 'cotizaYDetalle.levantarjoin' Puede moverla o quitarla según sea necesario.
            //this.levantarjoinTableAdapter.Fill(this.cotizaYDetalle.levantarjoin);
            //// TODO: esta línea de código carga datos en la tabla 'joincotizaciondetalle.Cotizacion' Puede moverla o quitarla según sea necesario.
            //this.cotizacionTableAdapter.Fill(this.joincotizaciondetalle.Cotizacion);
            //// TODO: esta línea de código carga datos en la tabla 'joincotizaciondetalle.Compras_Det' Puede moverla o quitarla según sea necesario.
            //this.compras_DetTableAdapter.Fill(this.joincotizaciondetalle.Compras_Det);
            enlazar();

        }
        BE.Cotizacion cotis = new BE.Cotizacion();
        BE.ComprasDEt detalles = new BE.ComprasDEt();
        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorped.traercotizaciones();
            string columna = "FechaGen";
            dataGridView1.Columns[columna].Visible = false;
            //string nueva1 = "Pedidos",vieja="IDPEDIDO";
            
            //dataGridView1.Columns[vieja].HeaderText = nueva1;
        }
        double cotizacion;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cotis = (BE.Cotizacion)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                textBox1.Text = cotis.ID_pedido.ToString();
                cotizacion = cotis.Cotizaciones;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void data2()
        {
            var listardetcompra = gestorped.traerdetallepedido().Where(x => x.ID_pedido.ToString() == textBox1.Text).ToList();
            dataGridView2.DataSource = listardetcompra;
            string columna = "ID_pedido";
            dataGridView2.Columns[columna].Visible = false;
            string columna2 = "ID_prov";
            dataGridView2.Columns[columna2].Visible = false;
        }
        BLL.Bitacora GetBitacora = new BLL.Bitacora();
        public void LLenarbitacoraC()
        {
            var idreg = 0;
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + cotis.ID_pedido + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now + "','" + "Cotizaciones', 'Generar colicitud de cotizacion',' Baja','4')";
            GetBitacora.Consultar(consulta);
            foreach (BE.Bitacora item in GetBitacora.listacambios())
            {
                idreg = item.IDREG;
            }
            //var idreg = GetBitacora.listacambios();
            string historico = "INSERT INTO CotizacionCambios (IDRegistro,Idpedido, Idprov, Usuario, Estado, descrip, criticidad, modulo, cotizacion, FechaGen, FechaAct, FechaBitacora) values('" + idreg + "','" + cotis.ID_pedido + "','" + cotis.ID_idprov + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + "4', 'Generar colicitud de cotizacion', 'baja', 'Cotizaciones','"+cotis.Cotizaciones + "','" + cotis.Fechagen + "','" + cotis.Fechaact + "','" + DateTime.Now + "')";
            GetBitacora.Consultar(historico);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //string consulta = "Select IDPROD, Cantidad,Precio from Compras Det where IDPEDIDO=" + textBox1.Text + "";
            try

            {
                data2();

                
            }
            catch (Exception)
            {

                throw;
            }
        }
        int idpdetalle=0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                detalles=(BE.ComprasDEt)dataGridView2.Rows[e.RowIndex].DataBoundItem;
                idpdetalle = detalles.ID_pedido;
                label5.Text = detalles.ID_producto.ToString();
                textBox2.Text = detalles.Costo.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)/// Generar orden de compra
        {
            try
            {
                foreach (BE.Cotizacion item in gestorped.traercotizaciones())
                {
                    if (item.ID_pedido == int.Parse(textBox1.Text))
                    {
                        if (item.Cotizaciones != 0)
                        {
                            cotis.ID_pedido = item.ID_pedido;
                            cotis.ID_idprov = item.ID_idprov;
                            cotis.Cotizaciones = item.Cotizaciones;
                            cotis.Fechagen = item.Fechagen;
                            cotis.Fechaact = item.Fechaact;
                            cotis.Estado = item.Estado;

                            string consulta = "Update Cotizacion set Estado= 4 where IDPEDIDO=" + int.Parse(textBox1.Text);
                            gestorped.Consulta(consulta);
                            LLenarbitacoraC();
                            enlazar();
                            CargarBitacora(SingletonSesion.Instancia.Usuario.usuario, "Generacion de orden de compra", "Media", "Compras");
                        }
                        else
                        {
                            MessageBox.Show("EL valor del campo cotizacion no puede estar en 0, por lo tanto no se puede generar la orden de compra");
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
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
        public void sumar()
        {
            double suma=0;
            foreach (BE.ComprasDEt item in gestorped.traerdetallepedido())
            {
                if (item.ID_pedido==int.Parse(textBox1.Text))
                {
                    suma = suma+item.Costo;
                }
            }

            string contuls = "Update Cotizacion set Cotizacion= " + suma + " where IDPEDIDO=" + int.Parse(textBox1.Text);
            gestorped.Consulta(contuls);
            //data2();
            enlazar();
        }
        private void button3_Click(object sender, EventArgs e)/// editar costo de los productos y sacar el total
        {
            try
            {
                string consulta = "Update [Compras Det] set Precio=" + double.Parse(textBox2.Text) + " where IDPEDIDO=" +int.Parse(textBox1.Text) +" AND IDPROD="+ int.Parse(label5.Text);
                gestorped.Consulta(consulta);
                data2();
                sumar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gestorped.xmlcompra();
        }
    }
}
