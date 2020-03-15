using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaLista
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }
        int cont = 0;
        int n;
        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(TxtValor.Text);
                switch (cont + 1)
                {
                    case 1:
                        Txt1.Text = "" + n;
                        Txt1.BackColor = Color.Blue;
                        cont++;
                        break;
                    case 2:
                        Txt2.Text = "" + n;
                        Txt2.BackColor = Color.Red;
                        cont++;
                        break;
                    case 3:
                        Txt3.Text = "" + n;
                        Txt3.BackColor = Color.Yellow;
                        cont++;
                        break;
                    case 4:
                        Txt4.Text = "" + n;
                        Txt4.BackColor = Color.Brown;
                        cont++;
                        break;
                    case 5:
                        Txt5.Text = "" + n;
                        Txt5.BackColor = Color.Green;
                        cont++;
                        break;
                    case 6:
                        Txt6.Text = "" + n;
                        Txt6.BackColor = Color.Orange;
                        cont++;
                        break;
                    case 7:
                        Txt7.Text = "" + n;
                        Txt7.BackColor = Color.Gray;
                        cont++;
                        break;
                    case 8:
                        Txt8.Text = "" + n;
                        Txt8.BackColor = Color.Violet;
                        cont++;
                        break;
                    case 9:
                        Txt9.Text = "" + n;
                        Txt9.BackColor = Color.Gold;
                        cont++;
                        break;
                    case 10:
                        Txt10.Text = "" + n;
                        Txt10.BackColor = Color.Fuchsia;
                        cont++;
                        break;
                    default:
                        MessageBox.Show("No se pueden agregar mas");
                        cont = 11;
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cont > 10)
                {
                    cont = 10;
                }
                switch (cont)
                {
                    case 10:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = Txt5.Text;
                        Txt4.BackColor = Txt5.BackColor;
                        Txt5.Text = Txt6.Text;
                        Txt5.BackColor = Txt6.BackColor;
                        Txt6.Text = Txt7.Text;
                        Txt6.BackColor = Txt7.BackColor;
                        Txt7.Text = Txt8.Text;
                        Txt7.BackColor = Txt8.BackColor;
                        Txt8.Text = Txt9.Text;
                        Txt8.BackColor = Txt9.BackColor;
                        Txt9.Text = Txt10.Text;
                        Txt9.BackColor = Txt10.BackColor;
                        Txt10.Text = "";
                        Txt10.BackColor = Color.Empty;
                        break;
                    case 9:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = Txt5.Text;
                        Txt4.BackColor = Txt5.BackColor;
                        Txt5.Text = Txt6.Text;
                        Txt5.BackColor = Txt6.BackColor;
                        Txt6.Text = Txt7.Text;
                        Txt6.BackColor = Txt7.BackColor;
                        Txt7.Text = Txt8.Text;
                        Txt7.BackColor = Txt8.BackColor;
                        Txt8.Text = Txt9.Text;
                        Txt8.BackColor = Txt9.BackColor;
                        Txt9.Text = "";
                        Txt9.BackColor = Color.Empty;
                        break;
                    case 8:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = Txt5.Text;
                        Txt4.BackColor = Txt5.BackColor;
                        Txt5.Text = Txt6.Text;
                        Txt5.BackColor = Txt6.BackColor;
                        Txt6.Text = Txt7.Text;
                        Txt6.BackColor = Txt7.BackColor;
                        Txt7.Text = Txt8.Text;
                        Txt7.BackColor = Txt8.BackColor;
                        Txt8.Text = "";
                        Txt8.BackColor = Color.Empty;
                        break;
                    case 7:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = Txt5.Text;
                        Txt4.BackColor = Txt5.BackColor;
                        Txt5.Text = Txt6.Text;
                        Txt5.BackColor = Txt6.BackColor;
                        Txt6.Text = Txt7.Text;
                        Txt6.BackColor = Txt7.BackColor;
                        Txt7.Text = "";
                        Txt7.BackColor = Color.Empty;
                        break;
                    case 6:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = Txt5.Text;
                        Txt4.BackColor = Txt5.BackColor;
                        Txt5.Text = Txt6.Text;
                        Txt5.BackColor = Txt6.BackColor;
                        Txt6.Text = "";
                        Txt6.BackColor = Color.Empty;
                        break;
                    case 5:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = Txt5.Text;
                        Txt4.BackColor = Txt5.BackColor;
                        Txt5.Text = "";
                        Txt5.BackColor = Color.Empty;
                        break;
                    case 4:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = Txt4.Text;
                        Txt3.BackColor = Txt4.BackColor;
                        Txt4.Text = "";
                        Txt4.BackColor = Color.Empty;
                        break;
                    case 3:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = Txt3.Text;
                        Txt2.BackColor = Txt3.BackColor;
                        Txt3.Text = "";
                        Txt3.BackColor = Color.Empty;
                        break;
                    case 2:
                        Txt1.Text = Txt2.Text;
                        Txt1.BackColor = Txt2.BackColor;
                        Txt2.Text = "";
                        Txt2.BackColor = Color.Empty;
                        break;
                    case 1:
                        Txt1.Text = "";
                        Txt1.BackColor = Color.Empty;
                        break;
                    default:
                        MessageBox.Show("No se pueden quitar mas");
                        cont = 1;
                        break;
                }
                cont--;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void BtnIralaLista_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pila p = new Pila();
            p.Show();
        }
    }
}
