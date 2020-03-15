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
    public partial class MenuII : Form
    {
        public MenuII()
        {
            InitializeComponent();
        }

        private void BtnIntervaloBiseccion_Click(object sender, EventArgs e)
        {
            FrmMenuIntervalo intervalo = new FrmMenuIntervalo();
            intervalo.Show();
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
