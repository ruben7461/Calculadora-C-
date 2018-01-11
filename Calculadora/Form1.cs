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
        Boolean numeroPulsado;
        String operando;
        double operacion1;
        double operacion2;
        double resultado;
        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button1.Text;
            }
            else
            {
                label1.Text += button1.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button2.Text;
            }
            else
            {
                label1.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button3.Text;
            }
            else
            {
                label1.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button4.Text;
            }
            else
            {
                label1.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button5.Text;
            }
            else
            {
                label1.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button6.Text;
            }
            else
            {
                label1.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button7.Text;
            }
            else
            {
                label1.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button8.Text;
            }
            else
            {
                label1.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = button9.Text;
            }
            else
            {
                label1.Text += button9.Text;
            }
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {

            numeroPulsado = false;
            operacion1 = Double.Parse(label1.Text);
            label1.Text = "0";
            operando = "+";

          
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Double.Parse(label1.Text);
            label1.Text = "0";
            operando = "-";

            
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
           

                operacion2 = Double.Parse(label1.Text);
                Console.WriteLine(RealizarOperacion());
            label1.Text = RealizarOperacion();

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Double.Parse(label1.Text);
            label1.Text = "0";
            operando = "/";
           
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Double.Parse(label1.Text);
            label1.Text = "0";
            operando = "*";
           
           
        }

        private void buttonRaizCuadrada(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Double.Parse(label1.Text);
            operando = "√";
            label1.Text = RealizarOperacion();
        }

        private String RealizarOperacion()
        {

            if (operando == "+")
            {
                resultado = operacion1 + operacion2;
            }

            if (operando == "-")
            {
                resultado = operacion1 - operacion2;
            }

            if (operando == "*")
            {
                resultado = operacion1 * operacion2;
            }

            if (operando == "/")
            {
                resultado = operacion1 / operacion2;
            }

            if (operando == "√")
            {
                resultado = Math.Sqrt(operacion1);
            }

            return Convert.ToString(resultado);
            
        }

       
    }
}
