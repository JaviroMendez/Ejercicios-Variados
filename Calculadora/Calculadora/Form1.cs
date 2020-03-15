using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double cantidad1;
        double cantidad2;
        double resultado;
        double memoria = 0;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 250;
            label2.Visible = true;
            label3.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button7.Visible = false;
            button28.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button24.Visible = false;
            button26.Visible = false;
            button23.Visible = false;
            button27.Visible = false;
            button25.Visible = false;
            button29.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
            button2.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button15.Enabled = false;
                button19.Enabled = false;
                button18.Enabled = false;
                button2.Enabled = true;
                textBox2.Visible = true;
                operador = "+";
                cantidad1 = double.Parse(textBox1.Text);
                textBox2.Text = textBox1.Text + "+";
                textBox1.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                button11.Enabled = true;
                button15.Enabled = true;
                button19.Enabled = true;
                button18.Enabled = true;
                textBox2.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button15.Enabled = false;
                button19.Enabled = false;
                button18.Enabled = false;
                button2.Enabled = true;
                textBox2.Visible = true;
                operador = "-";
                cantidad1 = double.Parse(textBox1.Text);
                textBox2.Text = textBox1.Text + "-";
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
                button11.Enabled = true;
                button15.Enabled = true;
                button19.Enabled = true;
                button18.Enabled = true;
                textBox2.Visible = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button15.Enabled = false;
                button19.Enabled = false;
                button18.Enabled = false;
                button2.Enabled = true;
                textBox2.Visible = true;
                operador = "*";
                cantidad1 = double.Parse(textBox1.Text);
                textBox2.Text = textBox1.Text + "*";
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                button11.Enabled = true;
                button15.Enabled = true;
                button19.Enabled = true;
                button18.Enabled = true;
                textBox2.Visible = false;
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = false;
                button15.Enabled = false;
                button19.Enabled = false;
                button18.Enabled = false;
                button2.Enabled = true;
                textBox2.Visible = true;
                operador = "/";
                cantidad1 = double.Parse(textBox1.Text);
                textBox2.Text = textBox1.Text + "/";
                textBox1.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                button11.Enabled = true;
                button15.Enabled = true;
                button19.Enabled = true;
                button18.Enabled = true;
                textBox2.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = true;
                button15.Enabled = true;
                button19.Enabled = true;
                button18.Enabled = true;
                if (textBox1.Text.Contains("."))
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                textBox2.Visible = false;
                textBox2.Clear();
                cantidad2 = double.Parse(textBox1.Text);
                switch (operador)
                {
                    case "+":
                        resultado = cantidad1 + cantidad2;
                        textBox1.Text = resultado.ToString();
                        break;
                    case "-":
                        resultado = cantidad1 - cantidad2;
                        textBox1.Text = resultado.ToString();
                        break;
                    case "*":
                        resultado = cantidad1 * cantidad2;
                        textBox1.Text = resultado.ToString();
                        break;
                    case "/":
                        try
                        {
                            if (cantidad2 == 0)
                            {
                                throw new DivideByZeroException("No se puede dividir un numero entre cero");
                            }
                            resultado = cantidad1 / cantidad2;
                            textBox1.Text = resultado.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button11.Enabled = true;
            button15.Enabled = true;
            button19.Enabled = true;
            button18.Enabled = true;
            textBox2.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 250;
            label1.Visible = false;
            label3.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button7.Visible = false;
            button28.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button24.Visible = false;
            button26.Visible = false;
            button23.Visible = false;
            button27.Visible = false;
            button25.Visible = false;
            button29.Visible = false;
            textBox2.Visible = false;
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            label2.Visible = false;
            label3.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button34.Visible = true;
            button35.Visible = true;
            button36.Visible = true;
            button37.Visible = true;
            button38.Visible = true;
            button7.Visible = true;
            button28.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button24.Visible = true;
            button26.Visible = true;
            button23.Visible = true;
            button27.Visible = true;
            button25.Visible = true;
            button29.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (memoria == 0)
            {
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = memoria.ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            memoria = 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                memoria = memoria + Convert.ToDouble(textBox1.Text);
                this.label1.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
            finally
            {
                MessageBox.Show("Usted utilizo la funcion de Guardar en Memoria");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                memoria = Convert.ToDouble(textBox1.Text);
                this.label1.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                memoria = memoria - Convert.ToDouble(textBox1.Text);
                this.label1.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Pow(cantidad1, 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            button2.Enabled = true;
            textBox1.Clear();
            button11.Enabled = true;
            button15.Enabled = true;
            button19.Enabled = true;
            button18.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //textBox2.Visible = false;
            button11.Enabled = true;
            button15.Enabled = true;
            button19.Enabled = true;
            button18.Enabled = true;
            if (textBox1.TextLength>1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Sqrt(cantidad1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Pow(cantidad1, 2).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "")
                {
                    throw new FormatException("No puedes presionar log sin antes dar un valor numerico");
                }
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Log(cantidad1).ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Pow(cantidad1, -1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad2 = double.Parse(textBox1.Text);
                resultado = cantidad1 + cantidad2;
                textBox1.Text = Convert.ToString((cantidad1 * cantidad2) / 100);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Pow(10, cantidad1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Sin(cantidad1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Cos(cantidad1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Tan(cantidad1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Sinh(cantidad1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Cosh(cantidad1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Tanh(cantidad1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad1 = double.Parse(textBox1.Text);
                resultado = cantidad1;
                textBox1.Text = Math.Exp(cantidad1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                MessageBox.Show("Acabas de utilizar la funcion Exponencial");
            }
        }
    }
}
