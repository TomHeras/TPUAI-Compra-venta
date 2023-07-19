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
    public partial class BACKUP : Form
    {

        string CarpetaB;
        string ArchivoB;

        Seguridad.Backup_restore BackupRestore = new Seguridad.Backup_restore();

        public BACKUP()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                FolderBrowserDialog Carpeta = new FolderBrowserDialog();


                if (Carpeta.ShowDialog() == DialogResult.OK)
                {
                    CarpetaB = Carpeta.SelectedPath;

                    textBox1.Text = CarpetaB;
                }
            }

            if (radioButton2.Checked == true)
            {
                OpenFileDialog Archivo = new OpenFileDialog();

                if (Archivo.ShowDialog() == DialogResult.OK)
                {
                    ArchivoB = Archivo.FileName;

                    textBox1.Text = ArchivoB;
                }
            }
        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    BackupRestore.GenerarBackUp(textBox1.Text);

                    MessageBox.Show("Realizado");
                }
                else
                {
                    MessageBox.Show("Elija un directorio");
                }
            }

            if (radioButton2.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    BackupRestore.GenerarRestore(textBox1.Text);

                    MessageBox.Show("Realizado");
                }
                else
                {
                    MessageBox.Show("Elija un directorio");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BACKUP_Load(object sender, EventArgs e)
        {

        }
    }
}
