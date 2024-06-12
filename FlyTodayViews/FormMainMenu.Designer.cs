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
            button1 = new Button();
            buttonSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 183);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonMainSearch
            // 
            buttonMainSearch.BackColor = SystemColors.ActiveCaption;
            buttonMainSearch.Font = new Font("Segoe UI", 16F);
            buttonMainSearch.Location = new Point(293, 212);
            buttonMainSearch.Location = new Point(184, 191);
            buttonMainSearch.Margin = new Padding(3, 2, 3, 2);
            buttonMainSearch.Name = "buttonMainSearch";
            buttonMainSearch.Size = new Size(269, 52);
            buttonMainSearch.Size = new Size(291, 39);
            buttonMainSearch.TabIndex = 1;
            buttonMainSearch.Text = "Поиск авиабилетов";
            buttonMainSearch.UseVisualStyleBackColor = false;
            buttonMainSearch.Click += buttonMainSearch_Click;
            // 
            // buttonMainEnter
            // 
            buttonMainEnter.Font = new Font("Segoe UI", 16F);
            buttonMainEnter.Location = new Point(294, 269);
            buttonMainEnter.Location = new Point(181, 273);
            buttonMainEnter.Margin = new Padding(3, 2, 3, 2);
            buttonMainEnter.Name = "buttonMainEnter";
            buttonMainEnter.Size = new Size(267, 47);
            buttonMainEnter.Size = new Size(293, 35);
            buttonMainEnter.TabIndex = 2;
            buttonMainEnter.Text = "Вход";
            buttonMainEnter.UseVisualStyleBackColor = true;
            buttonMainEnter.Click += buttonMainEnter_Click;
            // 
            // buttonMainRegistration
            // 
            buttonMainRegistration.BackColor = SystemColors.ActiveCaption;
            buttonMainRegistration.Font = new Font("Segoe UI", 16F);
            buttonMainRegistration.Location = new Point(293, 323);
            buttonMainRegistration.Location = new Point(180, 313);
            buttonMainRegistration.Margin = new Padding(3, 2, 3, 2);
            buttonMainRegistration.Name = "buttonMainRegistration";
            buttonMainRegistration.Size = new Size(270, 53);
            buttonMainRegistration.Size = new Size(295, 40);
            buttonMainRegistration.TabIndex = 3;
            buttonMainRegistration.Text = "Регистрация";
            buttonMainRegistration.UseVisualStyleBackColor = false;
            buttonMainRegistration.Click += buttonMainRegistration_Click;
            // 
            // buttonMainLK
            // 
            buttonMainLK.Font = new Font("Segoe UI", 16F);
            buttonMainLK.Location = new Point(296, 381);
            buttonMainLK.Location = new Point(183, 357);
            buttonMainLK.Margin = new Padding(3, 2, 3, 2);
            buttonMainLK.Name = "buttonMainLK";
            buttonMainLK.Size = new Size(265, 53);
            buttonMainLK.Size = new Size(291, 40);
            buttonMainLK.TabIndex = 4;
            buttonMainLK.Text = "Личный кабинет";
            buttonMainLK.UseVisualStyleBackColor = true;
            buttonMainLK.Click += buttonMainLK_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Font = new Font("Segoe UI", 12F);
            buttonEmployees.Location = new Point(14, 47);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(213, 67);
            buttonEmployees.TabIndex = 5;
            buttonEmployees.Text = "К подбору персонала";
            buttonEmployees.UseVisualStyleBackColor = true;
            buttonEmployees.Click += buttonEmployees_Click;
            // 
            // buttonSales
            // 
            buttonSales.Font = new Font("Segoe UI", 12F);
            buttonSales.Location = new Point(14, 122);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(213, 67);
            buttonSales.TabIndex = 6;
            buttonSales.Text = "Льготы";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonDirections
            // 
            buttonDirections.Location = new Point(575, 50);
            buttonDirections.Margin = new Padding(3, 4, 3, 4);
            buttonDirections.Name = "buttonDirections";
            buttonDirections.Size = new Size(213, 67);
            buttonDirections.TabIndex = 7;
            buttonDirections.Text = "Направления";
            buttonDirections.UseVisualStyleBackColor = true;
            buttonDirections.Click += buttonDirections_Click;
            // 
            // buttonPlanes
            // 
            buttonPlanes.Location = new Point(575, 125);
            buttonPlanes.Margin = new Padding(3, 4, 3, 4);
            buttonPlanes.Location = new Point(502, 156);
            buttonPlanes.Name = "buttonPlanes";
            buttonPlanes.Size = new Size(213, 64);
            buttonPlanes.TabIndex = 8;
            buttonPlanes.Text = "Самолеты";
            buttonPlanes.UseVisualStyleBackColor = true;
            buttonPlanes.Click += buttonPlanes_Click;
            // 
            // buttonFlights
            // 
            buttonFlights.Location = new Point(575, 201);
            buttonFlights.Margin = new Padding(3, 4, 3, 4);
            buttonFlights.Location = new Point(502, 185);
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Size = new Size(211, 63);
            buttonFlights.TabIndex = 9;
            buttonFlights.Text = "Рейсы";
            buttonFlights.UseVisualStyleBackColor = true;
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
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.Font = new Font("Segoe UI", 16F);
            buttonExit.Location = new Point(293, 445);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(270, 53);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(180, 405);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(295, 40);
            button1.TabIndex = 11;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSchedule
            // 
            buttonSchedule.BackColor = SystemColors.Control;
            buttonSchedule.Font = new Font("Segoe UI", 16F);
            buttonSchedule.Location = new Point(183, 234);
            buttonSchedule.Margin = new Padding(3, 2, 3, 2);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(291, 35);
            buttonSchedule.TabIndex = 12;
            buttonSchedule.Text = "Расписание на сегодня";
            buttonSchedule.UseVisualStyleBackColor = false;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 511);
            Controls.Add(buttonExit);
            ClientSize = new Size(700, 454);
            Controls.Add(buttonSchedule);
            Controls.Add(button1);
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
        private Button button1;
        private Button buttonSchedule;
    }
}