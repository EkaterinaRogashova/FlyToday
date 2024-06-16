namespace FlyTodayViews
{
    partial class FormProfile
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
            labelFIO = new Label();
            label2 = new Label();
            labelDateOfBirth = new Label();
            label3 = new Label();
            labelEmail = new Label();
            buttonUpd = new Button();
            buttonDel = new Button();
            buttonMyRents = new Button();
            groupBox1 = new GroupBox();
            checkBoxAllowNotif = new CheckBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            buttonTickets = new Button();
            buttonCreateBoardingPass = new Button();
            buttonAddToArhiv = new Button();
            buttonArchive = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(123, 44);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Личный кабинет";
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            labelFIO.Location = new Point(11, 40);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(47, 21);
            labelFIO.TabIndex = 1;
            labelFIO.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 79);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 4;
            label2.Text = "Дата рождения:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            labelDateOfBirth.Location = new Point(152, 79);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(88, 21);
            labelDateOfBirth.TabIndex = 5;
            labelDateOfBirth.Text = "01.01.2000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 6;
            label3.Text = "Электронная почта:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            labelEmail.Location = new Point(164, 112);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(133, 21);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "example@mail.ru";
            // 
            // buttonUpd
            // 
            buttonUpd.Anchor = AnchorStyles.None;
            buttonUpd.BackColor = SystemColors.ActiveCaption;
            buttonUpd.Font = new Font("Segoe UI", 14F);
            buttonUpd.Location = new Point(32, 327);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(378, 64);
            buttonUpd.TabIndex = 8;
            buttonUpd.Text = "Редактировать профиль";
            buttonUpd.UseVisualStyleBackColor = false;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Anchor = AnchorStyles.None;
            buttonDel.Font = new Font("Segoe UI", 14F);
            buttonDel.Location = new Point(32, 422);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(378, 64);
            buttonDel.TabIndex = 9;
            buttonDel.Text = "Удалить профиль";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonMyRents
            // 
            buttonMyRents.Anchor = AnchorStyles.None;
            buttonMyRents.BackColor = SystemColors.ActiveCaption;
            buttonMyRents.Font = new Font("Segoe UI", 14F);
            buttonMyRents.Location = new Point(32, 508);
            buttonMyRents.Name = "buttonMyRents";
            buttonMyRents.Size = new Size(378, 64);
            buttonMyRents.TabIndex = 10;
            buttonMyRents.Text = "В главное меню";
            buttonMyRents.UseVisualStyleBackColor = false;
            buttonMyRents.Click += buttonMyRents_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(labelFIO);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelDateOfBirth);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(32, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 180);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // checkBoxAllowNotif
            // 
            checkBoxAllowNotif.Anchor = AnchorStyles.None;
            checkBoxAllowNotif.AutoSize = true;
            checkBoxAllowNotif.Font = new Font("Segoe UI", 12F);
            checkBoxAllowNotif.Location = new Point(204, 98);
            checkBoxAllowNotif.Name = "checkBoxAllowNotif";
            checkBoxAllowNotif.Size = new Size(206, 25);
            checkBoxAllowNotif.TabIndex = 12;
            checkBoxAllowNotif.Text = "Разрешить уведомления";
            checkBoxAllowNotif.UseVisualStyleBackColor = true;
            checkBoxAllowNotif.CheckedChanged += checkBoxAllowNotif_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(772, 44);
            label4.Name = "label4";
            label4.Size = new Size(266, 37);
            label4.TabIndex = 13;
            label4.Text = "Мои бронирования";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.GrayText;
            dataGridView1.Location = new Point(501, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(788, 271);
            dataGridView1.TabIndex = 14;
            // 
            // buttonTickets
            // 
            buttonTickets.Anchor = AnchorStyles.None;
            buttonTickets.BackColor = SystemColors.ActiveCaption;
            buttonTickets.Font = new Font("Segoe UI", 14F);
            buttonTickets.Location = new Point(501, 406);
            buttonTickets.Name = "buttonTickets";
            buttonTickets.Size = new Size(378, 64);
            buttonTickets.TabIndex = 15;
            buttonTickets.Text = "Оформить билеты";
            buttonTickets.UseVisualStyleBackColor = false;
            buttonTickets.Click += buttonTickets_Click;
            // 
            // buttonCreateBoardingPass
            // 
            buttonCreateBoardingPass.Anchor = AnchorStyles.None;
            buttonCreateBoardingPass.BackColor = SystemColors.ActiveCaption;
            buttonCreateBoardingPass.Font = new Font("Segoe UI", 14F);
            buttonCreateBoardingPass.Location = new Point(911, 406);
            buttonCreateBoardingPass.Name = "buttonCreateBoardingPass";
            buttonCreateBoardingPass.Size = new Size(378, 64);
            buttonCreateBoardingPass.TabIndex = 16;
            buttonCreateBoardingPass.Text = "Посмотреть билеты и зарегистрироваться";
            buttonCreateBoardingPass.UseVisualStyleBackColor = false;
            buttonCreateBoardingPass.Click += buttonCreateBoardingPass_Click;
            // 
            // buttonAddToArhiv
            // 
            buttonAddToArhiv.Anchor = AnchorStyles.None;
            buttonAddToArhiv.Font = new Font("Segoe UI", 14F);
            buttonAddToArhiv.Location = new Point(501, 508);
            buttonAddToArhiv.Name = "buttonAddToArhiv";
            buttonAddToArhiv.Size = new Size(378, 64);
            buttonAddToArhiv.TabIndex = 17;
            buttonAddToArhiv.Text = "Добавить в архив";
            buttonAddToArhiv.UseVisualStyleBackColor = true;
            // 
            // buttonArchive
            // 
            buttonArchive.Anchor = AnchorStyles.None;
            buttonArchive.Font = new Font("Segoe UI", 14F);
            buttonArchive.Location = new Point(911, 508);
            buttonArchive.Name = "buttonArchive";
            buttonArchive.Size = new Size(378, 64);
            buttonArchive.TabIndex = 18;
            buttonArchive.Text = "Архив";
            buttonArchive.UseVisualStyleBackColor = true;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1332, 637);
            Controls.Add(buttonArchive);
            Controls.Add(buttonAddToArhiv);
            Controls.Add(buttonCreateBoardingPass);
            Controls.Add(buttonTickets);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(checkBoxAllowNotif);
            Controls.Add(groupBox1);
            Controls.Add(buttonMyRents);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormProfile";
            Text = "Профиль";
            WindowState = FormWindowState.Maximized;
            Load += FormProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelFIO;
        private Label label2;
        private Label labelDateOfBirth;
        private Label label3;
        private Label labelEmail;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonMyRents;
        private GroupBox groupBox1;
        private CheckBox checkBoxAllowNotif;
        private Label label4;
        private DataGridView dataGridView1;
        private Button buttonTickets;
        private Button buttonCreateBoardingPass;
        private Button buttonAddToArhiv;
        private Button buttonArchive;
    }
}