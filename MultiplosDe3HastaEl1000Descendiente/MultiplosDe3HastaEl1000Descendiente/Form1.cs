using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplosDe3HastaEl1000Descendiente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            Multiiplos m = new Multiiplos();
            DateTime inicio1 = DateTime.Now;
            TxtRecursivo.Text=m.MultiRecursivo(1000);
            DateTime final1 = DateTime.Now;
            TimeSpan tiempo1 = new TimeSpan(final1.Ticks-inicio1.Ticks);
            LblRecursivoTiempo.Text = "Tiempo Recursivo: "+tiempo1.TotalMilliseconds+" Milisegundos";
            DateTime inicio2 = DateTime.Now;
            TxtIterativo.Text = m.MultiIterativo(1000);
            DateTime final2 = DateTime.Now;
            TimeSpan tiempo2 = new TimeSpan(final2.Ticks - inicio2.Ticks);
            LblIterativoTiempo.Text = "Tiempo Iterativo: " + tiempo2.TotalMilliseconds + " Milisegundos";
        }
    }
}
