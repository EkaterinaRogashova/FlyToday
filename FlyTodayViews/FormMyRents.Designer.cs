namespace FlyTodayViews
{
    partial class FormMyRents
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            buttonRefresh = new Button();
            buttonLookTickets = new Button();
            buttonDeleteRent = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(523, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 0;
            label1.Text = "Мои бронирования";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(987, 372);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(1038, 71);
            button1.Name = "button1";
            button1.Size = new Size(224, 45);
            button1.TabIndex = 2;
            button1.Text = "Оформить билеты";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ActiveCaption;
            buttonRefresh.Font = new Font("Segoe UI", 12F);
            buttonRefresh.Location = new Point(1038, 386);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(224, 45);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonLookTickets
            // 
            buttonLookTickets.BackColor = SystemColors.ActiveCaption;
            buttonLookTickets.Font = new Font("Segoe UI", 12F);
            buttonLookTickets.Location = new Point(1038, 154);
            buttonLookTickets.Name = "buttonLookTickets";
            buttonLookTickets.Size = new Size(224, 45);
            buttonLookTickets.TabIndex = 4;
            buttonLookTickets.Text = "Посмотреть билеты";
            buttonLookTickets.UseVisualStyleBackColor = false;
            buttonLookTickets.Click += buttonLookTickets_Click;
            // 
            // buttonDeleteRent
            // 
            buttonDeleteRent.BackColor = SystemColors.ActiveCaption;
            buttonDeleteRent.Font = new Font("Segoe UI", 12F);
            buttonDeleteRent.Location = new Point(1038, 222);
            buttonDeleteRent.Name = "buttonDeleteRent";
            buttonDeleteRent.Size = new Size(224, 45);
            buttonDeleteRent.TabIndex = 5;
            buttonDeleteRent.Text = "Удалить бронь";
            buttonDeleteRent.UseVisualStyleBackColor = false;
            buttonDeleteRent.Click += buttonDeleteRent_Click;
            // 
            // FormMyRents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 447);
            Controls.Add(buttonDeleteRent);
            Controls.Add(buttonLookTickets);
            Controls.Add(buttonRefresh);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormMyRents";
            Text = "Мои бронирования";
            Load += FormMyRents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button buttonRefresh;
        private Button buttonLookTickets;
        private Button buttonDeleteRent;
    }
}