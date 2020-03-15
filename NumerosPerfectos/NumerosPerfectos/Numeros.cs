using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NumerosPerfectos
{
    class Numeros
    {
        string cad = "",cad2="";
        int sum, sum2;
        public string numerosRecursivo(int r)
        {
            sum = 0;
            if (r == 0)
            {
                return cad+ " son numeros perfectos";
            }
            else
            {
                for (int i = 1; i <r; i++)
                {
                    if (r % i == 0)
                    {
                        sum += i;
                    }
                }
                if (r == sum)
                {
                    cad += sum+", ";
                }
                return numerosRecursivo(r-1);
            }
        }
        public string numerosIterativo(int r)
        {
            for (int i =r; i>0; i--)
            {
                sum2 = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum2 += j;
                    }
                }
                if (i == sum2)
                {
                    cad2 += sum2 + ", ";
                }
            }
            return cad2+" son los numeros";
        }
    }
}
