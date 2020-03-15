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
    public partial class FrmSerieMaclaurin : Form
    {
        public FrmSerieMaclaurin()
        {
            InitializeComponent();
        }
        int n;
        float x;
        double valorV;
        double tem;
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                fact f = new fact();
                x =float.Parse(TxtValorX.Text);
                n= int.Parse(TxtCalcular.Text);
                bool band = true;
                double aux = 1 + x;
                double serie = 0;
                tem = aux;
                valorV += aux;
                for (int i = 3; i < 100; i++)
                {
                    valorV += ((Math.Pow(x, i - 1) / f.factorial(i - 1)));
                }
                while (band)
                {
                    if (n == 1)
                    {
                        DgvSerie.Rows.Add(1,serie+1,((valorV-1)/valorV*100));
                        band = false;
                    }
                    else if (n == 2)
                    {
                        DgvSerie.Rows.Add(1,serie+1, ((valorV - 1) / valorV * 100));
                        DgvSerie.Rows.Add(2,aux, ((valorV - aux) / valorV * 100),(x/aux)*100);
                        band = false;
                    }
                    else
                    {
                        DgvSerie.Rows.Add(1, serie+1, ((valorV - 1) / valorV) * 100);
                        DgvSerie.Rows.Add(2,aux, ((valorV - aux) / valorV) * 100, (x / aux) * 100);
                        serie += aux;
                        for (int i = 3; i <= n; i++)
                        {
                            serie += ((Math.Pow(x, i - 1) / f.factorial(i - 1)));
                            DgvSerie.Rows.Add(i, serie,((valorV-serie)/valorV)*100,(((serie-tem))/serie)*100);
                            tem = serie;
                        }
                        band = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void TxtValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtCalcular_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnEt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Et et = new Et();
            et.Show();
        }

        private void BtnEa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ea ea = new Ea();
            ea.Show();
        }

        private void TxtValorX_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuI menuI= new MenuI();
            menuI.Show();
            this.Hide();
        }
    }
}
