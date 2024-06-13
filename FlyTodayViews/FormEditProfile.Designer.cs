namespace FlyTodayViews
{
    partial class FormEditProfile
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
            dateTimePickerDateOfBirth = new DateTimePicker();
            textBoxSurname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            textBoxLastname = new TextBox();
            textBoxPassword = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxRepeatPassword = new TextBox();
            label7 = new Label();
            buttonEditPassword = new Button();
            label9 = new Label();
            buttonShowPassword = new Button();
            buttonShowRepeatPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(168, 143);
            dateTimePickerDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(319, 27);
            dateTimePickerDateOfBirth.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(168, 24);
            textBoxSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(319, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 108);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Отчество:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 143);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 5;
            label4.Text = "Дата рождения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 224);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 7;
            label6.Text = "Новый пароль:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(168, 65);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(319, 27);
            textBoxName.TabIndex = 8;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(168, 104);
            textBoxLastname.Margin = new Padding(3, 4, 3, 4);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(319, 27);
            textBoxLastname.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(168, 220);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ReadOnly = true;
            textBoxPassword.Size = new Size(227, 27);
            textBoxPassword.TabIndex = 11;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(288, 337);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 31);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(402, 337);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(98, 31);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(168, 259);
            textBoxRepeatPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.ReadOnly = true;
            textBoxRepeatPassword.Size = new Size(227, 27);
            textBoxRepeatPassword.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 263);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 15;
            label7.Text = "Повторите пароль:";
            // 
            // buttonEditPassword
            // 
            buttonEditPassword.Location = new Point(24, 181);
            buttonEditPassword.Margin = new Padding(3, 4, 3, 4);
            buttonEditPassword.Name = "buttonEditPassword";
            buttonEditPassword.Size = new Size(464, 31);
            buttonEditPassword.TabIndex = 16;
            buttonEditPassword.Text = "Изменить пароль";
            buttonEditPassword.UseVisualStyleBackColor = true;
            buttonEditPassword.Click += buttonEditPassword_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(168, 293);
            label9.Name = "label9";
            label9.Size = new Size(230, 30);
            label9.TabIndex = 20;
            label9.Text = "Пароль должен состоять обязательно\r\nиз цифр, букв и небуквенных символов.\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.Location = new Point(402, 220);
            buttonShowPassword.Margin = new Padding(3, 4, 3, 4);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(86, 31);
            buttonShowPassword.TabIndex = 21;
            buttonShowPassword.Text = "Показать";
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.MouseDown += buttonShowPassword_MouseDown;
            buttonShowPassword.MouseUp += buttonShowPassword_MouseUp;
            // 
            // buttonShowRepeatPassword
            // 
            buttonShowRepeatPassword.Location = new Point(402, 257);
            buttonShowRepeatPassword.Margin = new Padding(3, 4, 3, 4);
            buttonShowRepeatPassword.Name = "buttonShowRepeatPassword";
            buttonShowRepeatPassword.Size = new Size(86, 31);
            buttonShowRepeatPassword.TabIndex = 22;
            buttonShowRepeatPassword.Text = "Показать";
            buttonShowRepeatPassword.UseVisualStyleBackColor = true;
            buttonShowRepeatPassword.MouseDown += buttonShowRepeatPassword_MouseDown;
            buttonShowRepeatPassword.MouseUp += buttonShowRepeatPassword_MouseUp;
            // 
            // FormEditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 384);
            Controls.Add(buttonShowRepeatPassword);
            Controls.Add(buttonShowPassword);
            Controls.Add(label9);
            Controls.Add(buttonEditPassword);
            Controls.Add(label7);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxSurname);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormEditProfile";
            Text = "Редактирование профиля";
            Load += FormEditProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerDateOfBirth;
        private TextBox textBoxSurname;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBoxName;
        private TextBox textBoxLastname;
        private TextBox textBoxPassword;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxRepeatPassword;
        private Label label7;
        private Button buttonEditPassword;
        private Label label9;
        private Button buttonShowPassword;
        private Button buttonShowRepeatPassword;
    }
}