using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Gorrion:aves
    {
        private string color;
        public Gorrion()
        {
            color = null;
        }
        public void tipo(string color)
        {
            this.color = color;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Gorrion");
        }
        public override void consultar()
        {
            Console.WriteLine("Cantidad de Huesos: "+ huesos + " -Alas: "+ alas+ " -Cantidad de Plumas: "+ plumas+ " -Peso: " + peso + " -Color: " + color + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
