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
            labelSurname = new Label();
            labelName = new Label();
            labelLastName = new Label();
            label2 = new Label();
            labelDateOfBirth = new Label();
            label3 = new Label();
            labelEmail = new Label();
            buttonUpd = new Button();
            buttonDel = new Button();
            buttonMyRents = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Личный кабинет";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(46, 80);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(38, 15);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "label2";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(142, 79);
            labelName.Name = "labelName";
            labelName.Size = new Size(38, 15);
            labelName.TabIndex = 2;
            labelName.Text = "label2";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(249, 80);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(38, 15);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 138);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата рождения:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(176, 138);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(38, 15);
            labelDateOfBirth.TabIndex = 5;
            labelDateOfBirth.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 190);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Электронная почта:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(195, 190);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(38, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "label3";
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(569, 34);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(127, 23);
            buttonUpd.TabIndex = 8;
            buttonUpd.Text = "Редактировать";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(570, 76);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(126, 23);
            buttonDel.TabIndex = 9;
            buttonDel.Text = "Удалить профиль";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonMyRents
            // 
            buttonMyRents.Location = new Point(569, 120);
            buttonMyRents.Name = "buttonMyRents";
            buttonMyRents.Size = new Size(127, 23);
            buttonMyRents.TabIndex = 10;
            buttonMyRents.Text = "Мои бронирования";
            buttonMyRents.UseVisualStyleBackColor = true;
            buttonMyRents.Click += buttonMyRents_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMyRents);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(labelEmail);
            Controls.Add(label3);
            Controls.Add(labelDateOfBirth);
            Controls.Add(label2);
            Controls.Add(labelLastName);
            Controls.Add(labelName);
            Controls.Add(labelSurname);
            Controls.Add(label1);
            Name = "FormProfile";
            Text = "Профиль";
            Load += FormProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSurname;
        private Label labelName;
        private Label labelLastName;
        private Label label2;
        private Label labelDateOfBirth;
        private Label label3;
        private Label labelEmail;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonMyRents;
    }
}