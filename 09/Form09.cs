using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp1._09
{
    public partial class Form09 : Form
    {
        private PictureBox circlePictureBox;
        private int circleRadius = 50;
        private int circleSpeed = 5;
        private int directionX = 1;
        private int directionY = 1;

        public Form09()
        {
            InitializeComponent();
            InitializeForm();
            InitializeTimer();
        }

        private void InitializeForm()
        {
            this.Size = new Size(400, 400);

            circlePictureBox = new CirlePictureBox();
            circlePictureBox.Size = new Size(circleRadius * 2, circleRadius * 2);
            circlePictureBox.BackColor = Color.Red;

            circlePictureBox.Location = new Point(0, 0);

            this.Controls.Add(circlePictureBox);
        }

        private void InitializeTimer()
        {
            timer1.Interval = 30;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newX = circlePictureBox.Location.X + directionX * circleSpeed;
            int newY = circlePictureBox.Location.Y + directionY * circleSpeed;

            if (newX < 0 || newX + circleRadius * 2 > this.ClientSize.Width)
            {
                directionX = -directionX;
            }

            if (newY < 0 || newY + circleRadius * 2 > this.ClientSize.Height)
            {
                directionY = -directionY;
            }

            circlePictureBox.Location = new Point(newX, newY);
        }
    }
}
