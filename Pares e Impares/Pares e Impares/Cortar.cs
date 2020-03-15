using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pares_e_Impares
{
    class Cortar
    {
        int[] numeros;
        string[] letras;
        string suma = "";
        string suma2 = "";
        int cont = 0;
        public string cor(string a)
        {
                letras = new string[a.Length];
                letras = a.Split(',');
                numeros = new int[letras.Length];
            for (int i = 0; i <letras.Length; i++)
            {
                numeros[i] = int.Parse(letras[i]);
            }
            Cortar v = new Cortar();
            return v.verificar(cont,numeros.Length,numeros);
        }
        public string verificar(int cont,int b,int []v)
        {
            if (cont < b)
            {
                if (v[cont] % 2 == 0)
                {
                    suma += "par" + ", ";
                }
                else
                {
                    suma += "Impar" + ", ";
                }
                return verificar(cont+1,b,v);
            }
            else
            {
                return suma+" :)";
            }
        }
        public string cor2(string a)
        {
            letras = new string[a.Length];
            letras = a.Split(',');
            numeros = new int[letras.Length];
            for (int i = 0; i < letras.Length; i++)
            {
                numeros[i] = int.Parse(letras[i]);
            }
            Cortar v = new Cortar();
            return v.verificar2(numeros.Length, numeros);
        }
        public string verificar2(int b, int[] v)
        {
            for (int i = 0; i <b; i++)
            {
                if(v[i] % 2 ==0)
                {
                    suma2 += "par" + ", ";
                }
                else
                {
                    suma2 += "Impar" + ", ";
                }
            }
            return suma2 + " ;)";
        }
    }
}
