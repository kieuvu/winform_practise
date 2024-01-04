using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp5;

namespace WinFormsApp1._26
{
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        private void Calculate(char operation)
        {
            PhanSo result;
            PhanSo ps1 = new(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            PhanSo ps2 = new(Int32.Parse(textBox4.Text), Int32.Parse(textBox3.Text));

            switch (operation)
            {
                case '+':
                    result = ps1 + ps2;
                    break;
                case '-':
                    result = ps1 - ps2;
                    break;
                case '*':
                    result = ps1 * ps2;
                    break;
                case '/':
                    result = ps1 / ps2;
                    break;
                default:
                    throw new Exception("Sai phép tính");
            }

            textBox6.Text = result.getTuSo().ToString();
            textBox5.Text = result.getMauSo().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
    }
}
