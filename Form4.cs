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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown2.Text);
            int b;
            b = (a * 20) / 100;
            textBox4.Text = b.ToString();

            int x = int.Parse(textBox4.Text);
            int y;
            y = (x * 4) / 100;
            textBox8.Text = y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown5.Text);
            int b = 0;
            if (b <= 5000000)
            {
                b = 200000;
                numericUpDown6.Text = b.ToString(); 
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox18.Text);
            int b = int.Parse(numericUpDown1.Text);
            int x;
            int y;
            if (radioButton1.Checked)
            {
                int g = int.Parse(textBox8.Text);
                x = b + g;
                textBox7.Text = x.ToString();
            }
            if (radioButton2.Checked)
            {
                int p = int.Parse(numericUpDown6.Text);
                x = b + p;
                textBox7.Text = x.ToString();
            }
            int t = int.Parse(textBox7.Text);
            y = a - t;
            textBox6.Text = t.ToString();
            int o = int.Parse(textBox6.Text);
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

            textBox5.Text = o.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.textBox18.Text = textBox6.Text;
            f5.Show();
            this.Hide();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
