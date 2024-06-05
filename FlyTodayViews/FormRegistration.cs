using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using Microsoft.Extensions.Logging;
using FlyTodayDataModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlyTodayBusinessLogics.MailWorker;

namespace FlyTodayViews
{
    public partial class FormRegistration : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private readonly AbstractMailWorker _mailWorker;
        private int? _id;
        Random rnd = new Random();
        public int Id { set { _id = value; } }
        public FormRegistration(ILogger<FormRegistration> logger, IUserLogic logic, AbstractMailWorker mailWorker)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _mailWorker = mailWorker;
        }
        private static readonly Random _random = new Random();

        public static string GenerateRandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxRepeatPassword.Text) && dateTimePickerBirth == null)
            {
                MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( textBoxPassword.Text != textBoxRepeatPassword.Text )
            {
                MessageBox.Show("Повторите пароль еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение пользователя");
            try
            {
                var model = new UserBindingModel
                {
                    Id = _id ?? 0,
                    Surname = textBoxSurname.Text,
                    Name = textBoxName.Text,
                    LastName = textBoxLastName.Text,
                    DateOfBirthday = dateTimePickerBirth.Value.ToUniversalTime(),
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                    AccessRule = AccessEnum.Администратор
                };
                //string confirmationCode = GenerateRandomString();
                //var mailmodel = new MailSendInfoBindingModel 
                //{
                //    MailAddress = textBoxEmail.Text,
                //    Text = confirmationCode,
                //    Subject = "Код подтверждения"
                //};
                //_mailWorker.MailSendAsync(mailmodel);

                //ConfirmationDialog confirmationDialog = new ConfirmationDialog(confirmationCode);
                //if (confirmationDialog.ShowDialog() == DialogResult.OK)
                //{
                    var operationResult = _logic.Create(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                    MessageBox.Show("Вы зарегестрировались", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                //}
                //else
                //{
                //    MessageBox.Show("Неверный код подтверждения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения пользователя");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
