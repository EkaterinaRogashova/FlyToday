using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlyTodayViews
{
    public partial class ConfirmationDialogPassword : Form
    {
        private readonly IUserLogic _logic;
        private readonly string _confirmationCode;
        private int? _currentUserId;
        public int CurrentUserId { set { _currentUserId = value; } }
        public ConfirmationDialogPassword(string confirmationCode, IUserLogic userLogic)
        {
            InitializeComponent();
            _confirmationCode = confirmationCode;
            _logic = userLogic;
            textBoxPassword.Enabled = false;
            textBoxRepeatPassword.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == _confirmationCode)
            {
                textBoxPassword.Enabled = true;
                textBoxRepeatPassword.Enabled = true;
            }
            else
            {
                textBoxPassword.Enabled = false;
                textBoxRepeatPassword.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_currentUserId.HasValue)
            {
                try
                {
                    if (textBox1.Text == _confirmationCode)
                    {
                        if (textBoxPassword != null && textBoxRepeatPassword !=null && textBoxPassword.Text == textBoxRepeatPassword.Text)
                        {
                            var model = _logic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                            var user = new UserBindingModel
                            {
                                Id = _currentUserId ?? -1,
                                Surname = model.Surname,
                                Name = model.Name,
                                LastName = model.LastName,
                                DateOfBirthday = model.DateOfBirthday,
                                Email = model.Email,
                                AccessRule = model.AccessRule,
                                Password = textBoxPassword.Text
                            };
                            var operationResult = _logic.Update(user);
                            if (!operationResult)
                            {
                                throw new Exception("Ошибка при изменении");
                            }
                            MessageBox.Show("Вы изменили пароль", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("Неверный код подтверждения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
