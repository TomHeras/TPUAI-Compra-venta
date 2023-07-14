
namespace TP_DIPLOMA.Maestros
{
    partial class Clientesfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientesfrm));
            this.controlUsuario1 = new TP_DIPLOMA.ControlUsuario();
            this.lblidcl = new System.Windows.Forms.Label();
            this.controlUsuario2 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario3 = new TP_DIPLOMA.ControlUsuario();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario1.BackgroundImage")));
            this.controlUsuario1.Etiqueta = "Nombre";
            this.controlUsuario1.Location = new System.Drawing.Point(23, 57);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario1.TabIndex = 0;
            this.controlUsuario1.Texto = "";
            // 
            // lblidcl
            // 
            this.lblidcl.AutoSize = true;
            this.lblidcl.Location = new System.Drawing.Point(92, 24);
            this.lblidcl.Name = "lblidcl";
            this.lblidcl.Size = new System.Drawing.Size(58, 13);
            this.lblidcl.TabIndex = 19;
            this.lblidcl.Text = ".................";
            this.lblidcl.Visible = false;
            // 
            // controlUsuario2
            // 
            this.controlUsuario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario2.BackgroundImage")));
            this.controlUsuario2.Etiqueta = "Direccion";
            this.controlUsuario2.Location = new System.Drawing.Point(23, 120);
            this.controlUsuario2.Name = "controlUsuario2";
            this.controlUsuario2.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario2.TabIndex = 20;
            this.controlUsuario2.Texto = "";
            // 
            // controlUsuario3
            // 
            this.controlUsuario3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario3.BackgroundImage")));
            this.controlUsuario3.Etiqueta = "Telefono";
            this.controlUsuario3.Location = new System.Drawing.Point(23, 192);
            this.controlUsuario3.Name = "controlUsuario3";
            this.controlUsuario3.Size = new System.Drawing.Size(178, 45);
            this.controlUsuario3.TabIndex = 21;
            this.controlUsuario3.Texto = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Resgitrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 317);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Clientesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlUsuario3);
            this.Controls.Add(this.controlUsuario2);
            this.Controls.Add(this.lblidcl);
            this.Controls.Add(this.controlUsuario1);
            this.Name = "Clientesfrm";
            this.Text = "Clientesfrm";
            this.Load += new System.EventHandler(this.Clientesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUsuario controlUsuario1;
        private System.Windows.Forms.Label lblidcl;
        private ControlUsuario controlUsuario2;
        private ControlUsuario controlUsuario3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}