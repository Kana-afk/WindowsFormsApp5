using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll(); // select all text
            textBox1.Cut(); // cut out what was selected

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(textBox2.Text); // The function adds text to the end of the line textBox1 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Lines = new string[] { " Line 1 ", " Line 2 " };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
