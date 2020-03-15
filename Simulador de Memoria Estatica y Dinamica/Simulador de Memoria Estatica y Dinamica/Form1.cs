using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_Memoria_Estatica_y_Dinamica
{
    public partial class Form1 : Form
    {
        int memoriaestatica = 100;
        int memoriadinamica = 100;
        decimal valordelproceso;
        int proceso = 1;
        int acum=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                valordelproceso = ND1.Value;
                if (valordelproceso <= memoriaestatica && valordelproceso <= memoriadinamica)
                {
                    if(valordelproceso >= 1)
                    {
                        int aux=0;
                        if (valordelproceso > 90)
                        {
                            aux = 10;
                        }
                        else if (valordelproceso > 80)
                        {
                            aux = 9;
                        }
                        else if (valordelproceso > 70)
                        {
                            aux = 8;
                        }
                        else if (valordelproceso > 60)
                        {
                            aux = 7;
                        }
                        else if (valordelproceso > 50)
                        {
                            aux = 6;
                        }
                        else if (valordelproceso > 40)
                        {
                            aux = 5;
                        }
                        else if (valordelproceso > 30)
                        {
                            aux = 4;
                        }
                        else if (valordelproceso > 20)
                        {
                            aux = 3;
                        }
                        else if (valordelproceso > 10)
                        {
                            aux = 2;
                        }
                        else
                        {
                            aux = 1;
                        }
                        switch (proceso)
                        {
                            case 1:
                                switch (aux)
                                {
                                    case 10:
                                        Lble10.BackColor = Color.Blue;
                                        goto case 9;
                                    case 9:
                                        Lble9.BackColor = Color.Blue;
                                        goto case 8;
                                    case 8:
                                        Lble8.BackColor = Color.Blue;
                                        goto case 7;
                                    case 7:
                                        Lble7.BackColor = Color.Blue;
                                        goto case 6;
                                    case 6:
                                        Lble6.BackColor = Color.Blue;
                                        goto case 5;
                                    case 5:
                                        Lble5.BackColor = Color.Blue;
                                        goto case 4;
                                    case 4:
                                        Lble4.BackColor = Color.Blue;
                                        goto case 3;
                                    case 3:
                                        Lble3.BackColor = Color.Blue;
                                        goto case 2;
                                    case 2:
                                        Lble2.BackColor = Color.Blue;
                                        goto case 1;
                                    case 1:
                                        Lble1.BackColor = Color.Blue;
                                        Lbld1.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld1.Height;
                                        Lbld1.BackColor = Color.Blue;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -=aux*10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 2:
                                switch (aux)
                                {
                                    case 9:
                                        Lble10.BackColor = Color.Red;
                                        goto case 8;
                                    case 8:
                                        Lble9.BackColor = Color.Red;
                                        goto case 7;
                                    case 7:
                                        Lble8.BackColor = Color.Red;
                                        goto case 6;
                                    case 6:
                                        Lble7.BackColor = Color.Red;
                                        goto case 5;
                                    case 5:
                                        Lble6.BackColor = Color.Red;
                                        goto case 4;
                                    case 4:
                                        Lble5.BackColor = Color.Red;
                                        goto case 3;
                                    case 3:
                                        Lble4.BackColor = Color.Red;
                                        goto case 2;
                                    case 2:
                                        Lble3.BackColor = Color.Red;
                                        goto case 1;
                                    case 1:
                                        Lble2.BackColor = Color.Red;
                                        Lbld2.Visible = true;
                                        Lbld2.Location = Lbld1.Location;
                                        Lbld2.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld2.Height;
                                        Lbld2.BackColor = Color.Red;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 3:
                                switch (aux)
                                {
                                    case 8:
                                        Lble10.BackColor = Color.Green;
                                        goto case 7;
                                    case 7:
                                        Lble9.BackColor = Color.Green;
                                        goto case 6;
                                    case 6:
                                        Lble8.BackColor = Color.Green;
                                        goto case 5;
                                    case 5:
                                        Lble7.BackColor = Color.Green;
                                        goto case 4;
                                    case 4:
                                        Lble6.BackColor = Color.Green;
                                        goto case 3;
                                    case 3:
                                        Lble5.BackColor = Color.Green;
                                        goto case 2;
                                    case 2:
                                        Lble4.BackColor = Color.Green;
                                        goto case 1;
                                    case 1:
                                        Lble3.BackColor = Color.Green;
                                        Lbld3.Visible = true;
                                        Lbld3.Location = Lbld2.Location;
                                        Lbld3.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld3.Height;
                                        Lbld3.BackColor = Color.Green;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 4:
                                switch (aux)
                                {
                                    case 7:
                                        Lble10.BackColor = Color.Orange;
                                        goto case 6;
                                    case 6:
                                        Lble9.BackColor = Color.Orange;
                                        goto case 5;
                                    case 5:
                                        Lble8.BackColor = Color.Orange;
                                        goto case 4;
                                    case 4:
                                        Lble7.BackColor = Color.Orange;
                                        goto case 3;
                                    case 3:
                                        Lble6.BackColor = Color.Orange;
                                        goto case 2;
                                    case 2:
                                        Lble5.BackColor = Color.Orange;
                                        goto case 1;
                                    case 1:
                                        Lble4.BackColor = Color.Orange;
                                        Lbld4.Visible = true;
                                        Lbld4.Location = Lbld3.Location;
                                        Lbld4.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld4.Height;
                                        Lbld4.BackColor = Color.Orange;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 5:
                                switch (aux)
                                {
                                    case 6:
                                        Lble10.BackColor = Color.Silver;
                                        goto case 5;
                                    case 5:
                                        Lble9.BackColor = Color.Silver;
                                        goto case 4;
                                    case 4:
                                        Lble8.BackColor = Color.Silver;
                                        goto case 3;
                                    case 3:
                                        Lble7.BackColor = Color.Silver;
                                        goto case 2;
                                    case 2:
                                        Lble6.BackColor = Color.Silver;
                                        goto case 1;
                                    case 1:
                                        Lble5.BackColor = Color.Silver;
                                        Lbld5.Visible = true;
                                        Lbld5.Location = Lbld4.Location;
                                        Lbld5.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld5.Height;
                                        Lbld5.BackColor = Color.Silver;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 6:
                                switch (aux)
                                {
                                    case 5:
                                        Lble10.BackColor = Color.Brown;
                                        goto case 4;
                                    case 4:
                                        Lble9.BackColor = Color.Brown;
                                        goto case 3;
                                    case 3:
                                        Lble8.BackColor = Color.Brown;
                                        goto case 2;
                                    case 2:
                                        Lble7.BackColor = Color.Brown;
                                        goto case 1;
                                    case 1:
                                        Lble6.BackColor = Color.Brown;
                                        Lbld6.Visible = true;
                                        Lbld6.Location = Lbld5.Location;
                                        Lbld6.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld6.Height;
                                        Lbld6.BackColor = Color.Brown;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 7:
                                switch (aux)
                                {
                                    case 4:
                                        Lble10.BackColor = Color.Pink;
                                        goto case 3;
                                    case 3:
                                        Lble9.BackColor = Color.Pink;
                                        goto case 2;
                                    case 2:
                                        Lble8.BackColor = Color.Pink;
                                        goto case 1;
                                    case 1:
                                        Lble7.BackColor = Color.Pink;
                                        Lbld7.Visible = true;
                                        Lbld7.Location = Lbld6.Location;
                                        Lbld7.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld7.Height;
                                        Lbld7.BackColor = Color.Pink;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 8:
                                switch (aux)
                                {
                                    case 3:
                                        Lble10.BackColor = Color.Purple;
                                        goto case 2;
                                    case 2:
                                        Lble9.BackColor = Color.Purple;
                                        goto case 1;
                                    case 1:
                                        Lble8.BackColor = Color.Purple;
                                        Lbld8.Visible = true;
                                        Lbld8.Location = Lbld7.Location;
                                        Lbld8.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld8.Height;
                                        Lbld8.BackColor = Color.Purple;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 9:
                                switch (aux)
                                {
                                    case 2:
                                        Lble10.BackColor = Color.Gold;
                                        goto case 1;
                                    case 1:
                                        Lble9.BackColor = Color.Gold;
                                        Lbld9.Visible = true;
                                        Lbld9.Location = Lbld8.Location;
                                        Lbld9.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld9.Height;
                                        Lbld9.BackColor = Color.Gold;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            case 10:
                                switch (aux)
                                {
                                    case 1:
                                        Lble10.BackColor = Color.Black;
                                        Lbld10.Visible = true;
                                        Lbld10.Location = Lbld9.Location;
                                        Lbld10.Height = int.Parse(valordelproceso.ToString()) + int.Parse(valordelproceso.ToString()) + acum;
                                        acum = Lbld10.Height;
                                        Lbld10.BackColor = Color.Black;
                                        break;
                                    default:
                                        MessageBox.Show("Resulta que hay un error en tu programa ya que no deberia entrar al default");
                                        break;
                                }
                                memoriaestatica -= aux * 10;
                                memoriadinamica -= int.Parse(valordelproceso.ToString());
                                proceso += aux;
                                break;
                            default:
                                MessageBox.Show("Ya cumpliste con tus procesos, no puedes hacer otro mas aun cuando tengas memoria");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del proceso debe ser minimo de uno");
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficiente memoria para ejecutar este proceso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
