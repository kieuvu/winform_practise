using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._05
{
    public partial class Form05 : Form
    {
        public Form05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            double n = Double.Parse(numericUpDown1.Value.ToString());

            if (radioButton1.Checked)
            {
                result = CalcType1(n);
            }
            else if (radioButton2.Checked)
            {
                result = CalcType2(n);
            }
            else if (radioButton3.Checked)
            {
                result = CalcType3(n);
            }
            else
            {
                result = CalcType4(n);
            }

            textBox1.Text = result.ToString();
        }

        private double CalcType1(double n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += 2 * i + 1;
            }
            return result;
        }

        private double CalcType2(double n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += i * i;
            }

            return result;
        }

        private double CalcType3(double n)
        {
            double result = 0.0;

            for (int i = 1; i <= n; i++)
            {
                result += 1.0 / i;
            }

            return result;
        }

        private double CalcType4(double n)
        {
            double result = 0.0;
            double flag = 1.0;

            for (int i = 1; i <= n; i++)
            {
                flag *= i;
                result += 1.0 / flag;
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
