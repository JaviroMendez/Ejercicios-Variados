using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class invertebrado:animal
    {
        protected String armadura;

        public invertebrado ()
        {
            armadura = null;
        }
        public void Tiene(String armadura)
        {
            this.armadura = armadura;
        }
    }
}
