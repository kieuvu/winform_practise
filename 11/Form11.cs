namespace WinFormsApp3
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            int num_a = Int32.Parse(txt_num_a.Text);
            int num_b = Int32.Parse(txt_num_b.Text);

            int gcd = GCD(num_a, num_b);
            int lcm = LCM(num_a, num_b);

            txt_ucnl_result.Text = gcd.ToString();
            txt_bcnn_result.Text = lcm.ToString();
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_num_a.Text = string.Empty;
            txt_num_b.Text = string.Empty;
            txt_ucnl_result.Text = string.Empty;
            txt_bcnn_result.Text = string.Empty;
        }
    }
}