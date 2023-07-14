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

namespace TP_DIPLOMA
{
    public partial class Backupres : Form
    {
        public Backupres()
        {
            InitializeComponent();
        }
        Backup_restore bcp = new Backup_restore();


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = bcp.final;
            bcp.GenerarBackUp(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "Restore files(*.bak)|*.bak";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            bcp.GenerarRestore(bcp.final);
        }
    }
}
