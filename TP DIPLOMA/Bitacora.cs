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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GestorBitacora.Listar();
            
        }
    }
}
