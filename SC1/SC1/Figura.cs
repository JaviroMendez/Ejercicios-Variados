using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1
{
    public class Figura
    {
        protected double lado,b,altura;
        public Figura(double lado)
        {
            this.lado = lado;
        }
        public Figura(double b, double altura)
        {
            this.b = b;
            this.altura = altura;
        }
    }
}
