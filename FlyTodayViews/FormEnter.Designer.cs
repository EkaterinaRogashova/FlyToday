namespace FlyTodayViews
{
    partial class FormEnter
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
            buttonEnter = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = SystemColors.ActiveCaption;
            buttonEnter.Cursor = Cursors.Hand;
            buttonEnter.Font = new Font("Segoe UI", 16F);
            buttonEnter.ForeColor = SystemColors.Desktop;
            buttonEnter.Location = new Point(249, 225);
            buttonEnter.Margin = new Padding(3, 2, 3, 2);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(219, 45);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(249, 116);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(221, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(249, 178);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(221, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(216, 33);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 3;
            label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(249, 92);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 4;
            label2.Text = "Введите e-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(253, 154);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 5;
            label3.Text = "Введите пароль:";
            // 
            // FormEnter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonEnter);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEnter";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
