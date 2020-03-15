using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class aves : vertebrado
    {
        protected int plumas, alas;     
        public aves()
        {
            plumas = 0;
            alas =2;
        }
        public void CantidadDePlumas(int cantidad)
        {
            plumas = cantidad;
        }
    }
}
