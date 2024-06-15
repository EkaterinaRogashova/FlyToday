namespace FlyTodayViews
{
    partial class FormRentTickets
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
            pnlTickets = new Panel();
            groupBoxTicket = new GroupBox();
            labelBags = new Label();
            label8 = new Label();
            buttonSaveBoardingPass = new Button();
            labelPlace = new Label();
            label7 = new Label();
            buttonCreateBoardingPass = new Button();
            labelCost = new Label();
            labelType = new Label();
            labelDocument = new Label();
            labelFIO = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            pnlTickets.SuspendLayout();
            groupBoxTicket.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(880, 88);
            label1.Name = "label1";
            label1.Size = new Size(155, 54);
            label1.TabIndex = 0;
            label1.Text = "Билеты";
            // 
            // pnlTickets
            // 
            pnlTickets.Anchor = AnchorStyles.None;
            pnlTickets.AutoScroll = true;
            pnlTickets.Controls.Add(groupBoxTicket);
            pnlTickets.Location = new Point(355, 150);
            pnlTickets.Margin = new Padding(3, 2, 3, 2);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(1235, 688);
            pnlTickets.TabIndex = 1;
            // 
            // groupBoxTicket
            // 
            groupBoxTicket.Controls.Add(labelBags);
            groupBoxTicket.Controls.Add(label8);
            groupBoxTicket.Controls.Add(buttonSaveBoardingPass);
            groupBoxTicket.Controls.Add(labelPlace);
            groupBoxTicket.Controls.Add(label7);
            groupBoxTicket.Controls.Add(buttonCreateBoardingPass);
            groupBoxTicket.Controls.Add(labelCost);
            groupBoxTicket.Controls.Add(labelType);
            groupBoxTicket.Controls.Add(labelDocument);
            groupBoxTicket.Controls.Add(labelFIO);
            groupBoxTicket.Controls.Add(label5);
            groupBoxTicket.Controls.Add(label4);
            groupBoxTicket.Controls.Add(label3);
            groupBoxTicket.Controls.Add(label2);
            groupBoxTicket.Enabled = false;
            groupBoxTicket.Font = new Font("Segoe UI", 14F);
            groupBoxTicket.Location = new Point(10, 11);
            groupBoxTicket.Margin = new Padding(3, 2, 3, 2);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Padding = new Padding(3, 2, 3, 2);
            groupBoxTicket.Size = new Size(1222, 213);
            groupBoxTicket.TabIndex = 0;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Билет №1";
            groupBoxTicket.Visible = false;
            // 
            // labelBags
            // 
            labelBags.AutoSize = true;
            labelBags.Font = new Font("Segoe UI", 17F);
            labelBags.Location = new Point(154, 166);
            labelBags.MinimumSize = new Size(175, 0);
            labelBags.Name = "labelBags";
            labelBags.Size = new Size(175, 31);
            labelBags.TabIndex = 13;
            labelBags.Text = "Стоимость:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 17F);
            label8.Location = new Point(14, 166);
            label8.Name = "label8";
            label8.Size = new Size(135, 31);
            label8.TabIndex = 12;
            label8.Text = "Доп. багаж:";
            // 
            // buttonSaveBoardingPass
            // 
            buttonSaveBoardingPass.BackColor = SystemColors.ActiveCaption;
            buttonSaveBoardingPass.Font = new Font("Segoe UI", 12F);
            buttonSaveBoardingPass.Location = new Point(1010, 114);
            buttonSaveBoardingPass.Margin = new Padding(3, 2, 3, 2);
            buttonSaveBoardingPass.Name = "buttonSaveBoardingPass";
            buttonSaveBoardingPass.Size = new Size(172, 83);
            buttonSaveBoardingPass.TabIndex = 11;
            buttonSaveBoardingPass.Text = "Скачать\r\nпосадочный\r\nталон";
            buttonSaveBoardingPass.UseVisualStyleBackColor = false;
            buttonSaveBoardingPass.Click += buttonSaveBoardingPass_Click;
            // 
            // labelPlace
            // 
            labelPlace.AutoSize = true;
            labelPlace.Font = new Font("Segoe UI", 17F);
            labelPlace.Location = new Point(548, 76);
            labelPlace.MinimumSize = new Size(400, 0);
            labelPlace.Name = "labelPlace";
            labelPlace.Size = new Size(400, 31);
            labelPlace.TabIndex = 10;
            labelPlace.Text = "Стоимость:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F);
            label7.Location = new Point(457, 76);
            label7.Name = "label7";
            label7.Size = new Size(85, 31);
            label7.TabIndex = 9;
            label7.Text = "Место:";
            // 
            // buttonCreateBoardingPass
            // 
            buttonCreateBoardingPass.BackColor = SystemColors.ActiveCaption;
            buttonCreateBoardingPass.Font = new Font("Segoe UI", 12F);
            buttonCreateBoardingPass.Location = new Point(1010, 20);
            buttonCreateBoardingPass.Margin = new Padding(3, 2, 3, 2);
            buttonCreateBoardingPass.Name = "buttonCreateBoardingPass";
            buttonCreateBoardingPass.Size = new Size(172, 83);
            buttonCreateBoardingPass.TabIndex = 8;
            buttonCreateBoardingPass.Text = "Зарегистировать\r\nпосадочный\r\nталон";
            buttonCreateBoardingPass.UseVisualStyleBackColor = false;
            buttonCreateBoardingPass.Click += buttonCreateBoardingPass_Click;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 17F);
            labelCost.Location = new Point(592, 127);
            labelCost.MinimumSize = new Size(131, 0);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(131, 31);
            labelCost.TabIndex = 7;
            labelCost.Text = "Стоимость:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 17F);
            labelType.Location = new Point(155, 127);
            labelType.MinimumSize = new Size(175, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(175, 31);
            labelType.TabIndex = 6;
            labelType.Text = "Стоимость:";
            // 
            // labelDocument
            // 
            labelDocument.AutoSize = true;
            labelDocument.Font = new Font("Segoe UI", 17F);
            labelDocument.Location = new Point(154, 96);
            labelDocument.MinimumSize = new Size(250, 0);
            labelDocument.Name = "labelDocument";
            labelDocument.Size = new Size(250, 31);
            labelDocument.TabIndex = 5;
            labelDocument.Text = "Стоимость:";
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Font = new Font("Segoe UI", 17F);
            labelFIO.Location = new Point(155, 65);
            labelFIO.MinimumSize = new Size(280, 0);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(280, 31);
            labelFIO.TabIndex = 4;
            labelFIO.Text = "Стоимость:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F);
            label5.Location = new Point(457, 127);
            label5.Name = "label5";
            label5.Size = new Size(129, 31);
            label5.TabIndex = 3;
            label5.Text = "Стоимость:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F);
            label4.Location = new Point(15, 127);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 2;
            label4.Text = "Тип билета:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(29, 96);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 1;
            label3.Text = "Документ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(71, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 0;
            label2.Text = "ФИО:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(808, 860);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(308, 75);
            button1.TabIndex = 2;
            button1.Text = "Обновить данные";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormRentTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(pnlTickets);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormRentTickets";
            Text = "Билеты";
            WindowState = FormWindowState.Maximized;
            Load += FormRentTickets_Load;
            pnlTickets.ResumeLayout(false);
            groupBoxTicket.ResumeLayout(false);
            groupBoxTicket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlTickets;
        private GroupBox groupBoxTicket;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button buttonCreateBoardingPass;
        private Label labelCost;
        private Label labelType;
        private Label labelDocument;
        private Label labelFIO;
        private Label label5;
        private Label labelPlace;
        private Label label7;
        private Button button1;
        private Button buttonSaveBoardingPass;
        private Label labelBags;
        private Label label8;
    }
}