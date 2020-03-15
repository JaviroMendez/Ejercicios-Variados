using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_Dinamicos
{
    public partial class Form1 : Form
    {
        int [] X;
        int [] Y;
        int [] Z;
        int x, y, z;
        int Sumax; int Sumay; int Sumaz;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 115;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Sumax = 0; Sumay = 0; Sumaz = 0;
                int[] X = new int[x];
                int[] Y = new int[y];
                int[] Z = new int[z];
                switch (x)
                {
                    case 10:
                        X[9] = int.Parse(textBox13.Text);
                        Sumax += int.Parse(textBox13.Text);
                        goto case 9;
                    case 9:
                        X[8] = int.Parse(textBox12.Text);
                        Sumax += int.Parse(textBox12.Text);
                        goto case 8;
                    case 8:
                        X[7] = int.Parse(textBox11.Text);
                        Sumax += int.Parse(textBox11.Text);
                        goto case 7;
                    case 7:
                        X[6] = int.Parse(textBox10.Text);
                        Sumax += int.Parse(textBox10.Text);
                        goto case 6;
                    case 6:
                        X[5] = int.Parse(textBox9.Text);
                        Sumax += int.Parse(textBox9.Text);
                        goto case 5;
                    case 5:
                        X[4] = int.Parse(textBox8.Text);
                        Sumax += int.Parse(textBox8.Text);
                        goto case 4;
                    case 4:
                        X[3] = int.Parse(textBox7.Text);
                        Sumax += int.Parse(textBox7.Text);
                        goto case 3;
                    case 3:
                        X[2] = int.Parse(textBox6.Text);
                        Sumax += int.Parse(textBox6.Text);
                        goto case 2;
                    case 2:
                        X[1] = int.Parse(textBox5.Text);
                        Sumax += int.Parse(textBox5.Text);
                        goto case 1;
                    case 1:
                        X[0] = int.Parse(textBox4.Text);
                        Sumax += int.Parse(textBox4.Text);
                        break;
                }
                switch (y)
                {
                    case 10:
                        Y[9] = int.Parse(textBox23.Text);
                        Sumay += int.Parse(textBox23.Text);
                        goto case 9;
                    case 9:
                        Y[8] = int.Parse(textBox22.Text);
                        Sumay += int.Parse(textBox22.Text);
                        goto case 8;
                    case 8:
                        Y[7] = int.Parse(textBox21.Text);
                        Sumay += int.Parse(textBox21.Text);
                        goto case 7;
                    case 7:
                        Y[6] = int.Parse(textBox20.Text);
                        Sumay += int.Parse(textBox20.Text);
                        goto case 6;
                    case 6:
                        Y[5] = int.Parse(textBox19.Text);
                        Sumay += int.Parse(textBox19.Text);
                        goto case 5;
                    case 5:
                        Y[4] = int.Parse(textBox18.Text);
                        Sumay += int.Parse(textBox18.Text);
                        goto case 4;
                    case 4:
                        Y[3] = int.Parse(textBox17.Text);
                        Sumay += int.Parse(textBox17.Text);
                        goto case 3;
                    case 3:
                        Y[2] = int.Parse(textBox16.Text);
                        Sumay += int.Parse(textBox16.Text);
                        goto case 2;
                    case 2:
                        Y[1] = int.Parse(textBox15.Text);
                        Sumay += int.Parse(textBox15.Text);
                        goto case 1;
                    case 1:
                        Y[0] = int.Parse(textBox14.Text);
                        Sumay += int.Parse(textBox14.Text);
                        break;
                }
                switch (z)
                {
                    case 10:
                        Z[9] = int.Parse(textBox33.Text);
                        Sumaz += int.Parse(textBox33.Text);
                        goto case 9;
                    case 9:
                        Z[8] = int.Parse(textBox32.Text);
                        Sumaz += int.Parse(textBox32.Text);
                        goto case 8;
                    case 8:
                        Z[7] = int.Parse(textBox31.Text);
                        Sumaz += int.Parse(textBox31.Text);
                        goto case 7;
                    case 7:
                        Z[6] = int.Parse(textBox30.Text);
                        Sumaz += int.Parse(textBox30.Text);
                        goto case 6;
                    case 6:
                        Z[5] = int.Parse(textBox29.Text);
                        Sumaz += int.Parse(textBox29.Text);
                        goto case 5;
                    case 5:
                        Z[4] = int.Parse(textBox28.Text);
                        Sumaz += int.Parse(textBox28.Text);
                        goto case 4;
                    case 4:
                        Z[3] = int.Parse(textBox27.Text);
                        Sumaz += int.Parse(textBox27.Text);
                        goto case 3;
                    case 3:
                        Z[2] = int.Parse(textBox26.Text);
                        Sumaz += int.Parse(textBox26.Text);
                        goto case 2;
                    case 2:
                        Z[1] = int.Parse(textBox25.Text);
                        Sumaz += int.Parse(textBox25.Text);
                        goto case 1;
                    case 1:
                        Z[0] = int.Parse(textBox24.Text);
                        Sumaz += int.Parse(textBox24.Text);
                        break;
                }
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox34.Text = "" + Sumax;
                textBox35.Text = "" + Sumay;
                textBox36.Text = "" + Sumaz;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar j = new Validar();
            j.SinLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar j = new Validar();
            j.SinLetras(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar j = new Validar();
            j.SinLetras(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("LLENAR TODOS LOS ESPACIOS");
                }
                else
                {
                    if (int.Parse(textBox1.Text) < 11 && int.Parse(textBox2.Text) < 11 && int.Parse(textBox3.Text) < 11)
                    {
                        button2.Visible = true;
                        this.Width = 542;
                        x = int.Parse(textBox1.Text);
                        y = int.Parse(textBox2.Text);
                        z = int.Parse(textBox3.Text);
                        switch (x)
                        {
                            case 10:
                                textBox13.Visible = true;
                                goto case 9;
                            case 9:
                                textBox12.Visible = true;
                                goto case 8;
                            case 8:
                                textBox11.Visible = true;
                                goto case 7;
                            case 7:
                                textBox10.Visible = true;
                                goto case 6;
                            case 6:
                                textBox9.Visible = true;
                                goto case 5;
                            case 5:
                                textBox8.Visible = true;
                                goto case 4;
                            case 4:
                                textBox7.Visible = true;
                                goto case 3;
                            case 3:
                                textBox6.Visible = true;
                                goto case 2;
                            case 2:
                                textBox5.Visible = true;
                                goto case 1;
                            case 1:
                                textBox4.Visible = true;
                                break;
                        }
                        switch (y)
                        {
                            case 10:
                                textBox23.Visible = true;
                                goto case 9;
                            case 9:
                                textBox22.Visible = true;
                                goto case 8;
                            case 8:
                                textBox21.Visible = true;
                                goto case 7;
                            case 7:
                                textBox20.Visible = true;
                                goto case 6;
                            case 6:
                                textBox19.Visible = true;
                                goto case 5;
                            case 5:
                                textBox18.Visible = true;
                                goto case 4;
                            case 4:
                                textBox17.Visible = true;
                                goto case 3;
                            case 3:
                                textBox16.Visible = true;
                                goto case 2;
                            case 2:
                                textBox15.Visible = true;
                                goto case 1;
                            case 1:
                                textBox14.Visible = true;
                                break;
                        }
                        switch (z)
                        {
                            case 10:
                                textBox33.Visible = true;
                                goto case 9;
                            case 9:
                                textBox32.Visible = true;
                                goto case 8;
                            case 8:
                                textBox31.Visible = true;
                                goto case 7;
                            case 7:
                                textBox30.Visible = true;
                                goto case 6;
                            case 6:
                                textBox29.Visible = true;
                                goto case 5;
                            case 5:
                                textBox28.Visible = true;
                                goto case 4;
                            case 4:
                                textBox27.Visible = true;
                                goto case 3;
                            case 3:
                                textBox26.Visible = true;
                                goto case 2;
                            case 2:
                                textBox25.Visible = true;
                                goto case 1;
                            case 1:
                                textBox24.Visible = true;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO ES POSIBLE ENTRAR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }
        }
}
