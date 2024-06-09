namespace FlyTodayViews
{
    partial class ConfirmationDialogPassword
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxRepeatPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(104, 216);
            button1.Name = "button1";
            button1.Size = new Size(149, 43);
            button1.TabIndex = 0;
            button1.Text = "Восстановить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 1;
            label1.Text = "Код из письма:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(35, 113);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(314, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 76);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 3;
            label2.Text = "Новый пароль:";
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(35, 183);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(314, 27);
            textBoxRepeatPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(35, 146);
            label3.Name = "label3";
            label3.Size = new Size(253, 28);
            label3.TabIndex = 5;
            label3.Text = "Повторите новый пароль:";
            // 
            // ConfirmationDialogPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 263);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ConfirmationDialogPassword";
            Text = "Восстановление пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxRepeatPassword;
        private Label label3;
    }
}