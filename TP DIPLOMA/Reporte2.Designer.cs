
namespace TP_DIPLOMA
{
    partial class Reporte2
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
            
            this.levantarjoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.iDPEDIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPROVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.levantarjoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPEDIDODataGridViewTextBoxColumn,
            this.iDPROVDataGridViewTextBoxColumn,
            this.cotizacionDataGridViewTextBoxColumn,
            this.iDPRODDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.fechaActDataGridViewTextBoxColumn,
            this.fechaGenDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.levantarjoinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // tPMODELOSDataSet22
            // 
            // 
            // levantarjoinBindingSource
            // 
            
            this.levantarjoinBindingSource.DataMember = "levantarjoin";
            
            // 
            // levantarjoinTableAdapter
            // 
            
            // 
            // iDPEDIDODataGridViewTextBoxColumn
            // 
            this.iDPEDIDODataGridViewTextBoxColumn.DataPropertyName = "IDPEDIDO";
            this.iDPEDIDODataGridViewTextBoxColumn.HeaderText = "IDPEDIDO";
            this.iDPEDIDODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPEDIDODataGridViewTextBoxColumn.Name = "iDPEDIDODataGridViewTextBoxColumn";
            this.iDPEDIDODataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPROVDataGridViewTextBoxColumn
            // 
            this.iDPROVDataGridViewTextBoxColumn.DataPropertyName = "IDPROV";
            this.iDPROVDataGridViewTextBoxColumn.HeaderText = "IDPROV";
            this.iDPROVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPROVDataGridViewTextBoxColumn.Name = "iDPROVDataGridViewTextBoxColumn";
            this.iDPROVDataGridViewTextBoxColumn.Width = 125;
            // 
            // cotizacionDataGridViewTextBoxColumn
            // 
            this.cotizacionDataGridViewTextBoxColumn.DataPropertyName = "Cotizacion";
            this.cotizacionDataGridViewTextBoxColumn.HeaderText = "Cotizacion";
            this.cotizacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cotizacionDataGridViewTextBoxColumn.Name = "cotizacionDataGridViewTextBoxColumn";
            this.cotizacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPRODDataGridViewTextBoxColumn
            // 
            this.iDPRODDataGridViewTextBoxColumn.DataPropertyName = "IDPROD";
            this.iDPRODDataGridViewTextBoxColumn.HeaderText = "IDPROD";
            this.iDPRODDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPRODDataGridViewTextBoxColumn.Name = "iDPRODDataGridViewTextBoxColumn";
            this.iDPRODDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaActDataGridViewTextBoxColumn
            // 
            this.fechaActDataGridViewTextBoxColumn.DataPropertyName = "FechaAct";
            this.fechaActDataGridViewTextBoxColumn.HeaderText = "FechaAct";
            this.fechaActDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaActDataGridViewTextBoxColumn.Name = "fechaActDataGridViewTextBoxColumn";
            this.fechaActDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaGenDataGridViewTextBoxColumn
            // 
            this.fechaGenDataGridViewTextBoxColumn.DataPropertyName = "FechaGen";
            this.fechaGenDataGridViewTextBoxColumn.HeaderText = "FechaGen";
            this.fechaGenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaGenDataGridViewTextBoxColumn.Name = "fechaGenDataGridViewTextBoxColumn";
            this.fechaGenDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumen de compras totales";
            // 
            // Reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reporte2";
            this.Text = "Reporte Compras";
            this.Load += new System.EventHandler(this.Reporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.levantarjoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource levantarjoinBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPEDIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}