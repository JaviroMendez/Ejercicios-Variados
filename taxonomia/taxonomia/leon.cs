using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class leon : mamifero
    {
        private int muertos;

        public leon()
        {
            muertos = 0;
        }

        public void cazar(int muertos)
        {
            this.muertos += muertos;
        }

        public override void mostrar()
        {
            base.mostrar();
            System.Console.WriteLine("Se creo un Leon");
        }
    }

}
