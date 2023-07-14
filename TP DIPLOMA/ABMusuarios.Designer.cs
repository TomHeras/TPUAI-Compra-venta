
namespace TP_DIPLOMA
{
    partial class ABMusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMusuarios));
            this.controlUsuario1 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario2 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario3 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario4 = new TP_DIPLOMA.ControlUsuario();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblidcl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tPMODELOSDataSet7 = new TP_DIPLOMA.TPMODELOSDataSet7();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idiomaTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet7TableAdapters.IdiomaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario1.BackgroundImage")));
            this.controlUsuario1.Etiqueta = "Nombre";
            this.controlUsuario1.Location = new System.Drawing.Point(35, 31);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario1.TabIndex = 0;
            this.controlUsuario1.Texto = "";
            // 
            // controlUsuario2
            // 
            this.controlUsuario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario2.BackgroundImage")));
            this.controlUsuario2.Etiqueta = "Nick";
            this.controlUsuario2.Location = new System.Drawing.Point(35, 70);
            this.controlUsuario2.Name = "controlUsuario2";
            this.controlUsuario2.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario2.TabIndex = 1;
            this.controlUsuario2.Texto = "";
            // 
            // controlUsuario3
            // 
            this.controlUsuario3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario3.BackgroundImage")));
            this.controlUsuario3.Etiqueta = "Contraseña";
            this.controlUsuario3.Location = new System.Drawing.Point(35, 111);
            this.controlUsuario3.Name = "controlUsuario3";
            this.controlUsuario3.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario3.TabIndex = 2;
            this.controlUsuario3.Texto = "";
            // 
            // controlUsuario4
            // 
            this.controlUsuario4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario4.BackgroundImage")));
            this.controlUsuario4.Etiqueta = "Mail";
            this.controlUsuario4.Location = new System.Drawing.Point(35, 162);
            this.controlUsuario4.Name = "controlUsuario4";
            this.controlUsuario4.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario4.TabIndex = 3;
            this.controlUsuario4.Texto = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 386);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(77, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblidcl
            // 
            this.lblidcl.AutoSize = true;
            this.lblidcl.Location = new System.Drawing.Point(91, 15);
            this.lblidcl.Name = "lblidcl";
            this.lblidcl.Size = new System.Drawing.Size(58, 13);
            this.lblidcl.TabIndex = 20;
            this.lblidcl.Text = ".................";
            this.lblidcl.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.idiomaBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Idioma";
            // 
            // tPMODELOSDataSet7
            // 
            this.tPMODELOSDataSet7.DataSetName = "TPMODELOSDataSet7";
            this.tPMODELOSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataMember = "Idioma";
            this.idiomaBindingSource.DataSource = this.tPMODELOSDataSet7;
            // 
            // idiomaTableAdapter
            // 
            this.idiomaTableAdapter.ClearBeforeFill = true;
            // 
            // ABMusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblidcl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlUsuario4);
            this.Controls.Add(this.controlUsuario3);
            this.Controls.Add(this.controlUsuario2);
            this.Controls.Add(this.controlUsuario1);
            this.Name = "ABMusuarios";
            this.Text = "ABMusuarios";
            this.Load += new System.EventHandler(this.ABMusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUsuario controlUsuario1;
        private ControlUsuario controlUsuario2;
        private ControlUsuario controlUsuario3;
        private ControlUsuario controlUsuario4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblidcl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private TPMODELOSDataSet7 tPMODELOSDataSet7;
        private System.Windows.Forms.BindingSource idiomaBindingSource;
        private TPMODELOSDataSet7TableAdapters.IdiomaTableAdapter idiomaTableAdapter;
    }
}