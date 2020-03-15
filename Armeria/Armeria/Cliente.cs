using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armeria
{
    class Cliente
    {
        private string Cc, Nombre, Direccion, Correo, Fecha, Telefono, Imagen, Cantidad, Descripcion, Clave,Valor;
        private int A;
        public void Guardar(string C, string N, string D, string Co, string F, string T, string I)
        {
            Cc = C;
            Nombre = N;
            Direccion = D;
            Correo = Co;
            Fecha = F;
            Telefono = T;
            Imagen = I;
            ArchivoTexto archivotexto = new ArchivoTexto();
            archivotexto.Escribir(Cc + "|" + Nombre + "|" + Direccion + "|" + Correo + "|" + Fecha + "|" + Telefono + "|" + Imagen, 1);
            ArchivoBinario archivobinario = new ArchivoBinario();
            archivobinario.Escribir(Cc + "|" + Nombre + "|" + Direccion + "|" + Correo + "|" + Fecha + "|" + Telefono + "|" + Imagen, 1);
        }
        public void Guardar(string C, string N, string D, string Ca, string V, string I)
        {
            Cc = C;
            Nombre = N;
            Descripcion = D;
            Cantidad = Ca;
            Valor = V;
            Imagen = I;
            ArchivoTexto archivotexto = new ArchivoTexto();
            archivotexto.Escribir(Cc + "|" + Nombre + "|" + Descripcion + "|" + Cantidad + "|" + Valor + "|" + Imagen, 2);
            ArchivoBinario archivobinario = new ArchivoBinario();
            archivobinario.Escribir(Cc + "|" + Nombre + "|" + Descripcion + "|" + Cantidad + "|" + Valor+ "|" + Imagen, 2);
        }
        public void Guardar(string N,string D,string C,string V)
        {
            Cantidad = C;
            Nombre = N;
            Descripcion= D;
            Valor = V;
            ArchivoTexto archivotexto = new ArchivoTexto();
            archivotexto.Escribir("Cantidad: "+Cantidad + "|"+"Nombre: " + Nombre + "|"+ "Descripcion: " + Descripcion+" | "+"Valor: " + Valor, 3);
            ArchivoBinario archivobinario = new ArchivoBinario();
            archivobinario.Escribir("Cantidad: " + Cantidad + "|" + "Nombre: " + Nombre + "|" + "Descripcion: " + Descripcion + " | " + "Valor: " + Valor, 3);
        }
        public bool bajaCliente(string C, int a)
        {
            Clave = C;
            A = a;
            ArchivoTexto archivotexto = new ArchivoTexto();
            if (archivotexto.eliminar(Clave, A))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public String consultaCliente(String C, int a)
        {
            Clave = C;
            A = a;
            ArchivoTexto archivotexto = new ArchivoTexto();
            string datos = archivotexto.consultar(Clave, A);

            if (datos != null)
            {

                return datos;
            }
            else
            {
                return null;
            }

        }
    }
}
