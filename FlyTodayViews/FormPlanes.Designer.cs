namespace FlyTodayViews
{
    partial class FormPlanes
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
            buttonPlaneSchemes = new Button();
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
            dataGridView.Size = new Size(408, 568);
            dataGridView.Size = new Size(660, 426);
            dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(470, 41);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Location = new Point(703, 142);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 31);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(470, 105);
            buttonUpd.Margin = new Padding(3, 4, 3, 4);
            buttonUpd.Location = new Point(703, 190);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(86, 31);
            buttonUpd.TabIndex = 2;
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(470, 175);
            buttonDel.Margin = new Padding(3, 4, 3, 4);
            buttonDel.Location = new Point(703, 242);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(86, 31);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonRef
            // 
            buttonRef.Location = new Point(470, 249);
            buttonRef.Margin = new Padding(3, 4, 3, 4);
            buttonRef.Location = new Point(703, 298);
            buttonRef.Name = "buttonRef";
            buttonRef.Size = new Size(86, 31);
            buttonRef.TabIndex = 4;
            buttonRef.Text = "Обновить";
            buttonRef.UseVisualStyleBackColor = true;
            buttonRef.Click += ButtonRef_Click;
            // 
            // buttonPlaneSchemes
            // 
            buttonPlaneSchemes.Location = new Point(703, 75);
            buttonPlaneSchemes.Name = "buttonPlaneSchemes";
            buttonPlaneSchemes.Size = new Size(75, 47);
            buttonPlaneSchemes.TabIndex = 5;
            buttonPlaneSchemes.Text = "Схемы самолетов";
            buttonPlaneSchemes.UseVisualStyleBackColor = true;
            buttonPlaneSchemes.Click += buttonPlaneSchemes_Click;
            // 
            // FormPlanes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 600);
            ClientSize = new Size(805, 450);
            Controls.Add(buttonPlaneSchemes);
            Controls.Add(buttonRef);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormPlanes";
            Text = "Самолеты";
            Load += FormPlanes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonRef;
        private Button buttonPlaneSchemes;
    }
}