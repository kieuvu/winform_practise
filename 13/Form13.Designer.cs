namespace Listbox
{
    partial class Form13
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
            txt_input = new TextBox();
            btn_add = new Button();
            btn_delete = new Button();
            list_item = new ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 0;
            label1.Text = "Gõ 1 dòng vào đây và click nút Thêm";
            // 
            // txt_input
            // 
            txt_input.Location = new Point(28, 68);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(202, 23);
            txt_input.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(28, 120);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 2;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += this.btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(155, 120);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += this.btn_delete_Click;
            // 
            // list_item
            // 
            list_item.FormattingEnabled = true;
            list_item.ItemHeight = 15;
            list_item.Location = new Point(263, 30);
            list_item.Name = "list_item";
            list_item.Size = new Size(280, 139);
            list_item.TabIndex = 3;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(569, 195);
            this.Controls.Add(list_item);
            this.Controls.Add(btn_delete);
            this.Controls.Add(btn_add);
            this.Controls.Add(txt_input);
            this.Controls.Add(label1);
            this.Name = "Form13";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_input;
        private Button btn_add;
        private Button btn_delete;
        private ListBox list_item;
    }
}