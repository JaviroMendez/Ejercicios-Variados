using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armeria
{
    public abstract class Archivo
    {
        public abstract void Escribir(string cadena,int a);
        public abstract void Leer(int a);
    }
}
