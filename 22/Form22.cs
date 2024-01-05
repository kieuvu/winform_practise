using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._22
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string salary = textBox2.Text;
            string position = textBox4.Text;
            string salaryCoefficient = textBox3.Text;

            ListViewItem item = new(name);

            item.SubItems.Add(salary);
            item.SubItems.Add(position);
            item.SubItems.Add(salaryCoefficient);

            listView1.Items.Add(item);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                textBox1.Text = selectedItem.SubItems[0].Text;
                textBox2.Text = selectedItem.SubItems[1].Text;
                textBox4.Text = selectedItem.SubItems[2].Text;
                textBox3.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string name = textBox1.Text;
                string salary = textBox2.Text;
                string position = textBox4.Text;
                string salaryCoefficient = textBox3.Text;

                ListViewItem selectedItem = listView1.SelectedItems[0];

                selectedItem.SubItems[0].Text = name;
                selectedItem.SubItems[1].Text = salary;
                selectedItem.SubItems[2].Text = position;
                selectedItem.SubItems[3].Text = salaryCoefficient;

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                listView1.Items.Remove(selectedItem);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text;
            string salary = textBox7.Text;
            string level = textBox6.Text;
            string workingHour = textBox5.Text;

            ListViewItem item = new(name);

            item.SubItems.Add(salary);
            item.SubItems.Add(level);
            item.SubItems.Add(workingHour);

            listView2.Items.Add(item);

            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                string name = textBox8.Text;
                string salary = textBox7.Text;
                string level = textBox6.Text;
                string workingHour = textBox5.Text;

                ListViewItem selectedItem = listView2.SelectedItems[0];

                selectedItem.SubItems[0].Text = name;
                selectedItem.SubItems[1].Text = salary;
                selectedItem.SubItems[2].Text = level;
                selectedItem.SubItems[3].Text = workingHour;

                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox8.Text = string.Empty;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                listView2.Items.Remove(selectedItem);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];

                textBox8.Text = selectedItem.SubItems[0].Text;
                textBox7.Text = selectedItem.SubItems[1].Text;
                textBox6.Text = selectedItem.SubItems[2].Text;
                textBox5.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
