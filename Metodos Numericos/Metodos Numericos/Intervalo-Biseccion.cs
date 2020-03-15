using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Metodos_Numericos
{
    public partial class Intervalo_Biseccion : Form
    {
        public Intervalo_Biseccion()
        {
            InitializeComponent();
        }
        double g, m, t, v, inicio, fin,valor,aux;
        int cont = 0, cont2 = 0;
        bool band = true;
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuIntervalo frmmenu = new FrmMenuIntervalo();
            frmmenu.Show();
            this.Hide();
        }

        private void TxtInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void DgvIntervalo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }


        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            this.Width = 889;
            this.Height = 532;
            BtnRegresar1.Visible = false;
            BtnIniciar.Visible = false;
            LblFin.Visible = false;
            Lblg.Visible = false;
            LblInicio.Visible = false;
            Lblm.Visible = false;
            Lblt.Visible = false;
            Lblv.Visible = false;
            LblDatos.Visible = false;
            TxtFin.Visible = false;
            Txtg.Visible = false;
            TxtInicio.Visible = false;
            Txtm.Visible = false;
            Txtt.Visible = false;
            Txtv.Visible = false;
            LblBiseccion.Visible = true;
            LblIntervalos.Visible = true;
            DgvBiseccion.Visible = true;
            DgvIntervalo.Visible = true;
            ChtGrafico.Visible = true;
            BtnRegresar2.Visible = true;
            try
            {
                ChtGrafico.Titles.Add("Intervalos");
                Series series = ChtGrafico.Series.Add("F(c)");
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 4;
                g = double.Parse(Txtg.Text);
                m = double.Parse(Txtm.Text);
                t = double.Parse(Txtt.Text);
                v = double.Parse(Txtv.Text);
                inicio = double.Parse(TxtInicio.Text);
                fin = double.Parse(TxtFin.Text);
                for (double c = inicio; c <= fin; c++)
                {
                    aux = (((g * m) / c) * (1 - Math.Pow(Math.E, -((c / m) * t))) - v);
                    DgvIntervalo.Rows.Add(c, aux);
                    series.Points.Add(aux);
                    if (aux<=0 && band)
                    {
                        DgvIntervalo.Rows[cont-1].DefaultCellStyle.BackColor = Color.Yellow;
                        valor =c-1;
                        band = false;
                    }
                    cont++;         
                }
                for (double i =valor; i <valor+1;i+=0.001)
                {
                    aux = (((g * m) / i) * (1 - Math.Pow(Math.E, -((i / m) * t))) - v);
                    DgvBiseccion.Rows.Add(i, aux);
                    if (aux <= 0)
                    {
                        DgvBiseccion.Rows[cont2 - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                    cont2++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
                DgvBiseccion.Visible = false;
                DgvIntervalo.Visible = false;
                ChtGrafico.Visible = false;
                BtnRegresar2.Visible = false;
                LblBiseccion.Visible = false;
                LblIntervalos.Visible = false;
                BtnRegresar1.Visible = true;
                BtnIniciar.Visible = true;
                LblFin.Visible = true;
                Lblg.Visible = true;
                LblInicio.Visible = true;
                Lblm.Visible = true;
                Lblt.Visible = true;
                Lblv.Visible = true;
                LblDatos.Visible = true;
                TxtFin.Visible = true;
                Txtg.Visible = true;
                TxtInicio.Visible = true;
                Txtm.Visible = true;
                Txtt.Visible = true;
                Txtv.Visible = true;
                this.Width = 360;
                this.Height = 266;
            }
        }




        private void Intervalo_Biseccion_Load(object sender, EventArgs e)
        {
            DgvBiseccion.Visible = false;
            DgvIntervalo.Visible = false;
            ChtGrafico.Visible = false;
            BtnRegresar2.Visible = false;
            LblBiseccion.Visible = false;
            LblIntervalos.Visible = false;
            this.Width = 360;
            this.Height = 266;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DgvBiseccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRegresar1_Click(object sender, EventArgs e)
        {
            FrmMenuIntervalo frmmenu = new FrmMenuIntervalo();
            frmmenu.Show();
            this.Hide();
        }
    }
}
