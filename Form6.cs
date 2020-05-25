using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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
            int t = int.Parse(numericUpDown4.Text);
            int f = int.Parse(numericUpDown5.Text);
            int g = int.Parse(numericUpDown6.Text);
            int h = int.Parse(numericUpDown7.Text);
            int i = int.Parse(numericUpDown8.Text);
            int j = int.Parse(numericUpDown9.Text);
            int k = int.Parse(numericUpDown10.Text);
            int x = 0;
            int y;
            int z;
            if(f + g > 20000)
            {
                x = 20000;
            }    
            else if(f + g < 20000)
            {
                x = f + g;
            }
            y = b + c + d + t + h + i + j + k + x;
            textBox10.Text = y.ToString();
            z = a - y;
            textBox9.Text = z.ToString();
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
            Form7 f7 = new Form7();
            f7.textBox1.Text = textBox9.Text;
            f7.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
