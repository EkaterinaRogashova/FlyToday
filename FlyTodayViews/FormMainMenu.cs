using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
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
        }
        private void buttonMainEnter_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEnter));
            if (service is FormEnter form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
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
            var service = Program.ServiceProvider?.GetService(typeof(FormFlights));
            if (service is FormFlights form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonPlanes_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPlanes));
            if (service is FormPlanes form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonDirections_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormDirections));
            if (service is FormDirections form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormFlights));
            if (service is FormFlights form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonMainLK_Click(object sender, EventArgs e)
        {
            if (_currentUserId.HasValue)
            {
                try
                {
                    var currentUser = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value, Email = _email, Password = _password });
                    if (currentUser != null)
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormProfile));
                        if (service is FormProfile form)
                        {
                            form.Id = _currentUserId.Value;
                            form.Password = currentUser.Password;
                            form.Email = currentUser.Email;
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                // LoadData();
                            }
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
                MessageBox.Show("Идентификатор пользователя null", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
