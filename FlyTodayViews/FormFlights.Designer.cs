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
            menuStrip = new MenuStrip();
            cправочникиToolStripMenuItem = new ToolStripMenuItem();
            компонентыToolStripMenuItem = new ToolStripMenuItem();
            изделияToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            buttonRef = new Button();
            buttonSearch = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { cправочникиToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1069, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // cправочникиToolStripMenuItem
            // 
            cправочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { компонентыToolStripMenuItem, изделияToolStripMenuItem });
            cправочникиToolStripMenuItem.Name = "cправочникиToolStripMenuItem";
            cправочникиToolStripMenuItem.Size = new Size(94, 20);
            cправочникиToolStripMenuItem.Text = "Cправочники";
            // 
            // компонентыToolStripMenuItem
            // 
            компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            компонентыToolStripMenuItem.Size = new Size(180, 22);
            компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // изделияToolStripMenuItem
            // 
            изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
            изделияToolStripMenuItem.Size = new Size(180, 22);
            изделияToolStripMenuItem.Text = "Изделия";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(840, 369);
            dataGridView.TabIndex = 1;
            // 
            // buttonRef
            // 
            buttonRef.Location = new Point(882, 207);
            buttonRef.Name = "buttonRef";
            buttonRef.Size = new Size(159, 23);
            buttonRef.TabIndex = 6;
            buttonRef.Text = "Обновить список";
            buttonRef.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(882, 178);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(159, 23);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // FormFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 408);
            Controls.Add(buttonSearch);
            Controls.Add(buttonRef);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormFlights";
            Text = "Поиск авиабилетов";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem cправочникиToolStripMenuItem;
        private DataGridView dataGridView;
        private Button buttonRef;
        private ToolStripMenuItem компонентыToolStripMenuItem;
        private ToolStripMenuItem изделияToolStripMenuItem;
        private Button buttonSearch;
    }
}