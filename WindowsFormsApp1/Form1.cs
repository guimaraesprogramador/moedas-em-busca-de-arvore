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
            
              
        }
    }
}
