using System;
using System.Linq;

namespace Popovap
{
    public partial class Form1 : Form
    {

        int Max(int x1, int x2, int x3)
        {
            int max = int.MinValue; //������ ���������� ��� ��������� � ��������� ��������� MinValue
            if (x1 > max) max = x1; //�������� �� ������ ��������
            if (x2 > max) max = x2; //�������� �� ���� ��������
            if (x3 > max) max = x3; //�������� �� ���� ��������
            return max; //���������� ���������
        }

        void MaxAndName(int x1, int x2, int x3,
        string name1, string name2, string name3,
        out int max, out string name_max)
        {
            max = int.MinValue; //������ ���������� ��� ��������� � ��������� ��������� MinValue
            name_max = "";
            if (x1 > max)
            {
                max = x1; name_max = name1; //�������� �� ������ �������� � ���
            }
            if (x2 > max)
            {

                max = x2; name_max = name2; //�������� �� ���� �������� � ���
            }
            if (x3 > max)
            {
                max = x3; name_max = name3; //�������� �� ���� �������� � ���
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


            //������� ������. ���� ��������
            int value1, value2, value3;
            string name1, name2, name3;
            value1 = int.Parse(textBox4.Text);
            value2 = int.Parse(textBox5.Text);
            value3 = int.Parse(textBox6.Text);
            name1 = textBox1.Text;
            name2 = textBox2.Text;
            name3 = textBox3.Text;
            //����������
            int max_value;
            string max_name;
            //����������
            MaxAndName(value1, value2, value3,
            name1, name2, name3,
            out max_value, out max_name);
            //����� �����������
            textBox7.Text = max_name + "������(�) ������" +
            max_value + " ������ ����!";


        }


    }
}