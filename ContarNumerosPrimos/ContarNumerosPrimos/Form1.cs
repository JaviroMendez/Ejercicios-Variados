using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContarNumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numero;
        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void Btnprimos_Click(object sender, EventArgs e)
        {
            try
            {
                this.Height = 378;
                Txtprimos.Visible = true;
                TxtAux.Visible = true;
                LblTime.Visible = true;
                numero = int.Parse(TxtNumeros.Text);
                Calcular c = new Calcular();
                DateTime inicio1 = DateTime.Now;
                Txtprimos.Text = c.primosRecursivo(numero);
                DateTime final1 = DateTime.Now;
                TimeSpan res = new TimeSpan(final1.Ticks - inicio1.Ticks);
                LblTr.Text = "Tiempo Recursivo: " + res.TotalMilliseconds + " mls";
                DateTime inicio2 = DateTime.Now;
                TxtAux.Text = c.primosIterativo(numero);
                DateTime final2 = DateTime.Now;
                TimeSpan res2 = new TimeSpan(final2.Ticks - inicio2.Ticks);
                LblTi.Text = "Tiempo Iterativo: " + res2.TotalMilliseconds + " mls";
                Lblprimos.Text = "La cantidad de numeros primos son: " + c.valor() + " y los numeros primos son:";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +ex);
                this.Height = 133;
                this.Width = 411;
                Txtprimos.Visible = false;
                TxtAux.Visible = false;
                LblTime.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 133;
            this.Width = 411;
            Txtprimos.Visible = false;
            TxtAux.Visible = false;
            LblTime.Visible = false;
        }
    }
}
