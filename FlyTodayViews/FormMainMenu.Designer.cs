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
            components = new System.ComponentModel.Container();
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
            slider = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slider).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 58);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 180);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonMainSearch
            // 
            buttonMainSearch.Anchor = AnchorStyles.None;
            buttonMainSearch.AutoSize = true;
            buttonMainSearch.BackColor = SystemColors.ActiveCaption;
            buttonMainSearch.Font = new Font("Segoe UI", 16F);
            buttonMainSearch.Location = new Point(524, 256);
            buttonMainSearch.Margin = new Padding(3, 2, 3, 2);
            buttonMainSearch.Name = "buttonMainSearch";
            buttonMainSearch.Size = new Size(280, 59);
            buttonMainSearch.TabIndex = 1;
            buttonMainSearch.Text = "Поиск авиабилетов";
            buttonMainSearch.UseVisualStyleBackColor = false;
            buttonMainSearch.Click += buttonMainSearch_Click;
            // 
            // buttonMainEnter
            // 
            buttonMainEnter.Anchor = AnchorStyles.None;
            buttonMainEnter.BackColor = SystemColors.ActiveCaption;
            buttonMainEnter.Font = new Font("Segoe UI", 16F);
            buttonMainEnter.Location = new Point(524, 420);
            buttonMainEnter.Margin = new Padding(3, 2, 3, 2);
            buttonMainEnter.Name = "buttonMainEnter";
            buttonMainEnter.Size = new Size(280, 57);
            buttonMainEnter.TabIndex = 2;
            buttonMainEnter.Text = "Вход";
            buttonMainEnter.UseVisualStyleBackColor = false;
            buttonMainEnter.Click += buttonMainEnter_Click;
            // 
            // buttonMainRegistration
            // 
            buttonMainRegistration.Anchor = AnchorStyles.None;
            buttonMainRegistration.BackColor = SystemColors.ControlLightLight;
            buttonMainRegistration.Font = new Font("Segoe UI", 16F);
            buttonMainRegistration.Location = new Point(524, 501);
            buttonMainRegistration.Margin = new Padding(3, 2, 3, 2);
            buttonMainRegistration.Name = "buttonMainRegistration";
            buttonMainRegistration.Size = new Size(280, 57);
            buttonMainRegistration.TabIndex = 3;
            buttonMainRegistration.Text = "Регистрация";
            buttonMainRegistration.UseVisualStyleBackColor = false;
            buttonMainRegistration.Click += buttonMainRegistration_Click;
            // 
            // buttonMainLK
            // 
            buttonMainLK.Anchor = AnchorStyles.None;
            buttonMainLK.BackColor = SystemColors.ActiveCaption;
            buttonMainLK.Font = new Font("Segoe UI", 16F);
            buttonMainLK.Location = new Point(524, 582);
            buttonMainLK.Margin = new Padding(3, 2, 3, 2);
            buttonMainLK.Name = "buttonMainLK";
            buttonMainLK.Size = new Size(280, 57);
            buttonMainLK.TabIndex = 4;
            buttonMainLK.Text = "Личный кабинет";
            buttonMainLK.UseVisualStyleBackColor = false;
            buttonMainLK.Click += buttonMainLK_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Anchor = AnchorStyles.None;
            buttonEmployees.AutoSize = true;
            buttonEmployees.BackColor = SystemColors.ControlLightLight;
            buttonEmployees.Font = new Font("Segoe UI", 9F);
            buttonEmployees.Location = new Point(421, 22);
            buttonEmployees.Margin = new Padding(3, 2, 3, 2);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(185, 30);
            buttonEmployees.TabIndex = 5;
            buttonEmployees.Text = "К подбору персонала";
            buttonEmployees.UseVisualStyleBackColor = false;
            buttonEmployees.Click += buttonEmployees_Click;
            // 
            // buttonSales
            // 
            buttonSales.Anchor = AnchorStyles.None;
            buttonSales.AutoSize = true;
            buttonSales.BackColor = SystemColors.ControlLightLight;
            buttonSales.Font = new Font("Segoe UI", 9F);
            buttonSales.Location = new Point(212, 22);
            buttonSales.Margin = new Padding(3, 2, 3, 2);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(185, 31);
            buttonSales.TabIndex = 6;
            buttonSales.Text = "Льготы";
            buttonSales.UseVisualStyleBackColor = false;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonDirections
            // 
            buttonDirections.Anchor = AnchorStyles.Bottom;
            buttonDirections.BackColor = SystemColors.ControlLightLight;
            buttonDirections.Font = new Font("Segoe UI", 9F);
            buttonDirections.Location = new Point(630, 753);
            buttonDirections.Margin = new Padding(3, 4, 3, 4);
            buttonDirections.Name = "buttonDirections";
            buttonDirections.Size = new Size(191, 31);
            buttonDirections.TabIndex = 7;
            buttonDirections.Text = "Направления";
            buttonDirections.UseVisualStyleBackColor = false;
            buttonDirections.Click += buttonDirections_Click;
            // 
            // buttonPlanes
            // 
            buttonPlanes.Anchor = AnchorStyles.Bottom;
            buttonPlanes.BackColor = SystemColors.ControlLightLight;
            buttonPlanes.Font = new Font("Segoe UI", 9F);
            buttonPlanes.Location = new Point(430, 753);
            buttonPlanes.Margin = new Padding(3, 4, 3, 4);
            buttonPlanes.Name = "buttonPlanes";
            buttonPlanes.Size = new Size(191, 30);
            buttonPlanes.TabIndex = 8;
            buttonPlanes.Text = "Самолеты";
            buttonPlanes.UseVisualStyleBackColor = false;
            buttonPlanes.Click += buttonPlanes_Click;
            // 
            // buttonFlights
            // 
            buttonFlights.Anchor = AnchorStyles.Bottom;
            buttonFlights.BackColor = SystemColors.ControlLightLight;
            buttonFlights.Font = new Font("Segoe UI", 9F);
            buttonFlights.Location = new Point(230, 752);
            buttonFlights.Margin = new Padding(3, 4, 3, 4);
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Size = new Size(191, 31);
            buttonFlights.TabIndex = 9;
            buttonFlights.Text = "Рейсы";
            buttonFlights.UseVisualStyleBackColor = false;
            buttonFlights.Click += buttonFlights_Click;
            // 
            // labelIsAuthorized
            // 
            labelIsAuthorized.AutoSize = true;
            labelIsAuthorized.Font = new Font("Segoe UI", 14F);
            labelIsAuthorized.Location = new Point(12, 4);
            labelIsAuthorized.Name = "labelIsAuthorized";
            labelIsAuthorized.Size = new Size(63, 25);
            labelIsAuthorized.TabIndex = 10;
            labelIsAuthorized.Text = "label1";
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackColor = SystemColors.ControlLightLight;
            buttonExit.Font = new Font("Segoe UI", 16F);
            buttonExit.Location = new Point(524, 663);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(280, 57);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSchedule
            // 
            buttonSchedule.Anchor = AnchorStyles.None;
            buttonSchedule.AutoSize = true;
            buttonSchedule.BackColor = SystemColors.ControlLightLight;
            buttonSchedule.Font = new Font("Segoe UI", 16F);
            buttonSchedule.Location = new Point(524, 339);
            buttonSchedule.Margin = new Padding(3, 2, 3, 2);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(280, 57);
            buttonSchedule.TabIndex = 12;
            buttonSchedule.Text = "Расписание на сегодня";
            buttonSchedule.UseVisualStyleBackColor = false;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // buttonStatisticTickets
            // 
            buttonStatisticTickets.Anchor = AnchorStyles.None;
            buttonStatisticTickets.AutoSize = true;
            buttonStatisticTickets.BackColor = SystemColors.ControlLightLight;
            buttonStatisticTickets.Font = new Font("Segoe UI", 9F);
            buttonStatisticTickets.Location = new Point(630, 22);
            buttonStatisticTickets.Name = "buttonStatisticTickets";
            buttonStatisticTickets.Size = new Size(185, 31);
            buttonStatisticTickets.TabIndex = 13;
            buttonStatisticTickets.Text = "Статистика по продажам";
            buttonStatisticTickets.UseVisualStyleBackColor = false;
            buttonStatisticTickets.Click += buttonStatisticTickets_Click;
            // 
            // buttonDirStatistics
            // 
            buttonDirStatistics.Anchor = AnchorStyles.Bottom;
            buttonDirStatistics.BackColor = SystemColors.ControlLightLight;
            buttonDirStatistics.Font = new Font("Segoe UI", 9F);
            buttonDirStatistics.Location = new Point(21, 752);
            buttonDirStatistics.Name = "buttonDirStatistics";
            buttonDirStatistics.Size = new Size(191, 31);
            buttonDirStatistics.TabIndex = 13;
            buttonDirStatistics.Text = "Статистика по направлениям";
            buttonDirStatistics.UseVisualStyleBackColor = false;
            buttonDirStatistics.Click += buttonDirStatistics_Click;
            // 
            // slider
            // 
            slider.Anchor = AnchorStyles.None;
            slider.Image = (Image)resources.GetObject("slider.Image");
            slider.Location = new Point(12, 57);
            slider.Name = "slider";
            slider.Size = new Size(473, 663);
            slider.SizeMode = PictureBoxSizeMode.StretchImage;
            slider.TabIndex = 14;
            slider.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(842, 809);
            Controls.Add(slider);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormMainMenu";
            Text = "Главная";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormMainMenu_FormClosed;
            Load += FormMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slider).EndInit();
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
        private PictureBox slider;
        private System.Windows.Forms.Timer timer1;
    }
}