using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos
{
    public partial class FrmIteracionPunto : Form
    {
        public FrmIteracionPunto()
        {
            InitializeComponent();
        }

        double x, y, valorx, valory, temx, temy,auxx,auxy;
        int cont;
        private void FrmIteracionPunto_Load(object sender, EventArgs e)
        {

        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnRegresar2_Click(object sender, EventArgs e)
        {
            MenuIII menuIII = new MenuIII();
            menuIII.Show();
            this.Hide();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                x = double.Parse(TxtX.Text);
                y = double.Parse(TxtY.Text);
                Operacion();
                if (cont < 99)
                {
                    LblVx.Text = "X= " + valorx.ToString();
                    LblVy.Text = "Y= " + valory.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void Operacion()
        {
            try
            {
                TxtX.Clear();
                TxtY.Clear();
                LblVx.Text = "";
                LblVy.Text = "";
                cont = 0;
                temx = Math.Sqrt((10) - (x * y));
                temy = Math.Sqrt((57 - y) / (3 * temx));
                auxx = temx;
                auxy = temy;
                while (true && cont < 99)
                {
                    if (temx > 1.9 && temx < 2.1 && temy > 2.9 && temy < 3.1)
                    {
                        valorx = temx;
                        valory = temy;
                        break;
                    }
                    else
                    {
                        temx = Math.Sqrt((10) - (temx * temy));
                        temy = Math.Sqrt((57 - y) / (3 * temx));
                    }
                    cont++;
                }
                if (cont == 99) MessageBox.Show("No se puede encontrar un valor para la raiz de X y Y cercano a 2 y 3 en 98 iteraciones, intenta con otros valores");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }         
        }
    }
}
