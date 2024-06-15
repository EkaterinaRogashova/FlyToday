namespace FlyTodayViews
{
    partial class FormRent
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
            buttonCreateRent = new Button();
            labelFlight = new Label();
            textBoxEconomy = new TextBox();
            label2 = new Label();
            label3 = new Label();
            labelDate = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxBusiness = new TextBox();
            label1 = new Label();
            labelFreePlacesBusiness = new Label();
            label4 = new Label();
            labelFreePlacesEconom = new Label();
            SuspendLayout();
            // 
            // buttonCreateRent
            // 
            buttonCreateRent.Anchor = AnchorStyles.None;
            buttonCreateRent.BackColor = SystemColors.ActiveCaption;
            buttonCreateRent.Font = new Font("Segoe UI", 16F);
            buttonCreateRent.Location = new Point(212, 378);
            buttonCreateRent.Margin = new Padding(3, 2, 3, 2);
            buttonCreateRent.Name = "buttonCreateRent";
            buttonCreateRent.Size = new Size(205, 55);
            buttonCreateRent.TabIndex = 0;
            buttonCreateRent.Text = "Создать";
            buttonCreateRent.UseVisualStyleBackColor = false;
            buttonCreateRent.Click += buttonCreateRent_Click;
            // 
            // labelFlight
            // 
            labelFlight.Anchor = AnchorStyles.None;
            labelFlight.AutoSize = true;
            labelFlight.Font = new Font("Segoe UI", 16F);
            labelFlight.Location = new Point(176, 56);
            labelFlight.MinimumSize = new Size(500, 0);
            labelFlight.Name = "labelFlight";
            labelFlight.Size = new Size(500, 30);
            labelFlight.TabIndex = 1;
            labelFlight.Text = "Ульяновск - Москва";
            // 
            // textBoxEconomy
            // 
            textBoxEconomy.Anchor = AnchorStyles.None;
            textBoxEconomy.Font = new Font("Segoe UI", 16F);
            textBoxEconomy.Location = new Point(110, 268);
            textBoxEconomy.Margin = new Padding(3, 2, 3, 2);
            textBoxEconomy.Name = "textBoxEconomy";
            textBoxEconomy.Size = new Size(382, 36);
            textBoxEconomy.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(105, 56);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 3;
            label2.Text = "Рейс:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(105, 100);
            label3.Name = "label3";
            label3.Size = new Size(152, 30);
            label3.TabIndex = 5;
            label3.Text = "Дата и время:";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.None;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 16F);
            labelDate.Location = new Point(264, 100);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(109, 30);
            labelDate.TabIndex = 4;
            labelDate.Text = "1 августа ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(110, 236);
            label5.Name = "label5";
            label5.Size = new Size(382, 30);
            label5.TabIndex = 6;
            label5.Text = "Количество билетов эконом-класса:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(110, 306);
            label6.Name = "label6";
            label6.Size = new Size(378, 30);
            label6.TabIndex = 8;
            label6.Text = "Количество билетов бизнес-класса:";
            // 
            // textBoxBusiness
            // 
            textBoxBusiness.Anchor = AnchorStyles.None;
            textBoxBusiness.Font = new Font("Segoe UI", 16F);
            textBoxBusiness.Location = new Point(110, 338);
            textBoxBusiness.Margin = new Padding(3, 2, 3, 2);
            textBoxBusiness.Name = "textBoxBusiness";
            textBoxBusiness.Size = new Size(382, 36);
            textBoxBusiness.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(105, 144);
            label1.Name = "label1";
            label1.Size = new Size(336, 30);
            label1.TabIndex = 10;
            label1.Text = "Свободных мест бизнесс-класс:";
            // 
            // labelFreePlacesBusiness
            // 
            labelFreePlacesBusiness.Anchor = AnchorStyles.None;
            labelFreePlacesBusiness.AutoSize = true;
            labelFreePlacesBusiness.Font = new Font("Segoe UI", 16F);
            labelFreePlacesBusiness.Location = new Point(467, 144);
            labelFreePlacesBusiness.Name = "labelFreePlacesBusiness";
            labelFreePlacesBusiness.Size = new Size(25, 30);
            labelFreePlacesBusiness.TabIndex = 9;
            labelFreePlacesBusiness.Text = "5";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(105, 188);
            label4.Name = "label4";
            label4.Size = new Size(330, 30);
            label4.TabIndex = 12;
            label4.Text = "Свободных мест эконом-класс:";
            // 
            // labelFreePlacesEconom
            // 
            labelFreePlacesEconom.Anchor = AnchorStyles.None;
            labelFreePlacesEconom.AutoSize = true;
            labelFreePlacesEconom.Font = new Font("Segoe UI", 16F);
            labelFreePlacesEconom.Location = new Point(467, 188);
            labelFreePlacesEconom.Name = "labelFreePlacesEconom";
            labelFreePlacesEconom.Size = new Size(25, 30);
            labelFreePlacesEconom.TabIndex = 11;
            labelFreePlacesEconom.Text = "5";
            // 
            // FormRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 472);
            Controls.Add(label4);
            Controls.Add(labelFreePlacesEconom);
            Controls.Add(label1);
            Controls.Add(labelFreePlacesBusiness);
            Controls.Add(label6);
            Controls.Add(textBoxBusiness);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(labelDate);
            Controls.Add(label2);
            Controls.Add(textBoxEconomy);
            Controls.Add(labelFlight);
            Controls.Add(buttonCreateRent);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormRent";
            Text = "Бронирование";
            Load += FormRent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreateRent;
        private Label labelFlight;
        private TextBox textBoxEconomy;
        private Label label2;
        private Label label3;
        private Label labelDate;
        private Label label5;
        private Label label6;
        private TextBox textBoxBusiness;
        private Label label1;
        private Label labelFreePlacesBusiness;
        private Label label4;
        private Label labelFreePlacesEconom;
    }
}