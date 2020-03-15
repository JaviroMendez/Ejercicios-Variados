using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public abstract class Celular
    {
        public abstract void precio(double valor);
        public abstract void color(string color);
        public abstract void mostrar();
    }
}
