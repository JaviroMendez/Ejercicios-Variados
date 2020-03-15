using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class artropodo : invertebrado
    {
        protected int antenas;

        public artropodo()
        {
            antenas = 0;
        }

        public void NumeroDeAntenas(int antenas)
        {
            this.antenas = antenas;
        }
    }
}
