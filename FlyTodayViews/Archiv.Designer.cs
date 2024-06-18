namespace FlyTodayViews
{
    partial class Archiv
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 351);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(399, 37);
            label1.TabIndex = 1;
            label1.Text = "Мой архив с бронированиями";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(161, 46);
            label2.Name = "label2";
            label2.Size = new Size(649, 19);
            label2.TabIndex = 2;
            label2.Text = "(бронирования рейсов, которые были отменены или вылетели  - автоматически добавляются сюда)";
            // 
            // button1
            // 
            button1.Location = new Point(794, 87);
            button1.Name = "button1";
            button1.Size = new Size(149, 48);
            button1.TabIndex = 3;
            button1.Text = "Посмотреть билеты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Archiv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(955, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Archiv";
            Text = "Мой архив с бронированиями";
            Load += Archiv_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}