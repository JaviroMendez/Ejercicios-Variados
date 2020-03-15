using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class Araña:artropodo
    {
        private int patas;
        public Araña()
        {
            patas = 0;
        }
        public void tipo(int patas)
        {
            this.patas = patas;
        }
        public override void mostrar()
        {
            Console.WriteLine("A nacido una Araña");
        }
        public override void consultar()
        {
            Console.WriteLine("Tiene Armadura: " + armadura + " -Numero de Antenas: " + antenas + " -Numero de patas: " + patas + " - Peso: " + peso + " -Edad: " + edad + " -Hijos: " + hijos + " -Distancia: " + distancia);
        }
    }
}
