using System;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13;
            value1 = int.Parse(textBox1.Text);
            value2 = int.Parse(textBox2.Text);
            value3 = int.Parse(textBox3.Text);
            value4 = int.Parse(textBox4.Text);
            value5 = int.Parse(textBox5.Text);
            value6 = int.Parse(textBox6.Text);
            value7 = int.Parse(textBox7.Text);
            value8 = int.Parse(textBox8.Text);
            value9 = int.Parse(textBox9.Text);
            //value10 = int.Parse(textBox10.Text);
            //value11 = int.Parse(textBox11.Text);
            //value12 = int.Parse(textBox12.Text);
            //value13 = int.Parse(textBox13.Text);


            double a = (1500d / value1) + (40000d / ((value4 * 1000d) /  60d)) + (10000d / ((value7 * 1000d) / 60d));
            double b = (1500d / value2) + (40000d / ((value5 * 1000d) / 60d)) + (10000d / ((value8 * 1000d) / 60d));
            double c = (1500d / value3) + (40000d / ((value6 * 1000d) / 60d)) + (10000d / ((value9 * 1000d) / 60d));

            double[] max = { a, b, c };

            double max228 = max.Max();

            if (max228 == a)
            {
                textBox13.Text = "Андрей";
            }
            else if (max228 == b)
            {
                textBox13.Text = "Егор";
            }
            else if (max228 == c)
            {
                textBox13.Text = "Михаил";
            }

            textBox10.Text = a.ToString();
            textBox11.Text = b.ToString();
            textBox12.Text = c.ToString();

            



        }
    }
}