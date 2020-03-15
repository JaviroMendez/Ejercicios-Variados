using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pares_e_Impares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cortar c = new Cortar();
                DateTime inicio1 = DateTime.Now;
                TxtResultado.Text = c.cor(TxtNumeros.Text);
                DateTime final1 = DateTime.Now;
                TimeSpan res = new TimeSpan(final1.Ticks - inicio1.Ticks);
                LblRecursivo.Text = "Tiempo Recursivo: " + res.TotalMilliseconds + " Milisegundos";
                DateTime inicio2 = DateTime.Now;
                TxtResultado2.Text = c.cor2(TxtNumeros.Text);
                DateTime final2 = DateTime.Now;
                TimeSpan res2 = new TimeSpan(final2.Ticks - inicio2.Ticks);
                LblIterativo.Text = "Tiempo Iperativo: " + res2.TotalMilliseconds + " Milisegundos";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
