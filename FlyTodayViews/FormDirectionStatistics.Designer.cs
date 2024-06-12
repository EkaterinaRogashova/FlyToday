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
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 30);
            label1.TabIndex = 0;
            label1.Text = "Статистика по направлениям";
            // 
            // groupBoxDir
            // 
            groupBoxDir.Controls.Add(labelPercent);
            groupBoxDir.Controls.Add(labelTicketsCount);
            groupBoxDir.Controls.Add(labelDir);
            groupBoxDir.Location = new Point(3, 3);
            groupBoxDir.Name = "groupBoxDir";
            groupBoxDir.Size = new Size(744, 42);
            groupBoxDir.TabIndex = 1;
            groupBoxDir.TabStop = false;
            groupBoxDir.Visible = false;
            // 
            // labelPercent
            // 
            labelPercent.AutoSize = true;
            labelPercent.Font = new Font("Microsoft Sans Serif", 9.75F);
            labelPercent.Location = new Point(627, 19);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(33, 16);
            labelPercent.TabIndex = 2;
            labelPercent.Text = "40%";
            // 
            // labelTicketsCount
            // 
            labelTicketsCount.AutoSize = true;
            labelTicketsCount.Font = new Font("Microsoft Sans Serif", 9.75F);
            labelTicketsCount.Location = new Point(380, 19);
            labelTicketsCount.Name = "labelTicketsCount";
            labelTicketsCount.Size = new Size(21, 16);
            labelTicketsCount.TabIndex = 1;
            labelTicketsCount.Text = "18";
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic);
            labelDir.Location = new Point(17, 19);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(133, 16);
            labelDir.TabIndex = 0;
            labelDir.Text = "Ульяновск - Казань";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxDir);
            panel1.Location = new Point(3, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 334);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 3;
            label2.Text = "Направление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(300, 86);
            label3.Name = "label3";
            label3.Size = new Size(217, 16);
            label3.TabIndex = 4;
            label3.Text = "Количество проданных билетов";
            // 
            // dateTimePickerDateTo
            // 
            dateTimePickerDateTo.Location = new Point(386, 51);
            dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            dateTimePickerDateTo.Size = new Size(233, 23);
            dateTimePickerDateTo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 57);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 19;
            label4.Text = "по ";
            // 
            // dateTimePickerDateFrom
            // 
            dateTimePickerDateFrom.Location = new Point(126, 51);
            dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            dateTimePickerDateFrom.Size = new Size(233, 23);
            dateTimePickerDateFrom.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 57);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 17;
            label5.Text = "Выбрать период с ";
            // 
            // buttonView
            // 
            buttonView.Location = new Point(633, 51);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(120, 23);
            buttonView.TabIndex = 21;
            buttonView.Text = "Сформировать";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(613, 85);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 22;
            label6.Text = "Проценты";
            // 
            // FormDirectionStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 450);
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