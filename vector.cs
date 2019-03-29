using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combos_listas
{
    class vector
    {
        private int[] vec = new int[1000];

        public void llenar()
        {
            for(int i=0;i<1000;i++)
            {
                vec[i] = 1;
            }
        }

        public void reacomodo()
        {
            for (int i = 2; i < 1000; i++)
            {
                if(vec[i]==1)
                    for(int j=i+1;j<1000;j++)
                    {
                        if (j % i == 0)
                            vec[j] = 0;
                    }

            }
        }

        public string mostrar()
        {
            string a = "";
            for (int i = 1; i < 1000; i++)
            {
                a = a + " " + vec[i];
                if (i % 10 == 0)
                    a = a + "\r\n";
            }
            return a;
            
        }

    }
}
