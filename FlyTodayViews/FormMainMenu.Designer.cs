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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 137);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonMainSearch
            // 
            buttonMainSearch.BackColor = SystemColors.ActiveCaption;
            buttonMainSearch.Font = new Font("Segoe UI", 16F);
            buttonMainSearch.Location = new Point(256, 159);
            buttonMainSearch.Margin = new Padding(3, 2, 3, 2);
            buttonMainSearch.Name = "buttonMainSearch";
            buttonMainSearch.Size = new Size(235, 39);
            buttonMainSearch.TabIndex = 1;
            buttonMainSearch.Text = "Поиск авиабилетов";
            buttonMainSearch.UseVisualStyleBackColor = false;
            buttonMainSearch.Click += buttonMainSearch_Click;
            // 
            // buttonMainEnter
            // 
            buttonMainEnter.Font = new Font("Segoe UI", 16F);
            buttonMainEnter.Location = new Point(257, 202);
            buttonMainEnter.Margin = new Padding(3, 2, 3, 2);
            buttonMainEnter.Name = "buttonMainEnter";
            buttonMainEnter.Size = new Size(234, 35);
            buttonMainEnter.TabIndex = 2;
            buttonMainEnter.Text = "Вход";
            buttonMainEnter.UseVisualStyleBackColor = true;
            buttonMainEnter.Click += buttonMainEnter_Click;
            // 
            // buttonMainRegistration
            // 
            buttonMainRegistration.BackColor = SystemColors.ActiveCaption;
            buttonMainRegistration.Font = new Font("Segoe UI", 16F);
            buttonMainRegistration.Location = new Point(256, 242);
            buttonMainRegistration.Margin = new Padding(3, 2, 3, 2);
            buttonMainRegistration.Name = "buttonMainRegistration";
            buttonMainRegistration.Size = new Size(236, 40);
            buttonMainRegistration.TabIndex = 3;
            buttonMainRegistration.Text = "Регистрация";
            buttonMainRegistration.UseVisualStyleBackColor = false;
            buttonMainRegistration.Click += buttonMainRegistration_Click;
            // 
            // buttonMainLK
            // 
            buttonMainLK.Font = new Font("Segoe UI", 16F);
            buttonMainLK.Location = new Point(261, 288);
            buttonMainLK.Margin = new Padding(3, 2, 3, 2);
            buttonMainLK.Name = "buttonMainLK";
            buttonMainLK.Size = new Size(232, 40);
            buttonMainLK.TabIndex = 4;
            buttonMainLK.Text = "Личный кабинет";
            buttonMainLK.UseVisualStyleBackColor = true;
            buttonMainLK.Click += buttonMainLK_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Font = new Font("Segoe UI", 12F);
            buttonEmployees.Location = new Point(503, 9);
            buttonEmployees.Margin = new Padding(3, 2, 3, 2);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(186, 50);
            buttonEmployees.TabIndex = 5;
            buttonEmployees.Text = "К подбору персонала";
            buttonEmployees.UseVisualStyleBackColor = true;
            buttonEmployees.Click += buttonEmployees_Click;
            // 
            // buttonSales
            // 
            buttonSales.Font = new Font("Segoe UI", 12F);
            buttonSales.Location = new Point(503, 70);
            buttonSales.Margin = new Padding(3, 2, 3, 2);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(186, 50);
            buttonSales.TabIndex = 6;
            buttonSales.Text = "Льготы";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonDirections
            // 
            buttonDirections.Location = new Point(503, 125);
            buttonDirections.Name = "buttonDirections";
            buttonDirections.Size = new Size(186, 23);
            buttonDirections.TabIndex = 7;
            buttonDirections.Text = "Направления";
            buttonDirections.UseVisualStyleBackColor = true;
            buttonDirections.Click += buttonDirections_Click;
            // 
            // buttonPlanes
            // 
            buttonPlanes.Location = new Point(503, 159);
            buttonPlanes.Name = "buttonPlanes";
            buttonPlanes.Size = new Size(186, 23);
            buttonPlanes.TabIndex = 8;
            buttonPlanes.Text = "Самолеты";
            buttonPlanes.UseVisualStyleBackColor = true;
            buttonPlanes.Click += buttonPlanes_Click;
            // 
            // buttonFlights
            // 
            buttonFlights.Location = new Point(503, 188);
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Size = new Size(185, 23);
            buttonFlights.TabIndex = 9;
            buttonFlights.Text = "Рейсы";
            buttonFlights.UseVisualStyleBackColor = true;
            buttonFlights.Click += buttonFlights_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(700, 338);
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
            Name = "FormMainMenu";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
    }
}