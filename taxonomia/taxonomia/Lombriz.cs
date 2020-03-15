using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Lombriz:anelidos
    {
        private int collar;
        public Lombriz()
        {
            collar = 0;
        }
        public void tipo(int collar)
        {
            this.collar = collar;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido una Lombriz");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Cantidad de anillos: " + anillos + " -Numero de Collares: " + collar + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
