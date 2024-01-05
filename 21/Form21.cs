using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._21
{
    public partial class Form21 : Form
    {
        private List<string> imagePaths;

        public Form21()
        {
            InitializeComponent();
            InitializeImagePaths();

            flowLayoutPanel1.HorizontalScroll.Visible = true;
            flowLayoutPanel1.VerticalScroll.Visible = true;

            foreach (string imagePath in imagePaths)
            {
                PictureBox pictureBox = new PictureBox
                {
                    ImageLocation = imagePath,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 100,
                    Height = 100,
                    Cursor = Cursors.Hand
                };

                pictureBox.Click += PictureBox_Click;

                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        private void InitializeImagePaths()
        {
            imagePaths = new List<string>
            {
                @"D:\Kieu Vu\Download\Image\net1.jpg",
                @"D:\Kieu Vu\Download\Image\net2.png",
                @"D:\Kieu Vu\Download\Image\net3.jpg",
                @"D:\Kieu Vu\Download\Image\net3.jpg",
                @"D:\Kieu Vu\Download\Image\net3.jpg",
                @"D:\Kieu Vu\Download\Image\net3.jpg",
            };
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox selectedPictureBox = (PictureBox)sender;
            pictureBox1.ImageLocation = selectedPictureBox.ImageLocation;
        }
    }
}
