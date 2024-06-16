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
            label3 = new Label();
            buttonCreatePdfMonth = new Button();
            dateTimePicker1 = new DateTimePicker();
            buttonEdit = new Button();
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
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonCreatePdfMonth);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(buttonEdit);
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
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1880, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(1195, 18);
            label3.Name = "label3";
            label3.Size = new Size(251, 25);
            label3.TabIndex = 16;
            label3.Text = "Получить отчет на месяц с:";
            // 
            // buttonCreatePdfMonth
            // 
            buttonCreatePdfMonth.Font = new Font("Segoe UI", 14F);
            buttonCreatePdfMonth.Location = new Point(1195, 81);
            buttonCreatePdfMonth.Margin = new Padding(3, 2, 3, 2);
            buttonCreatePdfMonth.Name = "buttonCreatePdfMonth";
            buttonCreatePdfMonth.Size = new Size(319, 71);
            buttonCreatePdfMonth.TabIndex = 15;
            buttonCreatePdfMonth.Text = "Отчет\r\nPdf на выбранный период (месяц)";
            buttonCreatePdfMonth.UseVisualStyleBackColor = true;
            buttonCreatePdfMonth.Click += buttonCreatePdfMonth_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(1195, 45);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 32);
            dateTimePicker1.TabIndex = 14;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 14F);
            buttonEdit.Location = new Point(1586, 33);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 119);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Изменить запись";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Segoe UI", 14F);
            checkBox.Location = new Point(592, 25);
            checkBox.Margin = new Padding(3, 2, 3, 2);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(214, 29);
            checkBox.TabIndex = 11;
            checkBox.Text = "Фильтровать по дате";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // buttonToPdf
            // 
            buttonToPdf.Font = new Font("Segoe UI", 14F);
            buttonToPdf.Location = new Point(990, 31);
            buttonToPdf.Margin = new Padding(3, 2, 3, 2);
            buttonToPdf.Name = "buttonToPdf";
            buttonToPdf.Size = new Size(160, 123);
            buttonToPdf.TabIndex = 10;
            buttonToPdf.Text = "Отчет\r\nPdf на текущий месяц";
            buttonToPdf.UseVisualStyleBackColor = true;
            buttonToPdf.Click += ButtonToPdf_Click;
            // 
            // buttonFilterCancel
            // 
            buttonFilterCancel.Font = new Font("Segoe UI", 14F);
            buttonFilterCancel.Location = new Point(303, 106);
            buttonFilterCancel.Margin = new Padding(3, 2, 3, 2);
            buttonFilterCancel.Name = "buttonFilterCancel";
            buttonFilterCancel.Size = new Size(191, 32);
            buttonFilterCancel.TabIndex = 7;
            buttonFilterCancel.Text = "Сбросить";
            buttonFilterCancel.UseVisualStyleBackColor = true;
            buttonFilterCancel.Click += buttonFilterCancel_Click;
            // 
            // buttonSaveFilter
            // 
            buttonSaveFilter.Anchor = AnchorStyles.Top;
            buttonSaveFilter.Font = new Font("Segoe UI", 14F);
            buttonSaveFilter.Location = new Point(58, 106);
            buttonSaveFilter.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFilter.Name = "buttonSaveFilter";
            buttonSaveFilter.Size = new Size(191, 32);
            buttonSaveFilter.TabIndex = 6;
            buttonSaveFilter.Text = "Применить";
            buttonSaveFilter.UseVisualStyleBackColor = true;
            buttonSaveFilter.Click += buttonSaveFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(303, 26);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(569, 104);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 8;
            label5.Text = "По:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 14F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(303, 59);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 33);
            comboBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(569, 62);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 6;
            label4.Text = "С:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Смена:";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Font = new Font("Segoe UI", 14F);
            dateTimePickerTo.Location = new Point(621, 104);
            dateTimePickerTo.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(319, 32);
            dateTimePickerTo.TabIndex = 7;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Font = new Font("Segoe UI", 14F);
            dateTimePickerFrom.Location = new Point(621, 60);
            dateTimePickerFrom.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(319, 32);
            dateTimePickerFrom.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "День", "Ночь", "Отсыпной", "Выходной" });
            comboBox1.Location = new Point(58, 59);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 33);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 206);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1880, 798);
            dataGridView1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(967, 25);
            label6.Name = "label6";
            label6.Size = new Size(17, 150);
            label6.TabIndex = 17;
            label6.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormSchedule";
            Text = "Расписание";
            WindowState = FormWindowState.Maximized;
            Load += FormSchedule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonEdit;
        private Button buttoncreateExel;
        private DateTimePicker dateTimePicker1;
        private Button buttonCreatePdfMonth;
        private Label label3;
        private Label label6;
    }
}