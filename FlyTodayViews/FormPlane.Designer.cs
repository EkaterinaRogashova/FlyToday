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
            label2 = new Label();
            textBoxEconomPlacesCount = new TextBox();
            buttonCancel = new Button();
            label3 = new Label();
            textBoxBusinessPlacesCount = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(194, 117);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Название модели:";
            // 
            // textBoxModelName
            // 
            textBoxModelName.Location = new Point(125, 19);
            textBoxModelName.Name = "textBoxModelName";
            textBoxModelName.Size = new Size(228, 23);
            textBoxModelName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 3;
            label2.Text = "Кол-во мест эконом-класса:";
            // 
            // textBoxEconomPlacesCount
            // 
            textBoxEconomPlacesCount.Location = new Point(183, 50);
            textBoxEconomPlacesCount.Name = "textBoxEconomPlacesCount";
            textBoxEconomPlacesCount.Size = new Size(170, 23);
            textBoxEconomPlacesCount.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(278, 117);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 6;
            label3.Text = "Кол-во мест бизнес-класса:";
            // 
            // textBoxBusinessPlacesCount
            // 
            textBoxBusinessPlacesCount.Location = new Point(183, 78);
            textBoxBusinessPlacesCount.Name = "textBoxBusinessPlacesCount";
            textBoxBusinessPlacesCount.Size = new Size(170, 23);
            textBoxBusinessPlacesCount.TabIndex = 8;
            // 
            // FormPlane
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 145);
            Controls.Add(textBoxBusinessPlacesCount);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxEconomPlacesCount);
            Controls.Add(label2);
            Controls.Add(textBoxModelName);
            Controls.Add(label1);
            Controls.Add(buttonSave);
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
        private Label label2;
        private TextBox textBoxEconomPlacesCount;
        private Button buttonCancel;
        private Label label3;
        private TextBox textBoxBusinessPlacesCount;
    }
}