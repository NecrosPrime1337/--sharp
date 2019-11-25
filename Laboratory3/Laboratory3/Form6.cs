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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, s, p;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                if (a == c & b == a & c == b)
                {
                    textBox8.Text = "равносторонний треугольник";
                    textBox10.Text = s.ToString();
                }
                if (a == c & b == a | c == b & b == a | b==a & a==b)
                {
                    textBox8.Text = "равнобедренный треугольник" ;
                    textBox10.Text = s.ToString();
                }
                else
                {
                    textBox8.Text = "не равнобедренный треугольник";
                    textBox10.Text = s.ToString();
                }
            }
            catch
            {
                textBox8.Text = "ошибка ввода";
                textBox10.Text = "ошибка";

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
