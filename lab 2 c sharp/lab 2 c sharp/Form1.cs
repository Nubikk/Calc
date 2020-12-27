using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_c_sharp
{
    
    public partial class Form1 : Form
    {private void calculate()
    {
        switch (op)
        {
            case 1:
                b = a + float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
            case 2:
                b = a - float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
            case 3:
                b = a * float.Parse(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
            case 4:

                if (float.Parse(textBox1.Text) == 0)
                { textBox1.Text = "Делить на 0 нельзя!"; }
                else
                {
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                }
                break;
            default:
                break;
        }

    }
        float a,b;
        int op;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;

        }

    

        private void number_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void multiplay_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 1;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 1;
            label1.Text = a.ToString() + "-";
            znak = false;
        }

        private void divided_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 1;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void left_skob_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        private void right_skob_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void znach_znak_Click(object sender, EventArgs e) /* Если znak=true, мы меняем знак операнда в
                                                                   * textBox1, а если false, то 
                                                                   * знак числа удаляется из текстового поля.
            */{
            if(znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
