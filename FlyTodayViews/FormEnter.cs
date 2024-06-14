using FlyTodayBusinessLogics.MailWorker;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;
using System;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormEnter : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private readonly AbstractMailWorker _mailWorker;
        Random rnd = new Random();
        private static readonly Random _random = new Random();
        public FormEnter(ILogger<FormEnter> logger, IUserLogic logic, AbstractMailWorker mailWorker)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _mailWorker = mailWorker;
        }
        public static string GenerateRandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var CurrentUser = _logic.ReadElement(new UserSearchModel
                {
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                });
                if (CurrentUser != null)
                {
                    MessageBox.Show("Вы вошли", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    var service = Program.ServiceProvider?.GetService(typeof(FormMainMenu));
                    if (service is FormMainMenu newForm)
                    {
                        newForm.CurrentUserId = CurrentUser.Id;
                        newForm.Show();/*
                        newForm.LoadData();
                        newForm.Refresh(); */
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный адрес электронной почты или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка входа в систему");
                throw;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {

                string confirmationCode = GenerateRandomString();
                _mailWorker.MailSendAsync(new()
                {
                    MailAddress = textBoxEmail.Text,
                    Subject = "Код для подтвержения смены пароля:",
                    Text = $"Ваш код подтверждения: {confirmationCode}"
                });
                var CurrentUser = _logic.ReadElement(new UserSearchModel
                {
                    Email = textBoxEmail.Text
                });
                if (CurrentUser != null)
                {
                    var form = new ConfirmationDialogPassword(confirmationCode, _logic);
                    form.CurrentUserId = CurrentUser.Id;
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Пользователь с такой почтой не зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите почту, на которую нужно отправить письмо с подтверждением", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormMainMenu));
            if (service is FormMainMenu newForm)
            {
                newForm.Show();
                newForm.LoadData();
                newForm.Refresh();
                Close();
            }
        }
    }
}
