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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }
        BLL.Bitacora GestorBitacora = new BLL.Bitacora();
        private void Bitacora_Load(object sender, EventArgs e)
        {
            enlazar();
            
        }
        BE.BitacoraCAbmios bitacora2 = new BE.BitacoraCAbmios();
        BLL.Bitacora gestorbitacora = new BLL.Bitacora();
        BLL.Usuarios usugest = new BLL.Usuarios();
        BE.Usuario usus = new BE.Usuario();
        BLL.Maestros.Productos Productos = new BLL.Maestros.Productos();
        BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
        public  void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GestorBitacora.Listar();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            foreach (BE.Usuario item in usugest.Listarnicks())
            {

                cmbusuarios.Items.Add(item.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde, hasta;

                // Validación y filtro por fechas
                if (checkdias.Checked && !checkusuarios.Checked && !checkmodulos.Checked && !checkcriticidad.Checked)
                {
                    desde = dateTimePicker1.Value;
                    hasta = dateTimePicker2.Value;

                    var listardetcompra = gestorbitacora.Listar()
                        .Where(x => x.Fecha >= desde && x.Fecha <= hasta)
                        .ToList();

                    dataGridView1.DataSource = listardetcompra;
                }
                // Filtro por criticidad
                else if (!checkdias.Checked && !checkusuarios.Checked && !checkmodulos.Checked && checkcriticidad.Checked)
                {
                    if (comboBox3.SelectedItem != null)
                    {
                        string criticidad = comboBox3.SelectedItem.ToString();

                        var listardetcompra = gestorbitacora.Listar()
                            .Where(x => x.Criticidad == criticidad)
                            .ToList();

                        dataGridView1.DataSource = listardetcompra;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona una criticidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // Filtro por usuario
                else if (!checkdias.Checked && checkusuarios.Checked && !checkmodulos.Checked && !checkcriticidad.Checked)
                {
                    if (cmbusuarios.SelectedItem != null)
                    {
                        string usuario = cmbusuarios.SelectedItem.ToString();

                        var listardetcompra = gestorbitacora.Listar()
                            .Where(x => x.NickUsuario == usuario)
                            .ToList();

                        dataGridView1.DataSource = listardetcompra;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // Filtro por módulo
                else if (!checkdias.Checked && !checkusuarios.Checked && checkmodulos.Checked && !checkcriticidad.Checked)
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        string modulo = comboBox1.SelectedItem.ToString();

                        var listardetcompra = gestorbitacora.Listar()
                            .Where(x => x.Modulo == modulo)
                            .ToList();

                        dataGridView1.DataSource = listardetcompra;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un módulo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        BE.Usuario user = new BE.Usuario();
        BLL.Usuarios gestorusuarios = new BLL.Usuarios();
        BE.userauxiliar usaux = new BE.userauxiliar();
        BE.Bitacora bit = new BE.Bitacora();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bit = (BE.Bitacora)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            foreach (BE.Usuario item in gestorusuarios.Listar())
            {
                if (item.Usuarios==bit.NickUsuario)
                {
                    txtape.Text = item.Apellido;
                    txtname.Text = item.Nombre;
                }
            }
        }
    }
}
