
namespace TP_DIPLOMA.Maestros
{
    partial class Proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.controlUsuario2 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario3 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario4 = new TP_DIPLOMA.ControlUsuario();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnprod_prov = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.lblidcl = new System.Windows.Forms.Label();
            
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlUsuario2
            // 
            this.controlUsuario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario2.BackgroundImage")));
            this.controlUsuario2.Etiqueta = "Direccion";
            this.controlUsuario2.Location = new System.Drawing.Point(36, 107);
            this.controlUsuario2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlUsuario2.Name = "controlUsuario2";
            this.controlUsuario2.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario2.TabIndex = 1;
            this.controlUsuario2.Texto = "";
            // 
            // controlUsuario3
            // 
            this.controlUsuario3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario3.BackgroundImage")));
            this.controlUsuario3.Etiqueta = "Nombre";
            this.controlUsuario3.Location = new System.Drawing.Point(36, 32);
            this.controlUsuario3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlUsuario3.Name = "controlUsuario3";
            this.controlUsuario3.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario3.TabIndex = 2;
            this.controlUsuario3.Texto = "";
            // 
            // controlUsuario4
            // 
            this.controlUsuario4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario4.BackgroundImage")));
            this.controlUsuario4.Etiqueta = "Telefono";
            this.controlUsuario4.Location = new System.Drawing.Point(36, 180);
            this.controlUsuario4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlUsuario4.Name = "controlUsuario4";
            this.controlUsuario4.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario4.TabIndex = 3;
            this.controlUsuario4.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productos";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.stockBindingSource;
            this.comboBox1.DisplayMember = "ID_producto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "ID_producto";
            // 
            // stockBindingSource
            // 
             
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 520);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(36, 274);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(83, 28);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnprod_prov
            // 
            this.btnprod_prov.Location = new System.Drawing.Point(73, 448);
            this.btnprod_prov.Name = "btnprod_prov";
            this.btnprod_prov.Size = new System.Drawing.Size(147, 25);
            this.btnprod_prov.TabIndex = 8;
            this.btnprod_prov.Text = "Asignar producto";
            this.btnprod_prov.UseVisualStyleBackColor = true;
            this.btnprod_prov.Click += new System.EventHandler(this.btnprod_prov_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(102, 336);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(83, 28);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Modificar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(190, 274);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(83, 28);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.Text = "Eliminar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // lblidcl
            // 
            this.lblidcl.AutoSize = true;
            this.lblidcl.Location = new System.Drawing.Point(99, 9);
            this.lblidcl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidcl.Name = "lblidcl";
            this.lblidcl.Size = new System.Drawing.Size(76, 17);
            this.lblidcl.TabIndex = 20;
            this.lblidcl.Text = ".................";
            this.lblidcl.Visible = false;
            // 
            // stockTableAdapter
            // 
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Serealizar Informacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblidcl);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnprod_prov);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlUsuario4);
            this.Controls.Add(this.controlUsuario3);
            this.Controls.Add(this.controlUsuario2);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlUsuario controlUsuario2;
        private ControlUsuario controlUsuario3;
        private ControlUsuario controlUsuario4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnprod_prov;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label lblidcl;
        
        private System.Windows.Forms.BindingSource stockBindingSource;
        
        private System.Windows.Forms.Button button1;
    }
}