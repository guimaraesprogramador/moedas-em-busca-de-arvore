using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.entrada_da_moeda;
using WindowsFormsApp1.valor_de_troca;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        valores_contados valores;
        public Form1()
        {
            InitializeComponent();
            
        }
        public Dictionary<int,int> moedas()
        {
            Dictionary<int, int> m = new Dictionary<int, int>();
            m.Add(0, Convert.ToInt32(um_real_receber.Text));
            m.Add(1, Convert.ToInt32(cinquenta_receber.Text));
            m.Add(2, Convert.ToInt32(vinte_e_cinco_receber.Text));
            m.Add(3, Convert.ToInt32(dez_receber.Text));
            m.Add(4, Convert.ToInt32(cinco_receber.Text));
            return m;
        }
        private void button_resolver_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> valores2 = moedas();
            double a = double.Parse(troco.Text);
            valores = new valores_contados(valores2, a);

            um_real_pagos.Text = valores.um_real.ToString();
            cinquenta_pagos.Text = valores.cinquenta_centavos.ToString();
            vinte_e_cinco_pagos.Text = valores.vinte_e_cinco_centavos.ToString();
            dez_pagos.Text = valores.dez_centavos.ToString();
            cinco_pago.Text = valores.cinco_centavos.ToString();
            
        }

        private void limpar_tudo_Click(object sender, EventArgs e)
        {
            um_real_pagos.Clear();
            cinquenta_pagos.Clear();
            vinte_e_cinco_pagos.Clear();
            dez_pagos.Clear();
            cinco_pago.Clear();
            valores.cinco_centavos = 0;
            valores.cinquenta_centavos = 0;
            valores.dez_centavos = 0;
            valores.um_real = 0;
            valores.vinte_e_cinco_centavos = 0;
           um_real_receber.Clear();
            cinquenta_receber.Clear();
            vinte_e_cinco_receber.Clear();
            dez_receber.Clear();
            cinco_receber.Clear();
            troco.Clear();
        }
    }
}
