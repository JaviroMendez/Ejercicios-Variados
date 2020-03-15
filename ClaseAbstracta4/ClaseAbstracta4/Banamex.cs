using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta4
{
    class Banamex:Banco
    {
        private double dinero;
        public override void Fondo(double dinero)
        {
            this.dinero = dinero;
        }
        public override void mostrar()
        {
            Console.WriteLine("El fondo monetario del banco Banamex es de: "+dinero);
        }
    }
}
