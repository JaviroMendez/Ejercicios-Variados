using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
namespace Factorial
{
    class Factorial
    {
        public BigInteger factorialRecursivo(int n)
        {
                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    return n * factorialRecursivo(n - 1);
                }
        }
        public BigInteger factorialIterativo(int n)
        {
            BigInteger acum = new BigInteger(1);
            for (int i = 2; i <=n; i++)
            {
                acum *= i;
            }
            return acum;
        }
    }
}
