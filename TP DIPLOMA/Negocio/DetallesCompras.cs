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
    public partial class DetallesCompras : Form
    {
        public DetallesCompras()
        {
            InitializeComponent();
        }

        BE.ComprasDEt deta = new BE.ComprasDEt();
        BE.Cotizacion coti = new BE.Cotizacion();
        BLL.Negocio.Pedidos gestorpedidos = new BLL.Negocio.Pedidos();
        BLL.Bitacora bitacora = new BLL.Bitacora();
        private void DetallesCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet20.estados' Puede moverla o quitarla según sea necesario.
            //this.estadosTableAdapter.Fill(this.tPMODELOSDataSet20.estados);
            enlazar();
        }

        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorpedidos.traerdetallepedido();
        }

        private void button1_Click(object sender, EventArgs e)//buscar pedidos
        {
            try
            {
                var listardetcompra = gestorpedidos.traerdetallepedido().Where(x => x.ID_pedido.ToString() == textBox1.Text).ToList();
                dataGridView1.DataSource = listardetcompra;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LLenarbitacoraC()
        {
            var idreg = 0;
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + coti.ID_pedido + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now + "','" + "Cotizaciones', 'Generar colicitud de cotizacion',' Baja','2')";
            bitacora.Consultar(consulta);
            foreach (BE.Bitacora item in bitacora.listacambios())
            {
                idreg = item.IDREG;
            }
            //var idreg = GetBitacora.listacambios();
            string historico = "INSERT INTO CotizacionCambios (IDRegistro,Idpedido, Idprov, Usuario, Estado, descrip, criticidad, modulo, cotizacion, FechaGen, FechaAct, FechaBitacora) values('" + idreg + "','" + coti.ID_pedido + "','" + coti.ID_idprov + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + "2', 'Generar colicitud de cotizacion', 'baja', 'Cotizaciones','" + coti.Cotizaciones + "','" + coti.Fechagen + "','" + coti.Fechaact + "','" + DateTime.Now + "')";
            bitacora.Consultar(historico);
        }
        private void button2_Click(object sender, EventArgs e)//Actualizar estado a entregado
        {
            try
            {
                foreach (BE.Cotizacion item in gestorpedidos.traercotizaciones())
                {
                    if (item.ID_pedido==int.Parse(textBox1.Text))
                    {
                        coti.ID_pedido = item.ID_pedido;
                        coti.ID_idprov = item.ID_idprov;
                        coti.Cotizaciones = item.Cotizaciones;
                        coti.Fechagen = item.Fechagen;
                        coti.Fechaact = item.Fechaact;
                        coti.Estado = item.Estado;

                    }
                }
                string consulta = "Update Cotizacion set Estado= 2 where IDPEDIDO=" + int.Parse(textBox1.Text);
                bitacora.Consultar(consulta);
                LLenarbitacoraC();
                MessageBox.Show("El Estado Fue cambiado con exito");
                sumarprod();

            }
            catch (Exception)
            {

                throw;
            }           
        }
        public void sumarprod()
        {
            BE.Maestros.Productos pords = new BE.Maestros.Productos();
            BLL.Maestros.Productos productos = new BLL.Maestros.Productos();
            foreach (BE.ComprasDEt item in gestorpedidos.traerdetallepedido())
            {
                if (item.ID_pedido==int.Parse(textBox1.Text))
                {
                    pords.ID_producto = item.ID_producto;
                    foreach  (BE.Maestros.Productos items in productos.listar())
                    {
                        if (items.ID_producto==pords.ID_producto)
                        {
                            //pords.Cantidad = items.Cantidad;
                            item.Cantidad =item.Cantidad +items.Cantidad;
                        }
                    }
                    string consulta = "Update Stock set cantidad="+item.Cantidad+"where ID_producto="+pords.ID_producto;
                    bitacora.Consultar(consulta);
                }
            }
        }
    }
}
