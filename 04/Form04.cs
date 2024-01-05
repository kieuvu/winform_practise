using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1._04
{
    public partial class Form04 : Form
    {
        public Form04()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void UpdateFontStyle()
        {
            FontStyle newStyle = FontStyle.Regular;

            if (checkBox1.Checked)
                newStyle |= FontStyle.Bold;

            if (checkBox2.Checked)
                newStyle |= FontStyle.Italic;

            if (checkBox3.Checked)
                newStyle |= FontStyle.Underline;

            label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, newStyle);
        }
    }
}
