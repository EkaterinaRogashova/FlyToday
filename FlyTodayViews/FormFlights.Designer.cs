namespace FlyTodayViews
{
    partial class FormFlights
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
            dataGridView = new DataGridView();
            buttonAdd = new Button();
            buttonUpd = new Button();
            buttonDel = new Button();
            buttonRef = new Button();
            buttonCreatePlace = new Button();
            buttonReducePrices = new Button();
            buttonSaveReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(14, 16);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1174, 568);
            dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1216, 16);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(113, 31);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(1216, 55);
            buttonUpd.Margin = new Padding(3, 4, 3, 4);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(113, 31);
            buttonUpd.TabIndex = 2;
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(1216, 93);
            buttonDel.Margin = new Padding(3, 4, 3, 4);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(113, 31);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonRef
            // 
            buttonRef.Location = new Point(1216, 132);
            buttonRef.Margin = new Padding(3, 4, 3, 4);
            buttonRef.Name = "buttonRef";
            buttonRef.Size = new Size(113, 31);
            buttonRef.TabIndex = 4;
            buttonRef.Text = "Обновить";
            buttonRef.UseVisualStyleBackColor = true;
            buttonRef.Click += ButtonRef_Click;
            // 
            // buttonCreatePlace
            // 
            buttonCreatePlace.Location = new Point(1216, 171);
            buttonCreatePlace.Margin = new Padding(3, 4, 3, 4);
            buttonCreatePlace.Name = "buttonCreatePlace";
            buttonCreatePlace.Size = new Size(113, 55);
            buttonCreatePlace.TabIndex = 5;
            buttonCreatePlace.Text = "Добавить места";
            buttonCreatePlace.UseVisualStyleBackColor = true;
            buttonCreatePlace.Click += buttonCreatePlace_Click;
            // 
            // buttonReducePrices
            // 
            buttonReducePrices.Location = new Point(1216, 233);
            buttonReducePrices.Margin = new Padding(3, 4, 3, 4);
            buttonReducePrices.Name = "buttonReducePrices";
            buttonReducePrices.Size = new Size(113, 93);
            buttonReducePrices.TabIndex = 6;
            buttonReducePrices.Text = "Снизить цены на оставшиеся билеты";
            buttonReducePrices.UseVisualStyleBackColor = true;
            buttonReducePrices.Click += buttonReducePrices_Click;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Location = new Point(1216, 334);
            buttonSaveReport.Margin = new Padding(3, 4, 3, 4);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(113, 91);
            buttonSaveReport.TabIndex = 7;
            buttonSaveReport.Text = "Печать списка посадочных талонов";
            buttonSaveReport.UseVisualStyleBackColor = true;
            buttonSaveReport.Click += buttonSaveReport_Click;
            // 
            // FormFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 600);
            Controls.Add(buttonSaveReport);
            Controls.Add(buttonReducePrices);
            Controls.Add(buttonCreatePlace);
            Controls.Add(buttonRef);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormFlights";
            Text = "Рейсы";
            Load += FormFlights_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonRef;
        private Button buttonCreatePlace;
        private Button buttonReducePrices;
        private Button buttonSaveReport;
    }
}