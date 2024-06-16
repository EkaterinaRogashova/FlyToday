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
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(578, 320);
            dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(615, 118);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(77, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Location = new Point(615, 154);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(77, 23);
            buttonUpd.TabIndex = 2;
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(615, 194);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(77, 23);
            buttonDel.TabIndex = 3;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonRef
            // 
            buttonRef.Location = new Point(615, 236);
            buttonRef.Name = "buttonRef";
            buttonRef.Size = new Size(77, 23);
            buttonRef.TabIndex = 4;
            buttonRef.Text = "Обновить";
            buttonRef.UseVisualStyleBackColor = true;
            buttonRef.Click += ButtonRef_Click;
            // 
            // buttonPlaneSchemes
            // 
            buttonPlaneSchemes.Location = new Point(615, 56);
            buttonPlaneSchemes.Margin = new Padding(3, 2, 3, 2);
            buttonPlaneSchemes.Name = "buttonPlaneSchemes";
            buttonPlaneSchemes.Size = new Size(77, 48);
            buttonPlaneSchemes.TabIndex = 5;
            buttonPlaneSchemes.Text = "Схемы самолетов";
            buttonPlaneSchemes.UseVisualStyleBackColor = true;
            buttonPlaneSchemes.Click += buttonPlaneSchemes_Click;
            // 
            // FormPlanes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 338);
            Controls.Add(buttonPlaneSchemes);
            Controls.Add(buttonRef);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
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