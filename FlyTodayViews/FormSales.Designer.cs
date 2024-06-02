namespace FlyTodayViews
{
    partial class FormSales
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
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(276, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(294, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 48);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(294, 66);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 48);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(294, 120);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(126, 48);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Name = "FormSales";
            Text = "FormSales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}