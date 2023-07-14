using System;
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
    public partial class CotrolPass : UserControl
    {
        public CotrolPass()
        {
            InitializeComponent();
        }
        public string Etiqueta
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        protected void SetearColor(Color unColor)
        {
            label1.ForeColor = unColor;
        }

        public virtual bool Validar()
        {
            bool oki = true;
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                oki = false;
                SetearColor(Color.Red);
            }
            else
            {
                SetearColor(Color.Black);
            }
            return oki;

        }

        public void limpiar()
        {
            textBox1.Clear();
        }
    }
}
