using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Gato:mamifero
    {
        private String Raza;
        public Gato()
        {
            Raza = "";
        }
        public void tipo(String Raza)
        {
            this.Raza = Raza;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Gato");
        }
        public override void consultar()
        {
            Console.WriteLine("Cantidad de Huesos: " + huesos + " -Color de Cabello: " + pelo + " -Numero de Patas: " + patas + " -Raza: " + Raza + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
