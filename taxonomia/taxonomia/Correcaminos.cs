using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Correcaminos:aves
    {
        private int velocidad;
        public Correcaminos()
        {
            velocidad = 0;
        }
        public void tipo(int velocidad)
        {
            this.velocidad = velocidad;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Correcaminos");
        }
        public override void consultar()
        {
            Console.WriteLine("Cantidad de Huesos: " + huesos + " -Alas: " + alas + " -Cantidad de Plumas: " + plumas + "Peso: " + peso + " -Velocidad Maxima: " + velocidad + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
