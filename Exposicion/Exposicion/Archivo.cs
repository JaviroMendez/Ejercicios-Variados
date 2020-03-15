using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Exposicion
{
    class Archivo
    {
        public void escribir(String ruta, String dato)
        {
            FileStream stream = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(dato);
            writer.Close();
        }
        public bool eliminar(String ruta, String Id)
        {
            using (StreamWriter fileWrite = new StreamWriter(@"C:\Exposicion\tem.txt"))
            {
                using (StreamReader fielRead = new StreamReader(ruta))
                {
                    String line;
                    while ((line = fielRead.ReadLine()) != null)
                    {
                        string[] datos = line.Split(new char[] { '|' });
                        if (datos[0] != Id)
                        {
                            fileWrite.WriteLine(line);
                        }

                    }
                }
            }
            File.Delete(ruta);
            File.Move(@"C:\Exposicion\tem.txt", ruta);
            return true;
        }

        public String consultar(String ruta, String Id)
        {
            String cadena;
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                cadena = reader.ReadLine();
                string[] datos = cadena.Split('|');
                if (datos[0].Equals(Id))
                {
                    reader.Close();
                    return cadena;
                }
            }
            reader.Close();
            return null;
        }

        public void ordenar(String ruta)
        {
            string cad = "";
            List<string> lista = new List<string>();
            string cadena;
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                cadena = reader.ReadLine();
                lista.Add(cadena);
            }
            lista.Sort();
            for (int i = 0; i < lista.Count; i++)
            {
                cad += lista.ElementAt(i)+ "\n";
                FileStream s = new FileStream(@"C:\Exposicion\ArchivoOrdenado.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(s);
                writer.WriteLine(lista.ElementAt(i));
                writer.Close();
            }
            MessageBox.Show(cad);
            reader.Close();
        }
    }
}
