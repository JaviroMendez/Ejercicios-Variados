using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Factorial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(TxtNumero.Text) >= 1)
                {
                    int numero = (int.Parse(TxtNumero.Text));
                    Factorial f = new Factorial();
                    DateTime inicio1 = DateTime.Now;
                    TxtResultado.Text = (f.factorialRecursivo(numero)).ToString();
                    DateTime final1 = DateTime.Now;
                    TimeSpan total1 = new TimeSpan(final1.Ticks - inicio1.Ticks);
                    LblRecursivo.Text = "Tiempo Recursivo: " + total1.TotalMilliseconds + " milisegundos";
                    DateTime inicio2 = DateTime.Now;
                    TxtResultado2.Text = (f.factorialIterativo(numero)).ToString();
                    DateTime final2 = DateTime.Now;
                    TimeSpan total2 = new TimeSpan(final2.Ticks - inicio2.Ticks);
                    LblIterativo.Text = "Tiempo Iterativo: " + total2.TotalMilliseconds + " milisegundos";
                }
                else
                {
                    MessageBox.Show("No se puede calcular el factorial de un numero menor a 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
