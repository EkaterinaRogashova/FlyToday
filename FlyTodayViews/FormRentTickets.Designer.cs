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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(350, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Билеты";
            // 
            // pnlTickets
            // 
            pnlTickets.AutoScroll = true;
            pnlTickets.Controls.Add(groupBoxTicket);
            pnlTickets.Location = new Point(12, 49);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(776, 311);
            pnlTickets.TabIndex = 1;
            // 
            // groupBoxTicket
            // 
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
            groupBoxTicket.Location = new Point(12, 15);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Size = new Size(747, 129);
            groupBoxTicket.TabIndex = 0;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Билет №1";
            groupBoxTicket.Visible = false;
            // 
            // labelPlace
            // 
            labelPlace.AutoSize = true;
            labelPlace.Location = new Point(378, 23);
            labelPlace.MinimumSize = new Size(250, 0);
            labelPlace.Name = "labelPlace";
            labelPlace.Size = new Size(250, 20);
            labelPlace.TabIndex = 10;
            labelPlace.Text = "Стоимость:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 23);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 9;
            label7.Text = "Место:";
            // 
            // buttonCreateBoardingPass
            // 
            buttonCreateBoardingPass.BackColor = SystemColors.ActiveCaption;
            buttonCreateBoardingPass.Location = new Point(588, 46);
            buttonCreateBoardingPass.Name = "buttonCreateBoardingPass";
            buttonCreateBoardingPass.Size = new Size(141, 68);
            buttonCreateBoardingPass.TabIndex = 8;
            buttonCreateBoardingPass.Text = "Зарегистировать\r\nпосадочный\r\nталон";
            buttonCreateBoardingPass.UseVisualStyleBackColor = false;
            buttonCreateBoardingPass.Click += buttonCreateBoardingPass_Click;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(409, 91);
            labelCost.MinimumSize = new Size(150, 0);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(150, 20);
            labelCost.TabIndex = 7;
            labelCost.Text = "Стоимость:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(111, 91);
            labelType.MinimumSize = new Size(200, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(200, 20);
            labelType.TabIndex = 6;
            labelType.Text = "Стоимость:";
            // 
            // labelDocument
            // 
            labelDocument.AutoSize = true;
            labelDocument.Location = new Point(111, 55);
            labelDocument.MinimumSize = new Size(200, 0);
            labelDocument.Name = "labelDocument";
            labelDocument.Size = new Size(200, 20);
            labelDocument.TabIndex = 5;
            labelDocument.Text = "Стоимость:";
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Location = new Point(111, 23);
            labelFIO.MinimumSize = new Size(200, 0);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(200, 20);
            labelFIO.TabIndex = 4;
            labelFIO.Text = "Стоимость:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 91);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 3;
            label5.Text = "Стоимость:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 91);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 2;
            label4.Text = "Тип билета:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 55);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Документ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "ФИО:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(291, 382);
            button1.Name = "button1";
            button1.Size = new Size(202, 56);
            button1.TabIndex = 2;
            button1.Text = "Обновить данные";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormRentTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pnlTickets);
            Controls.Add(label1);
            Name = "FormRentTickets";
            Text = "Билеты";
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
    }
}