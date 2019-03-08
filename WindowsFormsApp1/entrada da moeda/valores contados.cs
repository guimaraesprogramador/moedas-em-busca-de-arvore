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
        List<double> filhosvivos = new List<double>();
        List<int> filhosmorto = new List<int>();
        public valores_contados(Dictionary<int,int> moedasinicializadas,double trocada)
        {
           
            Dictionary<int, int> moedas = moedasinicializadas;
            double folha = trocada;
        valores_zero(moedas);
            if(moedas.Values.Count > 0)
            {
               randrow(moedas,folha);
            }
        }
     
        public void valores_zero(Dictionary<int, int> mortos)
        {
            var list = mortos.Keys.ToList();
            list.Sort();
            foreach(var key in list)
            {
                if(mortos[key] == 0)
                {
                    mortos.Remove(key);
                    
                }
            }
        }
        public void randrow(Dictionary<int, int> value,double key)
        {
            double escolha = 0;
           var lista = value.Keys.ToList();
           foreach(var i in lista)
            {
                escolha = key - lista[i] * moedas_padrao.moedas[i];



            }
        }
        public void contagem(int[] valor, double subratação)
        {
            separ_moedas(subratação,valor);
      }
        private void separ_moedas(double s,int[] v)
        {

            int i = 0;
            while (s > 0)
            {

                if (s>= moedas_padrao.moedas[0])
                {
                    s =  s - moedas_padrao.moedas[0];
                    um_real++;
                }
                else if (s< moedas_padrao.moedas[0])
                {
                    if (s >= moedas_padrao.moedas[1]&& v[i]>0)
                    {
                        s = s - moedas_padrao.moedas[1];
                        cinquenta_centavos++;
                    }
                   else if(s >= moedas_padrao.moedas[2]&& v[i]>0)
                    {
                        s = s - moedas_padrao.moedas[2];
                        vinte_e_cinco_centavos++;
                    }
                    else if(s >= moedas_padrao.moedas[3]&& v[i]>0)
                    {
                        s = s - moedas_padrao.moedas[3];
                        dez_centavos++;
                    }
                    else if (s > moedas_padrao.moedas[4]&&v[i]>0)
                    {
                        s = s - moedas_padrao.moedas[4];
                        cinco_centavos++;
                    }
                    
                    i++;
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
