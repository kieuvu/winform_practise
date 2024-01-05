using System.Linq.Expressions;

namespace WinFormsApp7
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private string inputBox = "";

        private void addToInputBox(string key)
        {
            inputBox += key;
            txt_input_box.Text = inputBox;
        }

        private void addToInputBox(int key)
        {
            inputBox += key.ToString();
            txt_input_box.Text = inputBox;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            addToInputBox(0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            addToInputBox(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            addToInputBox(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            addToInputBox(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            addToInputBox(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            addToInputBox(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            addToInputBox(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            addToInputBox(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            addToInputBox(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            addToInputBox(9);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addToInputBox("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addToInputBox("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addToInputBox("*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addToInputBox("/");
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            addToInputBox(".");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputBox = "";
            txt_input_box.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Evaluate(inputBox);
                inputBox = result.ToString();
                txt_input_box.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi biểu thức");
            }
        }

        public double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}