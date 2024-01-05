using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._14
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            listBox1.Items.Add(name);
            textBox1.Clear();
            this.UpdateCombobox();
        }

        private void UpdateCombobox()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(i + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int pos = Int32.Parse(comboBox1.Text) - 1;

            listBox1.Items.Insert(pos, name);
            textBox2.Clear();
            this.UpdateCombobox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            bool flag = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == name)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("Có sản phẩm trong danh sách");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm trong danh sách");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
