
namespace TP_DIPLOMA.Negocio
{
    partial class Carritofrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carritofrm));
            this.listarclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPMODELOSDataSet = new TP_DIPLOMA.TPMODELOSDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPMODELOSDataSet3 = new TP_DIPLOMA.TPMODELOSDataSet3();
            this.listarprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPMODELOSDataSet1 = new TP_DIPLOMA.TPMODELOSDataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listarclientesTableAdapter = new TP_DIPLOMA.TPMODELOSDataSetTableAdapters.ListarclientesTableAdapter();
            this.listarprodTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet1TableAdapters.ListarprodTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnagregarcarrito = new System.Windows.Forms.Button();
            this.btnfactura = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlUsuario2 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario1 = new TP_DIPLOMA.ControlUsuario();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tPMODELOSDataSet2 = new TP_DIPLOMA.TPMODELOSDataSet2();
            this.clientesTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet2TableAdapters.ClientesTableAdapter();
            this.stockTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet3TableAdapters.StockTableAdapter();
            this.tPMODELOSDataSet4 = new TP_DIPLOMA.TPMODELOSDataSet4();
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new TP_DIPLOMA.TPMODELOSDataSet4TableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listarclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // listarclientesBindingSource
            // 
            this.listarclientesBindingSource.DataMember = "Listarclientes";
            this.listarclientesBindingSource.DataSource = this.tPMODELOSDataSet;
            // 
            // tPMODELOSDataSet
            // 
            this.tPMODELOSDataSet.DataSetName = "TPMODELOSDataSet";
            this.tPMODELOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.stockBindingSource;
            this.comboBox2.DisplayMember = "ID_producto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.tPMODELOSDataSet3;
            // 
            // tPMODELOSDataSet3
            // 
            this.tPMODELOSDataSet3.DataSetName = "TPMODELOSDataSet3";
            this.tPMODELOSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarprodBindingSource
            // 
            this.listarprodBindingSource.DataMember = "Listarprod";
            this.listarprodBindingSource.DataSource = this.tPMODELOSDataSet1;
            // 
            // tPMODELOSDataSet1
            // 
            this.tPMODELOSDataSet1.DataSetName = "TPMODELOSDataSet1";
            this.tPMODELOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(BLL.Maestros.Clientes);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataSource = typeof(BLL.Maestros.Clientes);
            // 
            // listarclientesTableAdapter
            // 
            this.listarclientesTableAdapter.ClearBeforeFill = true;
            // 
            // listarprodTableAdapter
            // 
            this.listarprodTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos";
            // 
            // btnagregarcarrito
            // 
            this.btnagregarcarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcarrito.Location = new System.Drawing.Point(85, 265);
            this.btnagregarcarrito.Name = "btnagregarcarrito";
            this.btnagregarcarrito.Size = new System.Drawing.Size(116, 23);
            this.btnagregarcarrito.TabIndex = 7;
            this.btnagregarcarrito.Text = "Agregar al carrito";
            this.btnagregarcarrito.UseVisualStyleBackColor = true;
            this.btnagregarcarrito.Click += new System.EventHandler(this.btnagregarcarrito_Click);
            // 
            // btnfactura
            // 
            this.btnfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfactura.Location = new System.Drawing.Point(85, 375);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(116, 23);
            this.btnfactura.TabIndex = 8;
            this.btnfactura.Text = "Generar Factura";
            this.btnfactura.UseVisualStyleBackColor = true;
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 318);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // controlUsuario2
            // 
            this.controlUsuario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario2.BackgroundImage")));
            this.controlUsuario2.Etiqueta = "Costo";
            this.controlUsuario2.Location = new System.Drawing.Point(23, 179);
            this.controlUsuario2.Name = "controlUsuario2";
            this.controlUsuario2.Size = new System.Drawing.Size(202, 45);
            this.controlUsuario2.TabIndex = 10;
            this.controlUsuario2.Texto = "";
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario1.BackgroundImage")));
            this.controlUsuario1.Etiqueta = "Cantidad";
            this.controlUsuario1.Location = new System.Drawing.Point(23, 127);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(202, 45);
            this.controlUsuario1.TabIndex = 6;
            this.controlUsuario1.Texto = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientesBindingSource3;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID_clientes";
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.tPMODELOSDataSet2;
            // 
            // tPMODELOSDataSet2
            // 
            this.tPMODELOSDataSet2.DataSetName = "TPMODELOSDataSet2";
            this.tPMODELOSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tPMODELOSDataSet4
            // 
            this.tPMODELOSDataSet4.DataSetName = "TPMODELOSDataSet4";
            this.tPMODELOSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "Clientes";
            this.clientesBindingSource3.DataSource = this.tPMODELOSDataSet4;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // Carritofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.controlUsuario2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnfactura);
            this.Controls.Add(this.btnagregarcarrito);
            this.Controls.Add(this.controlUsuario1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Name = "Carritofrm";
            this.Text = "Carritofrm";
            this.Load += new System.EventHandler(this.Carritofrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private TPMODELOSDataSet tPMODELOSDataSet;
        private System.Windows.Forms.BindingSource listarclientesBindingSource;
        private TPMODELOSDataSetTableAdapters.ListarclientesTableAdapter listarclientesTableAdapter;
        private TPMODELOSDataSet1 tPMODELOSDataSet1;
        private System.Windows.Forms.BindingSource listarprodBindingSource;
        private TPMODELOSDataSet1TableAdapters.ListarprodTableAdapter listarprodTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ControlUsuario controlUsuario1;
        private System.Windows.Forms.Button btnagregarcarrito;
        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlUsuario controlUsuario2;
        private System.Windows.Forms.ComboBox comboBox1;
        private TPMODELOSDataSet2 tPMODELOSDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private TPMODELOSDataSet2TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private TPMODELOSDataSet3 tPMODELOSDataSet3;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private TPMODELOSDataSet3TableAdapters.StockTableAdapter stockTableAdapter;
        private TPMODELOSDataSet4 tPMODELOSDataSet4;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
        private TPMODELOSDataSet4TableAdapters.ClientesTableAdapter clientesTableAdapter1;
    }
}