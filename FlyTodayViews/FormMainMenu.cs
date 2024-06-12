using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayDataModels.Enums;
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
        public FormMainMenu(ILogger<FormMainMenu> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            LoadData();
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
                    var currentUser = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                    if (currentUser != null)
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormProfile));
                        if (service is FormProfile form)
                        {
                            form.Id = _currentUserId.Value;
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
                MessageBox.Show("Сначала авторизуйтесь в системе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            if (_currentUserId != null)
            {
                var user = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                if (user != null)
                {
                    buttonDirections.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonEmployees.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonFlights.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonPlanes.Visible = user.AccessRule == AccessEnum.Администратор;
                    buttonSales.Visible = user.AccessRule == AccessEnum.Администратор;
                }
                else
                {
                    buttonDirections.Visible = false;
                    buttonEmployees.Visible = false;
                    buttonFlights.Visible = false;
                    buttonPlanes.Visible = false;
                    buttonSales.Visible = false;
                }
            }
            else
            {
                buttonDirections.Visible = false;
                buttonEmployees.Visible = false;
                buttonFlights.Visible = false;
                buttonPlanes.Visible = false;
                buttonSales.Visible = false;
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
    }
}
