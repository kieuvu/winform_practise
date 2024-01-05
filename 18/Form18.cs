using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._18
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string quantity = textBox2.Text;

            ListViewItem item = new (name);
            item.SubItems.Add(quantity);

            listView1.Items.Add(item);

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
