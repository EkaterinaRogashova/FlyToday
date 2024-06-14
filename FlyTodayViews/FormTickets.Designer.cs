namespace FlyTodayViews
{
    partial class FormTickets
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
            button2 = new Button();
            button1 = new Button();
            labelCost = new Label();
            label6 = new Label();
            labelDate = new Label();
            label4 = new Label();
            labelFlight = new Label();
            label1 = new Label();
            groupBoxTicket = new GroupBox();
            labelTypeTicket = new Label();
            checkedListBoxTypeDoc = new CheckedListBox();
            label13 = new Label();
            label10 = new Label();
            dateTimePickerBirth = new DateTimePicker();
            checkedListBoxGender = new CheckedListBox();
            textBoxCost = new TextBox();
            label14 = new Label();
            label16 = new Label();
            label15 = new Label();
            comboBoxSale = new ComboBox();
            checkBoxBags = new CheckBox();
            label12 = new Label();
            textBoxNumber = new TextBox();
            label11 = new Label();
            textBoxSeria = new TextBox();
            label9 = new Label();
            textBoxLastname = new TextBox();
            label8 = new Label();
            textBoxName = new TextBox();
            label7 = new Label();
            textBoxSurname = new TextBox();
            pnlTickets = new Panel();
            groupBox1.SuspendLayout();
            groupBoxTicket.SuspendLayout();
            pnlTickets.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(labelCost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelFlight);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(367, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Бронирование";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(7, 295);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(354, 32);
            button2.TabIndex = 7;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(7, 247);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(354, 32);
            button1.TabIndex = 6;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 12F);
            labelCost.Location = new Point(7, 172);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(46, 21);
            labelCost.TabIndex = 5;
            labelCost.Text = "5000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(5, 152);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 4;
            label6.Text = "Стоимость:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F);
            labelDate.Location = new Point(5, 109);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(75, 21);
            labelDate.TabIndex = 3;
            labelDate.Text = "1 августа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(5, 88);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 2;
            label4.Text = "Дата и время:";
            // 
            // labelFlight
            // 
            labelFlight.AutoSize = true;
            labelFlight.Font = new Font("Segoe UI", 12F);
            labelFlight.Location = new Point(5, 46);
            labelFlight.MinimumSize = new Size(350, 0);
            labelFlight.Name = "labelFlight";
            labelFlight.Size = new Size(350, 21);
            labelFlight.TabIndex = 1;
            labelFlight.Text = "Москва - Ульяновск";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(5, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Рейс:";
            // 
            // groupBoxTicket
            // 
            groupBoxTicket.BackColor = SystemColors.InactiveBorder;
            groupBoxTicket.Controls.Add(labelTypeTicket);
            groupBoxTicket.Controls.Add(checkedListBoxTypeDoc);
            groupBoxTicket.Controls.Add(label13);
            groupBoxTicket.Controls.Add(label10);
            groupBoxTicket.Controls.Add(dateTimePickerBirth);
            groupBoxTicket.Controls.Add(checkedListBoxGender);
            groupBoxTicket.Controls.Add(textBoxCost);
            groupBoxTicket.Controls.Add(label14);
            groupBoxTicket.Controls.Add(label16);
            groupBoxTicket.Controls.Add(label15);
            groupBoxTicket.Controls.Add(comboBoxSale);
            groupBoxTicket.Controls.Add(checkBoxBags);
            groupBoxTicket.Controls.Add(label12);
            groupBoxTicket.Controls.Add(textBoxNumber);
            groupBoxTicket.Controls.Add(label11);
            groupBoxTicket.Controls.Add(textBoxSeria);
            groupBoxTicket.Controls.Add(label9);
            groupBoxTicket.Controls.Add(textBoxLastname);
            groupBoxTicket.Controls.Add(label8);
            groupBoxTicket.Controls.Add(textBoxName);
            groupBoxTicket.Controls.Add(label7);
            groupBoxTicket.Controls.Add(textBoxSurname);
            groupBoxTicket.Enabled = false;
            groupBoxTicket.Location = new Point(3, 2);
            groupBoxTicket.Margin = new Padding(3, 2, 3, 2);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Padding = new Padding(3, 2, 3, 2);
            groupBoxTicket.Size = new Size(490, 225);
            groupBoxTicket.TabIndex = 1;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Билет №1";
            groupBoxTicket.Visible = false;
            // 
            // labelTypeTicket
            // 
            labelTypeTicket.AutoSize = true;
            labelTypeTicket.Location = new Point(424, 0);
            labelTypeTicket.Name = "labelTypeTicket";
            labelTypeTicket.Size = new Size(50, 15);
            labelTypeTicket.TabIndex = 30;
            labelTypeTicket.Text = "Эконом";
            // 
            // checkedListBoxTypeDoc
            // 
            checkedListBoxTypeDoc.FormattingEnabled = true;
            checkedListBoxTypeDoc.Items.AddRange(new object[] { "Паспорт", "Св. о рождении" });
            checkedListBoxTypeDoc.Location = new Point(300, 87);
            checkedListBoxTypeDoc.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxTypeDoc.Name = "checkedListBoxTypeDoc";
            checkedListBoxTypeDoc.Size = new Size(128, 22);
            checkedListBoxTypeDoc.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(18, 68);
            label13.Name = "label13";
            label13.Size = new Size(110, 19);
            label13.TabIndex = 20;
            label13.Text = "Дата рождения:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(300, 66);
            label10.Name = "label10";
            label10.Size = new Size(108, 19);
            label10.TabIndex = 14;
            label10.Text = "Вид документа:";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(18, 87);
            dateTimePickerBirth.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(128, 23);
            dateTimePickerBirth.TabIndex = 19;
            // 
            // checkedListBoxGender
            // 
            checkedListBoxGender.FormattingEnabled = true;
            checkedListBoxGender.Items.AddRange(new object[] { "М", "Ж" });
            checkedListBoxGender.Location = new Point(162, 87);
            checkedListBoxGender.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxGender.Name = "checkedListBoxGender";
            checkedListBoxGender.Size = new Size(128, 22);
            checkedListBoxGender.TabIndex = 28;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = Color.LightSteelBlue;
            textBoxCost.Location = new Point(300, 183);
            textBoxCost.Margin = new Padding(3, 2, 3, 2);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.ReadOnly = true;
            textBoxCost.Size = new Size(128, 23);
            textBoxCost.TabIndex = 27;
            textBoxCost.TextChanged += textBoxCost_Changed;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(162, 68);
            label14.Name = "label14";
            label14.Size = new Size(37, 19);
            label14.TabIndex = 24;
            label14.Text = "Пол:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(143, 183);
            label16.Name = "label16";
            label16.Size = new Size(139, 19);
            label16.TabIndex = 26;
            label16.Text = "Итоговая стоимость:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(300, 127);
            label15.Name = "label15";
            label15.Size = new Size(54, 19);
            label15.TabIndex = 25;
            label15.Text = "Льгота:";
            // 
            // comboBoxSale
            // 
            comboBoxSale.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Location = new Point(300, 146);
            comboBoxSale.Margin = new Padding(3, 2, 3, 2);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(128, 23);
            comboBoxSale.TabIndex = 23;
            // 
            // checkBoxBags
            // 
            checkBoxBags.AutoSize = true;
            checkBoxBags.Location = new Point(24, 185);
            checkBoxBags.Margin = new Padding(3, 2, 3, 2);
            checkBoxBags.Name = "checkBoxBags";
            checkBoxBags.Size = new Size(87, 19);
            checkBoxBags.TabIndex = 22;
            checkBoxBags.Text = "Доп. багаж";
            checkBoxBags.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(162, 128);
            label12.Name = "label12";
            label12.Size = new Size(55, 19);
            label12.TabIndex = 18;
            label12.Text = "Номер:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(162, 146);
            textBoxNumber.Margin = new Padding(3, 2, 3, 2);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(128, 23);
            textBoxNumber.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(24, 128);
            label11.Name = "label11";
            label11.Size = new Size(51, 19);
            label11.TabIndex = 16;
            label11.Text = "Серия:";
            // 
            // textBoxSeria
            // 
            textBoxSeria.Location = new Point(24, 146);
            textBoxSeria.Margin = new Padding(3, 2, 3, 2);
            textBoxSeria.Name = "textBoxSeria";
            textBoxSeria.Size = new Size(128, 23);
            textBoxSeria.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(300, 28);
            label9.Name = "label9";
            label9.Size = new Size(165, 19);
            label9.TabIndex = 12;
            label9.Text = "Отчество (при наличии):";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(300, 46);
            textBoxLastname.Margin = new Padding(3, 2, 3, 2);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(128, 23);
            textBoxLastname.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(162, 28);
            label8.Name = "label8";
            label8.Size = new Size(39, 19);
            label8.TabIndex = 10;
            label8.Text = "Имя:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(162, 46);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(128, 23);
            textBoxName.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(18, 28);
            label7.Name = "label7";
            label7.Size = new Size(69, 19);
            label7.TabIndex = 8;
            label7.Text = "Фамилия:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(18, 45);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(128, 23);
            textBoxSurname.TabIndex = 0;
            // 
            // pnlTickets
            // 
            pnlTickets.AutoScroll = true;
            pnlTickets.Controls.Add(groupBoxTicket);
            pnlTickets.Location = new Point(382, 9);
            pnlTickets.Margin = new Padding(3, 2, 3, 2);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(498, 377);
            pnlTickets.TabIndex = 2;
            // 
            // FormTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 395);
            Controls.Add(pnlTickets);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormTickets";
            Text = "Билеты";
            WindowState = FormWindowState.Maximized;
            Load += FormTicket_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxTicket.ResumeLayout(false);
            groupBoxTicket.PerformLayout();
            pnlTickets.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelCost;
        private Label label6;
        private Label labelDate;
        private Label label4;
        private Label labelFlight;
        private Label label1;
        private GroupBox groupBoxTicket;
        private Button button2;
        private Button button1;
        private Label label13;
        private DateTimePicker dateTimePickerBirth;
        private Label label12;
        private TextBox textBoxNumber;
        private Label label11;
        private TextBox textBoxSeria;
        private Label label10;
        private Label label9;
        private TextBox textBoxLastname;
        private Label label8;
        private TextBox textBoxName;
        private Label label7;
        private TextBox textBoxSurname;
        private TextBox textBoxCost;
        private Label label16;
        private Label label15;
        private Label label14;
        private ComboBox comboBoxSale;
        private CheckBox checkBoxBags;
        private Panel pnlTickets;
        private CheckedListBox checkedListBoxTypeDoc;
        private CheckedListBox checkedListBoxGender;
        private Label labelTypeTicket;
    }
}