using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxonomia
{
    class animal
    {
        protected int edad,hijos;
        protected double peso, distancia;
        public animal()
        {
            edad = 0;
            hijos = 0;
            peso = 0;
            distancia = 0;
        }

        public void nacer(double pesoNacimiento)
        {
            peso = pesoNacimiento;
        }

        public void crecer()
        {
            edad++;
        }

        public void reproducirse(int hijos)
        {
            this.hijos += hijos;
        }

        public void avanzar (double distancia)
        {
            this.distancia += distancia;
        }

        public virtual void consultar()
        {
            Console.WriteLine("Edad: " + edad +  " - Peso: " + peso + " - Hijos: " + hijos +   " - Distancia: " + distancia);
        }

        public virtual void mostrar()
        {
            Console.WriteLine("Se creo un animal");
        }
    }
}
