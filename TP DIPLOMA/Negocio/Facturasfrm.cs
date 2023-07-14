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
    public partial class Facturasfrm : Form
    {
        public Facturasfrm()
        {
            InitializeComponent();
        }
        BE.Negocio.Pedido_det detalle = new BE.Negocio.Pedido_det();
        BLL.Negocio.Pedidos gestor = new BLL.Negocio.Pedidos();

        public void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.listardetalles();
        }
        private void Facturasfrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet6.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.tPMODELOSDataSet6.estados);
            enlazar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detalle = (BE.Negocio.Pedido_det)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            textBox1.Text = detalle.ID_pedido.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (BE.Negocio.Pedido_det det in gestor.listardetalles())
            {
                det.ID_pedido = int.Parse(textBox1.Text);
                foreach (BE.Negocio.Pedido_Cab item in gestor.listarcabecera())
                {
                    if (item.ID_pedido==det.ID_pedido)
                    {
                        item.Estado = comboBox1.SelectedIndex;
                        item.Fechaact = DateTime.Now;
                        gestor.editarestado(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listdetalle = gestor.listardetalles().Where(x => x.ID_pedido.ToString() == textBox1.ToString());

            dataGridView1.DataSource = listdetalle;
        }
    }
}
