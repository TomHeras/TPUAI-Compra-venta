using System.Windows.Forms;
using System.Drawing;

namespace TP_DIPLOMA
{
    partial class FrmDashboardCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // === Filtros / Acciones ===
        private GroupBox grpFiltros;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dpDesde;
        private DateTimePicker dpHasta;
        private Button btnGenerar;
        private Button btnAbrirPdf;
        private Button btnAbrirExcel;
        private Button btnAbrirCarpeta;

        // === KPIs ===
        private Panel pnlKpis;
        private Panel pnlKpiTotal;
        private Panel pnlKpiPedidos;
        private Panel pnlKpiPendientes;
        private Label lblKpiTotalTitulo;
        private Label lblKpiTotalValor;
        private Label lblKpiPedidosTitulo;
        private Label lblKpiPedidosValor;
        private Label lblKpiPendTitulo;
        private Label lblKpiPendValor;

        // === Tabs / Visualización ===
        private TabControl tabReportes;
        private TabPage tabComprasMes;
        private TabPage tabGastoProveedor;
        private TabPage tabGastoProducto;
        private TabPage tabPdf;

        // === PictureBoxes para gráficos ===
        private PictureBox picComprasMes;
        private PictureBox picGastoProveedor;
        private PictureBox picGastoProducto;

        // === PDF Tab (si no usás WebView2) ===
        private Button btnAbrirPdfTab;

        /// <summary>
        /// Limpieza de recursos
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Crea y posiciona todos los controles de la vista.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ====== Form ======
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1080, 720);
            this.MinimumSize = new Size(960, 640);
            this.Name = "FrmDashboardCompras";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard Ejecutivo — Compras";
            this.Load += new System.EventHandler(this.FrmDashboardCompras_Load);

            // ====== GroupBox Filtros ======
            this.grpFiltros = new GroupBox();
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Text = "Filtros";
            this.grpFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.grpFiltros.Dock = DockStyle.Top;
            this.grpFiltros.Height = 80;
            this.grpFiltros.Padding = new Padding(10);

            this.lblDesde = new Label();
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Text = "Desde:";
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new Point(16, 35);

            this.dpDesde = new DateTimePicker();
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Format = DateTimePickerFormat.Short;
            this.dpDesde.Location = new Point(70, 30);
            this.dpDesde.Width = 140;

            this.lblHasta = new Label();
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new Point(230, 35);

            this.dpHasta = new DateTimePicker();
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Format = DateTimePickerFormat.Short;
            this.dpHasta.Location = new Point(285, 30);
            this.dpHasta.Width = 140;

            this.btnGenerar = new Button();
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Size = new Size(100, 28);
            this.btnGenerar.Location = new Point(450, 28);
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);

            this.btnAbrirPdf = new Button();
            this.btnAbrirPdf.Name = "btnAbrirPdf";
            this.btnAbrirPdf.Text = "Ver PDF";
            this.btnAbrirPdf.Size = new Size(90, 28);
            this.btnAbrirPdf.Location = new Point(570, 28);
            this.btnAbrirPdf.Click += new System.EventHandler(this.BtnAbrirPdf_Click);

            this.btnAbrirExcel = new Button();
            this.btnAbrirExcel.Name = "btnAbrirExcel";
            this.btnAbrirExcel.Text = "Ver Excel";
            this.btnAbrirExcel.Size = new Size(90, 28);
            this.btnAbrirExcel.Location = new Point(670, 28);
            this.btnAbrirExcel.Click += new System.EventHandler(this.BtnAbrirExcel_Click);

            this.btnAbrirCarpeta = new Button();
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Text = "Carpeta";
            this.btnAbrirCarpeta.Size = new Size(90, 28);
            this.btnAbrirCarpeta.Location = new Point(770, 28);
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.BtnAbrirCarpeta_Click);

            this.grpFiltros.Controls.Add(this.lblDesde);
            this.grpFiltros.Controls.Add(this.dpDesde);
            this.grpFiltros.Controls.Add(this.lblHasta);
            this.grpFiltros.Controls.Add(this.dpHasta);
            this.grpFiltros.Controls.Add(this.btnGenerar);
            this.grpFiltros.Controls.Add(this.btnAbrirPdf);
            this.grpFiltros.Controls.Add(this.btnAbrirExcel);
            this.grpFiltros.Controls.Add(this.btnAbrirCarpeta);

            // ====== Panel KPIs ======
            this.pnlKpis = new Panel();
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Dock = DockStyle.Top;
            this.pnlKpis.Height = 120;
            this.pnlKpis.Padding = new Padding(10);
            this.pnlKpis.BackColor = Color.White;

            // KPI Total
            this.pnlKpiTotal = new Panel();
            this.pnlKpiTotal.Name = "pnlKpiTotal";
            this.pnlKpiTotal.Size = new Size(330, 100);
            this.pnlKpiTotal.Location = new Point(10, 10);
            this.pnlKpiTotal.BorderStyle = BorderStyle.FixedSingle;

            this.lblKpiTotalTitulo = new Label();
            this.lblKpiTotalTitulo.Name = "lblKpiTotalTitulo";
            this.lblKpiTotalTitulo.Text = "Total Gastado";
            this.lblKpiTotalTitulo.AutoSize = true;
            this.lblKpiTotalTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblKpiTotalTitulo.Location = new Point(12, 10);

            this.lblKpiTotalValor = new Label();
            this.lblKpiTotalValor.Name = "lblKpiTotalValor";
            this.lblKpiTotalValor.Text = "$ 0,00";
            this.lblKpiTotalValor.AutoSize = true;
            this.lblKpiTotalValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblKpiTotalValor.ForeColor = Color.FromArgb(20, 75, 160);
            this.lblKpiTotalValor.Location = new Point(10, 40);

            this.pnlKpiTotal.Controls.Add(this.lblKpiTotalTitulo);
            this.pnlKpiTotal.Controls.Add(this.lblKpiTotalValor);

            // KPI Pedidos
            this.pnlKpiPedidos = new Panel();
            this.pnlKpiPedidos.Name = "pnlKpiPedidos";
            this.pnlKpiPedidos.Size = new Size(330, 100);
            this.pnlKpiPedidos.Location = new Point(370, 10);
            this.pnlKpiPedidos.BorderStyle = BorderStyle.FixedSingle;

            this.lblKpiPedidosTitulo = new Label();
            this.lblKpiPedidosTitulo.Name = "lblKpiPedidosTitulo";
            this.lblKpiPedidosTitulo.Text = "Pedidos Totales";
            this.lblKpiPedidosTitulo.AutoSize = true;
            this.lblKpiPedidosTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblKpiPedidosTitulo.Location = new Point(12, 10);

            this.lblKpiPedidosValor = new Label();
            this.lblKpiPedidosValor.Name = "lblKpiPedidosValor";
            this.lblKpiPedidosValor.Text = "0";
            this.lblKpiPedidosValor.AutoSize = true;
            this.lblKpiPedidosValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblKpiPedidosValor.ForeColor = Color.FromArgb(20, 75, 160);
            this.lblKpiPedidosValor.Location = new Point(10, 40);

            this.pnlKpiPedidos.Controls.Add(this.lblKpiPedidosTitulo);
            this.pnlKpiPedidos.Controls.Add(this.lblKpiPedidosValor);

            // KPI Pendientes
            this.pnlKpiPendientes = new Panel();
            this.pnlKpiPendientes.Name = "pnlKpiPendientes";
            this.pnlKpiPendientes.Size = new Size(330, 100);
            this.pnlKpiPendientes.Location = new Point(730, 10);
            this.pnlKpiPendientes.BorderStyle = BorderStyle.FixedSingle;

            this.lblKpiPendTitulo = new Label();
            this.lblKpiPendTitulo.Name = "lblKpiPendTitulo";
            this.lblKpiPendTitulo.Text = "Pendientes";
            this.lblKpiPendTitulo.AutoSize = true;
            this.lblKpiPendTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblKpiPendTitulo.Location = new Point(12, 10);

            this.lblKpiPendValor = new Label();
            this.lblKpiPendValor.Name = "lblKpiPendValor";
            this.lblKpiPendValor.Text = "0";
            this.lblKpiPendValor.AutoSize = true;
            this.lblKpiPendValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblKpiPendValor.ForeColor = Color.FromArgb(20, 75, 160);
            this.lblKpiPendValor.Location = new Point(10, 40);

            this.pnlKpiPendientes.Controls.Add(this.lblKpiPendTitulo);
            this.pnlKpiPendientes.Controls.Add(this.lblKpiPendValor);

            this.pnlKpis.Controls.Add(this.pnlKpiTotal);
            this.pnlKpis.Controls.Add(this.pnlKpiPedidos);
            this.pnlKpis.Controls.Add(this.pnlKpiPendientes);

            // ====== TabControl ======
            this.tabReportes = new TabControl();
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Dock = DockStyle.Fill;
            this.tabReportes.Padding = new Point(10, 6);

            this.tabComprasMes = new TabPage();
            this.tabComprasMes.Name = "tabComprasMes";
            this.tabComprasMes.Text = "Compras por mes";
            this.tabComprasMes.Padding = new Padding(3);

            this.tabGastoProveedor = new TabPage();
            this.tabGastoProveedor.Name = "tabGastoProveedor";
            this.tabGastoProveedor.Text = "Gasto por proveedor";
            this.tabGastoProveedor.Padding = new Padding(3);

            this.tabGastoProducto = new TabPage();
            this.tabGastoProducto.Name = "tabGastoProducto";
            this.tabGastoProducto.Text = "Gasto por producto";
            this.tabGastoProducto.Padding = new Padding(3);

            this.tabPdf = new TabPage();
            this.tabPdf.Name = "tabPdf";
            this.tabPdf.Text = "Reporte PDF";
            this.tabPdf.Padding = new Padding(3);

            this.tabReportes.TabPages.Add(this.tabComprasMes);
            this.tabReportes.TabPages.Add(this.tabGastoProveedor);
            this.tabReportes.TabPages.Add(this.tabGastoProducto);
            this.tabReportes.TabPages.Add(this.tabPdf);

            // ====== PictureBoxes ======
            this.picComprasMes = new PictureBox();
            this.picComprasMes.Name = "picComprasMes";
            this.picComprasMes.Dock = DockStyle.Fill;
            this.picComprasMes.BackColor = Color.WhiteSmoke;
            this.picComprasMes.SizeMode = PictureBoxSizeMode.Zoom;

            this.picGastoProveedor = new PictureBox();
            this.picGastoProveedor.Name = "picGastoProveedor";
            this.picGastoProveedor.Dock = DockStyle.Fill;
            this.picGastoProveedor.BackColor = Color.WhiteSmoke;
            this.picGastoProveedor.SizeMode = PictureBoxSizeMode.Zoom;

            this.picGastoProducto = new PictureBox();
            this.picGastoProducto.Name = "picGastoProducto";
            this.picGastoProducto.Dock = DockStyle.Fill;
            this.picGastoProducto.BackColor = Color.WhiteSmoke;
            this.picGastoProducto.SizeMode = PictureBoxSizeMode.Zoom;

            this.tabComprasMes.Controls.Add(this.picComprasMes);
            this.tabGastoProveedor.Controls.Add(this.picGastoProveedor);
            this.tabGastoProducto.Controls.Add(this.picGastoProducto);

            // ====== PDF Tab (botón abre PDF) ======
            this.btnAbrirPdfTab = new Button();
            this.btnAbrirPdfTab.Name = "btnAbrirPdfTab";
            this.btnAbrirPdfTab.Text = "Abrir PDF";
            this.btnAbrirPdfTab.AutoSize = true;
            this.btnAbrirPdfTab.Anchor = AnchorStyles.None;
            this.btnAbrirPdfTab.Click += new System.EventHandler(this.BtnAbrirPdf_Click);
            // Centro aproximado; el layout final lo ajusta el contenedor.
            //this.btnAbrirPdfTab.Location = new Point((this.tabPdf.ClientSize.Width - 90) / 2, (this.tabPdf.ClientSize.Height - 28) / 2);
            this.tabPdf.Controls.Add(this.btnAbrirPdfTab);

            // ====== Agregar al Form ======
            this.Controls.Add(this.tabReportes);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.grpFiltros);
        }

        #endregion
    }
}
