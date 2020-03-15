using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class equinodermos : invertebrado
    {
        protected string cubierta; //aspera o espinas

        public equinodermos()
        {
            cubierta = null;
        }
        public void Cubierta(String cubierta)
        {
            this.cubierta = cubierta;
        }
    }
}
