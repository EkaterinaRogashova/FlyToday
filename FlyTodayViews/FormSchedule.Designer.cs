namespace FlyTodayViews
{
    partial class FormSchedule
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
            groupBox1 = new GroupBox();
            checkBox = new CheckBox();
            buttonToPdf = new Button();
            buttonFilterCancel = new Button();
            buttonSaveFilter = new Button();
            label2 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(checkBox);
            groupBox1.Controls.Add(buttonToPdf);
            groupBox1.Controls.Add(buttonFilterCancel);
            groupBox1.Controls.Add(buttonSaveFilter);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerTo);
            groupBox1.Controls.Add(dateTimePickerFrom);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(712, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(339, 29);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(177, 24);
            checkBox.TabIndex = 11;
            checkBox.Text = "Фильтровать по дате";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // buttonToPdf
            // 
            buttonToPdf.Location = new Point(586, 23);
            buttonToPdf.Name = "buttonToPdf";
            buttonToPdf.Size = new Size(108, 96);
            buttonToPdf.TabIndex = 10;
            buttonToPdf.Text = "Отчет";
            buttonToPdf.UseVisualStyleBackColor = true;
            buttonToPdf.Click += ButtonToPdf_Click;
            // 
            // buttonFilterCancel
            // 
            buttonFilterCancel.Location = new Point(169, 93);
            buttonFilterCancel.Name = "buttonFilterCancel";
            buttonFilterCancel.Size = new Size(155, 29);
            buttonFilterCancel.TabIndex = 7;
            buttonFilterCancel.Text = "Сбросить";
            buttonFilterCancel.UseVisualStyleBackColor = true;
            buttonFilterCancel.Click += buttonFilterCancel_Click;
            // 
            // buttonSaveFilter
            // 
            buttonSaveFilter.Location = new Point(6, 93);
            buttonSaveFilter.Name = "buttonSaveFilter";
            buttonSaveFilter.Size = new Size(148, 29);
            buttonSaveFilter.TabIndex = 6;
            buttonSaveFilter.Text = "Применить";
            buttonSaveFilter.UseVisualStyleBackColor = true;
            buttonSaveFilter.Click += buttonSaveFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 34);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 95);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 8;
            label5.Text = "По:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(169, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 28);
            comboBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 65);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 6;
            label4.Text = "С:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Смена:";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(366, 94);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(189, 27);
            dateTimePickerTo.TabIndex = 7;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(366, 61);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(189, 27);
            dateTimePickerFrom.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "День", "Ночь", "Отсыпной", "Выходной" });
            comboBox1.Location = new Point(6, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 398);
            dataGridView1.TabIndex = 2;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 563);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "FormSchedule";
            Text = "Расписание";
            Load += FormSchedule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private DataGridView dataGridView1;
        private Button buttonFilterCancel;
        private Button buttonSaveFilter;
        private Button buttonToPdf;
        private CheckBox checkBox;
    }
}