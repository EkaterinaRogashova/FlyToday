namespace FlyTodayViews
{
    partial class FormSale
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
            textBoxCategoryName = new TextBox();
            textBoxPercent = new TextBox();
            label2 = new Label();
            textBoxAgeTo = new TextBox();
            label3 = new Label();
            textBoxAgeFrom = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(63, 227);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(139, 32);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 10);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 1;
            label1.Text = "Название категории";
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Location = new Point(24, 34);
            textBoxCategoryName.Margin = new Padding(3, 2, 3, 2);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(215, 23);
            textBoxCategoryName.TabIndex = 2;
            // 
            // textBoxPercent
            // 
            textBoxPercent.Location = new Point(24, 86);
            textBoxPercent.Margin = new Padding(3, 2, 3, 2);
            textBoxPercent.Name = "textBoxPercent";
            textBoxPercent.Size = new Size(215, 23);
            textBoxPercent.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 3;
            label2.Text = "Размер скидки в %";
            // 
            // textBoxAgeTo
            // 
            textBoxAgeTo.Location = new Point(24, 143);
            textBoxAgeTo.Margin = new Padding(3, 2, 3, 2);
            textBoxAgeTo.Name = "textBoxAgeTo";
            textBoxAgeTo.Size = new Size(215, 23);
            textBoxAgeTo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 120);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Возраст от:";
            // 
            // textBoxAgeFrom
            // 
            textBoxAgeFrom.Location = new Point(24, 200);
            textBoxAgeFrom.Margin = new Padding(3, 2, 3, 2);
            textBoxAgeFrom.Name = "textBoxAgeFrom";
            textBoxAgeFrom.Size = new Size(215, 23);
            textBoxAgeFrom.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 177);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 7;
            label4.Text = "Возраст до:";
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(264, 270);
            Controls.Add(textBoxAgeFrom);
            Controls.Add(label4);
            Controls.Add(textBoxAgeTo);
            Controls.Add(label3);
            Controls.Add(textBoxPercent);
            Controls.Add(label2);
            Controls.Add(textBoxCategoryName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormSale";
            Text = "Льгота";
            Load += FormSale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxCategoryName;
        private TextBox textBoxPercent;
        private Label label2;
        private TextBox textBoxAgeTo;
        private Label label3;
        private TextBox textBoxAgeFrom;
        private Label label4;
    }
}