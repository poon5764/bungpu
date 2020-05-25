using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox18.Text);
            int b = int.Parse(numericUpDown1.Text);
            int c = int.Parse(numericUpDown2.Text);
            int d = int.Parse(numericUpDown3.Text);
            int t = int.Parse(numericUpDown5.Text);
            int f = int.Parse(numericUpDown6.Text);
            int g = int.Parse(numericUpDown7.Text);
            int h = int.Parse(numericUpDown4.Text);
            int x = 0;
            int y;
            int z;
            int p;
            y = (a * 10) / 100;
            z = (b * 2) + (c * 2) + (d * 2) + (t * 2) + f + g + h;
            if(z > y)
            {
                x = y;
            }
            else if(z < y)
            {
                x = z;
            }
            textBox10.Text = x.ToString();
            p = a - x;
            textBox9.Text = p.ToString();
            int o = int.Parse(textBox9.Text);
            if (o > 5000000)
            {
                o = (o * 35 / 100);
            }
            else if (o > 2000000)
            {
                o = (o * 30 / 100);
            }
            else if (o > 1000000)
            {
                o = (o * 25 / 100);
            }
            else if (o > 750000)
            {
                o = (o * 20 / 100);
            }
            else if (o > 500000)
            {
                o = (o * 15 / 100);
            }
            else if (o > 300000)
            {
                o = (o * 10 / 100);
            }
            else if (o > 150000)
            {
                o = (o * 5 / 100);
            }
            else
            {
                o = (0);
            }

            textBox8.Text = o.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.textBox18.Text = textBox9.Text;
            f6.Show();
            this.Hide();
        }
    }
}
