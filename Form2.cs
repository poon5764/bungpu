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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox9.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox9.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                groupBox2.Enabled = false;
                groupBox7.Enabled = false;
                numericUpDown3.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox2.Enabled = true;
                groupBox7.Enabled = true;
                numericUpDown3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox7.Text);
            int b = int.Parse(numericUpDown3.Text); 
            int c = int.Parse(numericUpDown1.Text);
            int d = int.Parse(numericUpDown2.Text); 
            int t = int.Parse(numericUpDown4.Text); 
            int f = int.Parse(numericUpDown5.Text);
            int x = 0;
            int y = 0;
            int z = 0;
            int q = 0;
            int u = 0;
            int r = 0;
            int p;
            int k;
            if (radioButton14.Checked)
            {
                x = 60000;
            }
            if (radioButton6.Checked)
            {
                y = 30000;
            }
            if (radioButton9.Checked)
            {
                z = 30000;
            }
            if (radioButton10.Checked)
            {
                q = 30000;
            }
            if (radioButton13.Checked)
            {
                u = 30000;
            }
            p = b + c + (d * 30000) + (t * 60000) + (f * 60000) + x + y + z + q + u;
            textBox4.Text = p.ToString();
            k = a - p;
            textBox5.Text = k.ToString();
            int o = int.Parse(textBox5.Text);
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

            textBox6.Text = o.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.textBox4.Text = textBox5.Text;
            f3.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
