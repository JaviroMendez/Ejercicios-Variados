using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class anelidos : invertebrado
    {
        protected int anillos;

        public anelidos()
        {
            anillos = 0;
        }
        public void NumeroAnillos(int anillos)
        {
            this.anillos = anillos;
        }
    }
}
