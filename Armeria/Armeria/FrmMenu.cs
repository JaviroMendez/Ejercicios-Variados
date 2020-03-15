using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armeria
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCliente frmcliente = new FrmCliente();
                this.Hide();
                frmcliente.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                MessageBox.Show("Acabas de Utilizar el Boton Cliente");
            }
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProducto frmproducto = new FrmProducto();
                this.Hide();
                frmproducto.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
            finally
            {
                MessageBox.Show("Acabas de Utilizar el Boton Producto");
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
