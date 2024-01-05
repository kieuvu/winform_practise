namespace WinFormsApp8
{
    public partial class Form02 : Form
    {
        public Form02()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Co muon dong ung dung", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_qtt.Text == "")
            {
                MessageBox.Show("Chua Nhap So Luong");
                txt_qtt.Focus();
            }
            else if (txt_prc.Text == "")
            {
                MessageBox.Show("Chua Nhap Gia");
                txt_prc.Focus();
            }
            else
            {
                int qtt = Int32.Parse(txt_qtt.Text);
                int prc = Int32.Parse(txt_prc.Text);

                if (qtt <= 0)
                {
                    MessageBox.Show("So luong phai > 0");
                    txt_qtt.SelectAll();
                    txt_qtt.Focus();
                }
                else if (prc <= 0)
                {
                    MessageBox.Show("Gia phai > 0");
                    txt_prc.SelectAll();
                    txt_prc.Focus();
                }
                else
                {
                    txt_result.Text = (qtt * prc).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_prc.Text = string.Empty;
            txt_qtt.Text = string.Empty;
            txt_result.Text = string.Empty;
            textBox1.Text = string.Empty;

            textBox1.Focus();
        }

        private void Form02_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_qtt.Text == "")
                {
                    MessageBox.Show("Chua Nhap So Luong");
                    txt_qtt.Focus();
                }
                else if (txt_prc.Text == "")
                {
                    MessageBox.Show("Chua Nhap Gia");
                    txt_prc.Focus();
                }
                else
                {
                    int qtt = Int32.Parse(txt_qtt.Text);
                    int prc = Int32.Parse(txt_prc.Text);

                    if (qtt <= 0)
                    {
                        MessageBox.Show("So luong phai > 0");
                        txt_qtt.SelectAll();
                        txt_qtt.Focus();
                    }
                    else if (prc <= 0)
                    {
                        MessageBox.Show("Gia phai > 0");
                        txt_prc.SelectAll();
                        txt_prc.Focus();
                    }
                    else
                    {
                        txt_result.Text = (qtt * prc).ToString();
                    }
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

        }
    }
}