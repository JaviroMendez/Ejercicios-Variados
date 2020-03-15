using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class mamifero : vertebrado
    {
        protected String pelo;
        protected int patas;
        public mamifero()
        {
            pelo = "";
            patas = 0;
        }
        public void NumeroDePatas(int patas)
        {
            this.patas = patas;
        }
        public void ColorDePelo(String pelo)
        {
            this.pelo = pelo;
        }
    }
}
