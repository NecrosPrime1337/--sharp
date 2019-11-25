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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, s;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                
                s = a*b;
                

                if (a == b )
                {
                    textBox8.Text = "это квадрат";
                    textBox10.Text = s.ToString();
                }
               else
                {
                    textBox8.Text = "не квадрат";
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
            textBox8.Clear();
            textBox10.Clear();
        }
    }
    }

