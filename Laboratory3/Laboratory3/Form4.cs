using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double a, b, c, v;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                v = a * b * c;
                
                if (a == b & b == c & c == a) 
                {
                    textBox8.Text = "фигура является кубом!";
                    textBox10.Text = v.ToString();
                }
                else
                {
                    textBox8.Text = "фигура не является кубом!";
                    textBox10.Text = v.ToString();
                }
            }
            catch 
            { 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox8.Clear();
            textBox10.Clear();
        }
    }
}
