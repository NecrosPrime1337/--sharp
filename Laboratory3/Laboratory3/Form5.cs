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
    public partial class Form5 : Form
    {
        public Form5()
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

                if (a + b > c & b + c > a & c + a > b)
                {
                    textBox8.Text = "фигура может быть треугольником!";
                    textBox10.Text = s.ToString();
                }
                else
                {
                    textBox8.Text = "фигура не может быть треугольником!";
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
