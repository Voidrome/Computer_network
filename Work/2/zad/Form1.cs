using System;
using System.Linq;

namespace Popovap
{
    public partial class Form1 : Form
    {

        int Max(int x1, int x2, int x3)
        {
            int max = int.MinValue; //вводим переменную для максимума с начальным значением MinValue
            if (x1 > max) max = x1; //максимум из одного значения
            if (x2 > max) max = x2; //максимум из двух значений
            if (x3 > max) max = x3; //максимум из трех значения
            return max; //возвращаем результат
        }

        void MaxAndName(int x1, int x2, int x3,
        string name1, string name2, string name3,
        out int max, out string name_max)
        {
            max = int.MinValue; //вводим переменную для максимума с начальным значением MinValue
            name_max = "";
            if (x1 > max)
            {
                max = x1; name_max = name1; //максимум из одного значения и имя
            }
            if (x2 > max)
            {

                max = x2; name_max = name2; //максимум из двух значений и имя
            }
            if (x3 > max)
            {
                max = x3; name_max = name3; //максимум из трех значений и имя
            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int value1, value2, value3;
            value1 = int.Parse(textBox4.Text);
            value2 = int.Parse(textBox5.Text);
            value3 = int.Parse(textBox6.Text);
            int sum = (value1 + value2 + value3);
            textBox7.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //входные данные. Ввод значений
            int value1, value2, value3;
            string name1, name2, name3;
            value1 = int.Parse(textBox4.Text);
            value2 = int.Parse(textBox5.Text);
            value3 = int.Parse(textBox6.Text);
            name1 = textBox1.Text;
            name2 = textBox2.Text;
            name3 = textBox3.Text;
            //результаты
            int max_value;
            string max_name;
            //вычисления
            MaxAndName(value1, value2, value3,
            name1, name2, name3,
            out max_value, out max_name);
            //вывод результатов
            textBox7.Text = max_name + "собрал(а) грибов" +
            max_value + " Больше всех!";


        }


    }
}