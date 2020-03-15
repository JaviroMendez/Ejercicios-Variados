using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Agua: Bebida
    {
        private string nombre;
        public override void Nombre()
        {
            bool band = true;
            while (band)
            {
            Console.WriteLine("Que Agua quieres: ");
            Console.WriteLine("1.Santorini");
            Console.WriteLine("2.Bonafont");
            Console.WriteLine("3.Ciel");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        nombre = "Santorini";
                        band = false;
                        break;
                    case 2:
                        nombre = "Bonafont";
                        band = false;
                        break;
                    case 3:
                        nombre = "Ciel";
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
            Console.WriteLine("Elegiste un Agua: " + nombre + " XD");
        }
    }
}
