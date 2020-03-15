using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            Form2 arbol = new Form2();
            arbol.MdiParent = this;
            arbol.Show();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPS gps = new GPS();
            gps.MdiParent = this;
            gps.Show();
        }

        private void viajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viajero viajero = new Viajero();
            viajero.MdiParent = this;
            viajero.Show();
        }
    }
}
