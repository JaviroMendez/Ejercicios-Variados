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
    public partial class MenuI : Form
    {
        public MenuI()
        {
            InitializeComponent();
        }

        private void BtnSerieMaclaurin_Click(object sender, EventArgs e)
        {
            FrmSerieMaclaurin frmseriemaclaurin = new FrmSerieMaclaurin();
            frmseriemaclaurin.Show();
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
