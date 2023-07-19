using System.Windows.Forms;
using System.Drawing;

namespace TP_DIPLOMA.Reportes
{
    partial class FrmDashboardVentas
    {
        private System.ComponentModel.IContainer components = null;

        // ===== Contenedores base =====
        private Panel pnlHeader;
        private Panel pnlKpis;
        private TableLayoutPanel tlpCharts;

        // ===== Header: botones y fechas =====
        private FlowLayoutPanel flpBtns;
        private Button btnGenerar;
        private Button btnAbrirPdf;
        private Button btnAbrirExcel;

        private FlowLayoutPanel flpFechas;
        private Label lblDesde;
        private DateTimePicker dpDesde;
        private Label lblHasta;
        private DateTimePicker dpHasta;

        // ===== KPIs =====
        private Label lblVentTotal;
        private Label lblVentVentas;
        private Label lblVentTicket;
        private Label lblVentPendientes;
        private Label lblVentEntregados;

        // ===== Gráficos (2x2) =====
        private PictureBox picVentasMes;
        private PictureBox picTopProductos;
        private PictureBox picTopClientes;
        private PictureBox picEstados;

        /// <summary> Limpieza de recursos. </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1200, 780);
            this.MinimumSize = new Size(1100, 700);
            this.Name = "FrmDashboardVentas";
            this.Text = "Dashboard Ejecutivo — VENTAS";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmDashboardVentas_Load);

            // ===== Header =====
            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(8);
            pnlHeader.BackColor = Color.White;

            flpBtns = new FlowLayoutPanel();
            flpBtns.FlowDirection = FlowDirection.LeftToRight;
            flpBtns.Dock = DockStyle.Left;
            flpBtns.Width = 420;
            flpBtns.Padding = new Padding(4);

            btnGenerar = new Button();
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Text = "Generar";
            btnGenerar.Width = 110;
            btnGenerar.Height = 32;
            btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            btnAbrirPdf = new Button();
            btnAbrirPdf.Name = "btnAbrirPdf";
            btnAbrirPdf.Text = "Ver PDF";
            btnAbrirPdf.Width = 110;
            btnAbrirPdf.Height = 32;
            btnAbrirPdf.Click += new System.EventHandler(this.btnAbrirPdf_Click);

            btnAbrirExcel = new Button();
            btnAbrirExcel.Name = "btnAbrirExcel";
            btnAbrirExcel.Text = "Ver Excel";
            btnAbrirExcel.Width = 110;
            btnAbrirExcel.Height = 32;
            btnAbrirExcel.Click += new System.EventHandler(this.btnAbrirExcel_Click);

            flpBtns.Controls.Add(btnGenerar);
            flpBtns.Controls.Add(btnAbrirPdf);
            flpBtns.Controls.Add(btnAbrirExcel);

            flpFechas = new FlowLayoutPanel();
            flpFechas.FlowDirection = FlowDirection.LeftToRight;
            flpFechas.Dock = DockStyle.Fill;
            flpFechas.Padding = new Padding(4);

            lblDesde = new Label();
            lblDesde.Text = "Desde:";
            lblDesde.AutoSize = true;
            lblDesde.Margin = new Padding(8, 8, 4, 4);

            dpDesde = new DateTimePicker();
            dpDesde.Format = DateTimePickerFormat.Short;
            dpDesde.Width = 120;
            dpDesde.ShowCheckBox = true;

            lblHasta = new Label();
            lblHasta.Text = "Hasta:";
            lblHasta.AutoSize = true;
            lblHasta.Margin = new Padding(16, 8, 4, 4);

            dpHasta = new DateTimePicker();
            dpHasta.Format = DateTimePickerFormat.Short;
            dpHasta.Width = 120;
            dpHasta.ShowCheckBox = true;

            flpFechas.Controls.Add(lblDesde);
            flpFechas.Controls.Add(dpDesde);
            flpFechas.Controls.Add(lblHasta);
            flpFechas.Controls.Add(dpHasta);

            pnlHeader.Controls.Add(flpFechas);
            pnlHeader.Controls.Add(flpBtns);

            // ===== KPIs =====
            pnlKpis = new Panel();
            pnlKpis.Dock = DockStyle.Top;
            pnlKpis.Height = 110;
            pnlKpis.Padding = new Padding(12);

            lblVentTotal = new Label();
            lblVentTotal.AutoSize = true;
            lblVentTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblVentTotal.Text = "Total: $0";
            lblVentTotal.Location = new Point(12, 10);

            lblVentVentas = new Label();
            lblVentVentas.AutoSize = true;
            lblVentVentas.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblVentVentas.Text = "Ventas: 0";
            lblVentVentas.Location = new Point(12, 54);

            lblVentTicket = new Label();
            lblVentTicket.AutoSize = true;
            lblVentTicket.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblVentTicket.Text = "Ticket: $0";
            lblVentTicket.Location = new Point(160, 54);

            lblVentPendientes = new Label();
            lblVentPendientes.AutoSize = true;
            lblVentPendientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblVentPendientes.Text = "Pendientes: 0";
            lblVentPendientes.Location = new Point(12, 82);

            lblVentEntregados = new Label();
            lblVentEntregados.AutoSize = true;
            lblVentEntregados.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblVentEntregados.Text = "Entregados: 0";
            lblVentEntregados.Location = new Point(160, 82);

            pnlKpis.Controls.Add(lblVentTotal);
            pnlKpis.Controls.Add(lblVentVentas);
            pnlKpis.Controls.Add(lblVentTicket);
            pnlKpis.Controls.Add(lblVentPendientes);
            pnlKpis.Controls.Add(lblVentEntregados);

            // ===== Gráficos 2x2 =====
            tlpCharts = new TableLayoutPanel();
            tlpCharts.Dock = DockStyle.Fill;
            tlpCharts.ColumnCount = 2;
            tlpCharts.RowCount = 2;
            tlpCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlpCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlpCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            tlpCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            tlpCharts.Padding = new Padding(8);

            picVentasMes = new PictureBox();
            picVentasMes.Dock = DockStyle.Fill;
            picVentasMes.BackColor = Color.WhiteSmoke;
            picVentasMes.SizeMode = PictureBoxSizeMode.Zoom;

            picTopProductos = new PictureBox();
            picTopProductos.Dock = DockStyle.Fill;
            picTopProductos.BackColor = Color.WhiteSmoke;
            picTopProductos.SizeMode = PictureBoxSizeMode.Zoom;

            picTopClientes = new PictureBox();
            picTopClientes.Dock = DockStyle.Fill;
            picTopClientes.BackColor = Color.WhiteSmoke;
            picTopClientes.SizeMode = PictureBoxSizeMode.Zoom;

            picEstados = new PictureBox();
            picEstados.Dock = DockStyle.Fill;
            picEstados.BackColor = Color.WhiteSmoke;
            picEstados.SizeMode = PictureBoxSizeMode.Zoom;

            tlpCharts.Controls.Add(picVentasMes, 0, 0);
            tlpCharts.Controls.Add(picTopProductos, 1, 0);
            tlpCharts.Controls.Add(picTopClientes, 0, 1);
            tlpCharts.Controls.Add(picEstados, 1, 1);

            // ===== Agregar al Form =====
            this.Controls.Add(tlpCharts);
            this.Controls.Add(pnlKpis);
            this.Controls.Add(pnlHeader);
        }

        #endregion
    }
}