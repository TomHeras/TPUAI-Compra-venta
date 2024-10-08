﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DIPLOMA
{
    public partial class Reporte1 : Form
    {
        public Reporte1()
        {
            InitializeComponent();
        }
        BLL.Negocio.Pedidos gestorpedi = new BLL.Negocio.Pedidos();

        int cant = 0, cont = 0;
        double total = 0.0;
        private void Reporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet14.Reporte_prodRepo' Puede moverla o quitarla según sea necesario.
            //this.reporte_prodRepoTableAdapter.Fill(this.tPMODELOSDataSet14.Reporte_prodRepo);
            //// TODO: esta línea de código carga datos en la tabla 'tPMODELOSDataSet13.Reporta_prodVendidos' Puede moverla o quitarla según sea necesario.
            //this.reporta_prodVendidosTableAdapter.Fill(this.tPMODELOSDataSet13.Reporta_prodVendidos);

            foreach (BE.Negocio.Pedido_det item in gestorpedi.listardetalles())
            {
                cant += item.Cantidad;
                total += item.Costo;
            }
            foreach (BE.Negocio.Pedido_Cab item in gestorpedi.listarcabecera())
            {
                cont += 1;
            }

            llenar();
        }


        public void llenar()
        {
            textBox2.Text = cant.ToString();
            textBox1.Text = cont.ToString();
            textBox3.Text = total.ToString();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

        }
    }
}
