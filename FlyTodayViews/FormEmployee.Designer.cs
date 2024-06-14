namespace FlyTodayViews
{
    partial class FormEmployee
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
            buttonSave = new Button();
            textBoxSurname = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            dateTimePickerMedAnalys = new DateTimePicker();
            dateTimePickerBirth = new DateTimePicker();
            groupBox1 = new GroupBox();
            label6 = new Label();
            comboBoxGender = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            checkBoxMedAnalys = new CheckBox();
            groupBox3 = new GroupBox();
            comboBoxJob = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            comboBoxTypeWork = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 16F);
            buttonSave.Location = new Point(281, 292);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(147, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(13, 40);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(249, 23);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(13, 132);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(249, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 86);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(247, 23);
            textBoxName.TabIndex = 3;
            // 
            // dateTimePickerMedAnalys
            // 
            dateTimePickerMedAnalys.Font = new Font("Segoe UI", 10F);
            dateTimePickerMedAnalys.Location = new Point(21, 82);
            dateTimePickerMedAnalys.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerMedAnalys.Name = "dateTimePickerMedAnalys";
            dateTimePickerMedAnalys.Size = new Size(242, 25);
            dateTimePickerMedAnalys.TabIndex = 5;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Font = new Font("Segoe UI", 10F);
            dateTimePickerBirth.Location = new Point(13, 178);
            dateTimePickerBirth.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(249, 25);
            dateTimePickerBirth.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxGender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Controls.Add(dateTimePickerBirth);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Location = new Point(43, 17);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(282, 270);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(13, 206);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 12;
            label6.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Ж", "М" });
            comboBoxGender.Location = new Point(13, 229);
            comboBoxGender.Margin = new Padding(3, 2, 3, 2);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(249, 23);
            comboBoxGender.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(15, 63);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 10;
            label4.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 109);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 9;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 154);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 8;
            label2.Text = "Дата рождения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 7;
            label1.Text = "Фамилия:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(checkBoxMedAnalys);
            groupBox2.Controls.Add(dateTimePickerMedAnalys);
            groupBox2.Location = new Point(378, 17);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(282, 124);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Медицинский осмотр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(21, 58);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 7;
            label5.Text = "Действует до:";
            // 
            // checkBoxMedAnalys
            // 
            checkBoxMedAnalys.AutoSize = true;
            checkBoxMedAnalys.Font = new Font("Segoe UI", 12F);
            checkBoxMedAnalys.Location = new Point(23, 27);
            checkBoxMedAnalys.Margin = new Padding(3, 2, 3, 2);
            checkBoxMedAnalys.Name = "checkBoxMedAnalys";
            checkBoxMedAnalys.Size = new Size(59, 25);
            checkBoxMedAnalys.TabIndex = 6;
            checkBoxMedAnalys.Text = "Есть";
            checkBoxMedAnalys.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(comboBoxTypeWork);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(comboBoxJob);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(378, 149);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(282, 138);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные о работе";
            // 
            // comboBoxJob
            // 
            comboBoxJob.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Location = new Point(21, 97);
            comboBoxJob.Margin = new Padding(3, 2, 3, 2);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(246, 23);
            comboBoxJob.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(21, 74);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 5;
            label7.Text = "Должность:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(21, 17);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 10;
            label9.Text = "Тип работы:";
            // 
            // comboBoxTypeWork
            // 
            comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeWork.FormattingEnabled = true;
            comboBoxTypeWork.Items.AddRange(new object[] { "На рейсе", "Посменная" });
            comboBoxTypeWork.Location = new Point(18, 46);
            comboBoxTypeWork.Margin = new Padding(3, 2, 3, 2);
            comboBoxTypeWork.Name = "comboBoxTypeWork";
            comboBoxTypeWork.Size = new Size(246, 23);
            comboBoxTypeWork.Sorted = true;
            comboBoxTypeWork.TabIndex = 11;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 332);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormEmployee";
            Text = "Сотрудник";
            Load += FormEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private TextBox textBoxSurname;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerMedAnalys;
        private DateTimePicker dateTimePickerBirth;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private CheckBox checkBoxMedAnalys;
        private Label label6;
        private ComboBox comboBoxGender;
        private Label label5;
        private GroupBox groupBox3;
        private Label label7;
        private ComboBox comboBoxJob;
        private ComboBox comboBoxTypeWork;
        private Label label9;
    }
}