using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeropuerto
{
    public partial class Aeropuerto : Form
    {
        public Aeropuerto()
        {
            InitializeComponent();
        }
        int cont = 0, vueltas = 1, w = 12,fin=0, vueltas1 = 1,vueltas2 = 1, vueltas3 = 1, vueltas4 = 1, vueltas5 = 1, vueltas6 = 1, vueltas7 = 1,vueltas8=1, vueltas9 = 1;
        bool band;
        string[] a = new string[10];
        int[] c = new int[10];
        bool[] v = new bool[10];
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void TxtCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion v = new Validacion();
            v.SinLetras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Aeropuerto_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cont < 10)
                {
                    if (TxtAvion.Text != "" && TxtCombustible.Text != "")
                    {
                        if (int.Parse(TxtCombustible.Text) <= 300)
                        {
                            a[cont]= TxtAvion.Text;
                            c[cont]=int.Parse(TxtCombustible.Text);
                            ((PictureBox)Controls["picturebox" + (cont+1)]).Visible = true;
                            ((Label)Controls["label" + (cont+1)]).Visible = true;
                            ((Label)Controls["label" + (cont+1)]).Text =a[cont]+":"+c[cont];
                            TxtAvion.Clear();
                            TxtCombustible.Clear();
                            cont++;
                        }
                        else
                        {
                            MessageBox.Show("No se puede colocar mas de 300 de combustible");
                            TxtCombustible.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se deden de llenar todos los campos");
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden colocar mas de 10 aviones");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void TxtCombustible_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cont>0)
                {
                    BtnAgregar.Enabled=false;
                    TxtAvion.Visible = false;
                    TxtCombustible.Visible = false;
                    LblAvion.Visible = false;
                    LblCombustible.Visible = false;
                    while (!band)
                    {
                        for (int i = 0; i < cont; i++)
                        {
                            c[i] -= 10;
                            if (c[i] < 1)
                            {
                                if (v[i])
                                {

                                }
                                else
                                {
                                    ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(w, 456);
                                    ((Label)Controls["label" + (i + 1)]).Text = a[i];
                                    ((Label)Controls["label" + (i + 1)]).Location = new Point(w, 440);
                                    w += 70;
                                    fin++;
                                    v[i] = true;
                                }
                            }
                            else
                            {
                                switch (i + 1)
                                {
                                    case 1:
                                        switch (vueltas)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384,153);
                                                vueltas++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436,210);
                                                vueltas++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325,314);
                                                vueltas++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas = 1;
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (vueltas1)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas1++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas1++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas1++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas1++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas1++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas1++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas1++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas1++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas1++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas1 = 1;
                                                break;
                                        }
                                        break;
                                    case 3:
                                        switch (vueltas2)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas2++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas2++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas2++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas2++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas2++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas2++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas2++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas2++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas2++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas2 = 1; 
                                                break;
                                        }
                                        break;
                                    case 4:
                                        switch (vueltas3)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas3++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas3++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas3++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas3++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas3++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas3++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas3++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas3++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas3++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas3 = 1;
                                                break;
                                        }
                                        break;
                                    case 5:
                                        switch (vueltas4)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas4++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas4++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas4++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas4++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas4++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas4++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas4++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas4++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas4++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas4 = 1;
                                                break;
                                        }
                                        break;
                                    case 6:
                                        switch (vueltas5)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas5++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas5++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas5++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas5++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas5++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas5++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas5++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas5++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas5++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas5=1;
                                                break;
                                        }
                                        break;
                                    case 7:
                                        switch (vueltas6)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas6++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas6++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas6++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas6++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas6++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas6++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas6++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas6++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas6++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas6=1;
                                                break;
                                        }
                                        break;
                                    case 8:
                                        switch (vueltas7)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas7++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas7++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas7++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas7++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas7++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas7++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas7++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas7++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas7++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas7=1;
                                                break;
                                        }
                                        break;
                                    case 9:
                                        switch (vueltas8)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas8++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas8++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas8++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas8++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas8++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas8++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas8++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas8++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas8++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas8=1;
                                                break;
                                        }
                                        break;
                                    case 10:
                                        switch (vueltas9)
                                        {
                                            case 1:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 97);
                                                vueltas9++;
                                                break;
                                            case 2:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 113);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 97);
                                                vueltas9++;
                                                break;
                                            case 3:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(384, 153);
                                                vueltas9++;
                                                break;
                                            case 4:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(439, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(436, 210);
                                                vueltas9++;
                                                break;
                                            case 5:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(387, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(388, 258);
                                                vueltas9++;
                                                break;
                                            case 6:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(328, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(325, 314);
                                                vueltas9++;
                                                break;
                                            case 7:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(253, 330);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(250, 314);
                                                vueltas9++;
                                                break;
                                            case 8:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 274);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 258);
                                                vueltas9++;
                                                break;
                                            case 9:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(149, 224);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(146, 210);
                                                vueltas9++;
                                                break;
                                            case 10:
                                                ((PictureBox)Controls["picturebox" + (i + 1)]).Location = new Point(200, 169);
                                                ((Label)Controls["label" + (i + 1)]).Text = a[i] + ":" + c[i];
                                                ((Label)Controls["label" + (i + 1)]).Location = new Point(197, 153);
                                                vueltas9=1;
                                                break;
                                        }
                                        break;
                                }
                            }
                        }
                        if (cont == fin)
                        {
                            band = true;
                        }
                        DateTime Tthen = DateTime.Now;
                        do
                        {
                            Application.DoEvents();
                        } while (Tthen.AddSeconds(2) > DateTime.Now);
                    }
                    MessageBox.Show("La Simulacion a Terminado");
                }
                else
                {
                    MessageBox.Show("Debes de tener al menos un avion");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
    }
}

