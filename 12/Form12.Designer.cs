namespace WinFormsApp4
{
    partial class Form12
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
            txt_n = new TextBox();
            txt_result = new TextBox();
            btn_find = new Button();
            btn_exit = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 19);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 0;
            label1.Text = "Tìm số nguyên tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập N";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 132);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Số NT nhỏ hơn N";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(196, 74);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 3;
            // 
            // txt_result
            // 
            txt_result.Location = new Point(196, 124);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(297, 23);
            txt_result.TabIndex = 4;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(171, 170);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(75, 23);
            btn_find.TabIndex = 5;
            btn_find.Text = "Tìm";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += this.btn_find_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(267, 170);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += this.btn_exit_Click;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(530, 214);
            this.Controls.Add(btn_exit);
            this.Controls.Add(btn_find);
            this.Controls.Add(txt_result);
            this.Controls.Add(txt_n);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "Form12";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_n;
        private TextBox txt_result;
        private Button btn_find;
        private Button btn_exit;
    }
}