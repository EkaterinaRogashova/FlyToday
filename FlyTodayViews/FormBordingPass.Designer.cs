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
            labelProhod2 = new Label();
            labelProhod1 = new Label();
            buttonRegistration = new Button();
            panelBusiness = new Panel();
            labelProhod3 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panelEconom.SuspendLayout();
            panelBusiness.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(214, 7);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Места на рейсе";
            // 
            // panelEconom
            // 
            panelEconom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelEconom.AutoScroll = true;
            panelEconom.Controls.Add(labelProhod2);
            panelEconom.Controls.Add(labelProhod1);
            panelEconom.Location = new Point(12, 42);
            panelEconom.Margin = new Padding(3, 2, 3, 2);
            panelEconom.Name = "panelEconom";
            panelEconom.Size = new Size(543, 307);
            panelEconom.TabIndex = 1;
            // 
            // labelProhod2
            // 
            labelProhod2.AutoSize = true;
            labelProhod2.Font = new Font("Segoe UI", 9F);
            labelProhod2.Location = new Point(309, 3);
            labelProhod2.Name = "labelProhod2";
            labelProhod2.Size = new Size(16, 90);
            labelProhod2.TabIndex = 10;
            labelProhod2.Text = "П\r\nР\r\nО\r\nХ\r\nО\r\nД";
            labelProhod2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProhod1
            // 
            labelProhod1.AutoSize = true;
            labelProhod1.BackColor = Color.Transparent;
            labelProhod1.Font = new Font("Segoe UI", 9F);
            labelProhod1.Location = new Point(138, 3);
            labelProhod1.Name = "labelProhod1";
            labelProhod1.Size = new Size(16, 90);
            labelProhod1.TabIndex = 9;
            labelProhod1.Text = "П\r\nР\r\nО\r\nХ\r\nО\r\nД";
            labelProhod1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.ActiveCaption;
            buttonRegistration.Font = new Font("Segoe UI", 12F);
            buttonRegistration.ForeColor = SystemColors.ActiveCaptionText;
            buttonRegistration.Location = new Point(589, 45);
            buttonRegistration.Margin = new Padding(3, 2, 3, 2);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(174, 45);
            buttonRegistration.TabIndex = 2;
            buttonRegistration.Text = "Зарегистрировать";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // panelBusiness
            // 
            panelBusiness.AutoScroll = true;
            panelBusiness.Controls.Add(labelProhod3);
            panelBusiness.Location = new Point(9, 368);
            panelBusiness.Margin = new Padding(3, 2, 3, 2);
            panelBusiness.Name = "panelBusiness";
            panelBusiness.Size = new Size(546, 276);
            panelBusiness.TabIndex = 3;
            // 
            // labelProhod3
            // 
            labelProhod3.AutoSize = true;
            labelProhod3.BackColor = Color.Transparent;
            labelProhod3.Font = new Font("Segoe UI", 9F);
            labelProhod3.Location = new Point(141, 10);
            labelProhod3.Name = "labelProhod3";
            labelProhod3.Size = new Size(16, 90);
            labelProhod3.TabIndex = 11;
            labelProhod3.Text = "П\r\nР\r\nО\r\nХ\r\nО\r\nД";
            labelProhod3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 22);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Эконом-класс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 351);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Бизнесс-класс";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(626, 168);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 6;
            label4.Text = "Зеленые места -\r\nсвободные\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(626, 119);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 7;
            label5.Text = "Красные места -\r\nзанятые";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(614, 220);
            label6.Name = "label6";
            label6.Size = new Size(125, 90);
            label6.TabIndex = 8;
            label6.Text = "Для того, чтобы\r\nпоменять выбранное\r\nместо - нажмите на \r\nэто место еще раз.\r\nА затем - выберите \r\nдругое.\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBordingPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(813, 685);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelBusiness);
            Controls.Add(buttonRegistration);
            Controls.Add(panelEconom);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormBordingPass";
            Text = "Получение посадочного талона";
            Load += FormBordingPass_Load;
            panelEconom.ResumeLayout(false);
            panelEconom.PerformLayout();
            panelBusiness.ResumeLayout(false);
            panelBusiness.PerformLayout();
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
        private Label labelProhod1;
        private Label labelProhod2;
        private Label labelProhod3;
    }
}