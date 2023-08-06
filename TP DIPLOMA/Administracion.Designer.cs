
namespace TP_DIPLOMA
{
    partial class Administracion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnusesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiidioma = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltripselec = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltripgestionidioma = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltriplista = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulogut = new System.Windows.Forms.ToolStripMenuItem();
            this.smiseguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltrippermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltrippermisousuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmabmusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSession = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnusesion,
            this.smiseguridad,
            this.negocioToolStripMenuItem,
            this.maestrosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnusesion
            // 
            this.mnusesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiidioma,
            this.usuarioToolStripMenuItem,
            this.mnulogut});
            this.mnusesion.Name = "mnusesion";
            this.mnusesion.Size = new System.Drawing.Size(53, 20);
            this.mnusesion.Tag = "sesion";
            this.mnusesion.Text = "Sesion";
            // 
            // tsmiidioma
            // 
            this.tsmiidioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltripselec,
            this.tooltripgestionidioma,
            this.tooltriplista});
            this.tsmiidioma.Name = "tsmiidioma";
            this.tsmiidioma.Size = new System.Drawing.Size(143, 22);
            this.tsmiidioma.Tag = "idioma";
            this.tsmiidioma.Text = "Idioma";
            // 
            // tooltripselec
            // 
            this.tooltripselec.Name = "tooltripselec";
            this.tooltripselec.Size = new System.Drawing.Size(214, 22);
            this.tooltripselec.Tag = "seleccionar_idioma";
            this.tooltripselec.Text = "Seleccionar Idioma";
            this.tooltripselec.Click += new System.EventHandler(this.tooltripselec_Click);
            // 
            // tooltripgestionidioma
            // 
            this.tooltripgestionidioma.Name = "tooltripgestionidioma";
            this.tooltripgestionidioma.Size = new System.Drawing.Size(214, 22);
            this.tooltripgestionidioma.Tag = "gestionar_idioma";
            this.tooltripgestionidioma.Text = "Gestionar Idioma";
            this.tooltripgestionidioma.Click += new System.EventHandler(this.tooltripgestionidioma_Click);
            // 
            // tooltriplista
            // 
            this.tooltriplista.Name = "tooltriplista";
            this.tooltriplista.Size = new System.Drawing.Size(214, 22);
            this.tooltriplista.Tag = "actualizar_lista_idiomas";
            this.tooltriplista.Text = "Actualizar Lista de Idiomas";
            this.tooltriplista.Click += new System.EventHandler(this.tooltriplista_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.usuarioToolStripMenuItem.Tag = "usuario";
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cambiarClaveToolStripMenuItem.Tag = "cambiarcontra";
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // mnulogut
            // 
            this.mnulogut.Name = "mnulogut";
            this.mnulogut.Size = new System.Drawing.Size(143, 22);
            this.mnulogut.Tag = "cerrarsesion";
            this.mnulogut.Text = "Cerrar Sesion";
            this.mnulogut.Click += new System.EventHandler(this.mnulogut_Click);
            // 
            // smiseguridad
            // 
            this.smiseguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltrippermisos,
            this.tooltrippermisousuario,
            this.tsmabmusuarios});
            this.smiseguridad.Name = "smiseguridad";
            this.smiseguridad.Size = new System.Drawing.Size(100, 20);
            this.smiseguridad.Tag = "seguridad";
            this.smiseguridad.Text = "Administracion";
            // 
            // tooltrippermisos
            // 
            this.tooltrippermisos.Name = "tooltrippermisos";
            this.tooltrippermisos.Size = new System.Drawing.Size(180, 22);
            this.tooltrippermisos.Tag = "famypat";
            this.tooltrippermisos.Text = "Perfiles";
            this.tooltrippermisos.Click += new System.EventHandler(this.tooltrippermisos_Click);
            // 
            // tooltrippermisousuario
            // 
            this.tooltrippermisousuario.Name = "tooltrippermisousuario";
            this.tooltrippermisousuario.Size = new System.Drawing.Size(180, 22);
            this.tooltrippermisousuario.Tag = "usuarios";
            this.tooltrippermisousuario.Text = "Asignacion";
            this.tooltrippermisousuario.Click += new System.EventHandler(this.tooltrippermisousuario_Click);
            // 
            // tsmabmusuarios
            // 
            this.tsmabmusuarios.Name = "tsmabmusuarios";
            this.tsmabmusuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmabmusuarios.Tag = "Gestion de usuarios";
            this.tsmabmusuarios.Text = "Gestion de usuarios";
            this.tsmabmusuarios.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.negocioToolStripMenuItem.Tag = "negocio";
            this.negocioToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carritoToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Tag = "venta";
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carritoToolStripMenuItem.Tag = "carrito";
            this.carritoToolStripMenuItem.Text = "Carrito";
            this.carritoToolStripMenuItem.Click += new System.EventHandler(this.carritoToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.cobrosToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturacionToolStripMenuItem.Tag = "facturacion";
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.facturasToolStripMenuItem.Tag = "facturas";
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cobrosToolStripMenuItem.Tag = "pagos";
            this.cobrosToolStripMenuItem.Text = "Cobros";
            this.cobrosToolStripMenuItem.Click += new System.EventHandler(this.cobrosToolStripMenuItem_Click);
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrosToolStripMenuItem.Tag = "Maestros";
            this.maestrosToolStripMenuItem.Text = "Maestros";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.preciosToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.preciosToolStripMenuItem.Text = "Precios";
            this.preciosToolStripMenuItem.Click += new System.EventHandler(this.preciosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Tag = "Reportes";
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Tag = "Ayuda";
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSession,
            this.toolStripSesion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSession
            // 
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(39, 17);
            this.lblSession.Text = "Status";
            this.lblSession.Click += new System.EventHandler(this.lblSession_Click);
            // 
            // toolStripSesion
            // 
            this.toolStripSesion.Name = "toolStripSesion";
            this.toolStripSesion.Size = new System.Drawing.Size(116, 17);
            this.toolStripSesion.Text = "[ Sesión no iniciada ]";
            this.toolStripSesion.Click += new System.EventHandler(this.toolStripSesion_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1056, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administracion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administracion_FormClosed);
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnusesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiidioma;
        private System.Windows.Forms.ToolStripMenuItem tooltripselec;
        private System.Windows.Forms.ToolStripMenuItem tooltripgestionidioma;
        private System.Windows.Forms.ToolStripMenuItem tooltriplista;
        private System.Windows.Forms.ToolStripMenuItem mnulogut;
        private System.Windows.Forms.ToolStripMenuItem smiseguridad;
        private System.Windows.Forms.ToolStripMenuItem tooltrippermisos;
        private System.Windows.Forms.ToolStripMenuItem tooltrippermisousuario;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSession;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSesion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmabmusuarios;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
    }
}



