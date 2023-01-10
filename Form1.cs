using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador
{
    public partial class Form1 : Form
    { decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = " ";
        private object lblopracao;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbloperacao_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "SOMA";
                lbloperacao.Text = "+";
            } else
            {
                MessageBox.Show("Insira o valor primeiro !");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        { if (textresultado.Text != "")
            {
                valor2 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Insira o valor primeiro !");
            }
            if (operacao == "SOMA")
            {
                textresultado.Text = Convert.ToString(valor1 + valor2);

            }
            else if (operacao == "SUBTRACAO")
            {
                textresultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                textresultado.Text = Convert.ToString(valor1 * valor2);

            }
            else
            {
                textresultado.Text = Convert.ToString(valor1 / valor2);

               
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "SUBTRACAO";
                lbloperacao.Text = "-";
            } else
            {
                MessageBox.Show("Insira o valor primeiro !");

            }
        }
    

        private void button12_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "MULTIPLICACAO";
                lbloperacao.Text = "X";
            } else {
                MessageBox.Show("Insira o valor primeiro !");

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "DIVICAO";
                lbloperacao.Text = "/";
            } else
            {
                MessageBox.Show("Insira o valor primeiro !");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textresultado.Text = " ";
            lbloperacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textresultado.Text = "";
            valor2 = 0;
            valor1 = 0;
            lbloperacao.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
