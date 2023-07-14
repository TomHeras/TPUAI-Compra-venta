using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Seguridad;
using Seguridad.MultiIdioma;
using BLL;

namespace TP_DIPLOMA
{
    public partial class Idioma : Form
    {

        BLL.idioma gestoridioma = new BLL.idioma();
        BLL.Traductor tradu = new BLL.Traductor();
        Idiomas tmp;
        Idiomas id = new Idiomas();
        BE.Etiquetas et = new Etiquetas();
        Etiqueta et2 = new Etiqueta();


        public Idioma()
        {
            InitializeComponent();
            ObtenerIdiomas();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            tmp = new Idiomas();
            tmp.Nombre = cmbidioma.Text;
            tmp.Default = false;
            MessageBox.Show(gestoridioma.InsertarIdioma(tmp));
            tmp = null;
            // insertar etiquetas   
            // gestoridioma.InsertarEtiquetas(3, 1, "default");
            var t = gestoridioma.GetAllEtiquetas();
            var i = tradu.ObtenerIdiomas();
            foreach (var etiquetas in t)
            {
                foreach (var idiomas in i)
                {
                    if (cmbidioma.Text == idiomas.Nombre)
                    {
                        gestoridioma.InsertarEtiquetas(idiomas.Id, etiquetas.Id, "default");
                    }

                }

            }

            ValidarComboBox();
            ObtenerIdiomas();

        }

       

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            GrillaIdioma.DataSource = null;
            GrillaIdioma.DataSource = gestoridioma.ObtenerEyT(cmbidioma2.Text);
        }

        private void GrillaIdioma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            et = (Etiquetas)GrillaIdioma.Rows[e.RowIndex].DataBoundItem;
            txtetiqueta.Text = et.Nombre_Etiqueta.ToString();
            txttraduccion.Text = et.Traduccion.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int i = gestoridioma.ObtenerTraduccion(txtetiqueta.Text);
            gestoridioma.EditarTraduccion(txttraduccion.Text, cmbidioma2.Text, i);
            MessageBox.Show("Traduccion Agregada");
            GrillaIdioma.DataSource = gestoridioma.ObtenerEyT(cmbidioma2.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            ValidarComboBox();
        }


        public void ObtenerIdiomas()
        {
            cmbidioma2.DataSource = tradu.ObtenerIdiomas();
        }
        public void ValidarComboBox()
        {
            var t = tradu.ObtenerIdiomas();
            foreach (var idiomas in t)
            {

                cmbidioma.Items.Remove(idiomas.Nombre);

            }
        }

        private void GrillaIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
