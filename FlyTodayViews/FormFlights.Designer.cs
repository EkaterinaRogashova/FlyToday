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
            buttonCancelFlight = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Left;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1136, 450);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1151, 116);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(113, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(1151, 145);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(113, 23);
            buttonUpd.TabIndex = 2;
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(1151, 174);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(113, 23);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonRef
            // 
            buttonRef.Location = new Point(1151, 203);
            buttonRef.Name = "buttonRef";
            buttonRef.Size = new Size(113, 23);
            buttonRef.TabIndex = 4;
            buttonRef.Text = "Обновить";
            buttonRef.UseVisualStyleBackColor = true;
            buttonRef.Click += ButtonRef_Click;
            // 
            // buttonCreatePlace
            // 
            buttonCreatePlace.Location = new Point(1151, 232);
            buttonCreatePlace.Name = "buttonCreatePlace";
            buttonCreatePlace.Size = new Size(113, 24);
            buttonCreatePlace.TabIndex = 5;
            buttonCreatePlace.Text = "Добавить места";
            buttonCreatePlace.UseVisualStyleBackColor = true;
            buttonCreatePlace.Click += buttonCreatePlace_Click;
            // 
            // buttonReducePrices
            // 
            buttonReducePrices.Location = new Point(1151, 261);
            buttonReducePrices.Name = "buttonReducePrices";
            buttonReducePrices.Size = new Size(113, 70);
            buttonReducePrices.TabIndex = 6;
            buttonReducePrices.Text = "Снизить цены на оставшиеся билеты";
            buttonReducePrices.UseVisualStyleBackColor = true;
            buttonReducePrices.Click += buttonReducePrices_Click;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Location = new Point(1151, 336);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(113, 68);
            buttonSaveReport.TabIndex = 7;
            buttonSaveReport.Text = "Печать списка посадочных талонов";
            buttonSaveReport.UseVisualStyleBackColor = true;
            buttonSaveReport.Click += buttonSaveReport_Click;
            // 
            // buttonCancelFlight
            // 
            buttonCancelFlight.Location = new Point(1151, 410);
            buttonCancelFlight.Name = "buttonCancelFlight";
            buttonCancelFlight.Size = new Size(113, 23);
            buttonCancelFlight.TabIndex = 8;
            buttonCancelFlight.Text = "Отменить рейс";
            buttonCancelFlight.UseVisualStyleBackColor = true;
            buttonCancelFlight.Click += buttonCancelFlight_Click;
            // 
            // FormFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1276, 450);
            Controls.Add(buttonCancelFlight);
            Controls.Add(buttonSaveReport);
            Controls.Add(buttonReducePrices);
            Controls.Add(buttonCreatePlace);
            Controls.Add(buttonRef);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
            MaximizeBox = false;
            Name = "FormFlights";
            Text = "Рейсы";
            WindowState = FormWindowState.Maximized;
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
        private Button buttonCancelFlight;
    }
}