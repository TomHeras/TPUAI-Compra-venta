
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
            this.iDproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteArticulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPMODELOSDataSet8 = new TP_DIPLOMA.TPMODELOSDataSet8();
            this.reporte_ArticulosVendidosTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet8TableAdapters.Reporte_ArticulosVendidosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tPMODELOSDataSet9 = new TP_DIPLOMA.TPMODELOSDataSet9();
            this.reporteprodRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_prodRepoTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet9TableAdapters.Reporte_prodRepoTableAdapter();
            this.iDproductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteArticulosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteprodRepoBindingSource)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(243, 256);
            this.dataGridView1.TabIndex = 0;
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
            // reporteArticulosVendidosBindingSource
            // 
            this.reporteArticulosVendidosBindingSource.DataMember = "Reporte_ArticulosVendidos";
            this.reporteArticulosVendidosBindingSource.DataSource = this.tPMODELOSDataSet8;
            // 
            // tPMODELOSDataSet8
            // 
            this.tPMODELOSDataSet8.DataSetName = "TPMODELOSDataSet8";
            this.tPMODELOSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_ArticulosVendidosTableAdapter
            // 
            this.reporte_ArticulosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas Realizadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Productos Vendidos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Recaudado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 449);
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductoDataGridViewTextBoxColumn1,
            this.medidasDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reporteprodRepoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(404, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(342, 256);
            this.dataGridView2.TabIndex = 9;
            // 
            // tPMODELOSDataSet9
            // 
            this.tPMODELOSDataSet9.DataSetName = "TPMODELOSDataSet9";
            this.tPMODELOSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteprodRepoBindingSource
            // 
            this.reporteprodRepoBindingSource.DataMember = "Reporte_prodRepo";
            this.reporteprodRepoBindingSource.DataSource = this.tPMODELOSDataSet9;
            // 
            // reporte_prodRepoTableAdapter
            // 
            this.reporte_prodRepoTableAdapter.ClearBeforeFill = true;
            // 
            // iDproductoDataGridViewTextBoxColumn1
            // 
            this.iDproductoDataGridViewTextBoxColumn1.DataPropertyName = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn1.HeaderText = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn1.Name = "iDproductoDataGridViewTextBoxColumn1";
            // 
            // medidasDataGridViewTextBoxColumn
            // 
            this.medidasDataGridViewTextBoxColumn.DataPropertyName = "medidas";
            this.medidasDataGridViewTextBoxColumn.HeaderText = "medidas";
            this.medidasDataGridViewTextBoxColumn.Name = "medidasDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Productos para Reponer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Totales";
            // 
            // Reporte_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
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
            ((System.ComponentModel.ISupportInitialize)(this.reporteArticulosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteprodRepoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private TPMODELOSDataSet9 tPMODELOSDataSet9;
        private System.Windows.Forms.BindingSource reporteprodRepoBindingSource;
        private TPMODELOSDataSet9TableAdapters.Reporte_prodRepoTableAdapter reporte_prodRepoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}