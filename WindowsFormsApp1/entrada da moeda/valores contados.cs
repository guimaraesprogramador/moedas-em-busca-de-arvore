using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.valor_de_troca;
using System.Collections;
using System.Windows.Forms;
namespace WindowsFormsApp1.entrada_da_moeda
{
   public class valores_contados
    {
        List<double> filhosvivos = new List<double>();
        List<double> filhosmorto = new List<double>();
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
            var lista = value;
            double anterior = 0;
            
           foreach(KeyValuePair<int,int> i in lista)
            {
                anterior = moedas_padrao.moedas[i.Key] * i.Value;
                if (anterior > key)
                {
                    filhosmorto.Add(anterior);
                }
                else
                {
                    filhosvivos.Add(anterior);
                }
            }
            if ( somar_mortos(filhosmorto) < key)
            {
                MessageBox.Show("nao existe moedas");
            }
            else
            {
                if (filhosmorto.Count > 0)
                {
                    for (int i = 0; i < filhosmorto.Count; i++)
                    {
                        julgamento(filhosmorto[i]);
                    }
                }

                if (filhosvivos.Count > 0)
                {
                    for (int i = 0; i < filhosvivos.Count; i++)
                    {
                        separ(filhosvivos[i]);
                    }
                }
            }
            
           
        }

        private double somar_mortos(List<double> filhosmorto)
        {
            double s = 0.00;
            for(int i = 0; i < filhosmorto.Count; i++)
            {
                s = s + filhosmorto[i];
            }
            return s;
        }

        private void julgamento(double s)
        {
            for(int y= 0; y < moedas_padrao.moedas.Length; y++)
            {
                if(s % moedas_padrao.moedas[y] == 0)
                {
                    filhosvivos.Add(moedas_padrao.moedas[y]);
                }
            }
        }
        public void separ(double i)
        {
                        double encontrado = descobrir_valor(i);
                        valores(encontrado, contagem(i,encontrado));
        }
        public double descobrir_valor(double p)
        {
            for(int o = 0; o < moedas_padrao.moedas.Length; o++)
            {
                if (p % moedas_padrao.moedas[o] == 0)
                {
                    return moedas_padrao.moedas[o];
                }
            }
            return 0.00;
        }
        public void valores( double s,int valor)
        {

            if (s == moedas_padrao.moedas[0]) um_real = um_real + valor;
            else if (s == moedas_padrao.moedas[1]) cinquenta_centavos = cinquenta_centavos + valor;
            else if (s == moedas_padrao.moedas[2]) vinte_e_cinco_centavos = vinte_e_cinco_centavos +valor;
            else if (s == moedas_padrao.moedas[3]) dez_centavos = dez_centavos + valor;
            else if (s == moedas_padrao.moedas[4]) cinco_centavos = cinco_centavos + valor;


        }
        public int contagem(double vivos, double moeda)
        {
            int soma  = 0;
            float a = float.Parse(vivos.ToString().Replace(",","."));
            do
            {
                a = a - float.Parse(moeda.ToString().Replace(",", "."));
                soma++;
            } while (a>0);
            return soma;
        }
        public  int cinquenta_centavos { get; set; }
        public  int vinte_e_cinco_centavos { get;set; }
        public  int um_real { get;  set; }
        public  int dez_centavos { get;  set; }
        public  int cinco_centavos { get;  set; }
    }
}
