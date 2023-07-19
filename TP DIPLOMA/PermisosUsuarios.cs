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
    public partial class PermisosUsuarios : Form
    {
        BLL.Usuarios usu = new BLL.Usuarios();
        Patente_Usuario metodos;
        Patente_Usuario tmp;
        BLL.Patentes permisos;
        public PermisosUsuarios()
        {
            InitializeComponent();
            usu = new BLL.Usuarios();
            permisos = new BLL.Patentes();
            cmbusers.DataSource = usu.GetAll(); //llamado a un procedimiento
            this.cboFamilias.DataSource = permisos.GetAllFamilias(); //llamado a un procedimi
            this.cboPatentes.DataSource = permisos.GetAllPatentes(); //llamado a un procedimi
            this.comboBox1.DataSource = permisos.GetAllPerfiles();

        }


        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }
        }

        void MostrarPermisos(Patente_Usuario u)
        {
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(u.Nombre);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll();
        }

        private void cmdConfigurar_Click(object sender, EventArgs e)
        {
            metodos = (Patente_Usuario)cmbusers.SelectedItem;

            //hago una copia del objeto para no modificr el que esta en el combo.
            tmp = new Patente_Usuario();
            tmp.Idusuarios = metodos.Idusuarios;
            tmp.Nombre = metodos.Nombre;
            permisos.FillUserComponents(tmp);
            MostrarPermisos(tmp);
        }

        private void btnagregarfamilia_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var flia = (Familia)cboFamilias.SelectedItem;
                if (flia != null)
                {
                    var esta = false;
                    //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                    foreach (var item in tmp.Permisos)
                    {
                        if (permisos.Existe(item, flia.Id))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia indicada");
                    else
                    {
                        {
                            permisos.FillFamilyComponents(flia);

                            tmp.Permisos.Add(flia);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void btnagregarpatente_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = false;

                    foreach (var item in tmp.Permisos)
                    {
                        if (permisos.Existe(item, patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (esta)
                        MessageBox.Show("El usuario ya tiene la patente indicada");
                    else
                    {
                        {
                            tmp.Permisos.Add(patente);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                usu.GuardarPermisos(tmp);
                MessageBox.Show("Usuario guardado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar el usuario");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var flia = (Familia)comboBox1.SelectedItem;
                if (flia != null)
                {
                    var esta = false;
                    //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                    foreach (var item in tmp.Permisos)
                    {
                        if (permisos.Existe(item, flia.Id))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia indicada");
                    else
                    {
                        {
                            permisos.FillFamilyComponents(flia);

                            tmp.Permisos.Add(flia);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }
    }
}
