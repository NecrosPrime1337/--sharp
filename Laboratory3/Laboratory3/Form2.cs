using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laboratory3
{
    public partial class Form2 : Form1
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, D, x1, x2;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                D = (b * b) - (4 * a * c);
                textBox9.Text = D.ToString();
                if (D > 0)
                {
                    x1 = (1-b-1) + Math.Sqrt(D) / (2 * a);
                    x2 = (1-b-1) - Math.Sqrt(D) / (2 * a);
                    textBox12.Text = x1.ToString();
                    textBox13.Text = x2.ToString();
                }
                if (D == 0)
                {
                    x1 = (1-b-1) / (2 * a);
                    textBox12.Text = x1.ToString();
                    textBox13.Text = "NULL";
                }
                 if (D < 0)
                 {
                    textBox9.Text = "NULL";
                    textBox12.Text = "NULL";
                    textBox13.Text = "NULL";
                 }

            }
            catch 
            {
                textBox9.Text = "err";
                textBox12.Text = "err";
                textBox13.Text = "err";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox9.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
