
namespace FlyTodayViews
{
    partial class FormDirection
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
            textBoxCountryFrom = new TextBox();
            label2 = new Label();
            textBoxCityFrom = new TextBox();
            buttonCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxCountryTo = new TextBox();
            textBoxCityTo = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(192, 136);
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
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Страна откуда:";
            // 
            // textBoxCountryFrom
            // 
            textBoxCountryFrom.Location = new Point(106, 19);
            textBoxCountryFrom.Name = "textBoxCountryFrom";
            textBoxCountryFrom.Size = new Size(247, 23);
            textBoxCountryFrom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Город откуда:";
            // 
            // textBoxCityFrom
            // 
            textBoxCityFrom.Location = new Point(106, 50);
            textBoxCityFrom.Name = "textBoxCityFrom";
            textBoxCityFrom.Size = new Size(247, 23);
            textBoxCityFrom.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(276, 136);
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
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Страна куда:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Город куда:";
            // 
            // textBoxCountryTo
            // 
            textBoxCountryTo.Location = new Point(106, 78);
            textBoxCountryTo.Name = "textBoxCountryTo";
            textBoxCountryTo.Size = new Size(247, 23);
            textBoxCountryTo.TabIndex = 8;
            // 
            // textBoxCityTo
            // 
            textBoxCityTo.Location = new Point(106, 107);
            textBoxCityTo.Name = "textBoxCityTo";
            textBoxCityTo.Size = new Size(247, 23);
            textBoxCityTo.TabIndex = 9;
            // 
            // FormDirection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 165);
            Controls.Add(textBoxCityTo);
            Controls.Add(textBoxCountryTo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxCityFrom);
            Controls.Add(label2);
            Controls.Add(textBoxCountryFrom);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Name = "FormDirection";
            Text = "Направление";
            Load += FormDirection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxCountryFrom;
        private Label label2;
        private TextBox textBoxCityFrom;
        private Button buttonCancel;
        private Label label3;
        private Label label4;
        private TextBox textBoxCountryTo;
        private TextBox textBoxCityTo;
    }
}