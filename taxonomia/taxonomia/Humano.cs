using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Humano:mamifero
    {
        private String Idioma;
        public Humano()
        {
            Idioma = "";
        }
        public void tipo(String Idioma)
        {
            this.Idioma = Idioma;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Humano");
        }
        public override void consultar()
        {
            Console.WriteLine("Cantidad de Huesos: " + huesos + " -Color de Cabello: " + pelo + " -Numero de Pies: " + patas + " -Idioma: " +Idioma+ " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
