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
            buttonMainSearch.Location = new Point(292, 212);
            buttonMainSearch.Name = "buttonMainSearch";
            buttonMainSearch.Size = new Size(269, 52);
            buttonMainSearch.TabIndex = 1;
            buttonMainSearch.Text = "Поиск авиабилетов";
            buttonMainSearch.UseVisualStyleBackColor = false;
            // 
            // buttonMainEnter
            // 
            buttonMainEnter.Font = new Font("Segoe UI", 16F);
            buttonMainEnter.Location = new Point(294, 270);
            buttonMainEnter.Name = "buttonMainEnter";
            buttonMainEnter.Size = new Size(268, 47);
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
            buttonMainRegistration.Name = "buttonMainRegistration";
            buttonMainRegistration.Size = new Size(270, 54);
            buttonMainRegistration.TabIndex = 3;
            buttonMainRegistration.Text = "Регистрация";
            buttonMainRegistration.UseVisualStyleBackColor = false;
            buttonMainRegistration.Click += buttonMainRegistration_Click;
            // 
            // buttonMainLK
            // 
            buttonMainLK.Font = new Font("Segoe UI", 16F);
            buttonMainLK.Location = new Point(298, 384);
            buttonMainLK.Name = "buttonMainLK";
            buttonMainLK.Size = new Size(265, 54);
            buttonMainLK.TabIndex = 4;
            buttonMainLK.Text = "Личный кабинет";
            buttonMainLK.UseVisualStyleBackColor = true;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Font = new Font("Segoe UI", 12F);
            buttonEmployees.Location = new Point(575, 12);
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
            buttonSales.Location = new Point(575, 94);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(213, 67);
            buttonSales.TabIndex = 6;
            buttonSales.Text = "Льготы";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSales);
            Controls.Add(buttonEmployees);
            Controls.Add(buttonMainLK);
            Controls.Add(buttonMainRegistration);
            Controls.Add(buttonMainEnter);
            Controls.Add(buttonMainSearch);
            Controls.Add(pictureBox1);
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
    }
}