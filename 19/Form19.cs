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
using System.Xml.Linq;

namespace WinFormsApp1._19
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeListView();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Add("Details");
            comboBox1.Items.Add("LargeIcon");
            comboBox1.Items.Add("SmallIcon");
            comboBox1.Items.Add("List");
            comboBox1.Items.Add("Tile");

            comboBox1.SelectedIndex = 0;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text;
            string firstName = textBox2.Text;
            string phone = textBox3.Text;

            ListViewItem item = new(lastName);

            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(@"D:\Kieu Vu\Download\Image\net1.jpg"));
                
            listView1.LargeImageList = imageList;
            listView1.SmallImageList = imageList;
            listView1.GroupImageList = imageList;
            listView1.StateImageList = imageList;

            item.SubItems.Add(firstName);
            item.SubItems.Add(phone);
            item.ImageIndex = 0;

            listView1.Items.Add(item);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDisplayType = comboBox1.SelectedItem.ToString();

            switch (selectedDisplayType)
            {
                case "Details":
                    listView1.View = View.Details;
                    break;
                case "LargeIcon":
                    listView1.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    listView1.View = View.SmallIcon;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    break;
                default:
                    break;
            }
        }
    }
}
