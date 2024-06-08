using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Enums;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FlyTodayBusinessLogics.BusinessLogics;
using MigraDoc.DocumentObjectModel.Tables;

namespace FlyTodayViews
{
    public partial class FormEmployee : Form
    {
        private readonly ILogger _logger;
        private readonly IEmployeeLogic _logic;
        private readonly IPositionAtWorkLogic _joblogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private int? _id;
        public int Id { set { _id = value; } }
        private readonly List<PositionAtWorkViewModel>? _joblist;
        private readonly List<FlightViewModel>? _flightlist;
        public FormEmployee(ILogger<FormEmployee> logger, IEmployeeLogic logic, IPositionAtWorkLogic joblogic, IFlightLogic flightlogic, IDirectionLogic directionLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _joblogic = joblogic;
            _joblist = new List<PositionAtWorkViewModel>();
            _flightlist = new List<FlightViewModel>();
            _flightlogic = flightlogic;
            _directionlogic = directionLogic;
            dateTimePickerMedAnalys.Enabled = false;
            checkBoxMedAnalys.CheckedChanged += CheckBoxMedAnalys_CheckedChanged;
        }
        

        private void CheckBoxMedAnalys_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerMedAnalys.Enabled = checkBoxMedAnalys.Checked;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            var list = _joblogic.ReadList(null);
            comboBoxJob.DataSource = list;
            comboBoxJob.DisplayMember = "Name";
            comboBoxJob.ValueMember = "Id";
            
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
                        comboBoxTypeWork.SelectedItem = view.TypeWork == 0 ? "Посменная" : "На рейсе";
                        comboBoxGender.SelectedItem = view.Gender == "Женский" ? "Ж" : "М";
                        comboBoxJob.SelectedItem = view.PositionAtWorkId;
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
                if (comboBoxTypeWork.SelectedItem.ToString() == "Посменная")
                {
                    model.TypeWork = TypeWorkEnum.Посменно;
                }
                else
                {
                    model.TypeWork = TypeWorkEnum.НаРейсе;
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
    }
}
