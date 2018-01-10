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
        int operacion1;
        int operacion2;
        int resultado;
        
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
                label1.Text = "3";
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numeroPulsado = true;
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {

            numeroPulsado = false;
            operacion1 = Int32.Parse(label1.Text);
            label1.Text = "0";
            operando = "+";

          
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Int32.Parse(label1.Text);
            label1.Text = "0";
            operando = "-";

            
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
           

                operacion2 = Int32.Parse(label1.Text);
                Console.WriteLine(RealizarOperacion());
            label1.Text = RealizarOperacion();

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Int32.Parse(label1.Text);
            label1.Text = "0";
            operando = "/";
           
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            numeroPulsado = false;
            operacion1 = Int32.Parse(label1.Text);
            label1.Text = "0";
            operando = "*";
           
           
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

            return Convert.ToString(resultado);
            
        }
    }
}
