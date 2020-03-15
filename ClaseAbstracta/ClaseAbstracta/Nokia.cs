using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class Nokia:Celular
    {
        private double valor;
        private string color2;
        public override void precio(double valor)
        {
            this.valor = valor;
        }
        public override void color(string color2)
        {
            this.color2 = color2;
        }
        public override void mostrar()
        {
            Console.WriteLine("El Celular Nokia cuesta: "+valor+ " y es de color: "+color2);
        }
    }
}
