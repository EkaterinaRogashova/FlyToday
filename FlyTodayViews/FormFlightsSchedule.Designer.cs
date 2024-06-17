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
            panel1.Location = new Point(26, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 927);
            panel1.TabIndex = 0;
            // 
            // groupBoxFlight
            // 
            groupBoxFlight.BackColor = Color.AliceBlue;
            groupBoxFlight.Controls.Add(labelRegistration);
            groupBoxFlight.Controls.Add(labelPlane);
            groupBoxFlight.Controls.Add(labelDepartureDate);
            groupBoxFlight.Controls.Add(labelDirection);
            groupBoxFlight.FlatStyle = FlatStyle.Flat;
            groupBoxFlight.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxFlight.Location = new Point(3, 3);
            groupBoxFlight.Name = "groupBoxFlight";
            groupBoxFlight.Padding = new Padding(3, 2, 3, 3);
            groupBoxFlight.Size = new Size(1535, 75);
            groupBoxFlight.TabIndex = 0;
            groupBoxFlight.TabStop = false;
            groupBoxFlight.Visible = false;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Malgun Gothic Semilight", 16F);
            labelRegistration.ForeColor = Color.SteelBlue;
            labelRegistration.Location = new Point(997, 27);
            labelRegistration.MinimumSize = new Size(500, 0);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(500, 30);
            labelRegistration.TabIndex = 3;
            labelRegistration.Text = "Регистрация закончилась";
            labelRegistration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlane
            // 
            labelPlane.AutoSize = true;
            labelPlane.Font = new Font("Malgun Gothic Semilight", 16F);
            labelPlane.ForeColor = Color.SteelBlue;
            labelPlane.Location = new Point(814, 27);
            labelPlane.MinimumSize = new Size(200, 0);
            labelPlane.Name = "labelPlane";
            labelPlane.Size = new Size(200, 30);
            labelPlane.TabIndex = 2;
            labelPlane.Text = "боинк";
            labelPlane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDepartureDate
            // 
            labelDepartureDate.AutoSize = true;
            labelDepartureDate.Font = new Font("Malgun Gothic Semilight", 16F);
            labelDepartureDate.ForeColor = Color.SteelBlue;
            labelDepartureDate.Location = new Point(521, 27);
            labelDepartureDate.MinimumSize = new Size(200, 0);
            labelDepartureDate.Name = "labelDepartureDate";
            labelDepartureDate.Size = new Size(200, 30);
            labelDepartureDate.TabIndex = 1;
            labelDepartureDate.Text = "12.06.2024 16:41";
            labelDepartureDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDirection
            // 
            labelDirection.AutoSize = true;
            labelDirection.Font = new Font("Malgun Gothic Semilight", 16F);
            labelDirection.ForeColor = Color.SteelBlue;
            labelDirection.Location = new Point(6, 27);
            labelDirection.MinimumSize = new Size(500, 0);
            labelDirection.Name = "labelDirection";
            labelDirection.Size = new Size(500, 30);
            labelDirection.TabIndex = 0;
            labelDirection.Text = "Россия Азов - Россия Москва";
            labelDirection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic Semilight", 18F);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(1212, 16);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 4;
            label4.Text = "Состояние";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic Semilight", 18F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(890, 16);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 3;
            label3.Text = "Самолет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic Semilight", 18F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(539, 16);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 2;
            label2.Text = "Дата время вылета";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic Semilight", 18F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(206, 16);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 1;
            label1.Text = "Направление";
            // 
            // FormFlightsSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1579, 1041);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
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