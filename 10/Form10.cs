namespace WinFormsApp3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0) return;

            listBox2.Items.Add(listBox1.SelectedItems[0].ToString());
            listBox1.Items.Remove(listBox1.SelectedItems[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count <= 0) return;

            listBox1.Items.Add(listBox2.SelectedItems[0].ToString());
            listBox2.Items.Remove(listBox2.SelectedItems[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "";

            foreach (object item in listBox2.Items)
            {
                message += item.ToString() + ", ";
            }

            MessageBox.Show(message);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}