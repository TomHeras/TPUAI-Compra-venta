
namespace TP_DIPLOMA
{
    partial class Reporte1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.reporteprodRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.reportaprodVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelProductos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteprodRepoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportaprodVendidosBindingSource)).BeginInit();
=======
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            
            this.reportaprodVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.iDproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.reporteprodRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.iDproductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.reportaprodVendidosBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.reporteprodRepoBindingSource)).BeginInit();
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
<<<<<<< HEAD
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(172, 192);
=======
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductoDataGridViewTextBoxColumn1,
            this.medidasDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reporteprodRepoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(401, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 236);
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
<<<<<<< HEAD
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 54);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(175, 192);
=======
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductoDataGridViewTextBoxColumn,
            this.totalcantDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reportaprodVendidosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(303, 236);
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Tag = "productos_mas_vendidos";
=======
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 2;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.label1.Text = "Productos mas Vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(13, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "productos_a_reponer";
            this.label2.Text = "Productos A Reponer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelProductos);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelVentas);
            this.groupBox1.Location = new System.Drawing.Point(310, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(259, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "totales";
            this.groupBox1.Text = "Totales";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(5, 108);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(90, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Tag = "total_recaudado";
            this.labelTotal.Text = "Total Recaudado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(5, 69);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(102, 13);
            this.labelProductos.TabIndex = 2;
            this.labelProductos.Tag = "productos_vendidos";
            this.labelProductos.Text = "Productos Vendidos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelVentas
            // 
            this.labelVentas.AutoSize = true;
            this.labelVentas.Location = new System.Drawing.Point(5, 28);
            this.labelVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVentas.Name = "labelVentas";
            this.labelVentas.Size = new System.Drawing.Size(95, 13);
            this.labelVentas.TabIndex = 0;
            this.labelVentas.Tag = "ventas_realizadas";
            this.labelVentas.Text = "Ventas Realizadas";
            // 
            // Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 493);
=======
            this.label2.Location = new System.Drawing.Point(398, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos A Reponer";
            // 
            // tPMODELOSDataSet13
            // 
            // 
            // iDproductoDataGridViewTextBoxColumn
            // 
            this.iDproductoDataGridViewTextBoxColumn.DataPropertyName = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn.HeaderText = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDproductoDataGridViewTextBoxColumn.Name = "iDproductoDataGridViewTextBoxColumn";
            this.iDproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalcantDataGridViewTextBoxColumn
            // 
            this.totalcantDataGridViewTextBoxColumn.DataPropertyName = "totalcant";
            this.totalcantDataGridViewTextBoxColumn.HeaderText = "totalcant";
            this.totalcantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalcantDataGridViewTextBoxColumn.Name = "totalcantDataGridViewTextBoxColumn";
            this.totalcantDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalcantDataGridViewTextBoxColumn.Width = 125;
            // 
            // tPMODELOSDataSet14
            // 
            // 
            // reporteprodRepoBindingSource
            // 
            // 
            // reporte_prodRepoTableAdapter
            // 
            
            // 
            // iDproductoDataGridViewTextBoxColumn1
            // 
            this.iDproductoDataGridViewTextBoxColumn1.DataPropertyName = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn1.HeaderText = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDproductoDataGridViewTextBoxColumn1.Name = "iDproductoDataGridViewTextBoxColumn1";
            this.iDproductoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // medidasDataGridViewTextBoxColumn
            // 
            this.medidasDataGridViewTextBoxColumn.DataPropertyName = "medidas";
            this.medidasDataGridViewTextBoxColumn.HeaderText = "medidas";
            this.medidasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medidasDataGridViewTextBoxColumn.Name = "medidasDataGridViewTextBoxColumn";
            this.medidasDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ventas Realizadas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Productos Vendidos";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(659, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Recaudado";
            // 
            // Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 426);
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2);
=======
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.Name = "Reporte1";
            this.Text = "Reporte1";
            this.Load += new System.EventHandler(this.Reporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.reporteprodRepoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportaprodVendidosBindingSource)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.reportaprodVendidosBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.reporteprodRepoBindingSource)).EndInit();
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
       
        private System.Windows.Forms.BindingSource reportaprodVendidosBindingSource;
       
=======
        //private TPMODELOSDataSet13 tPMODELOSDataSet13;
        private System.Windows.Forms.BindingSource reportaprodVendidosBindingSource;
        
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcantDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.BindingSource reporteprodRepoBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
<<<<<<< HEAD
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVentas;
=======
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
    }
}