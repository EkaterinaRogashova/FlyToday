namespace FlyTodayViews
{
    partial class FormRegistration
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
            buttonRegistration = new Button();
            textBoxSurname = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRepeatPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePickerBirth = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(526, 83);
            label1.Name = "label1";
            label1.Size = new Size(249, 54);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // buttonRegistration
            // 
            buttonRegistration.Anchor = AnchorStyles.None;
            buttonRegistration.BackColor = SystemColors.ActiveCaption;
            buttonRegistration.Font = new Font("Segoe UI", 18F);
            buttonRegistration.Location = new Point(502, 557);
            buttonRegistration.Margin = new Padding(3, 2, 3, 2);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(306, 70);
            buttonRegistration.TabIndex = 1;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.Font = new Font("Segoe UI", 14F);
            textBoxSurname.Location = new Point(282, 219);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(331, 32);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.None;
            textBoxLastName.Font = new Font("Segoe UI", 14F);
            textBoxLastName.Location = new Point(282, 377);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(331, 32);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Font = new Font("Segoe UI", 14F);
            textBoxName.Location = new Point(282, 296);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(331, 32);
            textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Font = new Font("Segoe UI", 14F);
            textBoxEmail.Location = new Point(696, 219);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(331, 32);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Font = new Font("Segoe UI", 14F);
            textBoxPassword.Location = new Point(696, 296);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(330, 32);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Anchor = AnchorStyles.None;
            textBoxRepeatPassword.Font = new Font("Segoe UI", 14F);
            textBoxRepeatPassword.Location = new Point(696, 458);
            textBoxRepeatPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.PasswordChar = '*';
            textBoxRepeatPassword.Size = new Size(331, 32);
            textBoxRepeatPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(282, 178);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 9;
            label2.Text = "Фамимия:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(282, 260);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 10;
            label3.Text = "Имя:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(282, 345);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 11;
            label4.Text = "Отчество:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(282, 423);
            label5.Name = "label5";
            label5.Size = new Size(173, 30);
            label5.TabIndex = 12;
            label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(697, 178);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 13;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(697, 260);
            label7.Name = "label7";
            label7.Size = new Size(94, 30);
            label7.TabIndex = 14;
            label7.Text = "Пароль:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(696, 423);
            label8.Name = "label8";
            label8.Size = new Size(207, 30);
            label8.TabIndex = 15;
            label8.Text = "Повторите пароль:";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Anchor = AnchorStyles.None;
            dateTimePickerBirth.Font = new Font("Segoe UI", 14F);
            dateTimePickerBirth.Location = new Point(282, 458);
            dateTimePickerBirth.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(331, 32);
            dateTimePickerBirth.TabIndex = 18;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(731, 345);
            label9.Name = "label9";
            label9.Size = new Size(264, 38);
            label9.TabIndex = 19;
            label9.Text = "Пароль должен состоять обязательно\r\nиз цифр, букв и небуквенных символов.\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1277, 727);
            Controls.Add(label9);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxSurname);
            Controls.Add(buttonRegistration);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormRegistration";
            Text = "Регистрация";
            WindowState = FormWindowState.Maximized;
            Load += FormRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonRegistration;
        private TextBox textBoxSurname;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxRepeatPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePickerBirth;
        private Label label9;
    }
}