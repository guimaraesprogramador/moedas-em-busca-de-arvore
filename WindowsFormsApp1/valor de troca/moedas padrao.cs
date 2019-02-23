using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.valor_de_troca
{
    class moedas_padrao
    {
        public static double[] moedas
        {
            get
            {
                double[] valores = new double[5];
                valores[0] = 1.00;
                valores[1] = 0.50;
                valores[2] = 0.25;
                valores[3] = 0.10;
                valores[4] = 0.05;
                return valores;
            }
        }
    }
}
