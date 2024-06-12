using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayDataModels.Enums;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormProfile : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormProfile(ILogger<FormProfile> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            var user = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
            var service = Program.ServiceProvider?.GetService(typeof(FormEditProfile));
            if (service is FormEditProfile form)
            {
                if (_id != null)
                {
                    Hide();
                    form.Id = _id.Value;
                    form.Email = user.Email;
                    form.Password = user.Password;
                    form.Show();
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
                            form.Refresh();
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
            if (_id.HasValue || _id > 0)
            {
                try
                {
                    var currentUser = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
                    if (currentUser != null)
                    {
                        if (currentUser.AccessRule == AccessEnum.Взрослый || currentUser.AccessRule == AccessEnum.Администратор)
                        {
                            var service = Program.ServiceProvider?.GetService(typeof(FormMyRents));
                            if (service is FormMyRents form)
                            {
                                form.CurrentUserId = _id.Value;
                                form.ShowDialog();
                            }
                        }
                        else MessageBox.Show("Недостаточно прав доступа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        checkBoxAllowNotif.Checked = view.AllowNotifications;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBoxAllowNotif_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var currentUser = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
                bool isAllowNotifications = checkBoxAllowNotif.Checked;
                var model = new UserBindingModel
                {
                    Id = currentUser.Id,
                    Surname = currentUser.Surname,
                    Name = currentUser.Name,
                    LastName = currentUser.LastName,
                    DateOfBirthday = currentUser.DateOfBirthday,
                    Email = currentUser.Email,
                    Password = currentUser.Password,
                    AccessRule = currentUser.AccessRule,
                    AllowNotifications = isAllowNotifications
                };
                var operationResult = _logic.UpdateNotifications(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                }                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения пользователя");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
