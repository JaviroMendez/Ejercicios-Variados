using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe3HastaEl1000Descendiente
{
    class Multiiplos
    {
        string acum = "";
        string acum2 = "";
        public string MultiRecursivo(int a)
        {
            if (a==0)
            {
                return acum+ " ya no hay multiplos";
            }
            if (a % 3 == 0)
            {
                acum +=a+", ";
                return MultiRecursivo(a-1);
            }
            else
            {
                return MultiRecursivo(a - 1);
            }
        }
        public string MultiIterativo(int a)
        {
            for (int i = a; i >2 ; i--)
            {
                if(a % 3==0)
                {
                    acum += a + ", ";
                }
            }
            return acum + " son todos los multiplos";
        }
    }
}
