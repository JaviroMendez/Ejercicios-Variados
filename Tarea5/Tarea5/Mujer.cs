using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Mujer:Genero
    {
        private string nombre;
        public override void Tipo(string nombre)
        {
            this.nombre = nombre;
        }
        public override void mostrar()
        {
            Console.WriteLine("La mujer se Llama: "+nombre);
        }
    }
}
