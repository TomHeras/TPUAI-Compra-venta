
namespace TP_DIPLOMA.Maestros
{
    partial class Preciosfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preciosfrm));
            this.controlUsuario1 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario2 = new TP_DIPLOMA.ControlUsuario();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlUsuario3 = new TP_DIPLOMA.ControlUsuario();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario1.BackgroundImage")));
            this.controlUsuario1.Etiqueta = "Detalles";
            this.controlUsuario1.Location = new System.Drawing.Point(50, 86);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario1.TabIndex = 2;
            this.controlUsuario1.Texto = "";
            // 
            // controlUsuario2
            // 
            this.controlUsuario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario2.BackgroundImage")));
            this.controlUsuario2.Etiqueta = "Precio";
            this.controlUsuario2.Location = new System.Drawing.Point(50, 137);
            this.controlUsuario2.Name = "controlUsuario2";
            this.controlUsuario2.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario2.TabIndex = 3;
            this.controlUsuario2.Texto = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 395);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Aumentar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlUsuario3
            // 
            this.controlUsuario3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario3.BackgroundImage")));
            this.controlUsuario3.Etiqueta = "Producto";
            this.controlUsuario3.Location = new System.Drawing.Point(50, 43);
            this.controlUsuario3.Name = "controlUsuario3";
            this.controlUsuario3.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario3.TabIndex = 8;
            this.controlUsuario3.Texto = "";
            // 
            // Preciosfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlUsuario3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlUsuario2);
            this.Controls.Add(this.controlUsuario1);
            this.Name = "Preciosfrm";
            this.Text = "Preciosfrm";
            this.Load += new System.EventHandler(this.Preciosfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ControlUsuario controlUsuario1;
        private ControlUsuario controlUsuario2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ControlUsuario controlUsuario3;
    }
}