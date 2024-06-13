namespace FlyTodayViews
{
    partial class FormBordingPass
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
            panelEconom = new Panel();
            buttonRegistration = new Button();
            panelBusiness = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 0;
            label1.Text = "Места на рейсе";
            // 
            // panelEconom
            // 
            panelEconom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelEconom.AutoScroll = true;
            panelEconom.Location = new Point(12, 52);
            panelEconom.Name = "panelEconom";
            panelEconom.Size = new Size(469, 297);
            panelEconom.TabIndex = 1;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.ActiveCaption;
            buttonRegistration.Font = new Font("Segoe UI", 12F);
            buttonRegistration.ForeColor = SystemColors.ActiveCaptionText;
            buttonRegistration.Location = new Point(487, 49);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(199, 60);
            buttonRegistration.TabIndex = 2;
            buttonRegistration.Text = "Зарегистрировать";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // panelBusiness
            // 
            panelBusiness.AutoScroll = true;
            panelBusiness.Location = new Point(12, 379);
            panelBusiness.Name = "panelBusiness";
            panelBusiness.Size = new Size(469, 272);
            panelBusiness.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Эконом-класс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 356);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 5;
            label3.Text = "Бизнесс-класс";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(520, 112);
            label4.Name = "label4";
            label4.Size = new Size(123, 40);
            label4.TabIndex = 6;
            label4.Text = "Зеленые места -\r\nсвободные\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 164);
            label5.Name = "label5";
            label5.Size = new Size(124, 40);
            label5.TabIndex = 7;
            label5.Text = "Красные места -\r\nзанятые";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 217);
            label6.Name = "label6";
            label6.Size = new Size(161, 120);
            label6.TabIndex = 8;
            label6.Text = "Для того, чтобы\r\nпоменять выбранное\r\nместо - нажмите на \r\nэто место еще раз.\r\nА затем - выберите \r\nдругое.\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBordingPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 690);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelBusiness);
            Controls.Add(buttonRegistration);
            Controls.Add(panelEconom);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormBordingPass";
            Text = "Получение посадочного талона";
            Load += FormBordingPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelEconom;
        private Button buttonRegistration;
        private Panel panelBusiness;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}