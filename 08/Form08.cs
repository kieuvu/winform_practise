using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._08
{
    public partial class Form08 : Form
    {
        public Form08()
        {
            InitializeComponent();

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 255;
            hScrollBar1.Value = 0;
            hScrollBar2.Minimum = 0;
            hScrollBar2.Maximum = 255;
            hScrollBar2.Value = 0;
            hScrollBar3.Minimum = 0;
            hScrollBar3.Maximum = 255;
            hScrollBar3.Value = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = e.NewValue.ToString(); ;
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = e.NewValue.ToString();
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = e.NewValue.ToString(); ;
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
    }
}
