namespace WinFormsApp8
{
    partial class Form02
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txt_qtt = new TextBox();
            txt_prc = new TextBox();
            txt_result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 105);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 70);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 141);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Thành tiền";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 4;
            // 
            // txt_qtt
            // 
            txt_qtt.Location = new Point(145, 70);
            txt_qtt.Name = "txt_qtt";
            txt_qtt.Size = new Size(233, 23);
            txt_qtt.TabIndex = 5;
            txt_qtt.TextAlign = HorizontalAlignment.Right;
            txt_qtt.KeyPress += this.textBox2_KeyPress;
            // 
            // txt_prc
            // 
            txt_prc.Location = new Point(145, 105);
            txt_prc.Name = "txt_prc";
            txt_prc.Size = new Size(233, 23);
            txt_prc.TabIndex = 6;
            txt_prc.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_result
            // 
            txt_result.Location = new Point(145, 140);
            txt_result.Name = "txt_result";
            txt_result.ReadOnly = true;
            txt_result.Size = new Size(233, 23);
            txt_result.TabIndex = 7;
            txt_result.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(41, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(173, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Tiếp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(303, 178);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Kết thúc";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // Form02
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(455, 236);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(txt_result);
            this.Controls.Add(txt_prc);
            this.Controls.Add(txt_qtt);
            this.Controls.Add(textBox1);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.KeyPreview = true;
            this.Name = "Form02";
            this.Text = "Form1";
            this.KeyUp += this.Form02_KeyUp;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txt_qtt;
        private TextBox txt_prc;
        private TextBox txt_result;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}