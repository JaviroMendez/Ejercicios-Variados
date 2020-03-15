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
    public partial class Ea : Form
    {
        public Ea()
        {
            InitializeComponent();
        }

        private void BtnEa_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(TxtActual.Text);
                double b = double.Parse(TxtAnterior.Text);
                MessageBox.Show("" + ((a - b) / a) * 100);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void TxtActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtAnterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmSerieMaclaurin frmseriemauclarin= new FrmSerieMaclaurin();
            frmseriemauclarin.Show();
            this.Hide();
        }
    }
}
