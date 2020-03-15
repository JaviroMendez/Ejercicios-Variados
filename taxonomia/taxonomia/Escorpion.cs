using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Escorpion:artropodo
    {
        private String color;
        public Escorpion()
        {
            color = "";
        }
        public void tipo(String color)
        {
            this.color = color;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Escorpion");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Numero de Antenas: " + antenas + " -Color: " + color + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
