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
    public partial class FrmCliente : Form
    {
        Validacion v = new Validacion();
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Buscando Imagen";
                BuscarImagen.InitialDirectory = "C:\\";
                //BuscarImagen.FileName = this.textBox1.Text;
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                    //this.textBox1.Text = BuscarImagen.FileName; 
                    String Direccion = BuscarImagen.FileName;
                    this.PbCliente.ImageLocation = Direccion;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void PtbCargar_Click(object sender, EventArgs e)
        {

        }

        private void TxtCc_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SinLetras(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SinNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SinLetras(e);
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCc.Text != "" && TxtNombre.Text != "" && TxtDireccion.Text != "" && TxtCorreo.Text != "" && DtpFecha.Text != "" && TxtTelefono.Text != "" && PbCliente.ImageLocation!=null)
                {
                    Cliente cliente = new Cliente();
                    cliente.Guardar(TxtCc.Text, TxtNombre.Text, TxtDireccion.Text, TxtCorreo.Text, DtpFecha.Text, TxtTelefono.Text,PbCliente.ImageLocation);
                    MessageBox.Show("Datos Guardados Correctamente");
                    TxtCc.Clear();
                    TxtNombre.Clear();
                    TxtDireccion.Clear();
                    TxtCorreo.Clear();
                    TxtTelefono.Clear();
                    PbCliente.ImageLocation = null;
                }
                else
                {
                    if (PbCliente.ImageLocation != null)
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder dar de alta un cliente");
                    }
                    else
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder dar de alta un cliente y La imagen debe ser cargada");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            String Cla =TxtCc.Text;
            Cliente cliente = new Armeria.Cliente();
            if (cliente.bajaCliente(Cla,1))
                MessageBox.Show("Dato dado de Baja Corretamente");
            else
                MessageBox.Show("Dato dado de Baja Corretamente");


            TxtCc.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtCorreo.Clear();
            TxtTelefono.Clear();
            PbCliente.ImageLocation = null;
            //ArchivoTexto archivotexto = new ArchivoTexto();
            //archivotexto.Leer(1);
            //ArchivoBinario archivobinario = new ArchivoBinario();
            //archivobinario.Leer(1);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            String Cla = TxtCc.Text;
            Cliente cliente = new Armeria.Cliente();
            String datos =cliente.consultaCliente(Cla,1);

            if (datos != null)
            {
                string[] campos = datos.Split('|');

                TxtCc.Text = campos[0];
                TxtNombre.Text = campos[1];
                TxtDireccion.Text = campos[2];
                TxtCorreo.Text = campos[3];
                DtpFecha.Text = campos[4];
                TxtTelefono.Text = campos[5];
                PbCliente.ImageLocation = campos[6];
            }
            else
            {
                MessageBox.Show("Dato no encontrado", "Tienda");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                if (TxtCc.Text != "" && TxtNombre.Text != "" && TxtDireccion.Text != "" && TxtCorreo.Text != "" && DtpFecha.Text != "" && TxtTelefono.Text != "" && PbCliente.ImageLocation != null)
                {
                    String Cla = TxtCc.Text;
                    String datos = cliente.consultaCliente(Cla, 1);
                    if (datos != null)
                    {
                        string[] campos = datos.Split('|');
                        campos[0] = TxtCc.Text;
                        campos[1] = TxtNombre.Text;
                        campos[2] = TxtDireccion.Text;
                        campos[3] = TxtCorreo.Text;
                        campos[4] = DtpFecha.Text;
                        campos[5] = TxtTelefono.Text;
                        campos[6] = PbCliente.ImageLocation;
                        cliente.bajaCliente(Cla, 1);
                        cliente.Guardar(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], campos[6]);
                        MessageBox.Show("Datos Modificados Correctamente");
                        TxtCc.Clear();
                        TxtNombre.Clear();
                        TxtDireccion.Clear();
                        TxtCorreo.Clear();
                        TxtTelefono.Clear();
                        PbCliente.ImageLocation = null;
                    }
                    else
                    {
                        MessageBox.Show("Dato no encontrado");
                    }
                }
                else
                {
                    if (PbCliente.ImageLocation != null)
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder Modificar un cliente");
                    }
                    else
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder Modificar un cliente y La imagen debe ser cargada");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmVendedor frmvendedor = new FrmVendedor();
            this.Hide();
            frmvendedor.Show();
        }
    }
}
