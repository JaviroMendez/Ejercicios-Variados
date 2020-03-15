using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarNumerosPrimos
{
    class Calcular
    {
        int cont, cont2;
        int ndprimos=0;
        int ndprimos2 = 0;
        string cad = "";
        string cad2 = "";
        public string primosRecursivo(int n)
        {
            if (n == 0)
            {
                return cad;
            }
            else
            {
                cont = 0;
                for (int i = 1; i <=n; i++)
                {
                    if (n % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    ndprimos++;
                    cad +=n+", ";
                }
                return primosRecursivo(n-1);
            }
        }
        public int valor()
        {
            return ndprimos;
        }
        public string primosIterativo(int n)
        {
            for (int i = n; i > 0; i--)
            {
                cont2 = 0;
                for (int j = 1; j <=i; j++)
                {
                    if (i % j == 0)
                    {
                        cont2++;
                    }
                }
                if (cont2 == 2)
                {
                    ndprimos2++;
                    cad2 += i + ", ";
                }
            }
            return cad2;
        }
    }
}
