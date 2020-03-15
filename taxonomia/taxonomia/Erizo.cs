using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Erizo:equinodermos
    {
        private string Tipo;
        public Erizo()
        {
            Tipo = "";
        }
        public void tipo(String Tipo)
        {
            this.Tipo = Tipo;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido un Erizo de Mar");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Tiene cubierta: " + cubierta + " -Tipo: " + Tipo + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
