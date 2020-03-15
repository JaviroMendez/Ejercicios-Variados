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
    public partial class Form2 : Form
    {
        private UTree<string> t;
        public Form2()
        {
            InitializeComponent();
            t = new UTree<string>();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (tbC.Text.Trim().Length > 0)
            {
                t.InsertRoot(tbC.Text.Trim());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doubleBufferedPanel1.Invalidate();
        }

        private void doubleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            t.Draw(g, Width / 2, 0);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (tbIP.Text.Trim().Length > 0 && tbIH.Text.Trim().Length > 0)
            {
                t.Insert(tbIP.Text.Trim(), tbIH.Text.Trim());
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (tbE.Text.Trim().Length > 0)
            {
                t.Delete(tbE.Text.Trim());
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (tbB.Text.Trim().Length > 0)
            {
                if (t.Find(tbB.Text.Trim()))
                {
                    MessageBox.Show("Si Existe :)");
                }
                else
                {
                    MessageBox.Show("No Existe :(");
                }
                
            }
        }
    }
}
