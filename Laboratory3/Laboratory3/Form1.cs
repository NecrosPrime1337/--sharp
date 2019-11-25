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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void вариант3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void вариант4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void вариант5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            
            form2.Show();
           
        }

        private void вариант6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            form8.Show();
        }

        private void вариант7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            form9.Show();
        }

        private void вариант8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();

            form10.Show();
        }

        private void вариант16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form16 = new Form11();

            form16.Show();
        }
    }
}
