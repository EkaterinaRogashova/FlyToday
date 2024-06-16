namespace FlyTodayViews
{
    partial class FormScheduleForEmployee
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBoxShift = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(90, 118);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 30);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 1;
            label1.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 32);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxShift
            // 
            comboBoxShift.FormattingEnabled = true;
            comboBoxShift.Items.AddRange(new object[] { "День", "Ночь", "Отсыпной", "Выходной" });
            comboBoxShift.Location = new Point(50, 86);
            comboBoxShift.Margin = new Padding(3, 2, 3, 2);
            comboBoxShift.Name = "comboBoxShift";
            comboBoxShift.Size = new Size(218, 23);
            comboBoxShift.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 62);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 5;
            label2.Text = "Смена:";
            // 
            // FormScheduleForEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(317, 156);
            Controls.Add(label2);
            Controls.Add(comboBoxShift);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormScheduleForEmployee";
            Text = "Создание расписания для сотрудника";
            Load += FormScheduleForEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxShift;
        private Label label2;
    }
}