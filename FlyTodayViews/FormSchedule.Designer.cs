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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            buttonSaveFilter = new Button();
            buttonFilterCancel = new Button();
            buttonSearch = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(buttonFilterCancel);
            groupBox1.Controls.Add(buttonSaveFilter);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 35);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(384, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 36);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(199, 60);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 28);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Смена:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "День", "Ночь", "Отсыпной", "Выходной" });
            comboBox1.Location = new Point(12, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(buttonCancel);
            groupBox2.Controls.Add(buttonSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Location = new Point(597, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 134);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Период";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 8;
            label5.Text = "По:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 31);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 6;
            label4.Text = "С:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(39, 60);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(189, 27);
            dateTimePicker3.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(39, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(189, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(819, 399);
            dataGridView1.TabIndex = 2;
            // 
            // buttonSaveFilter
            // 
            buttonSaveFilter.Location = new Point(12, 95);
            buttonSaveFilter.Name = "buttonSaveFilter";
            buttonSaveFilter.Size = new Size(277, 29);
            buttonSaveFilter.TabIndex = 6;
            buttonSaveFilter.Text = "Применить";
            buttonSaveFilter.UseVisualStyleBackColor = true;
            // 
            // buttonFilterCancel
            // 
            buttonFilterCancel.Location = new Point(296, 95);
            buttonFilterCancel.Name = "buttonFilterCancel";
            buttonFilterCancel.Size = new Size(277, 29);
            buttonFilterCancel.TabIndex = 7;
            buttonFilterCancel.Text = "Сбросить";
            buttonFilterCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(6, 93);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(105, 29);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(117, 93);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 563);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormSchedule";
            Text = "Расписание";
            Load += FormSchedule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button buttonFilterCancel;
        private Button buttonSaveFilter;
        private Button buttonCancel;
        private Button buttonSearch;
    }
}