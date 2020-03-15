using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta2
{
    public abstract class Danza
    {
        public abstract void estado(string lugar);
        public abstract void duracion(int tiempo);
        public abstract void mostrar();
    }
}
