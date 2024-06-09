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
            labelFreePlaces = new Label();
            SuspendLayout();
            // 
            // buttonCreateRent
            // 
            buttonCreateRent.BackColor = SystemColors.ActiveCaption;
            buttonCreateRent.Font = new Font("Segoe UI", 12F);
            buttonCreateRent.Location = new Point(120, 220);
            buttonCreateRent.Name = "buttonCreateRent";
            buttonCreateRent.Size = new Size(154, 49);
            buttonCreateRent.TabIndex = 0;
            buttonCreateRent.Text = "Создать";
            buttonCreateRent.UseVisualStyleBackColor = false;
            buttonCreateRent.Click += buttonCreateRent_Click;
            // 
            // labelFlight
            // 
            labelFlight.AutoSize = true;
            labelFlight.Font = new Font("Segoe UI", 12F);
            labelFlight.Location = new Point(187, 12);
            labelFlight.Name = "labelFlight";
            labelFlight.Size = new Size(196, 28);
            labelFlight.TabIndex = 1;
            labelFlight.Text = "Ульяновск - Москва";
            // 
            // textBoxEconomy
            // 
            textBoxEconomy.Location = new Point(12, 127);
            textBoxEconomy.Name = "textBoxEconomy";
            textBoxEconomy.Size = new Size(359, 27);
            textBoxEconomy.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(120, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Рейс:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(44, 40);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 5;
            label3.Text = "Дата и время:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F);
            labelDate.Location = new Point(187, 40);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(99, 28);
            labelDate.TabIndex = 4;
            labelDate.Text = "1 августа ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 96);
            label5.Name = "label5";
            label5.Size = new Size(346, 28);
            label5.TabIndex = 6;
            label5.Text = "Количество билетов эконом-класса:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(341, 28);
            label6.TabIndex = 8;
            label6.Text = "Количество билетов бизнес-класса:";
            // 
            // textBoxBusiness
            // 
            textBoxBusiness.Location = new Point(12, 188);
            textBoxBusiness.Name = "textBoxBusiness";
            textBoxBusiness.Size = new Size(359, 27);
            textBoxBusiness.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 68);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 10;
            label1.Text = "Свободных мест:";
            // 
            // labelFreePlaces
            // 
            labelFreePlaces.AutoSize = true;
            labelFreePlaces.Font = new Font("Segoe UI", 12F);
            labelFreePlaces.Location = new Point(187, 68);
            labelFreePlaces.Name = "labelFreePlaces";
            labelFreePlaces.Size = new Size(23, 28);
            labelFreePlaces.TabIndex = 9;
            labelFreePlaces.Text = "5";
            // 
            // FormRent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 281);
            Controls.Add(label1);
            Controls.Add(labelFreePlaces);
            Controls.Add(label6);
            Controls.Add(textBoxBusiness);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(labelDate);
            Controls.Add(label2);
            Controls.Add(textBoxEconomy);
            Controls.Add(labelFlight);
            Controls.Add(buttonCreateRent);
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
        private Label labelFreePlaces;
    }
}