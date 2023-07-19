
namespace TP_DIPLOMA
{
    partial class Ordenes
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
            this.Cotizaciones = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.traercotizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.levantarjoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotizaYDetalle = new TP_DIPLOMA.CotizaYDetalle();
            this.joincotizaciondetalle = new TP_DIPLOMA.joincotizaciondetalle();
            this.joincotizaciondetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compras_DetTableAdapter = new TP_DIPLOMA.joincotizaciondetalleTableAdapters.Compras_DetTableAdapter();
            this.cotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotizacionTableAdapter = new TP_DIPLOMA.joincotizaciondetalleTableAdapters.CotizacionTableAdapter();
            this.comprasDetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.levantarjoinTableAdapter = new TP_DIPLOMA.CotizaYDetalleTableAdapters.levantarjoinTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Cotizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traercotizacionesBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.levantarjoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizaYDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cotizaciones
            // 
            this.Cotizaciones.Controls.Add(this.dataGridView1);
            this.Cotizaciones.Location = new System.Drawing.Point(9, 134);
            this.Cotizaciones.Name = "Cotizaciones";
            this.Cotizaciones.Size = new System.Drawing.Size(787, 447);
            this.Cotizaciones.TabIndex = 0;
            this.Cotizaciones.TabStop = false;
            this.Cotizaciones.Text = "Cotizaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // traercotizacionesBindingSource
            // 
            // 
            // levantarjoinBindingSource
            // 
            this.levantarjoinBindingSource.DataMember = "levantarjoin";
            this.levantarjoinBindingSource.DataSource = this.cotizaYDetalle;
            // 
            // cotizaYDetalle
            // 
            this.cotizaYDetalle.DataSetName = "CotizaYDetalle";
            this.cotizaYDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joincotizaciondetalle
            // 
            this.joincotizaciondetalle.DataSetName = "joincotizaciondetalle";
            this.joincotizaciondetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joincotizaciondetalleBindingSource
            // 
            this.joincotizaciondetalleBindingSource.DataSource = this.joincotizaciondetalle;
            this.joincotizaciondetalleBindingSource.Position = 0;
            // 
            // comprasDetBindingSource
            // 
            this.comprasDetBindingSource.DataMember = "Compras Det";
            this.comprasDetBindingSource.DataSource = this.joincotizaciondetalleBindingSource;
            // 
            // compras_DetTableAdapter
            // 
            this.compras_DetTableAdapter.ClearBeforeFill = true;
            // 
            // cotizacionBindingSource
            // 
            this.cotizacionBindingSource.DataMember = "Cotizacion";
            this.cotizacionBindingSource.DataSource = this.joincotizaciondetalleBindingSource;
            // 
            // cotizacionTableAdapter
            // 
            this.cotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // comprasDetBindingSource1
            // 
            this.comprasDetBindingSource1.DataMember = "Compras Det";
            this.comprasDetBindingSource1.DataSource = this.joincotizaciondetalleBindingSource;
            // 
            // levantarjoinTableAdapter
            // 
            this.levantarjoinTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(802, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(459, 416);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(48, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar Cotizacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de pedido";
            // 
            // traercotizacionesTableAdapter
            // 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Costo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(902, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generar orden de compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(902, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 24);
            this.button3.TabIndex = 11;
            this.button3.Text = "Editar Costo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tPMODELOSDataSet19
            
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = " ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 26);
            this.button4.TabIndex = 14;
            this.button4.Text = "Serelizar informacion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 647);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cotizaciones);
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            this.Cotizaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traercotizacionesBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.levantarjoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizaYDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Cotizaciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource joincotizaciondetalleBindingSource;
        private joincotizaciondetalle joincotizaciondetalle;
        private System.Windows.Forms.BindingSource comprasDetBindingSource;
        private joincotizaciondetalleTableAdapters.Compras_DetTableAdapter compras_DetTableAdapter;
        private System.Windows.Forms.BindingSource cotizacionBindingSource;
        private joincotizaciondetalleTableAdapters.CotizacionTableAdapter cotizacionTableAdapter;
        private System.Windows.Forms.BindingSource comprasDetBindingSource1;
        private CotizaYDetalle cotizaYDetalle;
        private System.Windows.Forms.BindingSource levantarjoinBindingSource;
        private CotizaYDetalleTableAdapters.levantarjoinTableAdapter levantarjoinTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.BindingSource traercotizacionesBindingSource;
        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        
        private System.Windows.Forms.BindingSource estadosBindingSource;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}