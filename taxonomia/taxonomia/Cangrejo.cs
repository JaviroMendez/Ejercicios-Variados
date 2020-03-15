using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Cangrejo:artropodo
    {
        private String color;
        public Cangrejo()
        {
            color = "";
        }
        public void tipo(String color)
        {
            this.color = color;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Cangrejo");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Numero de Antenas: " + antenas + " -Color: " + color + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
