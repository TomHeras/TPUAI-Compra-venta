<<<<<<< HEAD
﻿using Seguridad.Singleton;
using System;
=======
<<<<<<< HEAD
﻿using Seguridad.Singleton;
using System;
=======
﻿using System;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
=======
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
=======
using Seguridad.Singleton;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b

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
<<<<<<< HEAD
        BLL.Maestros.Productos gestorProd = new BLL.Maestros.Productos();
        BE.Maestros.Productos produ = new BE.Maestros.Productos();
=======
<<<<<<< HEAD
        BLL.Maestros.Productos gestorProd = new BLL.Maestros.Productos();
        BE.Maestros.Productos produ = new BE.Maestros.Productos();
=======
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
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
<<<<<<< HEAD
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + coti.ID_pedido + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "Cotizaciones', 'Generar colicitud de cotizacion',' Baja','2')";
=======
<<<<<<< HEAD
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + coti.ID_pedido + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "Cotizaciones', 'Generar colicitud de cotizacion',' Baja','2')";
=======
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + coti.ID_pedido + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now + "','" + "Cotizaciones', 'Generar colicitud de cotizacion',' Baja','2')";
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
            bitacora.Consultar(consulta);
            foreach (BE.Bitacora item in bitacora.listacambios())
            {
                idreg = item.IDREG;
            }
            //var idreg = GetBitacora.listacambios();
<<<<<<< HEAD
            string historico = "INSERT INTO Cambioshistorico ( Idpedido, Tipo, Estado, Cotizacion, Usuario, Fecha) values('" + coti.ID_pedido + "','" + "Compras" + "','" + 2 + "','" + coti.Cotizaciones + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
=======
<<<<<<< HEAD
            string historico = "INSERT INTO Cambioshistorico ( Idpedido, Tipo, Estado, Cotizacion, Usuario, Fecha) values('" + coti.ID_pedido + "','" + "Compras" + "','" + 2 + "','" + coti.Cotizaciones + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
=======
            string historico = "INSERT INTO CotizacionCambios (IDRegistro,Idpedido, Idprov, Usuario, Estado, descrip, criticidad, modulo, cotizacion, FechaGen, FechaAct, FechaBitacora) values('" + idreg + "','" + coti.ID_pedido + "','" + coti.ID_idprov + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + "2', 'Generar colicitud de cotizacion', 'baja', 'Cotizaciones','" + coti.Cotizaciones + "','" + coti.Fechagen + "','" + coti.Fechaact + "','" + DateTime.Now + "')";
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
            bitacora.Consultar(historico);
        }
        private void button2_Click(object sender, EventArgs e)//Actualizar estado a entregado
        {
            try
            {
                foreach (BE.Cotizacion item in gestorpedidos.traercotizaciones())
                {
<<<<<<< HEAD
                    if (item.ID_pedido == int.Parse(textBox1.Text))
=======
<<<<<<< HEAD
                    if (item.ID_pedido == int.Parse(textBox1.Text))
=======
                    if (item.ID_pedido==int.Parse(textBox1.Text))
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                    {
                        coti.ID_pedido = item.ID_pedido;
                        coti.ID_idprov = item.ID_idprov;
                        coti.Cotizaciones = item.Cotizaciones;
                        coti.Fechagen = item.Fechagen;
                        coti.Fechaact = item.Fechaact;
                        coti.Estado = item.Estado;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                        //foreach (BE.Maestros.Productos prods in )
                        //{

                        //}

<<<<<<< HEAD
=======
=======
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                    }
                }
                string consulta = "Update Cotizacion set Estado= 2 where IDPEDIDO=" + int.Parse(textBox1.Text);
                bitacora.Consultar(consulta);
                LLenarbitacoraC();
<<<<<<< HEAD
                sumarprod();
                MessageBox.Show("El Estado Fue cambiado con exito");
                
=======
<<<<<<< HEAD
                sumarprod();
                MessageBox.Show("El Estado Fue cambiado con exito");
                
=======
                MessageBox.Show("El Estado Fue cambiado con exito");
                sumarprod();
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b

            }
            catch (Exception)
            {

                throw;
<<<<<<< HEAD
            }
=======
<<<<<<< HEAD
            }
=======
            }           
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
        }
        public void sumarprod()
        {
            BE.Maestros.Productos pords = new BE.Maestros.Productos();
            BLL.Maestros.Productos productos = new BLL.Maestros.Productos();
            foreach (BE.ComprasDEt item in gestorpedidos.traerdetallepedido())
            {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                if (item.ID_pedido == int.Parse(textBox1.Text))
                {
                    pords.ID_producto = item.ID_producto;
                    foreach (BE.Maestros.Productos items in productos.listar())
                    {
                        if (items.ID_producto == pords.ID_producto)
                        {
                            //pords.Cantidad = items.Cantidad;
                            item.Cantidad = item.Cantidad + items.Cantidad;
                        }
                    }
                    string consulta = "Update Stock set cantidad=" + item.Cantidad + "where ID_producto=" + pords.ID_producto;
<<<<<<< HEAD
=======
=======
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
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                    bitacora.Consultar(consulta);
                }
            }
        }
    }
}
