using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Lirio:equinodermos
    {
        private int largo;
        public Lirio()
        {
            largo = 0;
        }
        public void tipo(int largo)
        {
            this.largo = largo;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Lirio de Mar");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Tiene cubierta: " + cubierta + " -Largo: " + largo + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
