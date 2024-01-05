namespace Listbox
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string input = txt_input.Text;
            list_item.Items.Add(input);
            txt_input.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_item.SelectedItems.Count <= 0) return;

            list_item.Items.Remove(list_item.SelectedItems[0]);
        }
    }
}