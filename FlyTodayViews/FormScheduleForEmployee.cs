using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using Microsoft.Extensions.Logging;
using FlyTodayContracts.ViewModels;
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
using FlyTodayContracts.SearchModels;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FlyTodayViews
{
    public partial class FormScheduleForEmployee : Form
    {
        private readonly ILogger _logger;
        private readonly IScheduleLogic _schedulelogic;
        private readonly IEmployeeLogic _employeelogic;
        private int? _id;
        public int Id { set { _id = value; } }
        private int? _scheduleid;
        public int ScheduleId { set { _scheduleid = value; } }
        public FormScheduleForEmployee(ILogger<FormScheduleForEmployee> logger, IScheduleLogic logic, IEmployeeLogic employeelogic)
        {
            InitializeComponent();
            _logger = logger;
            _schedulelogic = logic;
            _employeelogic = employeelogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_scheduleid.HasValue)
            {
                
                var model = new ScheduleBindingModel
                {
                    Id = _scheduleid ?? 0,
                    Date = dateTimePicker1.Value.ToUniversalTime(),
                    Shift = comboBoxShift.SelectedItem.ToString()                
                };
                var operationResult = _schedulelogic.Update(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при изменении. Дополнительная информация в логах.");
                }
                MessageBox.Show("Изменение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (comboBoxShift.Text == null)
                {
                    MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _logger.LogInformation("Сохранение расписания");
                try
                {
                    var shifts = new[] { "День", "Ночь", "Отсыпной", "Выходной" };
                    int shiftIndex = Array.IndexOf(shifts, comboBoxShift.Text);
                    if (shiftIndex == -1)
                    {
                        throw new Exception("Выбрана неизвестная смена");
                    }
                    DateTime date = dateTimePicker1.Value.ToUniversalTime();
                    int countDays = 30;
                    var employee = _employeelogic.ReadElement(new EmployeeSearchModel { Id = _id });
                    DateTime endDate = employee.DateMedAnalys;

                    if (employee.DateMedAnalys < DateTime.Now + TimeSpan.FromDays(30))
                    {
                        TimeSpan remainingDays = endDate - DateTime.Now;
                        countDays = remainingDays.Days;
                    }

                    for (int i = 0; i < countDays; i++)
                    {
                        if (date.Date >= endDate.AddDays(1).Date)
                        {
                            break;
                        }

                        var model = new ScheduleBindingModel
                        {
                            EmployeeId = _id ?? 0,
                            Shift = shifts[shiftIndex],
                            Date = date,
                            Presence = false
                        };
                        var operationResult = _schedulelogic.Create(model);
                        if (!operationResult)
                        {
                            throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                        }
                        shiftIndex = (shiftIndex + 1) % shifts.Length;
                        date = date.AddDays(1);
                    }
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка сохранения расписания");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            
        }

        private void FormScheduleForEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (_scheduleid.HasValue)
            {
                try
                {
                    var view = _schedulelogic.ReadElement(new ScheduleSearchModel
                    {
                        Id = _scheduleid.Value
                    });
                    
                    if (view != null)
                    {
                        if (view.Shift == "День") comboBoxShift.SelectedItem = "День";
                        if (view.Shift == "Ночь") comboBoxShift.SelectedItem = "Ночь";
                        if (view.Shift == "Отсыпной") comboBoxShift.SelectedItem = "Отсыпной";
                        if (view.Shift == "Выходной") comboBoxShift.SelectedItem = "Выходной";
                        dateTimePicker1.Value = view.Date;
                        comboBoxShift.SelectedValue = view.Shift;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения расписания");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
