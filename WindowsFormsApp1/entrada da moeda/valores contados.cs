using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.valor_de_troca;
namespace WindowsFormsApp1.entrada_da_moeda
{
   public class valores_contados
    {
        public static double valores { get; set; }
        public void contagem(int[] valor, double subratação)
        {
            double soma = 0.00;
            double total = somando_valor(valor);
            soma = total - subratação;
            double valor_monitario = 0.00;
            valor_monitario = soma / moedas_padrao.moedas[0];
             valores =  separ_um_real(valor_monitario);
            double nota_baixa = Math.Round((valor_monitario % moedas_padrao.moedas[4]) *100);
            double nota_media_0_25 = Math.Round((valor_monitario % moedas_padrao.moedas[2])*100);
            double nota_media_0_50 = Math.Round((valor_monitario % moedas_padrao.moedas[1])*100);
            double nota_media_0_10 = Math.Round((valor_monitario % moedas_padrao.moedas[3]) * 100);
            double s = valores + (nota_media_0_50*0.50) + (nota_media_0_25*0.25)+ (nota_media_0_10*0.10) + (nota_baixa*0.05);
      }
        private double somando_valor(int[] v)
        {
            double somadorio = 0.00;
            for(int i = 0; i < v.Length; i++)
            {
                somadorio = somadorio+(moedas_padrao.moedas[i] * v[i]);
            }
            return somadorio;
        }
        private double separ_um_real(double s)
        {
            double somadorio2 = 0.00;
            somadorio2 = Math.Round((s % moedas_padrao.moedas[0])*10); ;
            return somadorio2;
        }
        
    }
}
