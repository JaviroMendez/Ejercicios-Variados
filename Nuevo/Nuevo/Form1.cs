using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_memoria_estatica_y_dinamica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string m;
        int a = 0;
        int proseso, proseso2, aux = 1, color = 1, prodina = 0, tamaño2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int tamaño = int.Parse(textBox1.Text);

            if (aux > 11)
            {
                MessageBox.Show("Memoria estatica llena", "Error");
            }
            else if (tamaño < 11 && tamaño > 0)
            {
                proseso = 1;
            }
            else if (tamaño < 21 && tamaño > 10)
            {
                proseso = 2;
            }
            else if (tamaño < 31 && tamaño > 20)
            {
                proseso = 3;
            }
            else if (tamaño < 41 && tamaño > 30)
            {
                proseso = 4;
            }
            else if (tamaño < 51 && tamaño > 40)
            {
                proseso = 5;
            }
            else if (tamaño < 61 && tamaño > 50)
            {
                proseso = 6;
            }
            else if (tamaño < 71 && tamaño > 60)
            {
                proseso = 7;
            }
            else if (tamaño < 81 && tamaño > 70)
            {
                proseso = 8;
            }
            else if (tamaño < 91 && tamaño > 80)
            {
                proseso = 9;
            }
            else if (tamaño < 101 && tamaño > 90)
            {
                proseso = 10;
            }
            proseso2 = proseso + proseso2;
            switch (color)
            {
                case 1:
                    m = "A";
                    break;
                case 2:
                    m = "B";
                    break;
                case 3:
                    m = "C";
                    break;
                case 4:
                    m = "D";
                    break;
                case 5:
                    m = "F";
                    break;
                case 6:
                    m = "G";
                    break;
                case 7:
                    m = "H";
                    break;
                case 8:
                    m = "I";
                    break;
                case 9:
                    m = "J";
                    break;
                case 10:
                    m = "K";
                    break;
            }

            if (proseso2 <= 10)
            {
                for (; aux <= proseso2; aux++)
                {

                    switch (aux)
                    {
                        case 1:
                            p01.Text = m;
                            p01.Visible = true;
                            break;
                        case 2:
                            p02.Text = m;
                            p02.Visible = true;
                            break;
                        case 3:
                            p03.Text = m;
                            p03.Visible = true;
                            break;
                        case 4:
                            p04.Text = m;
                            p04.Visible = true;
                            break;
                        case 5:
                            p05.Text = m;
                            p05.Visible = true;
                            break;
                        case 6:
                            p06.Text = m;
                            p06.Visible = true;
                            break;
                        case 7:
                            p07.Text = m;
                            p07.Visible = true;
                            break;
                        case 8:
                            p08.Text = m;
                            p08.Visible = true;
                            break;
                        case 9:
                            p09.Text = m;
                            p09.Visible = true;
                            break;
                        case 10:
                            p10.Text = m;
                            p10.Visible = true;
                            break;
                    }
                }
                label2.Text = "Estatica:" + proseso2 * 10;
            }
            else
            {
                proseso2 = proseso2 - proseso;
                MessageBox.Show("Memoria estatica insuficiente", "Alerta");
            }
            color = 1 + color;
            //memmoria dinamica----------------------------------------------------------



            if (tamaño2 <= 100 && (tamaño2 + tamaño) < 101)
            {
                prodina = 1 + prodina;
                a = a + tamaño;
                if (prodina < 11)
                {

                    label3.Text = "Dinamica:" + a;
                    switch (prodina)
                    {
                        case 1:
                            d01.Left = (2 * tamaño2);
                            d01.Width = tamaño * 2;
                            break;
                        case 2:
                            d02.Left = (2 * tamaño2);
                            d02.Width = tamaño * 2;
                            break;
                        case 3:
                            d03.Left = (2 * tamaño2);
                            d03.Width = tamaño * 2;
                            break;
                        case 4:
                            d04.Left = (2 * tamaño2);
                            d04.Width = tamaño * 2;
                            break;
                        case 5:
                            d05.Left = (2 * tamaño2);
                            d05.Width = tamaño * 2;
                            break;
                        case 6:
                            d06.Left = (2 * tamaño2);
                            d06.Width = tamaño * 2;
                            break;
                        case 7:
                            d07.Left = (2 * tamaño2);
                            d07.Width = tamaño * 2;
                            break;
                        case 8:
                            d08.Left = (2 * tamaño2);
                            d08.Width = tamaño * 2;
                            break;
                        case 9:
                            d09.Left = (2 * tamaño2);
                            d09.Width = tamaño * 2;
                            break;
                        case 10:
                            d10.Left = (2 * tamaño2);
                            d10.Width = tamaño * 2;
                            break;
                        case 11:
                            MessageBox.Show("Numeros de procesos ", "alerta");
                            break;
                    }
                }
                tamaño2 = tamaño + tamaño2;


            }
            else
            {
                MessageBox.Show("Memoeria dinamica insuficiente", "alerta");
                a = a - tamaño;
                prodina = 1 - prodina;
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void p05_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
