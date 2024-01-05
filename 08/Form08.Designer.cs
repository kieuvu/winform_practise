namespace WinFormsApp1._08
{
    partial class Form08
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            hScrollBar1 = new HScrollBar();
            hScrollBar2 = new HScrollBar();
            hScrollBar3 = new HScrollBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)this.webView21).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = Color.White;
            this.webView21.Location = new Point(798, 454);
            this.webView21.Name = "webView21";
            this.webView21.Size = new Size(75, 23);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.Location = new Point(30, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 160);
            panel1.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(258, 69);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(259, 36);
            hScrollBar1.TabIndex = 2;
            hScrollBar1.Scroll += this.hScrollBar1_Scroll;
            // 
            // hScrollBar2
            // 
            hScrollBar2.LargeChange = 1;
            hScrollBar2.Location = new Point(258, 116);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(259, 36);
            hScrollBar2.TabIndex = 3;
            hScrollBar2.Scroll += this.hScrollBar2_Scroll;
            // 
            // hScrollBar3
            // 
            hScrollBar3.LargeChange = 1;
            hScrollBar3.Location = new Point(258, 163);
            hScrollBar3.Name = "hScrollBar3";
            hScrollBar3.Size = new Size(259, 36);
            hScrollBar3.TabIndex = 4;
            hScrollBar3.Scroll += this.hScrollBar3_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 81);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 128);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 174);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Blue";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(533, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(533, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(48, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(533, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(48, 23);
            textBox3.TabIndex = 10;
            // 
            // Form08
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(618, 265);
            this.Controls.Add(textBox3);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(hScrollBar3);
            this.Controls.Add(hScrollBar2);
            this.Controls.Add(hScrollBar1);
            this.Controls.Add(panel1);
            this.Controls.Add(this.webView21);
            this.Name = "Form08";
            this.Text = "Form08";
            ((System.ComponentModel.ISupportInitialize)this.webView21).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Panel panel1;
        private HScrollBar hScrollBar1;
        private HScrollBar hScrollBar2;
        private HScrollBar hScrollBar3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}