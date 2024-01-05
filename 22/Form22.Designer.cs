namespace WinFormsApp1._22
{
    partial class Form22
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            listView2 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(772, 388);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(764, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " Quản lý nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(6, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(752, 193);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += this.listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ tên";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Chức vụ";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Lương cơ bản";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hệ số lương";
            columnHeader4.Width = 180;
            // 
            // button3
            // 
            button3.Location = new Point(479, 98);
            button3.Name = "button3";
            button3.Size = new Size(164, 43);
            button3.TabIndex = 10;
            button3.Text = "Xóa nhân viên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(307, 98);
            button2.Name = "button2";
            button2.Size = new Size(164, 43);
            button2.TabIndex = 9;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(133, 98);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 8;
            button1.Text = "Thêm nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(470, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(450, 17);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 20);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 3;
            label5.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 62);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "Hệ số lương";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 62);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 1;
            label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 20);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(764, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý giáo viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(6, 156);
            listView2.Name = "listView2";
            listView2.Size = new Size(752, 193);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += this.listView2_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Họ tên";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Học vị";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tiền dạy 1 tiết";
            columnHeader7.Width = 180;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Số tiết dạy";
            columnHeader8.Width = 180;
            // 
            // button5
            // 
            button5.Location = new Point(479, 93);
            button5.Name = "button5";
            button5.Size = new Size(164, 43);
            button5.TabIndex = 22;
            button5.Text = "Xóa giáo viên";
            button5.UseVisualStyleBackColor = true;
            button5.Click += this.button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(307, 93);
            button6.Name = "button6";
            button6.Size = new Size(164, 43);
            button6.TabIndex = 21;
            button6.Text = "Cập nhật";
            button6.UseVisualStyleBackColor = true;
            button6.Click += this.button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(133, 93);
            button7.Name = "button7";
            button7.Size = new Size(164, 43);
            button7.TabIndex = 20;
            button7.Text = "Thêm giáo viên";
            button7.UseVisualStyleBackColor = true;
            button7.Click += this.button7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(470, 54);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(450, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(243, 23);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 54);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(206, 23);
            textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(96, 12);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(243, 23);
            textBox8.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 15);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "Học vị";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 57);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 14;
            label7.Text = "Số tiết dạy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 57);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 13;
            label8.Text = "Tiền dạy 1 tiết";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 15);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 12;
            label9.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(292, 19);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 1;
            label1.Text = "Quản lý nhân sự";
            // 
            // button4
            // 
            button4.Location = new Point(705, 467);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(796, 502);
            this.Controls.Add(button4);
            this.Controls.Add(label1);
            this.Controls.Add(tabControl1);
            this.Name = "Form22";
            this.Text = "Form22";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Button button4;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}