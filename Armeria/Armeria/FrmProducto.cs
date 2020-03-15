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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void LblCc_Click(object sender, EventArgs e)
        {

        }

        private void LblCantidad_Click(object sender, EventArgs e)
        {

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
                    this.PbArma.ImageLocation = Direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCc.Text != "" && TxtNombre.Text != "" && TxtDescripcion.Text != "" && TxtCantidad.Text != "" && TxtValor.Text != ""  && PbArma.ImageLocation != null)
                {
                    Cliente cliente = new Cliente();
                    cliente.Guardar(TxtCc.Text, TxtNombre.Text, TxtDescripcion.Text, TxtCantidad.Text, TxtValor.Text, PbArma.ImageLocation);
                    MessageBox.Show("Producto Agregado Correctamente");
                    TxtCc.Clear();
                    TxtNombre.Clear();
                    TxtDescripcion.Clear();
                    TxtCantidad.Clear();
                    TxtValor.Clear();
                    PbArma.ImageLocation = null;
                }
                else
                {
                    if (PbArma.ImageLocation != null)
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder agregar un producto");
                    }
                    else
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder agregar un producto y La imagen debe ser cargada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void TxtCc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinNumeros(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            String Cla = TxtCc.Text;
            Cliente cliente = new Armeria.Cliente();
            if (cliente.bajaCliente(Cla, 2))
                MessageBox.Show("Producto Eliminado Correctamente");
            else
                MessageBox.Show("Producto Eliminado Correctamente");


            TxtCc.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtCantidad.Clear();
            TxtValor.Clear();
            PbArma.ImageLocation = null;
            //ArchivoTexto archivotexto = new ArchivoTexto();
            //archivotexto.Leer(2);
            //ArchivoBinario archivobinario = new ArchivoBinario();
            //archivobinario.Leer(2);
        }

        private void TxtCc_Validated(object sender, EventArgs e)
        {

        }

        private void TxtCc_Enter(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            String Cla = TxtCc.Text;
            Cliente cliente = new Cliente();
            String datos = cliente.consultaCliente(Cla, 2);

            if (datos != null)
            {
                string[] campos = datos.Split('|');
                TxtCc.Text = campos[0];
                TxtNombre.Text = campos[1];
                TxtDescripcion.Text = campos[2];
                TxtCantidad.Text = campos[3];
                TxtValor.Text = campos[4];
                PbArma.ImageLocation = campos[5];
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                if (TxtCc.Text != "" && TxtNombre.Text != "" && TxtDescripcion.Text != "" && TxtCantidad.Text != "" && TxtValor.Text != ""  && PbArma.ImageLocation != null)
                {
                    String Cla = TxtCc.Text;
                    String datos = cliente.consultaCliente(Cla, 2);
                    if (datos != null)
                    {
                        string[] campos = datos.Split('|');
                        campos[0] = TxtCc.Text;
                        campos[1] = TxtNombre.Text;
                        campos[2] = TxtDescripcion.Text;
                        campos[3] = TxtCantidad.Text;
                        campos[4] = TxtValor.Text;
                        campos[5] = PbArma.ImageLocation;
                        cliente.bajaCliente(Cla, 2);
                        cliente.Guardar(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5]);
                        MessageBox.Show("Datos Modificados Correctamente");
                        TxtCc.Clear();
                        TxtNombre.Clear();
                        TxtDescripcion.Clear();
                        TxtCantidad.Clear();
                        TxtValor.Clear();
                        PbArma.ImageLocation = null;
                    }
                    else
                    {
                        MessageBox.Show("Dato no encontrado");
                    }
                }
                else
                {
                    if (PbArma.ImageLocation != null)
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder Modificar un cliente");
                    }
                    else
                    {
                        MessageBox.Show("Todos los Campos deben ser llenados para poder Modificar un cliente y La imagen debe ser cargada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void PbArma_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmVendedor frmvendedor = new FrmVendedor();
            this.Hide();
            frmvendedor.Show();
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v= new Validacion();
            v.SinLetras(e);
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
