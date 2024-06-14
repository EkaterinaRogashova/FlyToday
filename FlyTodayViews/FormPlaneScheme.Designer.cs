namespace FlyTodayViews
{
    partial class FormPlaneScheme
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
            buttonSave = new Button();
            label1 = new Label();
            textBoxFirstLineCountEconom = new TextBox();
            buttonCancel = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBoxEconomPlacesCount = new TextBox();
            textBoxSecondLineCountEconom = new TextBox();
            textBoxLastLineCountEconom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            textBoxBusinessPlacesCount = new TextBox();
            textBoxFirstLineCountBusiness = new TextBox();
            textBoxLastLineCountBusiness = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(236, 349);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Название:";
            // 
            // textBoxFirstLineCountEconom
            // 
            textBoxFirstLineCountEconom.Location = new Point(226, 50);
            textBoxFirstLineCountEconom.Name = "textBoxFirstLineCountEconom";
            textBoxFirstLineCountEconom.Size = new Size(148, 23);
            textBoxFirstLineCountEconom.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(317, 349);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество мест в первом ряду:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxEconomPlacesCount);
            groupBox1.Controls.Add(textBoxSecondLineCountEconom);
            groupBox1.Controls.Add(textBoxLastLineCountEconom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxFirstLineCountEconom);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 139);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Эконом-класс";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 24);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 10;
            label5.Text = "Общее количество мест:";
            // 
            // textBoxEconomPlacesCount
            // 
            textBoxEconomPlacesCount.Location = new Point(226, 21);
            textBoxEconomPlacesCount.Name = "textBoxEconomPlacesCount";
            textBoxEconomPlacesCount.Size = new Size(148, 23);
            textBoxEconomPlacesCount.TabIndex = 9;
            // 
            // textBoxSecondLineCountEconom
            // 
            textBoxSecondLineCountEconom.Location = new Point(226, 79);
            textBoxSecondLineCountEconom.Name = "textBoxSecondLineCountEconom";
            textBoxSecondLineCountEconom.Size = new Size(148, 23);
            textBoxSecondLineCountEconom.TabIndex = 8;
            // 
            // textBoxLastLineCountEconom
            // 
            textBoxLastLineCountEconom.Location = new Point(226, 108);
            textBoxLastLineCountEconom.Name = "textBoxLastLineCountEconom";
            textBoxLastLineCountEconom.Size = new Size(148, 23);
            textBoxLastLineCountEconom.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(205, 15);
            label4.TabIndex = 6;
            label4.Text = "Количество мест в последнем ряду:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(191, 15);
            label3.TabIndex = 5;
            label3.Text = "Количество мест в среднем ряду:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxBusinessPlacesCount);
            groupBox2.Controls.Add(textBoxFirstLineCountBusiness);
            groupBox2.Controls.Add(textBoxLastLineCountBusiness);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 117);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Бизнес-класс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(145, 15);
            label6.TabIndex = 16;
            label6.Text = "Общее количество мест:";
            // 
            // textBoxBusinessPlacesCount
            // 
            textBoxBusinessPlacesCount.Location = new Point(226, 22);
            textBoxBusinessPlacesCount.Name = "textBoxBusinessPlacesCount";
            textBoxBusinessPlacesCount.Size = new Size(148, 23);
            textBoxBusinessPlacesCount.TabIndex = 15;
            // 
            // textBoxFirstLineCountBusiness
            // 
            textBoxFirstLineCountBusiness.Location = new Point(226, 51);
            textBoxFirstLineCountBusiness.Name = "textBoxFirstLineCountBusiness";
            textBoxFirstLineCountBusiness.Size = new Size(148, 23);
            textBoxFirstLineCountBusiness.TabIndex = 11;
            // 
            // textBoxLastLineCountBusiness
            // 
            textBoxLastLineCountBusiness.Location = new Point(226, 80);
            textBoxLastLineCountBusiness.Name = "textBoxLastLineCountBusiness";
            textBoxLastLineCountBusiness.Size = new Size(148, 23);
            textBoxLastLineCountBusiness.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(186, 15);
            label8.TabIndex = 12;
            label8.Text = "Количество мест в первом ряду:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 83);
            label7.Name = "label7";
            label7.Size = new Size(191, 15);
            label7.TabIndex = 13;
            label7.Text = "Количество мест в среднем ряду:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(80, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(312, 23);
            textBoxName.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(0, 192, 192);
            label9.Location = new Point(148, 32);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 12;
            label9.Text = "Заполняется автоматически";
            // 
            // FormPlaneScheme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 379);
            Controls.Add(label9);
            Controls.Add(textBoxName);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Name = "FormPlaneScheme";
            Text = "Создание схемы самолета";
            Load += FormPlaneScheme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxFirstLineCountEconom;
        private Button buttonCancel;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox textBoxEconomPlacesCount;
        private TextBox textBoxSecondLineCountEconom;
        private TextBox textBoxLastLineCountEconom;
        private Label label6;
        private TextBox textBoxBusinessPlacesCount;
        private TextBox textBoxFirstLineCountBusiness;
        private TextBox textBoxLastLineCountBusiness;
        private Label label8;
        private Label label7;
        private TextBox textBoxName;
        private Label label9;
    }
}