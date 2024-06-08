using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

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
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEditProfile));
            if (service is FormEditProfile form)
            {
                if (_id != null)
                {
                    form.Id = _id.Value;
                    form.ShowDialog();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы дейстительно хотите удалить профиль?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {                
                _logger.LogInformation("Удаление пользователя");
                try
                {
                    if (!_logic.Delete(new UserBindingModel { Id = _id.Value }))
                    {
                        throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                    }
                    else
                    {
                        MessageBox.Show("Профиль успешно удален.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        _id = null;
                        var service = Program.ServiceProvider?.GetService(typeof(FormMainMenu));
                        if (service is FormMainMenu form)
                        {
                            form.CurrentUserId = -1;
                            form.LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка удаления пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
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
                    var view = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        labelFIO.Text = view.Surname + " " + view.Name + " " + view.LastName;
                        labelDateOfBirth.Text = view.DateOfBirthday.ToShortDateString();
                        labelEmail.Text = view.Email;
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
