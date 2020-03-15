using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta4
{
    class Bancomer: Banco
    {
        private double dinero;
        public override void Fondo(double dinero)
        {
            this.dinero = dinero;
        }
        public override void mostrar()
        {
            Console.WriteLine("El fondo monetario de Bancomer es de: " + dinero);
        }
    }
}
