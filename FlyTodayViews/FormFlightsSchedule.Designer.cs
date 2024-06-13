namespace FlyTodayViews
{
    partial class FormFlightsSchedule
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
            panel1 = new Panel();
            groupBoxFlight = new GroupBox();
            labelRegistration = new Label();
            labelPlane = new Label();
            labelDepartureDate = new Label();
            labelDirection = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBoxFlight.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBoxFlight);
            panel1.Location = new Point(12, 50);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 549);
            panel1.TabIndex = 0;
            // 
            // groupBoxFlight
            // 
            groupBoxFlight.BackColor = SystemColors.InactiveCaption;
            groupBoxFlight.Controls.Add(labelRegistration);
            groupBoxFlight.Controls.Add(labelPlane);
            groupBoxFlight.Controls.Add(labelDepartureDate);
            groupBoxFlight.Controls.Add(labelDirection);
            groupBoxFlight.FlatStyle = FlatStyle.Flat;
            groupBoxFlight.Location = new Point(3, 4);
            groupBoxFlight.Margin = new Padding(3, 4, 3, 4);
            groupBoxFlight.Name = "groupBoxFlight";
            groupBoxFlight.Padding = new Padding(3, 2, 3, 4);
            groupBoxFlight.Size = new Size(925, 55);
            groupBoxFlight.TabIndex = 0;
            groupBoxFlight.TabStop = false;
            groupBoxFlight.Visible = false;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Location = new Point(678, 23);
            labelRegistration.MinimumSize = new Size(250, 0);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(250, 20);
            labelRegistration.TabIndex = 3;
            labelRegistration.Text = "Регистрация закончилась";
            // 
            // labelPlane
            // 
            labelPlane.AutoSize = true;
            labelPlane.Location = new Point(511, 22);
            labelPlane.MinimumSize = new Size(100, 0);
            labelPlane.Name = "labelPlane";
            labelPlane.Size = new Size(100, 20);
            labelPlane.TabIndex = 2;
            labelPlane.Text = "боинк";
            // 
            // labelDepartureDate
            // 
            labelDepartureDate.AutoSize = true;
            labelDepartureDate.Location = new Point(317, 22);
            labelDepartureDate.Name = "labelDepartureDate";
            labelDepartureDate.Size = new Size(118, 20);
            labelDepartureDate.TabIndex = 1;
            labelDepartureDate.Text = "12.06.2024 16:41";
            // 
            // labelDirection
            // 
            labelDirection.AutoSize = true;
            labelDirection.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelDirection.Location = new Point(11, 23);
            labelDirection.MinimumSize = new Size(300, 0);
            labelDirection.Name = "labelDirection";
            labelDirection.Size = new Size(300, 20);
            labelDirection.TabIndex = 0;
            labelDirection.Text = "Россия Азов - Россия Москва";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(765, 27);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 4;
            label4.Text = "Состояние";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(535, 27);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "Самолет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(305, 27);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 2;
            label2.Text = "Дата время вылета";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(102, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Направление";
            // 
            // FormFlightsSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormFlightsSchedule";
            Text = "Расписание рейсов";
            Load += FormFlightsSchedule_Load;
            panel1.ResumeLayout(false);
            groupBoxFlight.ResumeLayout(false);
            groupBoxFlight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxFlight;
        private Label labelDepartureDate;
        private Label labelDirection;
        private Label labelPlane;
        private Label labelRegistration;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}