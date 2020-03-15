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
    public partial class FrmGauss : Form
    {
        public FrmGauss()
        {
            InitializeComponent();
        }
        bool band;
        int cont;
        double x, y, z, x1, y1, z1, ecux, ecuy, ecuz;

        private void BtnRegresar2_Click(object sender, EventArgs e)
        {
            MenuIII menuIII = new MenuIII();
            menuIII.Show();
            this.Hide();
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

        private void TxtZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int vueltas = 0;
                ecux = ecuy = ecuz = 0;
                cont = 0;
                band = true;
                x = double.Parse(TxtX.Text);
                y = double.Parse(TxtY.Text);
                z = double.Parse(TxtZ.Text);
                while (band)
                {
                    cont++;
                    if (ecux < 0.01 && ecux > 0 && ecuy < 0.01 && ecuy > 0 && ecuz < 0.01 && ecuz > 0)
                    {
                        band = false;
                    }
                    if (ecux < 0.01 && ecux > 0)
                    {
                        x = x1;

                    }
                    else
                    {
                        x1 = ((7.83 + (0.1 * y) + (0.2 * z)) / 3);
                        ecux = ((x1 - x) / x1);
                        x = x1;

                    }
                    if (ecuy < 0.01 && ecuy > 0)
                    {
                        y = y1;
                    }
                    else
                    {
                        y1 = ((-19.3 - (0.1 * x) + (0.3 * z)) / 7);
                        ecuy = ((y1 - y) / y1);
                        y = y1;


                    }
                    if (ecuz < 0.01 && ecuz > 0)
                    {
                        z = z1;
                    }
                    else
                    {
                        z1 = ((71.4 - (0.3 * x) + (0.2 * y)) / 10);
                        ecuz = ((z1 - z) / z1);
                        z = z1;

                    }
                    vueltas++;
                    if (vueltas > 1000)
                    {
                        band = false;
                    }
                }
                if (vueltas < 1000)
                {
                    MessageBox.Show("Error en X1: " + ecux + "\nError en Y1: " + ecuy + "\nError en Z1: " + ecuz);
                    LblVuleltas.Text = "Iteraciones: " + cont;
                }
                else
                {
                    MessageBox.Show("No se encontro raices en 1000 iteraciones");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
    }
}
