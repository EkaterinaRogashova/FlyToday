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
            label8 = new Label();
            textBoxFlightTeam = new TextBox();
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
            buttonSave.Location = new Point(315, 391);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(168, 47);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(15, 54);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(284, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(15, 176);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(284, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(17, 115);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(282, 27);
            textBoxName.TabIndex = 3;
            // 
            // dateTimePickerMedAnalys
            // 
            dateTimePickerMedAnalys.Font = new Font("Segoe UI", 10F);
            dateTimePickerMedAnalys.Location = new Point(24, 109);
            dateTimePickerMedAnalys.Name = "dateTimePickerMedAnalys";
            dateTimePickerMedAnalys.Size = new Size(276, 30);
            dateTimePickerMedAnalys.TabIndex = 5;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Font = new Font("Segoe UI", 10F);
            dateTimePickerBirth.Location = new Point(15, 237);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(284, 30);
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
            groupBox1.Location = new Point(49, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 353);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(15, 274);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 12;
            label6.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Ж", "М" });
            comboBoxGender.Location = new Point(15, 305);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(284, 28);
            comboBoxGender.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(17, 84);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 10;
            label4.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 145);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 9;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 206);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 8;
            label2.Text = "Дата рождения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(15, 23);
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
            groupBox2.Location = new Point(432, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 165);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Медицинский осмотр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 78);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 7;
            label5.Text = "Действует до:";
            // 
            // checkBoxMedAnalys
            // 
            checkBoxMedAnalys.AutoSize = true;
            checkBoxMedAnalys.Font = new Font("Segoe UI", 12F);
            checkBoxMedAnalys.Location = new Point(26, 36);
            checkBoxMedAnalys.Name = "checkBoxMedAnalys";
            checkBoxMedAnalys.Size = new Size(71, 32);
            checkBoxMedAnalys.TabIndex = 6;
            checkBoxMedAnalys.Text = "Есть";
            checkBoxMedAnalys.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(comboBoxJob);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBoxFlightTeam);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(432, 199);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 177);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные о работе";
            // 
            // comboBoxJob
            // 
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Location = new Point(20, 64);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(280, 28);
            comboBoxJob.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(20, 98);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 7;
            label8.Text = "Экипаж:";
            // 
            // textBoxFlightTeam
            // 
            textBoxFlightTeam.Location = new Point(20, 129);
            textBoxFlightTeam.Name = "textBoxFlightTeam";
            textBoxFlightTeam.Size = new Size(280, 27);
            textBoxFlightTeam.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(20, 30);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 5;
            label7.Text = "Должность:";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonSave);
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
        private Label label8;
        private TextBox textBoxFlightTeam;
        private Label label7;
        private ComboBox comboBoxJob;
    }
}