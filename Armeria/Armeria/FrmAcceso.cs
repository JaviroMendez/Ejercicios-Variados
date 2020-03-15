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
    public partial class FrmAcceso : Form
    {
        Validacion v = new Validacion();
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUsuario.Text == "Javier" && TxtContraseña.Text == "Cinthia")
                {
                    FrmMenu frmmenu = new FrmMenu();
                    this.Hide();
                    frmmenu.Show();
                }
                else if (TxtContraseña.Text == "Holis")
                {
                    FrmVendedor frmvendedor = new FrmVendedor();
                    this.Hide();
                    frmvendedor.Show();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SinNumeros(e);
        }
    }
}
