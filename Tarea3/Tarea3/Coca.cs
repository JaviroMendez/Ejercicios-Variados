using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Coca:Bebida
    {
        private string nombre;
        public override void Nombre()
        {
            bool band = true;
            while (band)
            {
            Console.WriteLine("Que Coca quieres: ");
            Console.WriteLine("1.Ligth");
            Console.WriteLine("2.Cero");
            int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        nombre = "Ligth";
                        band = false;
                        break;
                    case 2:
                        nombre = "Cero";
                        band = false;
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta, intenta de nuevo");
                        break;
                }
            }
        }
            public override void mostrar()
        {
            Console.WriteLine("Elegiste una coca cola: "+ nombre + " gracias por tu eleccion");
        }
    }
}
