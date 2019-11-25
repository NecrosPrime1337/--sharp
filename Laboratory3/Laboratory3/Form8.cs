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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, r;
                a = double.Parse(textBox1.Text);
                r = double.Parse(textBox2.Text);
                double  d = r  * 2;
                if (d <= a)
                {
                    textBox8.Text = "данную заготовку можно вырезать";
                }
                else 
                {
                    textBox8.Text = "заготовку не получится вырезать";
                }
            }
            catch
            {
                textBox8.Text = "ошибка ввода";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox8.Clear();
        }
    }
}
