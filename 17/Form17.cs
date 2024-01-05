using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1._17
{
    public partial class Form17 : Form
    {
        private int elapsedTime = 0;

        public Form17()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 30;
            progressBar1.Value = 0;

            Tuple<double, double> randomNumber = GenerateAB();
            textBox1.Text = randomNumber.Item1.ToString();
            textBox2.Text = randomNumber.Item2.ToString();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (elapsedTime >= 30)
            {
                MessageBox.Show("Hết giờ làm bài");
                return;
            }

            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double result = Double.Parse(textBox3.Text);

            double x = (-b) / a;

            if (result == x)
            {
                MessageBox.Show("Bạn đã làm đúng");
            }
            else
            {
                MessageBox.Show("Bạn đã trả lời sai");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;

            progressBar1.Value = elapsedTime;

            if (elapsedTime >= 30)
            {
                timer1.Stop();
                MessageBox.Show("Hết giờ làm bài");
            }
        }

        static Tuple<double, double> GenerateAB()
        {
            Random random = new();
            double a = random.Next(-10, 11);
            while (a == 0)
            {
                a = random.Next(-10, 11);
            }

            double b = random.Next(-100, 101);

            return Tuple.Create(a, b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
