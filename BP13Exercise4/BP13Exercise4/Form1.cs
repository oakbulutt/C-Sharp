using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP13Exercise4
{
    public partial class Form1 : Form
    {
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                result += i;
            }
            label1.Text = "Result: " + result.ToString();
            MessageBox.Show("Result: " + result.ToString());
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
        }
    }
}
