using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Gusano:anelidos
    {
        private int Tamaño;
        public Gusano()
        {
            Tamaño = 0;
        }
        public void tipo(int  Tamaño)
        {
            this.Tamaño=Tamaño;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Gusano");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Cantidad de anillos: " + anillos + " -Tamaño: " + Tamaño + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
