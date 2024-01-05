using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._20
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nodeName = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(nodeName))
            {
                treeView1.Nodes.Add(nodeName);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nodeName = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(nodeName) && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(nodeName);
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Expand();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Collapse();
            }
        }
    }
}
