using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPerfectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int valor;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 183;
            this.Height = 188;
            LblNumeros.Visible = false;
            TxtNumeros.Visible = false;
            LblAux.Visible = false;
            TxtAux.Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Width = 502;
                LblNumeros.Visible = true;
                TxtNumeros.Visible = true;
                LblAux.Visible = true;
                TxtAux.Visible = true;
                valor = int.Parse(TxtRango.Text);
                Numeros n = new Numeros();
                DateTime inicio1 = DateTime.Now;
                TxtNumeros.Text = n.numerosRecursivo(valor);
                DateTime final1 = DateTime.Now;
                TimeSpan res = new TimeSpan(final1.Ticks - inicio1.Ticks);
                LblTr.Text = "Tiempo Recursivo: " + res.TotalMilliseconds + " Milisegundos";
                DateTime inicio2 = DateTime.Now;
                TxtAux.Text = n.numerosIterativo(valor);
                DateTime final2 = DateTime.Now;
                TimeSpan res2 = new TimeSpan(final2.Ticks - inicio2.Ticks);
                LblTi.Text = "Tiempo Iterativo: " + res2.TotalMilliseconds + " Milisegundos";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                this.Width = 183;
                this.Height = 188;
                LblNumeros.Visible = false;
                TxtNumeros.Visible = false;
                LblAux.Visible = false;
                TxtAux.Visible = false;
            }
        }

        private void TxtRango_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }
    }
}
