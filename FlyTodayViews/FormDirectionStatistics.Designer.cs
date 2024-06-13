namespace FlyTodayViews
{
    partial class FormDirectionStatistics
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
            groupBoxDir = new GroupBox();
            labelPercent = new Label();
            labelTicketsCount = new Label();
            labelDir = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerDateTo = new DateTimePicker();
            label4 = new Label();
            dateTimePickerDateFrom = new DateTimePicker();
            label5 = new Label();
            buttonView = new Button();
            label6 = new Label();
            groupBoxDir.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(266, 12);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 37);
            label1.Size = new Size(283, 30);
            label1.TabIndex = 0;
            label1.Text = "Популярные направления";
            // 
            // groupBoxDir
            // 
            groupBoxDir.Controls.Add(labelPercent);
            groupBoxDir.Controls.Add(labelTicketsCount);
            groupBoxDir.Controls.Add(labelDir);
            groupBoxDir.Location = new Point(3, 4);
            groupBoxDir.Margin = new Padding(3, 4, 3, 4);
            groupBoxDir.Name = "groupBoxDir";
            groupBoxDir.Padding = new Padding(3, 4, 3, 4);
            groupBoxDir.Size = new Size(875, 56);
            groupBoxDir.TabIndex = 1;
            groupBoxDir.TabStop = false;
            groupBoxDir.Visible = false;
            // 
            // labelPercent
            // 
            labelPercent.AutoSize = true;
            labelPercent.Font = new Font("Microsoft Sans Serif", 9.75F);
            labelPercent.Location = new Point(717, 25);
            labelPercent.Location = new Point(627, 19);
            labelPercent.MinimumSize = new Size(33, 0);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(42, 20);
            labelPercent.TabIndex = 2;
            labelPercent.Text = "40%";
            // 
            // labelTicketsCount
            // 
            labelTicketsCount.AutoSize = true;
            labelTicketsCount.Font = new Font("Microsoft Sans Serif", 9.75F);
            labelTicketsCount.Location = new Point(434, 25);
            labelTicketsCount.Location = new Point(380, 19);
            labelTicketsCount.MinimumSize = new Size(25, 0);
            labelTicketsCount.Name = "labelTicketsCount";
            labelTicketsCount.Size = new Size(27, 20);
            labelTicketsCount.Size = new Size(25, 16);
            labelTicketsCount.TabIndex = 1;
            labelTicketsCount.Text = "18";
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic);
            labelDir.Location = new Point(19, 25);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(174, 20);
            labelDir.TabIndex = 0;
            labelDir.Text = "Ульяновск - Казань";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxDir);
            panel1.Location = new Point(3, 139);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 445);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 3;
            label2.Text = "Направление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(343, 115);
            label3.Name = "label3";
            label3.Size = new Size(281, 20);
            label3.TabIndex = 4;
            label3.Text = "Количество проданных билетов";
            // 
            // dateTimePickerDateTo
            // 
            dateTimePickerDateTo.Location = new Point(468, 72);
            dateTimePickerDateTo.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            dateTimePickerDateTo.Size = new Size(266, 27);
            dateTimePickerDateTo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 76);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 19;
            label4.Text = "по ";
            // 
            // dateTimePickerDateFrom
            // 
            dateTimePickerDateFrom.Location = new Point(159, 72);
            dateTimePickerDateFrom.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            dateTimePickerDateFrom.Size = new Size(266, 27);
            dateTimePickerDateFrom.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 76);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 17;
            label5.Text = "Выбрать период с ";
            // 
            // buttonView
            // 
            buttonView.Location = new Point(748, 71);
            buttonView.Margin = new Padding(3, 4, 3, 4);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(137, 31);
            buttonView.TabIndex = 21;
            buttonView.Text = "Сформировать";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(701, 113);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 22;
            label6.Text = "Проценты";
            // 
            // FormDirectionStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 600);
            Controls.Add(label6);
            Controls.Add(buttonView);
            Controls.Add(dateTimePickerDateTo);
            Controls.Add(label4);
            Controls.Add(dateTimePickerDateFrom);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDirectionStatistics";
            Text = "Статистика по направлениям";
            groupBoxDir.ResumeLayout(false);
            groupBoxDir.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxDir;
        private Label labelTicketsCount;
        private Label labelDir;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerDateTo;
        private Label label4;
        private DateTimePicker dateTimePickerDateFrom;
        private Label label5;
        private Button buttonView;
        private Label labelPercent;
        private Label label6;
    }
}