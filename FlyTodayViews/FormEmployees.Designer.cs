namespace FlyTodayViews
{
    partial class FormEmployees
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
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            groupBox1 = new GroupBox();
            buttonDeteteFilter = new Button();
            buttonSaveFilter = new Button();
            label1 = new Label();
            comboBoxJob = new ComboBox();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            tabelToolStripMenuItem = new ToolStripMenuItem();
            должностиToolStripMenuItem = new ToolStripMenuItem();
            buttonScheduleForEmployee = new Button();
            buttonEmployeePdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(972, 504);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(1010, 274);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 49);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(1010, 329);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(145, 49);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(1010, 384);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 49);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Уволить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(buttonDeteteFilter);
            groupBox1.Controls.Add(buttonSaveFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxJob);
            groupBox1.Location = new Point(1003, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 235);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // buttonDeteteFilter
            // 
            buttonDeteteFilter.Font = new Font("Segoe UI", 12F);
            buttonDeteteFilter.Location = new Point(7, 161);
            buttonDeteteFilter.Name = "buttonDeteteFilter";
            buttonDeteteFilter.Size = new Size(145, 49);
            buttonDeteteFilter.TabIndex = 6;
            buttonDeteteFilter.Text = "Сбросить";
            buttonDeteteFilter.UseVisualStyleBackColor = true;
            buttonDeteteFilter.Click += buttonDeteteFilter_Click;
            // 
            // buttonSaveFilter
            // 
            buttonSaveFilter.Font = new Font("Segoe UI", 12F);
            buttonSaveFilter.Location = new Point(6, 97);
            buttonSaveFilter.Name = "buttonSaveFilter";
            buttonSaveFilter.Size = new Size(145, 49);
            buttonSaveFilter.TabIndex = 5;
            buttonSaveFilter.Text = "Применить";
            buttonSaveFilter.UseVisualStyleBackColor = true;
            buttonSaveFilter.Click += buttonSaveFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(7, 23);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 1;
            label1.Text = "По должности:";
            // 
            // comboBoxJob
            // 
            comboBoxJob.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Location = new Point(5, 54);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(151, 28);
            comboBoxJob.Sorted = true;
            comboBoxJob.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1185, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleToolStripMenuItem, tabelToolStripMenuItem, должностиToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(174, 26);
            scheduleToolStripMenuItem.Text = "Расписание";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // tabelToolStripMenuItem
            // 
            tabelToolStripMenuItem.Name = "tabelToolStripMenuItem";
            tabelToolStripMenuItem.Size = new Size(174, 26);
            tabelToolStripMenuItem.Text = "Табель";
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(174, 26);
            должностиToolStripMenuItem.Text = "Должности";
            должностиToolStripMenuItem.Click += должностиToolStripMenuItem_Click;
            // 
            // buttonScheduleForEmployee
            // 
            buttonScheduleForEmployee.Font = new Font("Segoe UI", 9F);
            buttonScheduleForEmployee.Location = new Point(1010, 439);
            buttonScheduleForEmployee.Name = "buttonScheduleForEmployee";
            buttonScheduleForEmployee.Size = new Size(145, 49);
            buttonScheduleForEmployee.TabIndex = 6;
            buttonScheduleForEmployee.Text = "Добавить расписание смен";
            buttonScheduleForEmployee.UseVisualStyleBackColor = true;
            buttonScheduleForEmployee.Click += buttonScheduleForEmployee_Click;
            // 
            // buttonEmployeePdf
            // 
            buttonEmployeePdf.Font = new Font("Segoe UI", 7F);
            buttonEmployeePdf.Location = new Point(1009, 494);
            buttonEmployeePdf.Name = "buttonEmployeePdf";
            buttonEmployeePdf.Size = new Size(145, 49);
            buttonEmployeePdf.TabIndex = 7;
            buttonEmployeePdf.Text = "Получить расписание сотрудника";
            buttonEmployeePdf.UseVisualStyleBackColor = true;
            buttonEmployeePdf.Click += buttonEmployeePdf_Click;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 559);
            Controls.Add(buttonEmployeePdf);
            Controls.Add(buttonScheduleForEmployee);
            Controls.Add(groupBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormEmployees";
            Text = "Сотрудники";
            Load += FormEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBoxJob;
        private Button buttonSaveFilter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem tabelToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private Button buttonDeteteFilter;
        private Button buttonScheduleForEmployee;
        private Button buttonEmployeePdf;
    }
}