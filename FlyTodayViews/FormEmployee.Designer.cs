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
            comboBoxTypeWork = new ComboBox();
            label9 = new Label();
            comboBoxJob = new ComboBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 16F);
            buttonSave.Location = new Point(442, 545);
            buttonSave.Margin = new Padding(5, 4, 5, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(231, 65);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(20, 75);
            textBoxSurname.Margin = new Padding(5, 4, 5, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(394, 34);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(20, 246);
            textBoxLastName.Margin = new Padding(5, 4, 5, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(394, 34);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(20, 161);
            textBoxName.Margin = new Padding(5, 4, 5, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(394, 34);
            textBoxName.TabIndex = 3;
            // 
            // dateTimePickerMedAnalys
            // 
            dateTimePickerMedAnalys.Font = new Font("Segoe UI", 15F);
            dateTimePickerMedAnalys.Location = new Point(33, 153);
            dateTimePickerMedAnalys.Margin = new Padding(5, 4, 5, 4);
            dateTimePickerMedAnalys.Name = "dateTimePickerMedAnalys";
            dateTimePickerMedAnalys.Size = new Size(378, 34);
            dateTimePickerMedAnalys.TabIndex = 5;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Font = new Font("Segoe UI", 15F);
            dateTimePickerBirth.Location = new Point(20, 332);
            dateTimePickerBirth.Margin = new Padding(5, 4, 5, 4);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(394, 34);
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
            groupBox1.Location = new Point(68, 32);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(443, 504);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(20, 385);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 12;
            label6.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Ж", "М" });
            comboBoxGender.Location = new Point(20, 427);
            comboBoxGender.Margin = new Padding(5, 4, 5, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(394, 36);
            comboBoxGender.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(24, 129);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 10;
            label4.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(20, 214);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 9;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(20, 300);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 8;
            label2.Text = "Дата рождения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(20, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 7;
            label1.Text = "Фамилия:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(checkBoxMedAnalys);
            groupBox2.Controls.Add(dateTimePickerMedAnalys);
            groupBox2.Location = new Point(594, 32);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(443, 231);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Медицинский осмотр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(28, 107);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 7;
            label5.Text = "Действует до:";
            // 
            // checkBoxMedAnalys
            // 
            checkBoxMedAnalys.AutoSize = true;
            checkBoxMedAnalys.Font = new Font("Segoe UI", 15F);
            checkBoxMedAnalys.Location = new Point(36, 50);
            checkBoxMedAnalys.Margin = new Padding(5, 4, 5, 4);
            checkBoxMedAnalys.Name = "checkBoxMedAnalys";
            checkBoxMedAnalys.Size = new Size(68, 32);
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
            groupBox3.Location = new Point(594, 278);
            groupBox3.Margin = new Padding(5, 4, 5, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 4, 5, 4);
            groupBox3.Size = new Size(443, 258);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные о работе";
            // 
            // comboBoxTypeWork
            // 
            comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeWork.FormattingEnabled = true;
            comboBoxTypeWork.Items.AddRange(new object[] { "На рейсе", "Посменная" });
            comboBoxTypeWork.Location = new Point(33, 86);
            comboBoxTypeWork.Margin = new Padding(5, 4, 5, 4);
            comboBoxTypeWork.Name = "comboBoxTypeWork";
            comboBoxTypeWork.Size = new Size(384, 36);
            comboBoxTypeWork.Sorted = true;
            comboBoxTypeWork.TabIndex = 11;
            comboBoxTypeWork.SelectedIndexChanged += comboBoxTypeWork_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(28, 43);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 28);
            label9.TabIndex = 10;
            label9.Text = "Тип работы:";
            // 
            // comboBoxJob
            // 
            comboBoxJob.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Location = new Point(33, 181);
            comboBoxJob.Margin = new Padding(5, 4, 5, 4);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(384, 36);
            comboBoxJob.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(28, 139);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 5;
            label7.Text = "Должность:";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1100, 620);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonSave);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 4, 5, 4);
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