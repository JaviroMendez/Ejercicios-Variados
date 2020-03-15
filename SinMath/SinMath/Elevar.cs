using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinMath
{
    class Elevar
    {
        double valor=1,valor2=1;
        public double elevarRecursivo(int n,int el)
        {
            if (el == 0)
            {
                return valor;
            }
            else
            {
                valor *= n;
                return elevarRecursivo(n, el-1);
            }
        }
        public double elevarIterativo(int n,int el)
        {
            for (int i = 1; i <=el; i++)
            {
                valor2 *= n;
            }
            return valor2;
        }
    }
}
