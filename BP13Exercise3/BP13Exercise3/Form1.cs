using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP13Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            double x;

            if(double.TryParse(textBox1.Text, out x))
            {
                label1.Text = (x * x).ToString();
                label2.Text = (x * x * x).ToString();
                label3.Text = (x * x * x * x).ToString();
            }
            else
            {
                label1.Text = "-";
                label2.Text = "-";
                label3.Text = "-";
            }
        }
    }
}
