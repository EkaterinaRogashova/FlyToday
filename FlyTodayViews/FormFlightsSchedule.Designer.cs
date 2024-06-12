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
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 412);
            panel1.TabIndex = 0;
            // 
            // groupBoxFlight
            // 
            groupBoxFlight.BackColor = SystemColors.InactiveCaption;
            groupBoxFlight.Controls.Add(labelRegistration);
            groupBoxFlight.Controls.Add(labelPlane);
            groupBoxFlight.Controls.Add(labelDepartureDate);
            groupBoxFlight.Controls.Add(labelDirection);
            groupBoxFlight.Location = new Point(12, 3);
            groupBoxFlight.Name = "groupBoxFlight";
            groupBoxFlight.Size = new Size(636, 41);
            groupBoxFlight.TabIndex = 0;
            groupBoxFlight.TabStop = false;
            groupBoxFlight.Text = "groupBox1";
            groupBoxFlight.Visible = false;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Location = new Point(471, 19);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(149, 15);
            labelRegistration.TabIndex = 3;
            labelRegistration.Text = "Регистрация закончилась";
            // 
            // labelPlane
            // 
            labelPlane.AutoSize = true;
            labelPlane.Location = new Point(390, 19);
            labelPlane.Name = "labelPlane";
            labelPlane.Size = new Size(41, 15);
            labelPlane.TabIndex = 2;
            labelPlane.Text = "боинк";
            // 
            // labelDepartureDate
            // 
            labelDepartureDate.AutoSize = true;
            labelDepartureDate.Location = new Point(257, 19);
            labelDepartureDate.Name = "labelDepartureDate";
            labelDepartureDate.Size = new Size(91, 15);
            labelDepartureDate.TabIndex = 1;
            labelDepartureDate.Text = "12.06.2024 16:41";
            // 
            // labelDirection
            // 
            labelDirection.AutoSize = true;
            labelDirection.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelDirection.Location = new Point(10, 19);
            labelDirection.Name = "labelDirection";
            labelDirection.Size = new Size(178, 15);
            labelDirection.TabIndex = 0;
            labelDirection.Text = "Россия Азов - Россия Москва";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(473, 17);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 4;
            label4.Text = "Состояние";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(390, 17);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Самолет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(223, 17);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 2;
            label2.Text = "Дата время вылета";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 1;
            label1.Text = "Направление";
            // 
            // FormFlightsSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
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