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
            должностиToolStripMenuItem = new ToolStripMenuItem();
            buttonScheduleForEmployee = new Button();
            buttonEmployeePdfWeek = new Button();
            buttonToPdfMonth = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1586, 957);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Font = new Font("Segoe UI", 18F);
            buttonAdd.Location = new Point(1620, 271);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(240, 79);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.Font = new Font("Segoe UI", 18F);
            buttonEdit.Location = new Point(1620, 373);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(240, 86);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Font = new Font("Segoe UI", 18F);
            buttonDelete.Location = new Point(1620, 478);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(240, 85);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Уволить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(buttonDeteteFilter);
            groupBox1.Controls.Add(buttonSaveFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxJob);
            groupBox1.Location = new Point(1620, 37);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(240, 217);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // buttonDeteteFilter
            // 
            buttonDeteteFilter.Font = new Font("Segoe UI", 14F);
            buttonDeteteFilter.Location = new Point(27, 157);
            buttonDeteteFilter.Margin = new Padding(3, 2, 3, 2);
            buttonDeteteFilter.Name = "buttonDeteteFilter";
            buttonDeteteFilter.Size = new Size(183, 37);
            buttonDeteteFilter.TabIndex = 6;
            buttonDeteteFilter.Text = "Сбросить";
            buttonDeteteFilter.UseVisualStyleBackColor = true;
            buttonDeteteFilter.Click += buttonDeteteFilter_Click;
            // 
            // buttonSaveFilter
            // 
            buttonSaveFilter.Font = new Font("Segoe UI", 14F);
            buttonSaveFilter.Location = new Point(27, 116);
            buttonSaveFilter.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFilter.Name = "buttonSaveFilter";
            buttonSaveFilter.Size = new Size(183, 37);
            buttonSaveFilter.TabIndex = 5;
            buttonSaveFilter.Text = "Применить";
            buttonSaveFilter.UseVisualStyleBackColor = true;
            buttonSaveFilter.Click += buttonSaveFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 1;
            label1.Text = "По должности:";
            // 
            // comboBoxJob
            // 
            comboBoxJob.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJob.Font = new Font("Segoe UI", 14F);
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Location = new Point(27, 70);
            comboBoxJob.Margin = new Padding(3, 2, 3, 2);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(183, 33);
            comboBoxJob.Sorted = true;
            comboBoxJob.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1904, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleToolStripMenuItem, должностиToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(139, 22);
            scheduleToolStripMenuItem.Text = "Расписание";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(139, 22);
            должностиToolStripMenuItem.Text = "Должности";
            должностиToolStripMenuItem.Click += должностиToolStripMenuItem_Click;
            // 
            // buttonScheduleForEmployee
            // 
            buttonScheduleForEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonScheduleForEmployee.Font = new Font("Segoe UI", 16F);
            buttonScheduleForEmployee.Location = new Point(1620, 583);
            buttonScheduleForEmployee.Margin = new Padding(3, 2, 3, 2);
            buttonScheduleForEmployee.Name = "buttonScheduleForEmployee";
            buttonScheduleForEmployee.Size = new Size(240, 83);
            buttonScheduleForEmployee.TabIndex = 6;
            buttonScheduleForEmployee.Text = "Добавить расписание смен";
            buttonScheduleForEmployee.UseVisualStyleBackColor = true;
            buttonScheduleForEmployee.Click += buttonScheduleForEmployee_Click;
            // 
            // buttonEmployeePdfWeek
            // 
            buttonEmployeePdfWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEmployeePdfWeek.Font = new Font("Segoe UI", 14F);
            buttonEmployeePdfWeek.Location = new Point(1620, 686);
            buttonEmployeePdfWeek.Margin = new Padding(3, 2, 3, 2);
            buttonEmployeePdfWeek.Name = "buttonEmployeePdfWeek";
            buttonEmployeePdfWeek.Size = new Size(240, 92);
            buttonEmployeePdfWeek.TabIndex = 7;
            buttonEmployeePdfWeek.Text = "Получить расписание сотрудника на неделю";
            buttonEmployeePdfWeek.UseVisualStyleBackColor = true;
            buttonEmployeePdfWeek.Click += buttonEmployeePdf_Click;
            // 
            // buttonToPdfMonth
            // 
            buttonToPdfMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonToPdfMonth.Font = new Font("Segoe UI", 14F);
            buttonToPdfMonth.Location = new Point(1620, 807);
            buttonToPdfMonth.Margin = new Padding(3, 2, 3, 2);
            buttonToPdfMonth.Name = "buttonToPdfMonth";
            buttonToPdfMonth.Size = new Size(240, 87);
            buttonToPdfMonth.TabIndex = 8;
            buttonToPdfMonth.Text = "Получить расписание сотрудника на месяц";
            buttonToPdfMonth.UseVisualStyleBackColor = true;
            buttonToPdfMonth.Click += buttonToPdfMonth_Click;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(buttonToPdfMonth);
            Controls.Add(buttonEmployeePdfWeek);
            Controls.Add(buttonScheduleForEmployee);
            Controls.Add(groupBox1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormEmployees";
            Text = "Сотрудники";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem должностиToolStripMenuItem;
        private Button buttonDeteteFilter;
        private Button buttonScheduleForEmployee;
        private Button buttonEmployeePdfWeek;
        private Button buttonToPdfMonth;
    }
}