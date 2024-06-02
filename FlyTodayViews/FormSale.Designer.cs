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
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(80, 176);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(159, 42);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 14);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 1;
            label1.Text = "Название категории";
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Location = new Point(28, 45);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(245, 27);
            textBoxCategoryName.TabIndex = 2;
            // 
            // textBoxPercent
            // 
            textBoxPercent.Location = new Point(28, 115);
            textBoxPercent.Name = "textBoxPercent";
            textBoxPercent.Size = new Size(245, 27);
            textBoxPercent.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 3;
            label2.Text = "Размер скидки в %";
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 264);
            Controls.Add(textBoxPercent);
            Controls.Add(label2);
            Controls.Add(textBoxCategoryName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Name = "FormSale";
            Text = "FormSale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxCategoryName;
        private TextBox textBoxPercent;
        private Label label2;
    }
}