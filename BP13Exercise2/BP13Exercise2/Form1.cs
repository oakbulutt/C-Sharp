using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP13Exercise2
{
    public partial class Form1 : Form
    {
        bool operatorStatus = false;
        double result = 0;
        char operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvents(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operatorStatus)
                textBox1.Clear();
            operatorStatus = false;

            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

        }

        private void MathOperations(object sender, EventArgs e)
        {
            operatorStatus = true;
            Button btn = (Button)sender;
            char newOperation = Char.Parse(btn.Text);

            label1.Text = label1.Text + " " + textBox1.Text + " " + newOperation;

            switch (operation)
            {
                case '+': textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case '-':
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case '*':
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case '/':
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            result = double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
            operation = newOperation;

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            operation = ' ';
            result = 0;
            operatorStatus = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            operatorStatus = true;
            label1.Text = "";
            switch (operation)
            {
                case '+':
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case '-':
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case '*':
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case '/':
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            result = double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
            operation = ' ';
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else if (operatorStatus)
                textBox1.Text = "0";

            if (!textBox1.Text.Contains(","))
                textBox1.Text += ".";

            operatorStatus = false;
        }
    }
}
