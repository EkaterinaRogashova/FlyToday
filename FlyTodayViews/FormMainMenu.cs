﻿using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayDataModels.Enums;
using FlyTodayViews.Properties;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormMainMenu : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private int? _currentUserId;
        private string? _email;
        private string? _password;
        public int CurrentUserId { set { _currentUserId = value; } }
        public string Password { set { _password = value; } }
        public string Email { set { _email = value; } }
        private int picturenumber = 1;

        //private void ImageSlide()
        //{
        //    if (picturenumber == 1) slider.ImageLocation = "C:\\Users\\User\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\1.jpg";
        //    if (picturenumber == 2) slider.ImageLocation = "C:\\Users\\User\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\2.jpg";
        //    if (picturenumber == 3) slider.ImageLocation = "C:\\Users\\User\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\3.jpg";
        //    if (picturenumber == 4) slider.ImageLocation = "C:\\Users\\User\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\4.jpg";
        //    if (picturenumber == 5) slider.ImageLocation = "C:\\Users\\User\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\5.jpg";
        //    if (picturenumber == 6) { picturenumber = 1; slider.ImageLocation = "C:\\Users\\User\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\1.jpg"; }
        //    picturenumber++;
        //}
        private void ImageSlide()
        {
            if (picturenumber == 1) slider.ImageLocation = "C:\\Users\\admin\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\1.jpg";
            if (picturenumber == 2) slider.ImageLocation = "C:\\Users\\admin\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\2.jpg";
            if (picturenumber == 3) slider.ImageLocation = "C:\\Users\\admin\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\3.jpg";
            if (picturenumber == 4) slider.ImageLocation = "C:\\Users\\admin\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\4.jpg";
            if (picturenumber == 5) slider.ImageLocation = "C:\\Users\\admin\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\5.jpg";
            if (picturenumber == 6) { picturenumber = 1; slider.ImageLocation = "C:\\Users\\admin\\source\\repos\\FlyToday\\FlyTodayViews\\Resources\\1.jpg"; }
            picturenumber++;
        }
        public FormMainMenu(ILogger<FormMainMenu> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            //LoadData();
        }
        private void buttonMainEnter_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEnter));
            if (service is FormEnter form)
            {
                form.Show();
                Hide();
            }
        }

        private void buttonMainRegistration_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormRegistration));
            if (service is FormRegistration form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEmployees));
            if (service is FormEmployees form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormSales));
            if (service is FormSales form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonMainSearch_Click(object sender, EventArgs e)
        {
            if (_currentUserId.HasValue || _currentUserId > 0)
            {
                try
                {
                    var currentUser = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                    if (currentUser != null)
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormSearchFlights));
                        if (service is FormSearchFlights form)
                        {
                            form.CurrentUserId = _currentUserId.Value;
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var service = Program.ServiceProvider?.GetService(typeof(FormSearchFlights));
                if (service is FormSearchFlights form)
                {
                    form.ShowDialog();
                }
            }
        }

        private void buttonPlanes_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPlanes));
            if (service is FormPlanes form)
            {
                form.ShowDialog();
            }
        }

        private void buttonDirections_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormDirections));
            if (service is FormDirections form)
            {
                form.ShowDialog();
            }
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormFlights));
            if (service is FormFlights form)
            {
                form.ShowDialog();
            }
        }

        private void buttonMainLK_Click(object sender, EventArgs e)
        {
            if (_currentUserId.HasValue || _currentUserId > 0)
            {
                try
                {
                    Hide();
                    var currentUser = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                    if (currentUser != null)
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormProfile));
                        if (service is FormProfile form)
                        {
                            form.Id = _currentUserId.Value;
                            form.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Сначала авторизуйтесь в системе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            buttonExit.Enabled = false;
            if (_currentUserId != null)
            {
                buttonExit.Enabled = true;
                var user = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                if (user != null)
                {
                    buttonDirections.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonEmployees.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonFlights.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonPlanes.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonSales.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonStatisticTickets.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonDirStatistics.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonMainRegistration.Enabled = false;
                    buttonMainEnter.Enabled = false;
                }
                else
                {
                    buttonDirections.Visible = false;
                    buttonEmployees.Visible = false;
                    buttonFlights.Visible = false;
                    buttonPlanes.Visible = false;
                    buttonSales.Visible = false;
                    buttonStatisticTickets.Visible = false;
                    buttonDirStatistics.Visible = false;
                }
            }
            else
            {
                buttonDirections.Visible = false;
                buttonEmployees.Visible = false;
                buttonFlights.Visible = false;
                buttonPlanes.Visible = false;
                buttonSales.Visible = false;
                buttonStatisticTickets.Visible = false;
                buttonDirStatistics.Visible = false;
            }
            if (_currentUserId == null || _currentUserId <= 0)
            {
                labelIsAuthorized.Text = "Вы не авторизованы";
                labelIsAuthorized.ForeColor = Color.Red;
            }
            else
            {
                labelIsAuthorized.Text = "Вы авторизованы";
                labelIsAuthorized.ForeColor = Color.Green;
            }
            Refresh();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            _currentUserId = null;
            buttonDirections.Visible = false;
            buttonEmployees.Visible = false;
            buttonFlights.Visible = false;
            buttonPlanes.Visible = false;
            buttonSales.Visible = false;
            buttonStatisticTickets.Visible = false;
            buttonExit.Enabled = false;
            buttonMainRegistration.Enabled = true;

            MessageBox.Show("Вы вышли из системы.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            buttonMainEnter.Enabled = true;
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormFlightsSchedule));
            if (service is FormFlightsSchedule form)
            {
                form.ShowDialog();
            }
        }

        private void buttonStatisticTickets_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormStatisticTickets));
            if (service is FormStatisticTickets form)
            {
                form.ShowDialog();
            }
        }

        private void buttonDirStatistics_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormDirectionStatistics));
            if (service is FormDirectionStatistics form)
            {
                form.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ImageSlide();
        }
    }
}
