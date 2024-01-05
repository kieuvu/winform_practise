using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._07
{
    public partial class Form07 : Form
    {
        public Form07()
        {
            InitializeComponent();
        }

        private bool IsValidDateFormat(string input)
        {
            string dateFormat = "dd/MM/yyyy";

            if (DateTime.TryParseExact(input, dateFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider1.SetError(textBox2, "");

            errorProvider2.Clear();
            errorProvider2.SetError(textBox3, "");

            bool hasError = false;

            if (!IsValidDateFormat(textBox2.Text))
            {
                hasError = true;
                errorProvider1.SetError(textBox2, "Nhập ngày dd/mm/yyyy");
            }

            if (!int.TryParse(textBox3.Text, out _))
            {
                hasError = true;
                errorProvider2.SetError(textBox3, "Nhập số");
            }

            if (!hasError)
            {
                string name = textBox1.Text;
                string dob = textBox2.Text;
                string avg = textBox3.Text;

                MessageBox.Show($"Họ tên: {name}\nNgày sinh: {dob}\nĐiểm: {avg}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
