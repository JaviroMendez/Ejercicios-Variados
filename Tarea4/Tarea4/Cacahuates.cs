using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Cacahuates: Botana
    {
        private string sabor;
        public override void nombre()
        {
            bool band = true;
            while (band)
            {
                Console.WriteLine("Que Cacahuates quieres: ");
                Console.WriteLine("1.Con chilito");
                Console.WriteLine("2.Con Limonsito");
                Console.WriteLine("3.Con Salesita");
                Console.WriteLine("4.Con todo");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        sabor= "Con Chilito";
                        band = false;
                        break;
                    case 2:
                        sabor = "Con Limonsito";
                        band = false;
                        break;
                    case 3:
                        sabor = "Con Salesita";
                        band = false;
                        break;
                    case 4:
                        sabor = "Con Todo";
                        band = false;
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
            }
        }
        public override void mostrar()
        {
            Console.WriteLine("Escogiste cacahuates " + sabor + " ummmmmm");
        }
    }
}

