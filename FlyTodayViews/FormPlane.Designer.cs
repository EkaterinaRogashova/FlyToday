namespace FlyTodayViews
{
    partial class FormPlane
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
            textBoxModelName = new TextBox();
            buttonCancel = new Button();
            comboBoxPlaneScheme = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(191, 85);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(84, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Название модели:";
            // 
            // textBoxModelName
            // 
            textBoxModelName.Location = new Point(137, 20);
            textBoxModelName.Name = "textBoxModelName";
            textBoxModelName.Size = new Size(228, 23);
            textBoxModelName.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(281, 85);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(87, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // comboBoxPlaneScheme
            // 
            comboBoxPlaneScheme.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlaneScheme.FormattingEnabled = true;
            comboBoxPlaneScheme.Location = new Point(137, 48);
            comboBoxPlaneScheme.Margin = new Padding(3, 2, 3, 2);
            comboBoxPlaneScheme.Name = "comboBoxPlaneScheme";
            comboBoxPlaneScheme.Size = new Size(227, 23);
            comboBoxPlaneScheme.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "Схема:";
            // 
            // FormPlane
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 120);
            Controls.Add(label2);
            Controls.Add(comboBoxPlaneScheme);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxModelName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            MaximizeBox = false;
            Name = "FormPlane";
            Text = "Самолет";
            Load += FormPlane_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxModelName;
        private Button buttonCancel;
        private ComboBox comboBoxPlaneScheme;
        private Label label2;
    }
}