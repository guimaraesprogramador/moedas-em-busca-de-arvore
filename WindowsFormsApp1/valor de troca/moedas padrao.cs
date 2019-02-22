using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.valor_de_troca
{
    class moedas_padrao
    {
        public static int[] moedas
        {
            get
            {
                int[] valores = new int[4];
                valores[0] = 50;
                valores[1] = 25;
                valores[2] = 10;
                valores[3] = 5;
                return valores;
            }
        }
    }
}
