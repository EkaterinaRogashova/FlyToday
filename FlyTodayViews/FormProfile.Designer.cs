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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Личный кабинет";
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelFIO.Location = new Point(11, 31);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(35, 15);
            labelFIO.TabIndex = 1;
            labelFIO.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 62);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата рождения:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelDateOfBirth.Location = new Point(142, 62);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(61, 15);
            labelDateOfBirth.TabIndex = 5;
            labelDateOfBirth.Text = "01.01.2000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 88);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Электронная почта:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelEmail.Location = new Point(142, 88);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "example@mail.ru";
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(30, 218);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(303, 23);
            buttonUpd.TabIndex = 8;
            buttonUpd.Text = "Редактировать профиль";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(30, 247);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(303, 23);
            buttonDel.TabIndex = 9;
            buttonDel.Text = "Удалить профиль";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonMyRents
            // 
            buttonMyRents.Location = new Point(30, 189);
            buttonMyRents.Name = "buttonMyRents";
            buttonMyRents.Size = new Size(303, 23);
            buttonMyRents.TabIndex = 10;
            buttonMyRents.Text = "Мои бронирования";
            buttonMyRents.UseVisualStyleBackColor = true;
            buttonMyRents.Click += buttonMyRents_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFIO);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelDateOfBirth);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(30, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 117);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // checkBoxAllowNotif
            // 
            checkBoxAllowNotif.AutoSize = true;
            checkBoxAllowNotif.Location = new Point(171, 49);
            checkBoxAllowNotif.Name = "checkBoxAllowNotif";
            checkBoxAllowNotif.Size = new Size(162, 19);
            checkBoxAllowNotif.TabIndex = 12;
            checkBoxAllowNotif.Text = "Разрешить уведомления";
            checkBoxAllowNotif.UseVisualStyleBackColor = true;
            checkBoxAllowNotif.CheckedChanged += checkBoxAllowNotif_CheckedChanged;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 285);
            Controls.Add(checkBoxAllowNotif);
            Controls.Add(groupBox1);
            Controls.Add(buttonMyRents);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(label1);
            Name = "FormProfile";
            Text = "Профиль";
            Load += FormProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}