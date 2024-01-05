namespace ListBox_2
{
    partial class Form06
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_number = new TextBox();
            btn_update = new Button();
            list_item = new ListBox();
            btn_sum = new Button();
            btn_delete_first_last = new Button();
            btn_del_selected = new Button();
            btn_add_two = new Button();
            btn_pow = new Button();
            btn_show_even = new Button();
            button7 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // txt_number
            // 
            txt_number.Location = new Point(170, 41);
            txt_number.Name = "txt_number";
            txt_number.Size = new Size(301, 23);
            txt_number.TabIndex = 1;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(492, 41);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Thêm";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += this.btn_update_Click;
            // 
            // list_item
            // 
            list_item.FormattingEnabled = true;
            list_item.ItemHeight = 15;
            list_item.Location = new Point(31, 28);
            list_item.Name = "list_item";
            list_item.Size = new Size(264, 304);
            list_item.TabIndex = 3;
            // 
            // btn_sum
            // 
            btn_sum.Location = new Point(16, 37);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(194, 25);
            btn_sum.TabIndex = 4;
            btn_sum.Text = "Tổng của danh sách";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += this.btn_sum_Click;
            // 
            // btn_delete_first_last
            // 
            btn_delete_first_last.Location = new Point(16, 68);
            btn_delete_first_last.Name = "btn_delete_first_last";
            btn_delete_first_last.Size = new Size(194, 25);
            btn_delete_first_last.TabIndex = 4;
            btn_delete_first_last.Text = "Xóa phần tử đầu và cuối";
            btn_delete_first_last.UseVisualStyleBackColor = true;
            btn_delete_first_last.Click += this.btn_delete_first_last_Click;
            // 
            // btn_del_selected
            // 
            btn_del_selected.Location = new Point(16, 99);
            btn_del_selected.Name = "btn_del_selected";
            btn_del_selected.Size = new Size(194, 25);
            btn_del_selected.TabIndex = 4;
            btn_del_selected.Text = "Xóa phần tử đang chọn";
            btn_del_selected.UseVisualStyleBackColor = true;
            btn_del_selected.Click += this.btn_del_selected_Click;
            // 
            // btn_add_two
            // 
            btn_add_two.Location = new Point(16, 130);
            btn_add_two.Name = "btn_add_two";
            btn_add_two.Size = new Size(194, 25);
            btn_add_two.TabIndex = 4;
            btn_add_two.Text = "Tăng mỗi phần tử lên 2";
            btn_add_two.UseVisualStyleBackColor = true;
            btn_add_two.Click += this.btn_add_two_Click;
            // 
            // btn_pow
            // 
            btn_pow.Location = new Point(16, 161);
            btn_pow.Name = "btn_pow";
            btn_pow.Size = new Size(194, 25);
            btn_pow.TabIndex = 4;
            btn_pow.Text = "Bình phương các phần tử";
            btn_pow.UseVisualStyleBackColor = true;
            btn_pow.Click += this.btn_pow_Click;
            // 
            // btn_show_even
            // 
            btn_show_even.Location = new Point(16, 192);
            btn_show_even.Name = "btn_show_even";
            btn_show_even.Size = new Size(194, 25);
            btn_show_even.TabIndex = 4;
            btn_show_even.Text = "Chọn số chẵn";
            btn_show_even.UseVisualStyleBackColor = true;
            btn_show_even.Click += this.btn_show_even_Click;
            // 
            // button7
            // 
            button7.Location = new Point(16, 223);
            button7.Name = "button7";
            button7.Size = new Size(194, 25);
            button7.TabIndex = 4;
            button7.Text = "Chọn số lẻ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += this.button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(list_item);
            groupBox1.Location = new Point(64, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 355);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_sum);
            groupBox2.Controls.Add(btn_delete_first_last);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(btn_del_selected);
            groupBox2.Controls.Add(btn_show_even);
            groupBox2.Controls.Add(btn_add_two);
            groupBox2.Controls.Add(btn_pow);
            groupBox2.Location = new Point(391, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 355);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button1
            // 
            button1.Location = new Point(64, 480);
            button1.Name = "button1";
            button1.Size = new Size(563, 25);
            button1.TabIndex = 5;
            button1.Text = "Kết thúc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(701, 529);
            this.Controls.Add(button1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(btn_update);
            this.Controls.Add(txt_number);
            this.Controls.Add(label1);
            this.Name = "Form06";
            this.Text = "List";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_number;
        private Button btn_update;
        private ListBox list_item;
        private Button btn_sum;
        private Button btn_delete_first_last;
        private Button btn_del_selected;
        private Button btn_add_two;
        private Button btn_pow;
        private Button btn_show_even;
        private Button button7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
    }
}