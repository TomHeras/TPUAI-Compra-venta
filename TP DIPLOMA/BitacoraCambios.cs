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

namespace TP_DIPLOMA
{
    public partial class BitacoraCambios : Form
    {
        public BitacoraCambios()
        {
            InitializeComponent();
        }

        private void BitacoraCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet21.Usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter.Fill(this.tPMODELOSDataSet21.Usuarios);
            enlazar();

        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
        BE.BitacoraCAbmios bitacora2 = new BE.BitacoraCAbmios();
        BLL.Bitacora gestorbitacora = new BLL.Bitacora();
        BLL.Usuarios usugest = new BLL.Usuarios();
        BE.Usuario usus = new BE.Usuario();
        BLL.Maestros.Productos Productos = new BLL.Maestros.Productos();
        BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
        BLL.Cambioshistorico Historico=new BLL.Cambioshistorico();
<<<<<<< HEAD
=======
=======
            BE.BitacoraCAbmios bitacora2 = new BE.BitacoraCAbmios();
            BLL.Bitacora gestorbitacora = new BLL.Bitacora();
            BLL.Usuarios usugest = new BLL.Usuarios();
            BE.Usuario usus = new BE.Usuario();
            BLL.Maestros.Productos Productos = new BLL.Maestros.Productos();
            BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorbitacora.Cambios();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            foreach (BE.Usuario item in usugest.Listarnicks())
            {
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
                
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                cmbusuarios.Items.Add(item.Nombre);
            }
            //cmbusuarios.Items.Add (usugest.Listarnicks());
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
            if (checkBox1.Checked == true && checkBox3.Checked == false && checkBox2.Checked == false)
            {
                string fecha1 = dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss");
                string fecha2 = dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm:ss");

                DateTime desde, hasta;
                hasta = DateTime.Parse(fecha2);
                desde = DateTime.Parse(fecha1);
<<<<<<< HEAD
=======
=======
            if (checkBox1.Checked== true && checkBox3.Checked == false && checkBox2.Checked == false)
            {                
                string fecha1 = dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss");
                string fecha2=dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm:ss");

                DateTime desde, hasta;
                hasta =DateTime.Parse( fecha2);
                desde = DateTime.Parse(fecha1);                                
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                var listardetcompra = gestorbitacora.Cambios().Where(x => x.Fecha >= desde).ToList().Where(x => x.Fecha <= hasta).ToList();
                dataGridView1.DataSource = listardetcompra;
            }
            else if (checkBox3.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false)
            {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                string criticidad = cmbxcriticidad.SelectedItem.ToString();//int.Parse(cmbusuarios.SelectedIndex.ToString());

                if (criticidad == "Baja")
                {
                    criticidad = " Baja";
                }
                else if (criticidad == "Alta")
<<<<<<< HEAD
=======
=======
                string criticidad= cmbxcriticidad.SelectedItem.ToString();//int.Parse(cmbusuarios.SelectedIndex.ToString());
                              
                if (criticidad=="Baja")
                {
                    criticidad = " Baja";
                }
                else if (criticidad =="Alta")
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                {
                    criticidad = " Alta";
                }
                else
                {
                    criticidad = " Media";
                }
                var listardetcompra = gestorbitacora.Cambios().Where(x => x.Criticidad == criticidad).ToList();
                dataGridView1.DataSource = listardetcompra;
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == false && checkBox1.Checked == false)
            {
                var listardetcompra = gestorbitacora.Cambios().Where(x => x.Usuario == cmbusuarios.SelectedItem.ToString()).ToList();
                dataGridView1.DataSource = listardetcompra;
            }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b

        }
        int idreg, idped;string tipo;
        double cotizacion = 0.0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bitacora2 = (BE.BitacoraCAbmios)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            idreg = bitacora2.Idregistro;
            idped = bitacora2.Idpedido;
            tipo = bitacora2.Modulo;
    
        }
        BLL.Bitacora bitacora = new BLL.Bitacora();
        public void LLenarbitacoraC( int estado)
        {
            var idreg = 0;
            string consulta = "INSERT INTO BitacoraCambios (Idpedido, NickUsuario, Fecha, Modulo, Operacion, Criticidad, Estado) VALUES ('" + idped + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + tipo+"', 'Reetablece registro del pedido',' Baja','"+estado+"')";
            bitacora.Consultar(consulta);
            foreach (BE.Bitacora item in bitacora.listacambios())
            {
                idreg = item.IDREG;
            }
            //var idreg = GetBitacora.listacambios();
            if (tipo=="Compras")
            {
                foreach (BE.Cotizacion item in pedidos.traercotizaciones())
                {
                    if (idped==item.ID_pedido)
                    {
                        cotizacion = item.Cotizaciones;
                    }
                }
            }
            else
            {
                cotizacion = 0.0;
            }
            string historico = "INSERT INTO Cambioshistorico ( Idpedido, Tipo, Estado, Cotizacion, Usuario, Fecha) values('" + idped + "','" + tipo+ "','" + 2 + "','" + cotizacion + "','" + SingletonSesion.Instancia.Usuario.usuario + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            bitacora.Consultar(historico);
<<<<<<< HEAD
=======
=======
            
        }
        int idreg, idped;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bitacora2=(BE.BitacoraCAbmios)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            idreg = bitacora2.Idregistro;
            idped = bitacora2.Idpedido;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                int idreg2 = idreg;
                int estadoact = 0;

                foreach (BE.Cotizacion item in pedidos.traercotizaciones())
                {
                    if (item.ID_pedido==idped)
                    {
                        estadoact = item.Estado;
                    }
                }
<<<<<<< HEAD
=======
=======
                int idreg2 = idreg - 1;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                foreach (BE.BitacoraCAbmios item in gestorbitacora.Cambios())
                {
                    if (item.Idregistro == idreg2)
                    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                        int  pedido = idped;
                       
                        int estado = Historico.ObtenerEstadoAnterior(pedido);
                        string consulta = "Update Cotizacion set Estado=" + estado + " where IDPEDIDO=" + pedido;
<<<<<<< HEAD
=======
=======
                        int estado = item.Estado, pedido = idped;
                        string consulta = "Update Cotizacion set Estado=" + estado + "where IDPEDIDO=" + pedido;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                        gestorbitacora.Consultar(consulta);

                        foreach (BE.ComprasDEt item3 in pedidos.traerdetallepedido())
                        {
                            if (item3.ID_pedido == pedido)
                            {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                                if (estadoact==2)
                                {
                                    foreach (BE.Maestros.Productos item2 in Productos.listar())
                                    {
                                        if (item2.ID_producto == item3.ID_producto)
                                        {
<<<<<<< HEAD
=======
=======

                                foreach (BE.Maestros.Productos item2 in Productos.listar())
                                {
                                    if (item2.ID_producto == item3.ID_producto)
                                    {
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                                        int cant = item2.Cantidad - item3.Cantidad;
                                        string consulta2 = "Update Stock set Cantidad=" + cant + "where ID_producto=" + item2.ID_producto;
                                        gestorbitacora.Consultar(consulta2);
                                        string contula3 = "Update BitacoraCambios set Estado=" + estado + "where=" + idreg2;
                                        gestorbitacora.Consultar(contula3);
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                                        }
                                    }

                                }
                                


                            }
                        }

                        LLenarbitacoraC( estado);

<<<<<<< HEAD
=======
=======
                                    }
                                }
                            }   
                        }

>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
