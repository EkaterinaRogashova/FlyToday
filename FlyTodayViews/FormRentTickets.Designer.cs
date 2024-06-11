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
            buttonCreateBoardingPass = new Button();
            labelCost = new Label();
            labelType = new Label();
            labelDocument = new Label();
            labelFIO = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            pnlTickets.Controls.Add(groupBoxTicket);
            pnlTickets.Location = new Point(12, 49);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(776, 389);
            pnlTickets.TabIndex = 1;
            // 
            // groupBoxTicket
            // 
            groupBoxTicket.Controls.Add(buttonCreateBoardingPass);
            groupBoxTicket.Controls.Add(labelCost);
            groupBoxTicket.Controls.Add(labelType);
            groupBoxTicket.Controls.Add(labelDocument);
            groupBoxTicket.Controls.Add(labelFIO);
            groupBoxTicket.Controls.Add(label5);
            groupBoxTicket.Controls.Add(label4);
            groupBoxTicket.Controls.Add(label3);
            groupBoxTicket.Controls.Add(label2);
            groupBoxTicket.Location = new Point(12, 15);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Size = new Size(747, 129);
            groupBoxTicket.TabIndex = 0;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Билет №1";
            groupBoxTicket.Visible = false;
            // 
            // buttonCreateBoardingPass
            // 
            buttonCreateBoardingPass.BackColor = SystemColors.ActiveCaption;
            buttonCreateBoardingPass.Location = new Point(587, 23);
            buttonCreateBoardingPass.Name = "buttonCreateBoardingPass";
            buttonCreateBoardingPass.Size = new Size(141, 88);
            buttonCreateBoardingPass.TabIndex = 8;
            buttonCreateBoardingPass.Text = "Зарегистировать\r\nпосадочный\r\nталон";
            buttonCreateBoardingPass.UseVisualStyleBackColor = false;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(418, 91);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(86, 20);
            labelCost.TabIndex = 7;
            labelCost.Text = "Стоимость:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(111, 91);
            labelType.Name = "labelType";
            labelType.Size = new Size(86, 20);
            labelType.TabIndex = 6;
            labelType.Text = "Стоимость:";
            // 
            // labelDocument
            // 
            labelDocument.AutoSize = true;
            labelDocument.Location = new Point(111, 55);
            labelDocument.Name = "labelDocument";
            labelDocument.Size = new Size(86, 20);
            labelDocument.TabIndex = 5;
            labelDocument.Text = "Стоимость:";
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Location = new Point(111, 23);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(86, 20);
            labelFIO.TabIndex = 4;
            labelFIO.Text = "Стоимость:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 91);
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
            // FormRentTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlTickets);
            Controls.Add(label1);
            Name = "FormRentTickets";
            Text = "FormRentTickets";
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
    }
}