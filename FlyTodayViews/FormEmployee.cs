using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormEmployee : Form
    {
        private readonly ILogger _logger;
        private readonly IEmployeeLogic _logic;
        private readonly IPositionAtWorkLogic _joblogic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormEmployee(ILogger<FormEmployee> logger, IEmployeeLogic logic, IPositionAtWorkLogic joblogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _joblogic = joblogic;
            dateTimePickerMedAnalys.Enabled = false;
            checkBoxMedAnalys.CheckedChanged += CheckBoxMedAnalys_CheckedChanged;
        }
        private void CheckBoxMedAnalys_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerMedAnalys.Enabled = checkBoxMedAnalys.Checked;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                _logger.LogInformation("Загрузка сотрудника");
                try
                {
                    var view = _logic.ReadElement(new EmployeeSearchModel
                    {
                        Id = _id.Value
                    });
                    if (view != null)
                    {
                        textBoxSurname.Text = view.Surname;
                        textBoxName.Text = view.Name;
                        textBoxLastName.Text = view.LastName;
                        dateTimePickerBirth.Value = view.DateOfBirth;
                        dateTimePickerMedAnalys.Value = view.DateMedAnalys;
                        checkBoxMedAnalys.Checked = view.MedAnalys;
                        comboBoxGender.SelectedItem = view.Gender == "Женский" ? "Ж" : "М";
                        comboBoxJob.SelectedValue = view.PositionAtWorkId;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка загрузки сотрудника");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) || comboBoxGender.Text == null || comboBoxJob.Text == null)
            {
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int days18 = 365 * 18;
            if (dateTimePickerBirth.Value >= DateTime.Now - TimeSpan.FromDays(days18))
            {
                MessageBox.Show("Возраст сотрудника не может быть меньше 18 лет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение сотрудника");
            try
            {
                // Получить выбранный элемент из comboBoxGender
                string selectedGender = comboBoxGender.SelectedItem.ToString();
                var selectedJob = (PositionAtWorkViewModel)comboBoxJob.SelectedItem;
                // Преобразовать выбранное значение в соответствующую строку
                string genderAsString = (selectedGender == "Ж") ? "Женский" : "Мужской";
                var model = new EmployeeBindingModel
                {
                    Id = _id ?? 0,
                    Surname = textBoxSurname.Text,
                    Name = textBoxName.Text,
                    LastName = textBoxLastName.Text,
                    DateOfBirth = dateTimePickerBirth.Value.ToUniversalTime(),
                    MedAnalys = checkBoxMedAnalys.Checked,
                    PositionAtWorkId = selectedJob.Id,
                    Gender = genderAsString
                };
                if (checkBoxMedAnalys.Checked)
                {
                    dateTimePickerMedAnalys.Enabled = true;
                    model.DateMedAnalys = dateTimePickerMedAnalys.Value.ToUniversalTime();
                }
                else
                {
                    model.DateMedAnalys = new DateTime(1900, 1, 1).ToUniversalTime();
                }
                var operationResult = _id.HasValue ? _logic.Update(model) :
               _logic.Create(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения сотрудника");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void comboBoxTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранное значение в comboBoxTypeWork
            string selectedTypeWork = comboBoxTypeWork.SelectedItem.ToString();

            if (selectedTypeWork == "Посменная")
            {
                // Отфильтровать элементы в comboBoxJob по TypeWork == "посменная"
                var filteredJobs = _joblogic.ReadList(new PositionAtWorkSearchModel { TypeWork = selectedTypeWork });

                // Установить новый источник данных для comboBoxJob
                comboBoxJob.DataSource = filteredJobs;
                comboBoxJob.DisplayMember = "Name";
                comboBoxJob.ValueMember = "Id";
            }
            else
            {
                // Отфильтровать элементы в comboBoxJob по TypeWork == "посменная"
                var filteredJobs = _joblogic.ReadList(new PositionAtWorkSearchModel { TypeWork = selectedTypeWork });

                // Установить новый источник данных для comboBoxJob
                comboBoxJob.DataSource = filteredJobs;
                comboBoxJob.DisplayMember = "Name";
                comboBoxJob.ValueMember = "Id";
            }
        }
    }
}
