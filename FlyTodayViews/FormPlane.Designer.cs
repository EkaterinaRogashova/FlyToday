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
            buttonSave.Location = new Point(212, 156);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Location = new Point(192, 89);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(96, 31);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 1;
            label1.Text = "Название модели:";
            // 
            // textBoxModelName
            // 
            textBoxModelName.Location = new Point(157, 26);
            textBoxModelName.Margin = new Padding(3, 4, 3, 4);
            textBoxModelName.Name = "textBoxModelName";
            textBoxModelName.Size = new Size(260, 27);
            textBoxModelName.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(318, 156);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Location = new Point(276, 89);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 31);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // comboBoxPlaneScheme
            // 
            comboBoxPlaneScheme.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlaneScheme.FormattingEnabled = true;
            comboBoxPlaneScheme.Location = new Point(125, 48);
            comboBoxPlaneScheme.Name = "comboBoxPlaneScheme";
            comboBoxPlaneScheme.Size = new Size(228, 23);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 193);
            ClientSize = new Size(363, 120);
            Controls.Add(label2);
            Controls.Add(comboBoxPlaneScheme);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxModelName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 4, 3, 4);
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