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
            label3 = new Label();
            comboBoxTypeWork = new ComboBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(70, 192);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(126, 34);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 1;
            label1.Text = "Название должности:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 41);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(255, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Enabled = false;
            textBoxNumber.Location = new Point(18, 162);
            textBoxNumber.Margin = new Padding(3, 2, 3, 2);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(255, 23);
            textBoxNumber.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 139);
            label2.Name = "label2";
            label2.Size = new Size(226, 21);
            label2.TabIndex = 3;
            label2.Text = "Количество человек на смене:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 76);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 5;
            label3.Text = "Тип работы:";
            // 
            // comboBoxTypeWork
            // 
            comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeWork.FormattingEnabled = true;
            comboBoxTypeWork.Items.AddRange(new object[] { "Посменная", "На рейсе" });
            comboBoxTypeWork.Location = new Point(18, 100);
            comboBoxTypeWork.Name = "comboBoxTypeWork";
            comboBoxTypeWork.Size = new Size(252, 23);
            comboBoxTypeWork.TabIndex = 6;
            comboBoxTypeWork.SelectedIndexChanged += comboBoxTypeWork_SelectedIndexChanged;
            // 
            // FormPositionAtWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 237);
            Controls.Add(comboBoxTypeWork);
            Controls.Add(label3);
            Controls.Add(textBoxNumber);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private ComboBox comboBoxTypeWork;
    }
}