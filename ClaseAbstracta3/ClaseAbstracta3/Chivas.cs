using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta3
{
    class Chivas : Equipo
    {
        private int Cantidad;
        public override void campeonatos(int Cantidad)
        {
            this.Cantidad = Cantidad;
        }
        public override void mostrar()
        {
            Console.WriteLine("Las Chivas tienen: " + Cantidad + " campeonatos");
        }
    }
}
