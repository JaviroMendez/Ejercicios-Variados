using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1
{
    public class Cuadrado:Figura
    {
        public Cuadrado(double lado) : base(lado)
        {
            Console.WriteLine("El area del cuadrado es: "+(lado*lado));
        }
    }
}
