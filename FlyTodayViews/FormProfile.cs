using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormProfile : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private int? _id;
        private string? _password;
        private string? _email;
        public int Id { set { _id = value; } }
        public string Password { set { _password = value; } }
        public string Email { set { _email = value; } }
        public FormProfile(ILogger<FormProfile> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            /*labelSurname.Text = "";
            labelName.Text = "";
            labelLastName.Text = "";
            labelDateOfBirth.Text = "";
            labelEmail.Text = "";*/
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void buttonMyRents_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение пользователя");
                    var view = _logic.ReadElement(new UserSearchModel { Id = _id.Value, Email = _email, Password = _password });
                    if (view != null)
                    {
                        labelSurname.Text = view.Surname.ToString();
                        labelName.Text = view.Name.ToString();
                        labelLastName.Text = view.LastName.ToString();
                        labelDateOfBirth.Text = view.DateOfBirthday.ToString();
                        labelEmail.Text = view.Email.ToString();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
