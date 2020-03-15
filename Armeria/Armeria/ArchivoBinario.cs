using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Armeria
{
    class ArchivoBinario:Archivo
    {
        public override void Escribir(string cadena,int a)
        {
            try
            {
                if (a == 1)
                {
                    FileStream fs = new FileStream(@"C:\Temp\ArchivoBinarioClientes.txt", FileMode.Append);
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                    bw.Write(cadena);
                    bw.Close();
                }
                else if (a == 2)
                {
                    FileStream fs = new FileStream(@"C:\Temp\ArchivoBinarioProductos.txt", FileMode.Append);
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                    bw.Write(cadena);
                    bw.Close();
                }
                else if (a == 3)
                {
                    FileStream fs = new FileStream(@"C:\Temp\ArchivoBinarioTexto.txt", FileMode.Append);
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                    bw.Write(cadena);
                    bw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public override void Leer(int a)
        {
            try
            {
                if (a == 1)
                {
                    StreamReader sr = new StreamReader(@"C:\Temp\ArchivoBinarioProductos.txt");
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                }
                else if (a == 2)
                {
                    StreamReader sr = new StreamReader(@"C:\Temp\ArchivoBinarioProductos.txt");
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                }
                else if (a == 3)
                {
                    StreamReader sr = new StreamReader(@"C:\Temp\ArchivoBinarioVentas.txt");
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
