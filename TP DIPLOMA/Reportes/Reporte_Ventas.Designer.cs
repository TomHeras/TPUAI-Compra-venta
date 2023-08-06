
namespace TP_DIPLOMA.Reportes
{
    partial class Reporte_Ventas
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
            this.tPMODELOSDataSet8 = new TP_DIPLOMA.TPMODELOSDataSet8();
            this.reporteArticulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_ArticulosVendidosTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet8TableAdapters.Reporte_ArticulosVendidosTableAdapter();
            this.iDproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteArticulosVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductoDataGridViewTextBoxColumn,
            this.totalcantDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reporteArticulosVendidosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // tPMODELOSDataSet8
            // 
            this.tPMODELOSDataSet8.DataSetName = "TPMODELOSDataSet8";
            this.tPMODELOSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteArticulosVendidosBindingSource
            // 
            this.reporteArticulosVendidosBindingSource.DataMember = "Reporte_ArticulosVendidos";
            this.reporteArticulosVendidosBindingSource.DataSource = this.tPMODELOSDataSet8;
            // 
            // reporte_ArticulosVendidosTableAdapter
            // 
            this.reporte_ArticulosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // iDproductoDataGridViewTextBoxColumn
            // 
            this.iDproductoDataGridViewTextBoxColumn.DataPropertyName = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn.HeaderText = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn.Name = "iDproductoDataGridViewTextBoxColumn";
            // 
            // totalcantDataGridViewTextBoxColumn
            // 
            this.totalcantDataGridViewTextBoxColumn.DataPropertyName = "totalcant";
            this.totalcantDataGridViewTextBoxColumn.HeaderText = "totalcant";
            this.totalcantDataGridViewTextBoxColumn.Name = "totalcantDataGridViewTextBoxColumn";
            this.totalcantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas Realizadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Productos Vendidos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(509, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Recaudado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(509, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Productos mas vendidos";
            // 
            // Reporte_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reporte_Ventas";
            this.Text = "Reporte_Ventas";
            this.Load += new System.EventHandler(this.Reporte_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteArticulosVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TPMODELOSDataSet8 tPMODELOSDataSet8;
        private System.Windows.Forms.BindingSource reporteArticulosVendidosBindingSource;
        private TPMODELOSDataSet8TableAdapters.Reporte_ArticulosVendidosTableAdapter reporte_ArticulosVendidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcantDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}