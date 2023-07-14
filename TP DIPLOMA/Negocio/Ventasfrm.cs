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
    public partial class Ventasfrm : Form
    {
        public Ventasfrm()
        {
            InitializeComponent();
        }
        public void enlazar()
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet6.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.tPMODELOSDataSet6.estados);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorped.listarcabecera();

        }
        private void Ventasfrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet6.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.tPMODELOSDataSet6.estados);
            enlazar();
        }

        BE.Negocio.Pedido_Cab cab = new BE.Negocio.Pedido_Cab();
        BLL.Negocio.Pedidos gestorped = new BLL.Negocio.Pedidos();

        

        private void button2_Click(object sender, EventArgs e)
        {
            var listcabecera=gestorped.listarcabecera().Where(x=>x.ID_pedido.ToString()==textBox1.Text).ToList();

            dataGridView1.DataSource = listcabecera;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (BE.Negocio.Pedido_Cab item in gestorped.listarcabecera())
            {
                if (textBox1.Text == item.ID_pedido.ToString())
                {
                    item.Estado = comboBox1.SelectedIndex;
                    item.Fechaact = DateTime.Now;

                    gestorped.editarestado(item);
                    MessageBox.Show("El cambio fue registrado");
                    enlazar();
                    textBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cab = (BE.Negocio.Pedido_Cab)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                textBox1.Text = cab.ID_pedido.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
