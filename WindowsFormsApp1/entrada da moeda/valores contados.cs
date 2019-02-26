using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.valor_de_troca;
using System.Collections;
namespace WindowsFormsApp1.entrada_da_moeda
{
   public class valores_contados
    {
        public static Stack valores { get; set; }
        public void contagem(int[] valor, double subratação)
        {
            separ_moedas(subratação);
      }
        private double somando_valor(int[] v)
        {
            double somadorio = 0.00;
           
            for(int i = 0; i < v.Length-1; i++)
            {
                somadorio = somadorio+(moedas_padrao.moedas[i] * v[i]);
            }
            return somadorio;
        }
        private void separ_moedas(double s)
        {
            
            while (s > 0)
            {
                if (s>= moedas_padrao.moedas[0])
                {
                    s =  s - moedas_padrao.moedas[0];
                    um_real++;
                }
                else if (s< moedas_padrao.moedas[0])
                {
                    if (s >= moedas_padrao.moedas[1])
                    {
                        s = s - moedas_padrao.moedas[1];
                        cinquenta_centavos++;
                    }
                   else if(s >= moedas_padrao.moedas[2])
                    {
                        s = s - moedas_padrao.moedas[2];
                        vinte_e_cinco_centavos++;
                    }
                    else if(s >= moedas_padrao.moedas[3])
                    {
                        s = s - moedas_padrao.moedas[3];
                        dez_centavos++;
                    }
                    else if (s > moedas_padrao.moedas[4])
                    {
                        s = s - moedas_padrao.moedas[4];
                        cinco_centavos++;
                    }
                    else if(double.MaxValue > s)
                    {
                        break; 
                    }
                }
            }
           
        }
        public  int cinquenta_centavos { get; set; }
        public  int vinte_e_cinco_centavos { get;set; }
        public  int um_real { get;  set; }
        public  int dez_centavos { get;  set; }
        public  int cinco_centavos { get;  set; }
    }
}
