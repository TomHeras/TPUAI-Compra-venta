
namespace TP_DIPLOMA
{
    partial class LOGIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.controlUsuario1 = new TP_DIPLOMA.ControlUsuario();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.cotrolPass1 = new TP_DIPLOMA.CotrolPass();
            this.SuspendLayout();
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario1.BackgroundImage")));
            this.controlUsuario1.Etiqueta = "Usuario";
            this.controlUsuario1.Location = new System.Drawing.Point(12, 22);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(177, 36);
            this.controlUsuario1.TabIndex = 0;
            this.controlUsuario1.Texto = "";
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(63, 176);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(108, 25);
            this.Btnlogin.TabIndex = 3;
            this.Btnlogin.Text = "Iniciar Sesion";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // cotrolPass1
            // 
            this.cotrolPass1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cotrolPass1.BackgroundImage")));
            this.cotrolPass1.Etiqueta = "Contraseña";
            this.cotrolPass1.Location = new System.Drawing.Point(12, 52);
            this.cotrolPass1.Name = "cotrolPass1";
            this.cotrolPass1.Size = new System.Drawing.Size(177, 45);
            this.cotrolPass1.TabIndex = 2;
            this.cotrolPass1.Texto = "";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(240, 220);
            this.Controls.Add(this.cotrolPass1);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.controlUsuario1);
            this.Name = "LOGIN";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlUsuario controlUsuario1;
        private System.Windows.Forms.Button Btnlogin;
        private CotrolPass cotrolPass1;
    }
}

