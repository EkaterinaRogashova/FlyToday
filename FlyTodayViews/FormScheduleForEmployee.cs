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

namespace FlyTodayViews
{
    public partial class FormScheduleForEmployee : Form
    {
        private readonly ILogger _logger;
        private readonly IScheduleLogic _schedulelogic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormScheduleForEmployee(ILogger<FormScheduleForEmployee> logger, IScheduleLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _schedulelogic = logic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
                for (int i = 0; i < 30; i++)
                {
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
}
