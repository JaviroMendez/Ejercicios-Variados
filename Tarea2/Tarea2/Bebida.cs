using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Bebida:Tienda
    {
        private string nombre;
        private int precio;
        public override void producto(string nombre)
        {
         this.nombre = nombre;
        }
        public override void valor(int precio)
        {
            this.precio = precio;
        }
        public override void mostrar()
        {
            Console.WriteLine("Hola soy una bebida llamada "+ nombre + " y mi precio es: "+ precio + " xD");
        }
    }
}
