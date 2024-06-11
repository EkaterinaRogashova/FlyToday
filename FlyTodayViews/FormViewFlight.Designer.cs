namespace FlyTodayViews
{
    partial class FormViewFlight
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
            labelDirection = new Label();
            label = new Label();
            label2 = new Label();
            labelDepartureDate = new Label();
            label3 = new Label();
            labelTimeInFlight = new Label();
            buttonRent = new Button();
            groupBox1 = new GroupBox();
            labelFreePlacesCountBusiness = new Label();
            label7 = new Label();
            labelBusinessPrice = new Label();
            labelEconomPrice = new Label();
            labelFreePlacesCountEconom = new Label();
            labelPlane = new Label();
            labelArrivalDate = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            buttonTrackPriceChanges = new Button();
            buttonTrasferInfo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDirection
            // 
            labelDirection.AutoSize = true;
            labelDirection.FlatStyle = FlatStyle.Flat;
            labelDirection.Font = new Font("Segoe UI", 20F, FontStyle.Italic);
            labelDirection.Location = new Point(34, 12);
            labelDirection.Name = "labelDirection";
            labelDirection.Size = new Size(322, 46);
            labelDirection.TabIndex = 0;
            labelDirection.Text = "Ульяновск - Москва";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F);
            label.Location = new Point(14, 41);
            label.Name = "label";
            label.Size = new Size(97, 20);
            label.TabIndex = 1;
            label.Text = "Дата вылета:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 41);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 4;
            label2.Text = "Дата прибытия:";
            // 
            // labelDepartureDate
            // 
            labelDepartureDate.AutoSize = true;
            labelDepartureDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelDepartureDate.Location = new Point(109, 41);
            labelDepartureDate.Name = "labelDepartureDate";
            labelDepartureDate.Size = new Size(118, 20);
            labelDepartureDate.TabIndex = 5;
            labelDepartureDate.Text = "01.01.2000 15:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 120);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Самолет:";
            // 
            // labelTimeInFlight
            // 
            labelTimeInFlight.AutoSize = true;
            labelTimeInFlight.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelTimeInFlight.Location = new Point(123, 81);
            labelTimeInFlight.Name = "labelTimeInFlight";
            labelTimeInFlight.Size = new Size(114, 20);
            labelTimeInFlight.TabIndex = 7;
            labelTimeInFlight.Text = "1 час 30 минут";
            // 
            // buttonRent
            // 
            buttonRent.Location = new Point(34, 357);
            buttonRent.Margin = new Padding(3, 4, 3, 4);
            buttonRent.Name = "buttonRent";
            buttonRent.Size = new Size(568, 31);
            buttonRent.TabIndex = 9;
            buttonRent.Text = "Забронировать";
            buttonRent.UseVisualStyleBackColor = true;
            buttonRent.Click += buttonRent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFreePlacesCountBusiness);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labelBusinessPrice);
            groupBox1.Controls.Add(labelEconomPrice);
            groupBox1.Controls.Add(labelFreePlacesCountEconom);
            groupBox1.Controls.Add(labelPlane);
            groupBox1.Controls.Add(labelArrivalDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelTimeInFlight);
            groupBox1.Controls.Add(labelDepartureDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(34, 88);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(568, 261);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            // 
            // labelFreePlacesCountBusiness
            // 
            labelFreePlacesCountBusiness.AutoSize = true;
            labelFreePlacesCountBusiness.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelFreePlacesCountBusiness.Location = new Point(498, 157);
            labelFreePlacesCountBusiness.Name = "labelFreePlacesCountBusiness";
            labelFreePlacesCountBusiness.Size = new Size(33, 20);
            labelFreePlacesCountBusiness.TabIndex = 18;
            labelFreePlacesCountBusiness.Text = "100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 157);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 17;
            label7.Text = "Бизнес-класса:";
            // 
            // labelBusinessPrice
            // 
            labelBusinessPrice.AutoSize = true;
            labelBusinessPrice.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelBusinessPrice.Location = new Point(262, 231);
            labelBusinessPrice.Name = "labelBusinessPrice";
            labelBusinessPrice.Size = new Size(33, 20);
            labelBusinessPrice.TabIndex = 16;
            labelBusinessPrice.Text = "100";
            // 
            // labelEconomPrice
            // 
            labelEconomPrice.AutoSize = true;
            labelEconomPrice.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelEconomPrice.Location = new Point(265, 193);
            labelEconomPrice.Name = "labelEconomPrice";
            labelEconomPrice.Size = new Size(33, 20);
            labelEconomPrice.TabIndex = 15;
            labelEconomPrice.Text = "100";
            // 
            // labelFreePlacesCountEconom
            // 
            labelFreePlacesCountEconom.AutoSize = true;
            labelFreePlacesCountEconom.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelFreePlacesCountEconom.Location = new Point(336, 157);
            labelFreePlacesCountEconom.Name = "labelFreePlacesCountEconom";
            labelFreePlacesCountEconom.Size = new Size(33, 20);
            labelFreePlacesCountEconom.TabIndex = 14;
            labelFreePlacesCountEconom.Text = "100";
            // 
            // labelPlane
            // 
            labelPlane.AutoSize = true;
            labelPlane.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelPlane.Location = new Point(86, 120);
            labelPlane.Name = "labelPlane";
            labelPlane.Size = new Size(81, 20);
            labelPlane.TabIndex = 13;
            labelPlane.Text = "Boeing 737";
            // 
            // labelArrivalDate
            // 
            labelArrivalDate.AutoSize = true;
            labelArrivalDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelArrivalDate.Location = new Point(415, 41);
            labelArrivalDate.Name = "labelArrivalDate";
            labelArrivalDate.Size = new Size(118, 20);
            labelArrivalDate.TabIndex = 12;
            labelArrivalDate.Text = "01.01.2000 16:30";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 231);
            label6.Name = "label6";
            label6.Size = new Size(242, 20);
            label6.TabIndex = 11;
            label6.Text = "Стоимость билета бизнес-класса:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 193);
            label5.Name = "label5";
            label5.Size = new Size(245, 20);
            label5.TabIndex = 10;
            label5.Text = "Стоимость билета эконом-класса:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 157);
            label4.Name = "label4";
            label4.Size = new Size(317, 20);
            label4.TabIndex = 9;
            label4.Text = "Количество свободных мест эконом-класса:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 81);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 8;
            label1.Text = "Время в пути:";
            // 
            // buttonTrackPriceChanges
            // 
            buttonTrackPriceChanges.Location = new Point(34, 396);
            buttonTrackPriceChanges.Margin = new Padding(3, 4, 3, 4);
            buttonTrackPriceChanges.Name = "buttonTrackPriceChanges";
            buttonTrackPriceChanges.Size = new Size(568, 31);
            buttonTrackPriceChanges.TabIndex = 12;
            buttonTrackPriceChanges.Text = "Отслеживать изменение цены";
            buttonTrackPriceChanges.UseVisualStyleBackColor = true;
            buttonTrackPriceChanges.Click += buttonTrackPriceChanges_Click;
            // 
            // buttonTrasferInfo
            // 
            buttonTrasferInfo.Location = new Point(327, 63);
            buttonTrasferInfo.Name = "buttonTrasferInfo";
            buttonTrasferInfo.Size = new Size(277, 32);
            buttonTrasferInfo.TabIndex = 13;
            buttonTrasferInfo.Text = "Посмотреть информацию о пересадке";
            buttonTrasferInfo.UseVisualStyleBackColor = true;
            buttonTrasferInfo.Click += buttonTrasferInfo_Click;
            // 
            // FormViewFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 439);
            Controls.Add(buttonTrasferInfo);
            Controls.Add(buttonTrackPriceChanges);
            Controls.Add(groupBox1);
            Controls.Add(buttonRent);
            Controls.Add(labelDirection);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormViewFlight";
            Text = "Информация о рейсе";
            Load += FormFlight_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDirection;
        private Label label;
        private Label label2;
        private Label labelDepartureDate;
        private Label label3;
        private Label labelTimeInFlight;
        private Button buttonRent;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label6;
        private Label labelArrivalDate;
        private Label labelBusinessPrice;
        private Label labelEconomPrice;
        private Label labelFreePlacesCountEconom;
        private Label labelPlane;
        private Button buttonTrackPriceChanges;
        private Button buttonTrasferInfo;
        private Label labelFreePlacesCountBusiness;
        private Label label7;
    }
}