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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.ActiveCaption;
            buttonRegistration.Font = new Font("Segoe UI", 14F);
            buttonRegistration.Location = new Point(298, 333);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(250, 60);
            buttonRegistration.TabIndex = 1;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(117, 85);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(250, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(117, 210);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(250, 27);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(117, 146);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(490, 85);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(490, 146);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(250, 27);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(489, 271);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.PasswordChar = '*';
            textBoxRepeatPassword.Size = new Size(250, 27);
            textBoxRepeatPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(118, 54);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 9;
            label2.Text = "Фамимия:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(117, 115);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 10;
            label3.Text = "Имя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(117, 176);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 11;
            label4.Text = "Отчество:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(117, 240);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 12;
            label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(489, 54);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 13;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(489, 115);
            label7.Name = "label7";
            label7.Size = new Size(85, 28);
            label7.TabIndex = 14;
            label7.Text = "Пароль:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(489, 240);
            label8.Name = "label8";
            label8.Size = new Size(187, 28);
            label8.TabIndex = 15;
            label8.Text = "Повторите пароль:";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(117, 271);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(250, 27);
            dateTimePickerBirth.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(500, 189);
            label9.Name = "label9";
            label9.Size = new Size(230, 30);
            label9.TabIndex = 19;
            label9.Text = "Пароль должен состоять обязательно\r\nиз цифр, букв и небуквенных символов.\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormRegistration";
            Text = "Регистрация";
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