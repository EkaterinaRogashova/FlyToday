using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace FlyTodayViews
{
    public partial class FormEditProfile : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        private string? _password;
        private string? _email;
        public string Password { set { _password = value; } }
        public string Email { set { _email = value; } }
        public FormEditProfile(ILogger<FormEditProfile> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
         {
            if (string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxLastname.Text) || string.IsNullOrEmpty(dateTimePickerDateOfBirth.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение изменений данных пользователя");
            try
            {
                if (_email != null && _password != null)
                {
                    var model = new UserBindingModel
                    {
                        Id = _id.Value,
                        Surname = textBoxSurname.Text,
                        Name = textBoxName.Text,
                        LastName = textBoxLastname.Text,
                        DateOfBirthday = dateTimePickerDateOfBirth.Value.ToUniversalTime(),
                        Email = _email,
                        Password = textBoxPassword.Text.IsNullOrEmpty() ? _password : textBoxPassword.Text
                    };
                    var operationResult = _id.HasValue && _logic.Update(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        var currentUser = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
                        if (currentUser != null)
                        {
                            var service = Program.ServiceProvider?.GetService(typeof(FormProfile));
                            if (service is FormProfile form)
                            {
                                form.Id = _id.Value;
                                form.Show();
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
                    Close();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения изменений данных пользователя");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxRepeatPassword.UseSystemPasswordChar = true;
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение пользователя");
                    var view = _logic.ReadElement(new UserSearchModel { Id = _id.Value, Email = _email, Password = _password });
                    if (view != null)
                    {
                        textBoxSurname.Text = view.Surname;
                        textBoxName.Text = view.Name;
                        textBoxLastname.Text = view.LastName;
                        dateTimePickerDateOfBirth.Text = view.DateOfBirthday.ToString();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonEditPassword_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы дейстительно хотите поменять пароль?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                textBoxPassword.ReadOnly = false;
                textBoxRepeatPassword.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void buttonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonShowRepeatPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxRepeatPassword.UseSystemPasswordChar = false;
        }

        private void buttonShowRepeatPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxRepeatPassword.UseSystemPasswordChar = true;
        }
    }
}
