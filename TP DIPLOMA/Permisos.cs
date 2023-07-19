using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad.Composite;

namespace TP_DIPLOMA
{
    public partial class Permisos : Form
    {
        BLL.Patentes GestorPatentes = new BLL.Patentes();
        Familia flia ;
        public Permisos()
        {
            InitializeComponent();
            this.cboPermisos.DataSource = GestorPatentes.GetAllPermission();
        }

        private void btnGuardarPatente_Click(object sender, EventArgs e)
        {
            Patente p = new Patente()
            {
                Nombre = this.txtNombrePatente.Text,
                Permiso = (Tipopatente)this.cboPermisos.SelectedItem

            };

            GestorPatentes.guardarcomponente(p, false);
            llenarpatentefamilias();

            MessageBox.Show("Patente guardada correctamente");
            limpiar();
        }//guarda las nuevas patentes a crear

        private void llenarpatentefamilias()
        {
            this.cboPatentes.DataSource = GestorPatentes.GetAllPatentes();
            this.cboFamilias.DataSource = GestorPatentes.GetAllFamilias();
            this.cmbperfiles.DataSource = GestorPatentes.GetAllPerfiles();
        }//listar patentes y familias

        void limpiar()
        {
            txtNombreFamilia.Clear();
            txtNombrePatente.Clear();
        }//limpia las txt

        private void Permisos_Load(object sender, EventArgs e)
        {
            llenarpatentefamilias();
        }

        private void cmdGuardarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                GestorPatentes.GuardarFamilia(flia);
                MessageBox.Show("Familia guardada correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar la familia");
            }
        }

        private void cmdAgregarPatente_Click(object sender, EventArgs e)
        {
            if (flia != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = GestorPatentes.Existe(flia, patente.Id);
                    if (esta)
                        MessageBox.Show("ya existe la patente indicada");
                    else
                    {

                        {
                            flia.AgregarHijo(patente);
                            MostrarFamilia(false);
                        }
                    }
                }
            }
        }//agrega los permisos a la flias


        void MostrarFamilia(bool init)
        {
            if (flia == null)
                return;
            IList<Componente> familias = null;
            if (init)
            {
                familias = GestorPatentes.GetAll("=" + flia.Id);
                foreach (var item in familias)
                    flia.AgregarHijo(item);
            }
            else
            {
                familias = flia.Hijos;
            }

            this.treeConfigurarFamilia.Nodes.Clear();

            TreeNode root = new TreeNode(flia.Nombre);
            root.Tag = flia;
            this.treeConfigurarFamilia.Nodes.Add(root);

            foreach (var item in familias)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigurarFamilia.ExpandAll();
        }//listado de familias

        void MostrarEnTreeView(TreeNode tn, Componente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {
                    MostrarEnTreeView(n, item);
                }

        }//muestra en el arbol

        private void cmdAgregarFamilia_Click(object sender, EventArgs e)//agrega la familia para asignarle patentes o permisos
        {
            if (flia != null)
            {
                var familia = (Familia)cboFamilias.SelectedItem;
                if (familia != null)
                {
                    var variable = GestorPatentes.Existe(flia, familia.Id);
                    if (variable)
                        MessageBox.Show("Ya Existe la familia");
                    else
                    {
                        GestorPatentes.FillFamilyComponents(familia);
                        flia.AgregarHijo(familia);
                        MostrarFamilia(false);
                    }
                }
            }
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)//selecciona la flia para asignar
        {

            var tmp = (Familia)this.cboFamilias.SelectedItem;
            flia = new Familia();
            flia.Id = tmp.Id;
            flia.Nombre = tmp.Nombre;

            MostrarFamilia(true);
        }

        private void btnGuardarFamilia_Click(object sender, EventArgs e)
        {
            Familia p = new Familia()
            {
                Nombre = this.txtNombreFamilia.Text

            };
            GestorPatentes.guardarcomponente(p, true);
            llenarpatentefamilias();
            MessageBox.Show("Familia guardada correctamente");

            

        }//guarda las familias modificada con los permisos

        private void btnconfigurarperfiles_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cmbperfiles.SelectedItem;
            flia = new Familia();
            flia.Id = tmp.Id;
            flia.Nombre = tmp.Nombre;

            MostrarFamilia(true);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string perfil = Tipopatente.perfil.ToString();
            Familia p = new Familia()
            {
                Nombre = textBox1.Text,             
                             
            };

            GestorPatentes.GuardarComponentePerfil(p,perfil);
            llenarpatentefamilias();
            MessageBox.Show("Perfil guardado correctamente");
        }
    }
}