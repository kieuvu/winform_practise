namespace ListBox_2
{
    public partial class Form06 : Form
    {
        public Form06()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_number.Text.Trim().Length == 0) return;

            int num = Int32.Parse(txt_number.Text);

            list_item.Items.Add(num);

            txt_number.Text = "";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (int item in list_item.Items)
            {
                sum += item;
            }

            MessageBox.Show(sum.ToString(), "Tổng");
        }

        private void btn_delete_first_last_Click(object sender, EventArgs e)
        {
            if (list_item.Items.Count > 0) list_item.Items.RemoveAt(0);
            if (list_item.Items.Count > 1) list_item.Items.RemoveAt(list_item.Items.Count - 1);
        }

        private void btn_del_selected_Click(object sender, EventArgs e)
        {
            if (list_item.SelectedItems.Count <= 0) return;

            list_item.Items.Remove(list_item.SelectedItems[0]);
        }

        private void btn_add_two_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_item.Items.Count; i++)
            {
                int currentValue = Int32.Parse(list_item.Items[i].ToString());

                int newValue = currentValue + 2;

                list_item.Items[i] = newValue;
            }
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_item.Items.Count; i++)
            {
                int currentValue = Int32.Parse(list_item.Items[i].ToString());

                int newValue = currentValue * currentValue;

                list_item.Items[i] = newValue;
            }
        }

        private void btn_show_even_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (int item in list_item.Items)
            {
                if (item % 2 == 0)
                {
                    result += item.ToString();
                    result += ", ";
                }
            }
            MessageBox.Show(result, "Số chẵn");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (int item in list_item.Items)
            {
                if (item % 2 != 0)
                {
                    result += item.ToString();
                    result += ", ";
                }
            }
            MessageBox.Show(result, "Số lẻ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}