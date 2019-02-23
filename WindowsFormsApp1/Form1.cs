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
            valores = new valores_contados();
        }

        private void button_resolver_Click(object sender, EventArgs e)
        {
            int[] receber =new int[]
            {
              int.Parse(um_real_receber.Text),
              int.Parse(cinquenta_receber.Text),
              int.Parse(vinte_e_cinco_receber.Text),
              int.Parse(dez_receber.Text),
              int.Parse(cinco_receber.Text)
            };
          valores.contagem(receber, double.Parse(troco.Text));
            um_real_pagos.Text = valores_contados.um_real.ToString();
            cinquenta_pagos.Text = valores_contados.cinquenta_centavos.ToString();
            vinte_e_cinco_pagos.Text = valores_contados.vinte_e_cinco_centavos.ToString();
            dez_pagos.Text = valores_contados.dez_centavos.ToString();
            cinco_pago.Text = valores_contados.cinco_centavos.ToString();
            
        }

        private void limpar_tudo_Click(object sender, EventArgs e)
        {
            um_real_pagos.Clear();
            cinquenta_pagos.Clear();
            vinte_e_cinco_receber.Clear();
            dez_pagos.Clear();
            cinco_pago.Clear();
        }
    }
}
