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
    public partial class FrmMenuIntervalo : Form
    {
        public FrmMenuIntervalo()
        {
            InitializeComponent();
        }

        private void BtnEjemplo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Planteamiento del problema.Utilice el método gráfico para determinar el coeficiente de arrastre (coeficiente de resistencia) c necesario para que un paracaidista de masa m = 68.1 kg tenga una velocidad de 40 m/s después de una caída libre de t = 10 s. Nota: La aceleración de la gravedad es 9.8 m/s2. ");
            Intervalo_Biseccion intervalo = new Intervalo_Biseccion();
            intervalo.Show();
            this.Hide();
        }

        private void BtnEjemplo2_Click(object sender, EventArgs e)
        {
            FrmIntervaloBiseccion intervalo = new FrmIntervaloBiseccion();
            intervalo.Show();
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuII menuII = new MenuII();
            menuII.Show();
            this.Hide();
        }

        private void FrmMenuIntervalo_Load(object sender, EventArgs e)
        {

        }
    }
}
