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
            double soma = 0.00;
            double total = somando_valor(valor);
            soma = total - subratação;
            valores = separ_moedas(soma);
            divisao(valores);
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
        private Stack separ_moedas(double s)
        {
            Stack moedas = new Stack(); 
            while (s > 0)
            {
                if (s>= moedas_padrao.moedas[0])
                {
                    s =  s - moedas_padrao.moedas[0];
                    moedas.Push(moedas_padrao.moedas[0]);
                }
                else if (s< moedas_padrao.moedas[0])
                {
                    if (s >= moedas_padrao.moedas[1])
                    {
                        s = s - moedas_padrao.moedas[1];
                        moedas.Push(moedas_padrao.moedas[1]);
                    }
                   else if(s >= moedas_padrao.moedas[2])
                    {
                        s = s - moedas_padrao.moedas[2];
                        moedas.Push(moedas_padrao.moedas[2]);
                    }
                    else if(s >= moedas_padrao.moedas[3])
                    {
                        s = s - moedas_padrao.moedas[3];
                        moedas.Push(moedas_padrao.moedas[3]);
                    }
                    else if (s <= moedas_padrao.moedas[4])
                    {
                        s = s - moedas_padrao.moedas[4];
                        moedas.Push(moedas_padrao.moedas[4]);
                    }
                    else if(double.MaxValue > s)
                    {
                        break; 
                    }
                }
            }
            return moedas;
        }
        public  int cinquenta_centavos { get; set; }
        public  int vinte_e_cinco_centavos { get; set; }
        public  int um_real { get; set; }
        public  int dez_centavos { get; set; }
        public  int cinco_centavos { get; set; }
        private void divisao(Stack valor_principal)
        {
            
            foreach (var obj in valor_principal)
            {
                if (obj.ToString() == moedas_padrao.moedas[0].ToString())
                {
                    um_real = Convert.ToInt32(obj) +um_real;
                }
                else if(obj.ToString() == moedas_padrao.moedas[1].ToString())
                {
                    cinquenta_centavos = cinquenta_centavos + 1;
                }
                else if(obj.ToString() == moedas_padrao.moedas[2].ToString())
                {
                    vinte_e_cinco_centavos = vinte_e_cinco_centavos + 1;
                }
                else if(obj.ToString() == moedas_padrao.moedas[3].ToString())
                {
                    dez_centavos = dez_centavos + 1;
                }
                else if(obj.ToString() == moedas_padrao.moedas[4].ToString())
                {
                    cinco_centavos =   cinco_centavos+1;
                }
            }
        }
    }
}
