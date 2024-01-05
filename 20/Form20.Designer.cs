namespace WinFormsApp1._20
{
    partial class Form20
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
            treeView1 = new TreeView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(398, 448);
            treeView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Tiêu đề node";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(438, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(438, 91);
            button1.Name = "button1";
            button1.Size = new Size(277, 36);
            button1.TabIndex = 3;
            button1.Text = "Thêm node gốc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(438, 133);
            button2.Name = "button2";
            button2.Size = new Size(277, 36);
            button2.TabIndex = 4;
            button2.Text = "Thêm node con tại vị trí đã chọn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(438, 175);
            button3.Name = "button3";
            button3.Size = new Size(277, 36);
            button3.TabIndex = 5;
            button3.Text = "Xóa tất cả các node";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(438, 217);
            button4.Name = "button4";
            button4.Size = new Size(277, 36);
            button4.TabIndex = 6;
            button4.Text = "Xóa node đang chọn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(438, 259);
            button5.Name = "button5";
            button5.Size = new Size(277, 36);
            button5.TabIndex = 7;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = true;
            button5.Click += this.button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(330, 473);
            button6.Name = "button6";
            button6.Size = new Size(37, 23);
            button6.TabIndex = 8;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += this.button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(373, 473);
            button7.Name = "button7";
            button7.Size = new Size(37, 23);
            button7.TabIndex = 9;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += this.button7_Click;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(727, 508);
            this.Controls.Add(button7);
            this.Controls.Add(button6);
            this.Controls.Add(button5);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(treeView1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}