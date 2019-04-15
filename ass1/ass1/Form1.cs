using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hexa.Checked == true)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text.ToString(), 16), 2);
                
               
            }
            else if (other.Checked == true)
            {

                int number = int.Parse(textBox1.Text);
                string B = Convert.ToString(number, 2);
                textBox2.Text = B;
            }

            else if (radioButton2.Checked == true)
            {
                int number = int.Parse(textBox1.Text);
                string B = Convert.ToString(Convert.ToInt32(textBox1.Text),2);
                
                
                textBox2.Text = B;

            }

            else if (radioButton1.Checked == true)
            {
                textBox2.Text = textBox1.Text;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Hexa.Checked == true)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8);

            }

            else if (other.Checked == true)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8));

            }
            else if (radioButton1.Checked == true)
            {
                int number = int.Parse(textBox1.Text);
                string B = Convert.ToString(number, 8);
                textBox2.Text = B;

            }

            else if (radioButton2.Checked == true)
            {
                textBox2.Text = textBox1.Text;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Hexa.Checked == true)
            {
                textBox2.Text = textBox1.Text;

            }
            else if (radioButton1.Checked == true)
            {
                int number = int.Parse(textBox1.Text);
                string B = Convert.ToString(number, 16);
                textBox2.Text = B;

            }

            else if (other.Checked == true)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16));
            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt16(textBox1.Text, 16));

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Hexa.Checked == true)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16));
            }
            else if (other.Checked == true)
            {
                textBox2.Text = textBox1.Text;

            }
            else if (radioButton1.Checked == true)
            {
               textBox2.Text= Convert.ToString(Convert.ToInt32(textBox1.Text, 2));

            }
            else if (radioButton2.Checked == true)
            {
                if (int.Parse(textBox1.Text) <= 8)
                {
                    textBox2.Text = textBox1.Text;
                }

                else
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8));
                }
            }



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hexa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
