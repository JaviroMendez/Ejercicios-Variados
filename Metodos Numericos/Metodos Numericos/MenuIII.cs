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
    public partial class MenuIII : Form
    {
        public MenuIII()
        {
            InitializeComponent();
        }

        private void BtnIteracion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuacion se muestra un ejercicio en el cual Las Raices son 2 en el caso de X y 3 en el caso de Y, utilizando ecuaciones ya establecidas para cada variable, obtendremos un valor aproximado a la raiz de cada uno");
            FrmIteracionPunto punto = new FrmIteracionPunto();
            punto.Show();
            this.Hide();
        }

        private void BtnGauss_Click(object sender, EventArgs e)
        {
            FrmGauss frmgauss = new FrmGauss();
            frmgauss.Show();
            this.Hide();
        }

        private void BtnRegresar2_Click(object sender, EventArgs e)
        {
            Unidades unidades = new Unidades();
            unidades.Show();
            this.Hide();
        }
    }
}
