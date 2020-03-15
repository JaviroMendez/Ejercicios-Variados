using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Beta: peces
    {
        private String Color;
        public Beta()
        {
            Color = "";
        }
        public void tipo(String Color)
        {
            this.Color = Color;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Pez Beta");
        }
        public override void consultar()
        {
            Console.WriteLine("Cantidad de Huesos: " + huesos + " -Cantidad de Aletas: " + aletas + " -Color: " + Color + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
