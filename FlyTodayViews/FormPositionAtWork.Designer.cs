namespace FlyTodayViews
{
    partial class FormPositionAtWork
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
            textBoxName = new TextBox();
            textBoxNumber = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(100, 174);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(144, 46);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 1;
            label1.Text = "Название должности:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(17, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 27);
            textBoxName.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(17, 128);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(291, 27);
            textBoxNumber.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 95);
            label2.Name = "label2";
            label2.Size = new Size(291, 28);
            label2.TabIndex = 3;
            label2.Text = "Количество человек на смене:";
            // 
            // FormPositionAtWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 263);
            Controls.Add(textBoxNumber);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            MaximizeBox = false;
            Name = "FormPositionAtWork";
            Text = "Должность";
            Load += FormPositionAtWork_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxNumber;
        private Label label2;
    }
}