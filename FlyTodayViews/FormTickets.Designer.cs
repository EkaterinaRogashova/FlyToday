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
            dateTimePickerBirth = new DateTimePicker();
            checkedListBoxGender = new CheckedListBox();
            textBoxCost = new TextBox();
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(labelCost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelFlight);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(458, 1021);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Бронирование";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(52, 874);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(354, 74);
            button2.TabIndex = 7;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(52, 780);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(354, 74);
            button1.TabIndex = 6;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 18F);
            labelCost.Location = new Point(22, 369);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(66, 32);
            labelCost.TabIndex = 5;
            labelCost.Text = "5000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(22, 337);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 4;
            label6.Text = "Стоимость:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 18F);
            labelDate.Location = new Point(22, 269);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(113, 32);
            labelDate.TabIndex = 3;
            labelDate.Text = "1 августа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(22, 230);
            label4.Name = "label4";
            label4.Size = new Size(167, 32);
            label4.TabIndex = 2;
            label4.Text = "Дата и время:";
            // 
            // labelFlight
            // 
            labelFlight.AutoSize = true;
            labelFlight.Font = new Font("Segoe UI", 18F);
            labelFlight.Location = new Point(22, 160);
            labelFlight.MinimumSize = new Size(350, 0);
            labelFlight.Name = "labelFlight";
            labelFlight.Size = new Size(350, 32);
            labelFlight.TabIndex = 1;
            labelFlight.Text = "Москва - Ульяновск";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(22, 114);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 0;
            label1.Text = "Рейс:";
            // 
            // groupBoxTicket
            // 
            groupBoxTicket.AutoSize = true;
            groupBoxTicket.BackColor = SystemColors.InactiveBorder;
            groupBoxTicket.Controls.Add(labelTypeTicket);
            groupBoxTicket.Controls.Add(checkedListBoxTypeDoc);
            groupBoxTicket.Controls.Add(label13);
            groupBoxTicket.Controls.Add(dateTimePickerBirth);
            groupBoxTicket.Controls.Add(checkedListBoxGender);
            groupBoxTicket.Controls.Add(textBoxCost);
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
            groupBoxTicket.Font = new Font("Segoe UI", 13F);
            groupBoxTicket.Location = new Point(3, 2);
            groupBoxTicket.Margin = new Padding(3, 2, 3, 2);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Padding = new Padding(3, 2, 3, 2);
            groupBoxTicket.Size = new Size(1471, 371);
            groupBoxTicket.TabIndex = 1;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Билет №1";
            groupBoxTicket.Visible = false;
            // 
            // labelTypeTicket
            // 
            labelTypeTicket.AutoSize = true;
            labelTypeTicket.Font = new Font("Segoe UI", 20F);
            labelTypeTicket.Location = new Point(1291, 22);
            labelTypeTicket.Name = "labelTypeTicket";
            labelTypeTicket.Size = new Size(114, 37);
            labelTypeTicket.TabIndex = 30;
            labelTypeTicket.Text = "Эконом";
            // 
            // checkedListBoxTypeDoc
            // 
            checkedListBoxTypeDoc.Anchor = AnchorStyles.None;
            checkedListBoxTypeDoc.Font = new Font("Segoe UI", 18F);
            checkedListBoxTypeDoc.FormattingEnabled = true;
            checkedListBoxTypeDoc.Items.AddRange(new object[] { "Паспорт", "Св. о рождении" });
            checkedListBoxTypeDoc.Location = new Point(1010, 149);
            checkedListBoxTypeDoc.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxTypeDoc.Name = "checkedListBoxTypeDoc";
            checkedListBoxTypeDoc.Size = new Size(367, 72);
            checkedListBoxTypeDoc.TabIndex = 29;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(45, 139);
            label13.Name = "label13";
            label13.Size = new Size(189, 32);
            label13.TabIndex = 20;
            label13.Text = "Дата рождения:";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Anchor = AnchorStyles.None;
            dateTimePickerBirth.Font = new Font("Segoe UI", 18F);
            dateTimePickerBirth.Location = new Point(45, 178);
            dateTimePickerBirth.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(408, 39);
            dateTimePickerBirth.TabIndex = 19;
            // 
            // checkedListBoxGender
            // 
            checkedListBoxGender.Anchor = AnchorStyles.None;
            checkedListBoxGender.Font = new Font("Segoe UI", 18F);
            checkedListBoxGender.FormattingEnabled = true;
            checkedListBoxGender.Items.AddRange(new object[] { "М", "Ж" });
            checkedListBoxGender.Location = new Point(530, 149);
            checkedListBoxGender.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxGender.Name = "checkedListBoxGender";
            checkedListBoxGender.Size = new Size(384, 72);
            checkedListBoxGender.TabIndex = 28;
            // 
            // textBoxCost
            // 
            textBoxCost.Anchor = AnchorStyles.None;
            textBoxCost.BackColor = Color.LightSteelBlue;
            textBoxCost.Font = new Font("Segoe UI", 18F);
            textBoxCost.Location = new Point(1010, 304);
            textBoxCost.Margin = new Padding(3, 2, 3, 2);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.ReadOnly = true;
            textBoxCost.Size = new Size(367, 39);
            textBoxCost.TabIndex = 27;
            textBoxCost.TextChanged += textBoxCost_Changed;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F);
            label16.Location = new Point(693, 311);
            label16.Name = "label16";
            label16.Size = new Size(241, 32);
            label16.TabIndex = 26;
            label16.Text = "Итоговая стоимость:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F);
            label15.Location = new Point(1010, 219);
            label15.Name = "label15";
            label15.Size = new Size(92, 32);
            label15.TabIndex = 25;
            label15.Text = "Льгота:";
            // 
            // comboBoxSale
            // 
            comboBoxSale.Anchor = AnchorStyles.None;
            comboBoxSale.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSale.Font = new Font("Segoe UI", 18F);
            comboBoxSale.FormattingEnabled = true;
            comboBoxSale.Location = new Point(1010, 256);
            comboBoxSale.Margin = new Padding(3, 2, 3, 2);
            comboBoxSale.Name = "comboBoxSale";
            comboBoxSale.Size = new Size(367, 40);
            comboBoxSale.TabIndex = 23;
            // 
            // checkBoxBags
            // 
            checkBoxBags.Anchor = AnchorStyles.None;
            checkBoxBags.AutoSize = true;
            checkBoxBags.Font = new Font("Segoe UI", 18F);
            checkBoxBags.Location = new Point(45, 300);
            checkBoxBags.Margin = new Padding(3, 2, 3, 2);
            checkBoxBags.Name = "checkBoxBags";
            checkBoxBags.Size = new Size(155, 36);
            checkBoxBags.TabIndex = 22;
            checkBoxBags.Text = "Доп. багаж";
            checkBoxBags.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(530, 223);
            label12.Name = "label12";
            label12.Size = new Size(94, 32);
            label12.TabIndex = 18;
            label12.Text = "Номер:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Anchor = AnchorStyles.None;
            textBoxNumber.Font = new Font("Segoe UI", 18F);
            textBoxNumber.Location = new Point(530, 257);
            textBoxNumber.Margin = new Padding(3, 2, 3, 2);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(384, 39);
            textBoxNumber.TabIndex = 17;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(45, 219);
            label11.Name = "label11";
            label11.Size = new Size(87, 32);
            label11.TabIndex = 16;
            label11.Text = "Серия:";
            // 
            // textBoxSeria
            // 
            textBoxSeria.Anchor = AnchorStyles.None;
            textBoxSeria.Font = new Font("Segoe UI", 18F);
            textBoxSeria.Location = new Point(45, 257);
            textBoxSeria.Margin = new Padding(3, 2, 3, 2);
            textBoxSeria.Name = "textBoxSeria";
            textBoxSeria.Size = new Size(408, 39);
            textBoxSeria.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(1010, 59);
            label9.Name = "label9";
            label9.Size = new Size(287, 32);
            label9.TabIndex = 12;
            label9.Text = "Отчество (при наличии):";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Anchor = AnchorStyles.None;
            textBoxLastname.Font = new Font("Segoe UI", 18F);
            textBoxLastname.Location = new Point(1010, 96);
            textBoxLastname.Margin = new Padding(3, 2, 3, 2);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(367, 39);
            textBoxLastname.TabIndex = 11;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(530, 59);
            label8.Name = "label8";
            label8.Size = new Size(66, 32);
            label8.TabIndex = 10;
            label8.Text = "Имя:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Font = new Font("Segoe UI", 18F);
            textBoxName.Location = new Point(530, 93);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(384, 39);
            textBoxName.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(45, 59);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 8;
            label7.Text = "Фамилия:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.Font = new Font("Segoe UI", 18F);
            textBoxSurname.Location = new Point(45, 93);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(408, 39);
            textBoxSurname.TabIndex = 0;
            // 
            // pnlTickets
            // 
            pnlTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlTickets.AutoScroll = true;
            pnlTickets.Controls.Add(groupBoxTicket);
            pnlTickets.Location = new Point(474, 9);
            pnlTickets.Margin = new Padding(3, 2, 3, 2);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(1418, 1021);
            pnlTickets.TabIndex = 2;
            // 
            // FormTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
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
            pnlTickets.PerformLayout();
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
        private Label label9;
        private TextBox textBoxLastname;
        private Label label8;
        private TextBox textBoxName;
        private Label label7;
        private TextBox textBoxSurname;
        private TextBox textBoxCost;
        private Label label16;
        private Label label15;
        private ComboBox comboBoxSale;
        private CheckBox checkBoxBags;
        private Panel pnlTickets;
        private CheckedListBox checkedListBoxTypeDoc;
        private CheckedListBox checkedListBoxGender;
        private Label labelTypeTicket;
    }
}