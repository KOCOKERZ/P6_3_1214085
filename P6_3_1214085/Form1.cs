using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_1214085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            else
            {
            
                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul!");
                }
                else
                {
                    epWrong.SetError(textBox1, "Inputan Hanya Boleh Huruf!");
                    epWarning.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "");
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                epWarning.SetError(textBox2, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");
            }
            else
            {
                if ((textBox2.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textBox2, "Betul!");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                }
                else
                {
                    epCorrect.SetError(textBox2, "");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                epWarning.SetError(textBox3, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }
            else
            {
                if (Regex.IsMatch(textBox3.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "");
                    epCorrect.SetError(textBox3, "Betul!");
                }
                else
                {
                    epWrong.SetError(textBox3, "Format email salah!\nContoh : a@b.c");
                    epWarning.SetError(textBox3, "");
                    epCorrect.SetError(textBox3, "");
                }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                epWarning.SetError(textBox5, "Text box tidak boleh kosong");
                epWrong.SetError(textBox5, "");
                epCorrect.SetError(textBox5, "");

            }
            else
            {
                if ((textBox5.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox5, "");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "Betul");
                }

                else
                {
                    epWarning.SetError(textBox5, "");
                    epWrong.SetError(textBox5, "Inputan hanya bole satu");
                    epCorrect.SetError(textBox5, "");
                }
                if (textBox6.Text == "")
                {
                    epWarning.SetError(textBox5, "Inputan hanya bole satu");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "");
                }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(textBox5.Text);
            int Angka2 = int.Parse(textBox6.Text);

            if (textBox5.Text == "")
            {
                epWarning.SetError(textBox6, "Text obx tiadk boleh kosong");
                epWrong.SetError(textBox6, "");
                epCorrect.SetError(textBox6, "");

            }
            else
            {
                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox6, "");
                    epWrong.SetError(textBox6, "");
                    epCorrect.SetError(textBox6, "Betul");
                }

                else
                {
                    epWarning.SetError(textBox6, "");
                    epWrong.SetError(textBox6, "Inputan hanya bole satu");
                    epCorrect.SetError(textBox6, "");
                }
                if (Angka1 > Angka2)
                {
                    epWarning.SetError(textBox5, "");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "Betul");

                    epWarning.SetError(textBox6, "");
                    epWrong.SetError(textBox6, "");
                    epCorrect.SetError(textBox6, "benar");
                }
                else
                {

                    epWarning.SetError(textBox5, "wrong");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "");

                    epWarning.SetError(textBox6, "wrong");
                    epWrong.SetError(textBox6, "");
                    epCorrect.SetError(textBox6, "");
                }
            }
        }
    }
}
