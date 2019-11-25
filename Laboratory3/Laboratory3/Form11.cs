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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1CSale, v2CSale, v1CBuy, v2CBuy, k1, k2, v1saled, v2saled , v1buy, v2buy;
            try
            {
                v1CSale = double.Parse(textBox1.Text);
                v2CSale = double.Parse(textBox2.Text);
                v1CBuy = double.Parse(textBox12.Text);
                v2CBuy = double.Parse(textBox10.Text);
                v1saled = double.Parse(textBox7.Text);
                v2saled = double.Parse(textBox4.Text);
                v1buy = double.Parse(textBox18.Text);
                v2buy = double.Parse(textBox16.Text);
                k1 = v1CSale * v1saled - v1CBuy * v1buy;
                k2 = v2CSale * v2saled - v2CBuy * v2buy;
                if (k1 > k2)
                {
                    textBox8.Text = "прибыль от первой валюты больше, чем от второй";
                    textBox20.Text = k1.ToString();
                    textBox22.Text = k2.ToString();
                }
                if (k1 == k2)
                {
                    textBox8.Text = "прибыль равна";
                    textBox20.Text = k1.ToString();
                    textBox22.Text = k2.ToString();
                }
                if (k1 < k2)
                {
                    textBox8.Text = "прибыль от второй валюты больше, чем от первой";
                    textBox20.Text = k1.ToString();
                    textBox22.Text = k2.ToString();
                }
            
            
            }
            catch
            {
                textBox8.Text = "Ошибка ввода";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
