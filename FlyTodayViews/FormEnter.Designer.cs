namespace FlyTodayViews
{
    partial class FormEnter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEnter = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.None;
            buttonEnter.BackColor = SystemColors.ActiveCaption;
            buttonEnter.Cursor = Cursors.Hand;
            buttonEnter.Font = new Font("Segoe UI", 16F);
            buttonEnter.ForeColor = SystemColors.Desktop;
            buttonEnter.Location = new Point(368, 513);
            buttonEnter.Margin = new Padding(3, 2, 3, 2);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(300, 78);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Font = new Font("Segoe UI", 16F);
            textBoxEmail.Location = new Point(368, 220);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 36);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Font = new Font("Segoe UI", 16F);
            textBoxPassword.Location = new Point(368, 338);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(300, 36);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(554, 66);
            label1.Name = "label1";
            label1.Size = new Size(383, 54);
            label1.TabIndex = 3;
            label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(368, 178);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 4;
            label2.Text = "Введите e-mail:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(368, 287);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 5;
            label3.Text = "Введите пароль:";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13F);
            linkLabel1.Location = new Point(385, 411);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(271, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забыли пароль? Нажмите сюда";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_06_14_150221;
            pictureBox1.Location = new Point(782, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(782, 513);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(303, 78);
            button1.TabIndex = 10;
            button1.Text = "Назад в меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonMenu_Click;
            // 
            // FormEnter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1433, 786);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonEnter);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormEnter";
            Text = "Вход";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
