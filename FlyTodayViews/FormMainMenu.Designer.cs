namespace FlyTodayViews
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            pictureBox1 = new PictureBox();
            buttonMainSearch = new Button();
            buttonMainEnter = new Button();
            buttonMainRegistration = new Button();
            buttonMainLK = new Button();
            buttonEmployees = new Button();
            buttonSales = new Button();
            buttonDirections = new Button();
            buttonPlanes = new Button();
            buttonFlights = new Button();
            labelIsAuthorized = new Label();
            buttonExit = new Button();
            buttonSchedule = new Button();
            buttonStatisticTickets = new Button();
            buttonDirStatistics = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 149);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonMainSearch
            // 
            buttonMainSearch.BackColor = SystemColors.ActiveCaption;
            buttonMainSearch.Font = new Font("Segoe UI", 16F);
            buttonMainSearch.Location = new Point(246, 186);
            buttonMainSearch.Name = "buttonMainSearch";
            buttonMainSearch.Size = new Size(299, 51);
            buttonMainSearch.TabIndex = 1;
            buttonMainSearch.Text = "Поиск авиабилетов";
            buttonMainSearch.UseVisualStyleBackColor = false;
            buttonMainSearch.Click += buttonMainSearch_Click;
            // 
            // buttonMainEnter
            // 
            buttonMainEnter.BackColor = SystemColors.ActiveCaption;
            buttonMainEnter.Font = new Font("Segoe UI", 16F);
            buttonMainEnter.Location = new Point(246, 297);
            buttonMainEnter.Name = "buttonMainEnter";
            buttonMainEnter.Size = new Size(299, 51);
            buttonMainEnter.TabIndex = 2;
            buttonMainEnter.Text = "Вход";
            buttonMainEnter.UseVisualStyleBackColor = false;
            buttonMainEnter.Click += buttonMainEnter_Click;
            // 
            // buttonMainRegistration
            // 
            buttonMainRegistration.BackColor = SystemColors.ControlLightLight;
            buttonMainRegistration.Font = new Font("Segoe UI", 16F);
            buttonMainRegistration.Location = new Point(246, 351);
            buttonMainRegistration.Name = "buttonMainRegistration";
            buttonMainRegistration.Size = new Size(299, 51);
            buttonMainRegistration.TabIndex = 3;
            buttonMainRegistration.Text = "Регистрация";
            buttonMainRegistration.UseVisualStyleBackColor = false;
            buttonMainRegistration.Click += buttonMainRegistration_Click;
            // 
            // buttonMainLK
            // 
            buttonMainLK.BackColor = SystemColors.ActiveCaption;
            buttonMainLK.Font = new Font("Segoe UI", 16F);
            buttonMainLK.Location = new Point(246, 405);
            buttonMainLK.Name = "buttonMainLK";
            buttonMainLK.Size = new Size(299, 51);
            buttonMainLK.TabIndex = 4;
            buttonMainLK.Text = "Личный кабинет";
            buttonMainLK.UseVisualStyleBackColor = false;
            buttonMainLK.Click += buttonMainLK_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.BackColor = SystemColors.ControlLightLight;
            buttonEmployees.Font = new Font("Segoe UI", 12F);
            buttonEmployees.Location = new Point(14, 47);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(213, 67);
            buttonEmployees.TabIndex = 5;
            buttonEmployees.Text = "К подбору персонала";
            buttonEmployees.UseVisualStyleBackColor = false;
            buttonEmployees.Click += buttonEmployees_Click;
            // 
            // buttonSales
            // 
            buttonSales.BackColor = SystemColors.ControlLightLight;
            buttonSales.Font = new Font("Segoe UI", 12F);
            buttonSales.Location = new Point(14, 123);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(213, 67);
            buttonSales.TabIndex = 6;
            buttonSales.Text = "Льготы";
            buttonSales.UseVisualStyleBackColor = false;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonDirections
            // 
            buttonDirections.BackColor = SystemColors.ControlLightLight;
            buttonDirections.Font = new Font("Segoe UI", 12F);
            buttonDirections.Location = new Point(549, 21);
            buttonDirections.Margin = new Padding(3, 5, 3, 5);
            buttonDirections.Name = "buttonDirections";
            buttonDirections.Size = new Size(213, 67);
            buttonDirections.TabIndex = 7;
            buttonDirections.Text = "Направления";
            buttonDirections.UseVisualStyleBackColor = false;
            buttonDirections.Click += buttonDirections_Click;
            // 
            // buttonPlanes
            // 
            buttonPlanes.BackColor = SystemColors.ControlLightLight;
            buttonPlanes.Font = new Font("Segoe UI", 12F);
            buttonPlanes.Location = new Point(549, 97);
            buttonPlanes.Margin = new Padding(3, 5, 3, 5);
            buttonPlanes.Name = "buttonPlanes";
            buttonPlanes.Size = new Size(213, 64);
            buttonPlanes.TabIndex = 8;
            buttonPlanes.Text = "Самолеты";
            buttonPlanes.UseVisualStyleBackColor = false;
            buttonPlanes.Click += buttonPlanes_Click;
            // 
            // buttonFlights
            // 
            buttonFlights.BackColor = SystemColors.ControlLightLight;
            buttonFlights.Font = new Font("Segoe UI", 12F);
            buttonFlights.Location = new Point(550, 169);
            buttonFlights.Margin = new Padding(3, 5, 3, 5);
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Size = new Size(211, 63);
            buttonFlights.TabIndex = 9;
            buttonFlights.Text = "Рейсы";
            buttonFlights.UseVisualStyleBackColor = false;
            buttonFlights.Click += buttonFlights_Click;
            // 
            // labelIsAuthorized
            // 
            labelIsAuthorized.AutoSize = true;
            labelIsAuthorized.Location = new Point(14, 12);
            labelIsAuthorized.Name = "labelIsAuthorized";
            labelIsAuthorized.Size = new Size(50, 20);
            labelIsAuthorized.TabIndex = 10;
            labelIsAuthorized.Text = "label1";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ControlLightLight;
            buttonExit.Font = new Font("Segoe UI", 16F);
            buttonExit.Location = new Point(248, 460);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(299, 51);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSchedule
            // 
            buttonSchedule.BackColor = SystemColors.ControlLightLight;
            buttonSchedule.Font = new Font("Segoe UI", 14F);
            buttonSchedule.Location = new Point(246, 243);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(299, 51);
            buttonSchedule.TabIndex = 12;
            buttonSchedule.Text = "Расписание на сегодня";
            buttonSchedule.UseVisualStyleBackColor = false;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // buttonStatisticTickets
            // 
            buttonStatisticTickets.BackColor = SystemColors.ControlLightLight;
            buttonStatisticTickets.Font = new Font("Segoe UI", 12F);
            buttonStatisticTickets.Location = new Point(12, 197);
            buttonStatisticTickets.Margin = new Padding(3, 4, 3, 4);
            buttonStatisticTickets.Name = "buttonStatisticTickets";
            buttonStatisticTickets.Size = new Size(215, 65);
            buttonStatisticTickets.TabIndex = 13;
            buttonStatisticTickets.Text = "Статистика по продажам";
            buttonStatisticTickets.UseVisualStyleBackColor = false;
            buttonStatisticTickets.Click += buttonStatisticTickets_Click;
            // 
            // buttonDirStatistics
            // 
            buttonDirStatistics.BackColor = SystemColors.ControlLightLight;
            buttonDirStatistics.Location = new Point(551, 241);
            buttonDirStatistics.Margin = new Padding(3, 4, 3, 4);
            buttonDirStatistics.Name = "buttonDirStatistics";
            buttonDirStatistics.Size = new Size(211, 63);
            buttonDirStatistics.TabIndex = 13;
            buttonDirStatistics.Text = "Статистика по направлениям";
            buttonDirStatistics.UseVisualStyleBackColor = false;
            buttonDirStatistics.Click += buttonDirStatistics_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(773, 523);
            Controls.Add(buttonStatisticTickets);
            Controls.Add(buttonDirStatistics);
            Controls.Add(buttonExit);
            Controls.Add(buttonSchedule);
            Controls.Add(labelIsAuthorized);
            Controls.Add(buttonFlights);
            Controls.Add(buttonPlanes);
            Controls.Add(buttonDirections);
            Controls.Add(buttonSales);
            Controls.Add(buttonEmployees);
            Controls.Add(buttonMainLK);
            Controls.Add(buttonMainRegistration);
            Controls.Add(buttonMainEnter);
            Controls.Add(buttonMainSearch);
            Controls.Add(pictureBox1);
            Name = "FormMainMenu";
            Text = "Главная";
            FormClosed += FormMainMenu_FormClosed;
            Load += FormMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonMainSearch;
        private Button buttonMainEnter;
        private Button buttonMainRegistration;
        private Button buttonMainLK;
        private Button buttonEmployees;
        private Button buttonSales;
        private Button buttonDirections;
        private Button buttonPlanes;
        private Button buttonFlights;
        private Label labelIsAuthorized;
        private Button buttonExit;
        private Button buttonSchedule;
        private Button buttonStatisticTickets;
        private Button buttonDirStatistics;
    }
}