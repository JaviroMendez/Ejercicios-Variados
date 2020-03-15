using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Metodos_Numericos
{
    public partial class FrmIntervaloBiseccion : Form
    {
        public FrmIntervaloBiseccion()
        {
            InitializeComponent();
        }
        double inicio, fin, valor, aux;
        int cont = 0, cont2 = 0;
        bool band = true;
        private void TxtInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnRegresar1_Click(object sender, EventArgs e)
        {
            FrmMenuIntervalo frmmenu = new FrmMenuIntervalo();
            frmmenu.Show();
            this.Hide();
        }

        private void FrmIntervaloBiseccion_Load(object sender, EventArgs e)
        {
            this.Width = 232;
            this.Height = 157;
            DgvBiseccion.Visible = false;
            DgvIntervalo.Visible = false;
            ChtGrafico.Visible = false;
            BtnRegresar2.Visible = false;
            LblBiseccion.Visible = false;
            LblIntervalos.Visible = false;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            this.Width = 918;
            this.Height = 525;
            BtnRegresar1.Visible = false;
            BtnIniciar.Visible = false;
            LblFin.Visible = false;
            LblInicio.Visible = false;
            TxtInicio.Visible = false;
            TxtFin.Visible = false;
            LblMensaje.Visible = false;
            LblBiseccion.Visible = true;
            LblIntervalos.Visible = true;
            DgvBiseccion.Visible = true;
            DgvIntervalo.Visible = true;
            ChtGrafico.Visible = true;
            BtnRegresar2.Visible = true;
            try
            {
                ChtGrafico.Titles.Add("Intervalos");
                Series series = ChtGrafico.Series.Add("F(x)");
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 4;
                inicio = double.Parse(TxtInicio.Text);
                fin = double.Parse(TxtFin.Text);
                for (double c = inicio; c <= fin; c++)
                {
                    aux = Math.Sin((10*c))+Math.Cos((3*c));
                    DgvIntervalo.Rows.Add(c, aux);
                    series.Points.Add(aux);
                    if (aux >= 0 && band)
                    {
                        DgvIntervalo.Rows[cont].DefaultCellStyle.BackColor = Color.Yellow;
                        valor = c;
                        band = false;
                    }
                    else if(aux >= 0)
                    {
                        DgvIntervalo.Rows[cont].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    cont++;
                }
                for (double i = valor; i < valor + 1; i += 0.001)
                {
                    aux = Math.Sin((10 * i)) + Math.Cos((3 * i));
                    DgvBiseccion.Rows.Add(i, aux);
                    if (aux <= 0)
                    {
                        DgvBiseccion.Rows[cont2 - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                    cont2++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                DgvBiseccion.Visible = false;
                DgvIntervalo.Visible = false;
                ChtGrafico.Visible = false;
                BtnRegresar2.Visible = false;
                LblBiseccion.Visible = false;
                LblIntervalos.Visible = false;
                BtnRegresar1.Visible = true;
                BtnIniciar.Visible = true;
                LblFin.Visible = true;
                LblInicio.Visible = true;
                LblMensaje.Visible = true;
                TxtFin.Visible = true;
                TxtInicio.Visible = true;
                this.Width = 232;
                this.Height = 157;
            }
        }

        private void BtnRegresar2_Click(object sender, EventArgs e)
        {
            FrmMenuIntervalo frmmenu = new FrmMenuIntervalo();
            frmmenu.Show();
            this.Hide();
        }
    }
}
