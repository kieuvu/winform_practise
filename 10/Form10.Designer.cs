namespace WinFormsApp3
{
    partial class Form10
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Bò kho", "Phở bò", "Phở gà", "Bún măng", "Bún bò", "Bún riêu", "Mì xáo thập cẩm", "Mì xào bò", "Mì xào chay" });
            listBox1.Location = new Point(69, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 259);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(447, 79);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(245, 259);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(341, 156);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(341, 185);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(341, 243);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "<<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(341, 214);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = ">>";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(255, 15);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 6;
            button5.Text = "In Thực Đơn";
            button5.UseVisualStyleBackColor = true;
            button5.Click += this.button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(405, 15);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "Thoát";
            button6.UseVisualStyleBackColor = true;
            button6.Click += this.button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 8);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 8;
            label1.Text = "Thực đơn trong ngày";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 47);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(3, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 47);
            panel2.TabIndex = 10;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(760, 428);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(listBox2);
            this.Controls.Add(listBox1);
            this.Name = "Form10";
            this.Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}