using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._27
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string dob = textBox2.Text;
            string gender = radioButton1.Checked ? "Anh" : "Chị";

            DateTime date = DateTime.Parse(dob);
            string dayOfWeek = GetDayOfWeek(date.DayOfWeek);
            int age = CalculateAge(date);

            MessageBox.Show($"{name}, {gender} {age} tuổi, sinh vào ngày {dayOfWeek} ");
        }

        private static string GetDayOfWeek(DayOfWeek day)
        {
            Dictionary<DayOfWeek, string> days = new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Sunday, "Chủ Nhật" },
                { DayOfWeek.Monday, "Thứ Hai" },
                { DayOfWeek.Tuesday, "Thứ Ba" },
                { DayOfWeek.Wednesday, "Thứ Tư" },
                { DayOfWeek.Thursday, "Thứ Năm" },
                { DayOfWeek.Friday, "Thứ Sáu" },
                { DayOfWeek.Saturday, "Thứ Bảy" }
            };

            return days[day];
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;

            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
