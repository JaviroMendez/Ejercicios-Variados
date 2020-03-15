using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Estrella:equinodermos
    {
        private string  color;
        public Estrella()
        {
            color = "";
        }
        public void tipo(String color)
        {
            this.color = color;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido una Estrella de Mar");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Tiene cubierta: " + cubierta + " -Color: " + color + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
