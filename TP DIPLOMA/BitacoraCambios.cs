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

            BE.BitacoraCAbmios bitacora2 = new BE.BitacoraCAbmios();
            BLL.Bitacora gestorbitacora = new BLL.Bitacora();
            BLL.Usuarios usugest = new BLL.Usuarios();
            BE.Usuario usus = new BE.Usuario();
            BLL.Maestros.Productos Productos = new BLL.Maestros.Productos();
            BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
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
                
                cmbusuarios.Items.Add(item.Nombre);
            }
            //cmbusuarios.Items.Add (usugest.Listarnicks());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true && checkBox3.Checked == false && checkBox2.Checked == false)
            {                
                string fecha1 = dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss");
                string fecha2=dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm:ss");

                DateTime desde, hasta;
                hasta =DateTime.Parse( fecha2);
                desde = DateTime.Parse(fecha1);                                
                var listardetcompra = gestorbitacora.Cambios().Where(x => x.Fecha >= desde).ToList().Where(x => x.Fecha <= hasta).ToList();
                dataGridView1.DataSource = listardetcompra;
            }
            else if (checkBox3.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false)
            {
                string criticidad= cmbxcriticidad.SelectedItem.ToString();//int.Parse(cmbusuarios.SelectedIndex.ToString());
                              
                if (criticidad=="Baja")
                {
                    criticidad = " Baja";
                }
                else if (criticidad =="Alta")
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
            
        }
        int idreg, idped;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bitacora2=(BE.BitacoraCAbmios)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            idreg = bitacora2.Idregistro;
            idped = bitacora2.Idpedido;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idreg2 = idreg - 1;
                foreach (BE.BitacoraCAbmios item in gestorbitacora.Cambios())
                {
                    if (item.Idregistro == idreg2)
                    {
                        int estado = item.Estado, pedido = idped;
                        string consulta = "Update Cotizacion set Estado=" + estado + "where IDPEDIDO=" + pedido;
                        gestorbitacora.Consultar(consulta);

                        foreach (BE.ComprasDEt item3 in pedidos.traerdetallepedido())
                        {
                            if (item3.ID_pedido == pedido)
                            {

                                foreach (BE.Maestros.Productos item2 in Productos.listar())
                                {
                                    if (item2.ID_producto == item3.ID_producto)
                                    {
                                        int cant = item2.Cantidad - item3.Cantidad;
                                        string consulta2 = "Update Stock set Cantidad=" + cant + "where ID_producto=" + item2.ID_producto;
                                        gestorbitacora.Consultar(consulta2);
                                        string contula3 = "Update BitacoraCambios set Estado=" + estado + "where=" + idreg2;
                                        gestorbitacora.Consultar(contula3);
                                    }
                                }
                            }   
                        }

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
