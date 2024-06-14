namespace FlyTodayViews
{
    partial class FormCreatePlaces
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new Button();
            label1 = new Label();
            buttonCancel = new Button();
            label4 = new Label();
            labelFlightDirection = new Label();
            labelPlane = new Label();
            label2 = new Label();
            labelEconomPlacesCount = new Label();
            label3 = new Label();
            label5 = new Label();
            labelBusinessPlacesCount = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(137, 176);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 31);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "Рейс:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(248, 176);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(96, 31);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 51);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Самолет:";
            // 
            // labelFlightDirection
            // 
            labelFlightDirection.AutoSize = true;
            labelFlightDirection.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelFlightDirection.Location = new Point(69, 17);
            labelFlightDirection.Name = "labelFlightDirection";
            labelFlightDirection.Size = new Size(142, 20);
            labelFlightDirection.TabIndex = 19;
            labelFlightDirection.Text = "Ульяновск - Москва";
            // 
            // labelPlane
            // 
            labelPlane.AutoSize = true;
            labelPlane.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelPlane.Location = new Point(89, 51);
            labelPlane.Name = "labelPlane";
            labelPlane.Size = new Size(49, 20);
            labelPlane.TabIndex = 20;
            labelPlane.Text = "Боинк";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 93);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 21;
            label2.Text = "Будет создано ";
            // 
            // labelEconomPlacesCount
            // 
            labelEconomPlacesCount.AutoSize = true;
            labelEconomPlacesCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelEconomPlacesCount.Location = new Point(122, 93);
            labelEconomPlacesCount.Name = "labelEconomPlacesCount";
            labelEconomPlacesCount.Size = new Size(25, 20);
            labelEconomPlacesCount.TabIndex = 22;
            labelEconomPlacesCount.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 93);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 23;
            label3.Text = "мест эконом-класса";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 129);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 26;
            label5.Text = "мест бизнес-класса";
            // 
            // labelBusinessPlacesCount
            // 
            labelBusinessPlacesCount.AutoSize = true;
            labelBusinessPlacesCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelBusinessPlacesCount.Location = new Point(122, 129);
            labelBusinessPlacesCount.Name = "labelBusinessPlacesCount";
            labelBusinessPlacesCount.Size = new Size(25, 20);
            labelBusinessPlacesCount.TabIndex = 25;
            labelBusinessPlacesCount.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 129);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 24;
            label7.Text = "Будет создано ";
            // 
            // FormCreatePlaces
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 223);
            Controls.Add(label5);
            Controls.Add(labelBusinessPlacesCount);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(labelEconomPlacesCount);
            Controls.Add(label2);
            Controls.Add(labelPlane);
            Controls.Add(labelFlightDirection);
            Controls.Add(label4);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormCreatePlaces";
            Text = "Создание мест на рейс";
            Load += FormCreatePlaces_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Button buttonCancel;
        private Label label4;
        private Label labelFlightDirection;
        private Label labelPlane;
        private Label label2;
        private Label labelEconomPlacesCount;
        private Label label3;
        private Label label5;
        private Label labelBusinessPlacesCount;
        private Label label7;
    }
}