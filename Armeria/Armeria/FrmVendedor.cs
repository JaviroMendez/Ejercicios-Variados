using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Armeria
{
    public partial class FrmVendedor : Form
    {
        string aux="", aux2 = "";
        //string aux5="";
        int d;
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new FileNotFoundException("No Has Creado Un Archivo que Tenga Guardado algun producto");
                if (TxtCc.Text != "")
                {
                    String Cla = TxtCc.Text;
                    Cliente cliente = new Cliente();
                    String datos = cliente.consultaCliente(Cla, 2);

                    if (datos != null)
                    {
                        string[] campos = datos.Split('|');
                        LblNombreM.Text = campos[1];
                        LblDescripcionM.Text = campos[2];
                        aux= campos[3];
                        aux2= campos[4];
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void DgvVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvVendedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = DgvVendedor.CurrentRow.Index;
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            int aux3 = 0;
            try
            {
                //String Cla =aux5;
                String Cla = TxtCc.Text;
                Cliente cliente = new Cliente();
                String datos = cliente.consultaCliente(Cla, 2);
                if (datos != null)
                {
                    string[] campos = datos.Split('|');
                    aux3 = int.Parse(aux3.ToString()) + int.Parse(aux);
                    cliente.bajaCliente(Cla, 2);
                    cliente.Guardar(campos[0], campos[1], campos[2], aux3.ToString(), campos[4], campos[5]);
                    MessageBox.Show("Se acaba de modificar el inventario");
                }
                DgvVendedor.Rows.RemoveAt(d);
                aux = "";
                aux2 = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmAcceso frmacceso = new FrmAcceso();
                frmacceso.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void TxtCcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            int aux3 = 0;
            try
            {
                Cliente cliente = new Cliente();
                if (int.Parse(TxtCcantidad.Text) <= int.Parse(aux))
                {
                    DgvVendedor.Rows.Add(LblNombreM.Text, LblDescripcionM.Text, TxtCcantidad.Text, aux2);
                    cliente.Guardar(LblNombreM.Text, LblDescripcionM.Text, TxtCcantidad.Text, aux2);
                    String Cla = TxtCc.Text;
                    //aux5 = Cla;
                    String datos = cliente.consultaCliente(Cla, 2);
                    if (datos != null)
                    {
                        string[] campos = datos.Split('|');
                        aux3 = int.Parse(aux) -int.Parse(TxtCcantidad.Text);
                        cliente.bajaCliente(Cla, 2);
                        cliente.Guardar(campos[0], campos[1], campos[2], aux3.ToString(), campos[4], campos[5]);
                        MessageBox.Show("Se acaba de modificar el inventario");
                    }
                    else
                    {
                        MessageBox.Show("No existen suficientes productos");
                    }
                }
                else
                {
                    MessageBox.Show("No existen suficientes productos");
                }
                TxtCc.Clear();
                LblNombreM.Text = "";
                LblDescripcionM.Text = "";
                TxtCcantidad.Clear();
                aux = "";
                aux2 = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
