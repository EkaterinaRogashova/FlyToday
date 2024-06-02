using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormEnter : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        public FormEnter(ILogger<FormRegistration> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("��������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("�� �����", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("������������ ����� ����������� ����� ��� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "������ ����� � �������");
                throw;
            }

        }
    }
}
