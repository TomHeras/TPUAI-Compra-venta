
namespace TP_DIPLOMA.Maestros
{
    partial class Productosfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productosfrm));
            this.ctrlmedidas = new TP_DIPLOMA.ControlUsuario();
            this.ctrlcantidad = new TP_DIPLOMA.ControlUsuario();
            this.ctrltipo = new TP_DIPLOMA.ControlUsuario();
            this.lblidprod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlmedidas
            // 
            this.ctrlmedidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlmedidas.BackgroundImage")));
            this.ctrlmedidas.Etiqueta = "Medidas";
            this.ctrlmedidas.Location = new System.Drawing.Point(50, 45);
            this.ctrlmedidas.Name = "ctrlmedidas";
            this.ctrlmedidas.Size = new System.Drawing.Size(178, 45);
            this.ctrlmedidas.TabIndex = 0;
            this.ctrlmedidas.Texto = "";
            // 
            // ctrlcantidad
            // 
            this.ctrlcantidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlcantidad.BackgroundImage")));
            this.ctrlcantidad.Etiqueta = "Cantidad";
            this.ctrlcantidad.Location = new System.Drawing.Point(50, 86);
            this.ctrlcantidad.Name = "ctrlcantidad";
            this.ctrlcantidad.Size = new System.Drawing.Size(178, 45);
            this.ctrlcantidad.TabIndex = 1;
            this.ctrlcantidad.Texto = "";
            // 
            // ctrltipo
            // 
            this.ctrltipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrltipo.BackgroundImage")));
            this.ctrltipo.Etiqueta = "Tipo";
            this.ctrltipo.Location = new System.Drawing.Point(50, 127);
            this.ctrltipo.Name = "ctrltipo";
            this.ctrltipo.Size = new System.Drawing.Size(178, 45);
            this.ctrltipo.TabIndex = 2;
            this.ctrltipo.Texto = "";
            // 
            // lblidprod
            // 
            this.lblidprod.AutoSize = true;
            this.lblidprod.Location = new System.Drawing.Point(47, 19);
            this.lblidprod.Name = "lblidprod";
            this.lblidprod.Size = new System.Drawing.Size(58, 13);
            this.lblidprod.TabIndex = 20;
            this.lblidprod.Text = ".................";
            this.lblidprod.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(301, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(301, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(301, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 338);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Productosfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblidprod);
            this.Controls.Add(this.ctrltipo);
            this.Controls.Add(this.ctrlcantidad);
            this.Controls.Add(this.ctrlmedidas);
            this.Name = "Productosfrm";
            this.Text = "Productosfrm";
            this.Load += new System.EventHandler(this.Productosfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUsuario ctrlmedidas;
        private ControlUsuario ctrlcantidad;
        private ControlUsuario ctrltipo;
        private System.Windows.Forms.Label lblidprod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}