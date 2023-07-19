
namespace TP_DIPLOMA
{
    partial class COMpras
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
            this.joincotizaciondetalle = new TP_DIPLOMA.joincotizaciondetalle();
            this.joincotizaciondetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.joincotizaciondetalleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 416);
            this.dataGridView1.TabIndex = 1;
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
            // COMpras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 630);
            this.Controls.Add(this.dataGridView1);
            this.Name = "COMpras";
            this.Text = "Ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joincotizaciondetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource joincotizaciondetalleBindingSource;
        private joincotizaciondetalle joincotizaciondetalle;
    }
}