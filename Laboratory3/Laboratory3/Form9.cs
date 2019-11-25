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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double s, n, c, h;
                s = double.Parse(textBox1.Text);
                n = double.Parse(textBox2.Text);
                c = double.Parse(textBox7.Text);
                
                if (c*n <= s)
                {
                    textBox8.Text = "хватает";
                }
                else
                {
                    textBox8.Text = "не хватает";
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
            textBox7.Clear();
            textBox8.Clear();
        }
    }
}
