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

namespace WinFormsApp1._23
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url)) return;

            listBox1.Items.Add(url);
            textBox1.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                textBox1.Text = selectedItem;
                webView21.Source = new Uri(selectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url)) return;
            if (listBox1.SelectedIndex == -1) return;

            listBox1.Items[listBox1.SelectedIndex] = url;
            webView21.Source = new Uri(url);
            textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.SelectedIndex = -1;
                webView21.CoreWebView2.Navigate("about:blank");
            }
        }
    }
}
