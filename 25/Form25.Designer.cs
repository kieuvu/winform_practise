namespace WinFormsApp1._25
{
    partial class Form25
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(285, 33);
            label1.Name = "label1";
            label1.Size = new Size(238, 37);
            label1.TabIndex = 0;
            label1.Text = "Soạn thảo văn bản";
            // 
            // button1
            // 
            button1.Location = new Point(25, 112);
            button1.Name = "button1";
            button1.Size = new Size(236, 33);
            button1.TabIndex = 1;
            button1.Text = "Mở tệp tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(25, 151);
            button2.Name = "button2";
            button2.Size = new Size(236, 33);
            button2.TabIndex = 2;
            button2.Text = "Lưu tệp tin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(25, 190);
            button3.Name = "button3";
            button3.Size = new Size(236, 33);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 326);
            textBox1.TabIndex = 4;
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(textBox1);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(label1);
            this.Name = "Form25";
            this.Text = "Form25";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}