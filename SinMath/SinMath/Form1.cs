using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinMath
{
    public partial class SinMath : Form
    {
        public SinMath()
        {
            InitializeComponent();
        }
        int numero, elevar;
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtElevar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnYa_Click(object sender, EventArgs e)
        {
            try
            {
                numero = int.Parse(TxtNumero.Text);
                elevar = int.Parse(TxtElevar.Text);
                Elevar el = new Elevar();
                DateTime inicio1 = DateTime.Now;
                TxtRr.Text = "" + el.elevarRecursivo(numero, elevar);
                DateTime final1 = DateTime.Now;
                TimeSpan res = new TimeSpan(final1.Ticks - inicio1.Ticks);
                LblTr.Text = "Tiempo Recursivo: " + res.TotalMilliseconds + " Mls";
                DateTime inicio2 = DateTime.Now;
                TxtRi.Text = "" + el.elevarIterativo(numero, elevar);
                DateTime final2 = DateTime.Now;
                TimeSpan res2 = new TimeSpan(final2.Ticks - inicio2.Ticks);
                LblTi.Text = "Tiempo Iterativo: " + res2.TotalMilliseconds + " Mls";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
