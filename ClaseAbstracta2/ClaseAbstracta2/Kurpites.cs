using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta2
{
    class Kurpites:Danza
    {
        private string lugar;
        private int tiempo;
        public override void estado(string lugar)
        {
            this.lugar = lugar;
        }
        public override void duracion(int tiempo)
        {
            this.tiempo = tiempo;
        }
        public override void mostrar()
        {
            Console.WriteLine("Kurpites se baila en: " +lugar+ " y dura: " + tiempo+" minutos");
        }
    }
}
