using System.Threading.Tasks;
using System;

namespace Tarea2
{
    class Botana : Tienda
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
            Console.WriteLine("Yo soy,mmmmmmmm "+ nombre +" cuesto: "+ precio + "adios");
        }
    }
}
