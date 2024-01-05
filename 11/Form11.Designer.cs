namespace WinFormsApp3
{
    partial class Form11
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
            label5 = new Label();
            txt_num_a = new TextBox();
            txt_num_b = new TextBox();
            txt_ucnl_result = new TextBox();
            txt_bcnn_result = new TextBox();
            calc = new Button();
            exit = new Button();
            button1 = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 30);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 0;
            label1.Text = " USCLN và BSCNN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập số a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập số b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 190);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 3;
            label4.Text = "Ước số chung lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 234);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Bội số chung nhỏ nhất";
            // 
            // txt_num_a
            // 
            txt_num_a.Location = new Point(209, 103);
            txt_num_a.Name = "txt_num_a";
            txt_num_a.Size = new Size(241, 23);
            txt_num_a.TabIndex = 5;
            // 
            // txt_num_b
            // 
            txt_num_b.Location = new Point(209, 146);
            txt_num_b.Name = "txt_num_b";
            txt_num_b.Size = new Size(241, 23);
            txt_num_b.TabIndex = 6;
            // 
            // txt_ucnl_result
            // 
            txt_ucnl_result.Location = new Point(209, 190);
            txt_ucnl_result.Name = "txt_ucnl_result";
            txt_ucnl_result.Size = new Size(241, 23);
            txt_ucnl_result.TabIndex = 7;
            // 
            // txt_bcnn_result
            // 
            txt_bcnn_result.Location = new Point(209, 234);
            txt_bcnn_result.Name = "txt_bcnn_result";
            txt_bcnn_result.Size = new Size(241, 23);
            txt_bcnn_result.TabIndex = 8;
            // 
            // calc
            // 
            calc.Location = new Point(87, 279);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 9;
            calc.Text = "Thực hiện";
            calc.UseVisualStyleBackColor = true;
            calc.Click += this.calc_Click;
            // 
            // exit
            // 
            exit.Location = new Point(269, 279);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 11;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += this.exit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(178, 279);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(482, 341);
            this.Controls.Add(button1);
            this.Controls.Add(exit);
            this.Controls.Add(calc);
            this.Controls.Add(txt_bcnn_result);
            this.Controls.Add(txt_ucnl_result);
            this.Controls.Add(txt_num_b);
            this.Controls.Add(txt_num_a);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "Form11";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_num_a;
        private TextBox txt_num_b;
        private TextBox txt_ucnl_result;
        private TextBox txt_bcnn_result;
        private Button calc;
        private Button exit;
        private Button button1;
    }
}