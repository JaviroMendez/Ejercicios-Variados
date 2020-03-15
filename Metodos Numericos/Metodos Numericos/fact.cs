using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Numericos
{
    class fact
    {
        public double factorial(int n)
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return n*factorial(n - 1);
            }
        }
    }
}
