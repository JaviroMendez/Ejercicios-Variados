using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Armeria
{
    class ArchivoTexto:Archivo
    {
        string I;
        string M;
        string V;
        public ArchivoTexto()
        {
             I = @"C:\Temp\ArchivoTextoClientes.txt";
             M = @"C:\Temp\ArchivoTextoProductos.txt";
             V = @"C:\Temp\ArchivoTextoVentas.txt";
        }
        public override void Escribir(string cadena,int a)
        {
            try
            {
                if (a == 1)
                {
                    StreamWriter sw = new StreamWriter(I, true);
                    sw.WriteLine(cadena);
                    sw.Close();
                }
                else if(a == 2)
                {
                    StreamWriter sw = new StreamWriter(M, true);
                    sw.WriteLine(cadena);
                    sw.Close();
                }
                else if(a == 3)
                {
                    StreamWriter sw = new StreamWriter(V, true);
                    sw.WriteLine(cadena);
                    sw.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
        public bool eliminar(string clave,int a)
        {
            if (a == 1) {
                using (StreamWriter fileWrite = new StreamWriter(@"C:\Temp\Tem.txt"))
                {
                    using (StreamReader fielRead = new StreamReader(@"C:\Temp\ArchivoTextoClientes.txt"))
                    {
                        String line;

                        while ((line = fielRead.ReadLine()) != null)
                        {
                            string[] datos = line.Split(new char[] { '|' });
                            if (datos[0] != clave)
                            {
                                fileWrite.WriteLine(line);
                            }

                        }
                    }
                }
                File.Delete(@"C:\Temp\ArchivoTextoClientes.txt");
                File.Move(@"C:\Temp\Tem.txt", @"C:\Temp\ArchivoTextoClientes.txt");

            }

            if (a == 2)
            {
                using (StreamWriter fileWrite = new StreamWriter(@"C:\Temp\Tem.txt"))
                {
                    using (StreamReader fielRead = new StreamReader(@"C:\Temp\ArchivoTextoProductos.txt"))
                    {
                        String line;

                        while ((line = fielRead.ReadLine()) != null)
                        {
                            string[] datos = line.Split(new char[] { '|' });
                            if (datos[0] != clave)
                            {
                                fileWrite.WriteLine(line);
                            }

                        }
                    }
                }
                File.Delete(@"C:\Temp\ArchivoTextoProductos.txt");
                File.Move(@"C:\Temp\Tem.txt", @"C:\Temp\ArchivoTextoProductos.txt");
            }
            return true;
        }
        public override void Leer(int a)
        {
            try
            {
                if (a == 1)
                {
                    StreamReader sr = new StreamReader(@"C:\Temp\ArchivoTextoClientes.txt");
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                }
                else if(a == 2)
                {
                    StreamReader sr = new StreamReader(@"C:\Temp\ArchivoTextoProductos.txt");
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                }
                else if(a == 3)
                {
                    StreamReader sr = new StreamReader(@"C:\Temp\ArchivoTextoVentas.txt");
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public String consultar(string clave, int a)
        {
            String cadena;
            if (a == 1)
            {
                FileStream stream = new FileStream(@"C:\Temp\ArchivoTextoClientes.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    cadena = reader.ReadLine();
                    string[] datos = cadena.Split('|');
                    if (datos[0].Equals(clave))
                    {
                        reader.Close();
                        return cadena;
                    }

                }
                reader.Close();
            }
            if (a == 2)
            {
                FileStream stream = new FileStream(@"C:\Temp\ArchivoTextoProductos.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    cadena = reader.ReadLine();
                    string[] datos = cadena.Split('|');
                    if (datos[0].Equals(clave))
                    {
                        reader.Close();
                        return cadena;
                    }

                }
                reader.Close();
            }
            return null;
    }
        ~ArchivoTexto()
        {
            MessageBox.Show("Aqui esta el destructor, wiiiiii");
        }
}
}
