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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1027, 426);
            dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1064, 60);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(99, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(1064, 108);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(99, 23);
            buttonUpd.TabIndex = 2;
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(1064, 160);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(99, 23);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonRef
            // 
            buttonRef.Location = new Point(1064, 216);
            buttonRef.Name = "buttonRef";
            buttonRef.Size = new Size(99, 23);
            buttonRef.TabIndex = 4;
            buttonRef.Text = "Обновить";
            buttonRef.UseVisualStyleBackColor = true;
            buttonRef.Click += ButtonRef_Click;
            // 
            // buttonCreatePlace
            // 
            buttonCreatePlace.Location = new Point(1064, 264);
            buttonCreatePlace.Name = "buttonCreatePlace";
            buttonCreatePlace.Size = new Size(99, 41);
            buttonCreatePlace.TabIndex = 5;
            buttonCreatePlace.Text = "Добавить места";
            buttonCreatePlace.UseVisualStyleBackColor = true;
            buttonCreatePlace.Click += buttonCreatePlace_Click;
            // 
            // buttonReducePrices
            // 
            buttonReducePrices.Location = new Point(1064, 330);
            buttonReducePrices.Name = "buttonReducePrices";
            buttonReducePrices.Size = new Size(99, 70);
            buttonReducePrices.TabIndex = 6;
            buttonReducePrices.Text = "Снизить цены на оставшиеся билеты";
            buttonReducePrices.UseVisualStyleBackColor = true;
            buttonReducePrices.Click += buttonReducePrices_Click;
            // 
            // FormFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 450);
            Controls.Add(buttonReducePrices);
            Controls.Add(buttonCreatePlace);
            Controls.Add(buttonRef);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
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
    }
}