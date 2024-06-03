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
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(75, 174);
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
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 1;
            label1.Text = "Название должности:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(21, 72);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(269, 27);
            textBoxName.TabIndex = 2;
            // 
            // FormPositionAtWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 263);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
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
    }
}