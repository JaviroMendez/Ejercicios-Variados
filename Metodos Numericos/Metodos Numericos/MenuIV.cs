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
    public partial class MenuIV : Form
    {
        public MenuIV()
        {
            InitializeComponent();
        }

        private void BtnTrapecio_Click(object sender, EventArgs e)
        {
            FrmTrapecio t = new FrmTrapecio();
            t.Show();
            this.Hide();
        }

        private void BtnRegresar2_Click(object sender, EventArgs e)
        {
            Unidades unidades = new Unidades();
            unidades.Show();
            this.Hide();
        }

        private void MenuIV_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSimpson_Click(object sender, EventArgs e)
        {
            Simpson simpson = new Simpson();
            simpson.Show();
            this.Hide();
        }
    }
}
