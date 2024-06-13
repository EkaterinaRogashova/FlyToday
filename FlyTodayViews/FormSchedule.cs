using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FlyTodayViews
{
    public partial class FormSchedule : Form
    {
        private readonly ILogger _logger;
        private readonly IScheduleLogic _schedulelogic;
        private readonly IEmployeeLogic _employeelogic;
        private readonly IPositionAtWorkLogic _joblogic;
        private readonly IReportLogic _logic;

        public FormSchedule(ILogger<FormSchedule> logger, IScheduleLogic schedulelogic, IEmployeeLogic employeeLogic, IPositionAtWorkLogic joblogic, IReportLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _schedulelogic = schedulelogic;
            _employeelogic = employeeLogic;
            dataGridView1.Columns.Add("Fio", "Сотрудник");
            _joblogic = joblogic;
            dateTimePickerFrom.Enabled = false;
            dateTimePickerTo.Enabled = false;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            _logic = logic;
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = checkBox.Checked;
            dateTimePickerTo.Enabled = checkBox.Checked;
        }
        private void FormSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var joblist = _joblogic.ReadList(null);
            var emptyItem = new PositionAtWorkViewModel
            {
                Id = 0,
                Name = ""
            };
            // Добавляем пустой элемент в начало списка
            joblist.Insert(0, emptyItem);
            comboBox2.DataSource = joblist;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            try
            {
                var list = _schedulelogic.ReadList(null);
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["EmployeeId"].Visible = false;
                    dataGridView1.Columns["Shift"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "d";
                    dataGridView1.Columns["Presence"].Visible = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int employeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value);
                        var employee = _employeelogic.ReadElement(new EmployeeSearchModel
                        {
                            Id = employeeId
                        });
                        if (employee != null)
                        {
                            row.Cells["Fio"].Value = employee.Surname + " " + employee.Name;
                        }
                        else
                        {
                            row.Cells["Fio"].Value = "Сотрудник не найден";
                        }
                    }
                }
                _logger.LogInformation("Загрузка расписания");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки расписания");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFilter_Click(object sender, EventArgs e)
        {
            //список без фильтра
            var list = _schedulelogic.ReadList(null);
            //получение должности
            var selectedJob = (PositionAtWorkViewModel)comboBox2.SelectedItem;
            int selectedJobId = selectedJob.Id;
            //получение периода
            DateTime startDate = dateTimePickerFrom.Value.Date.ToUniversalTime();
            DateTime endDate = dateTimePickerTo.Value.Date.ToUniversalTime().AddDays(1).AddTicks(-1);
            //расписание по периоду
            var listDate = _schedulelogic.ReadList(new ScheduleSearchModel
            {
                DateFrom = startDate,
                DateTo = endDate
            });
            //сотрудники по должности
            var employeesList = _employeelogic.ReadList(new EmployeeSearchModel
            {
                PositionAtWorkId = selectedJobId
            });
            //сотрудники по смене
            var scheduleList = _schedulelogic.ReadList(new ScheduleSearchModel
            {
                Shift = comboBox1.SelectedItem?.ToString()
            });
            
            //объединение списков сотрудников и расписания (оба фильтрованны)
            var filteredList = from employee in employeesList
                               join schedule in scheduleList
                               on employee.Id equals schedule.EmployeeId
                               select schedule;
            //объединение списков сотрудников и расписания (фильтр только по должности)
            var filltredlist1 = from employee in employeesList
                                join schedule in list
                                on employee.Id equals schedule.EmployeeId
                                select schedule;
            // Сохраняем результат в filltredlist
            var filltredlist = filteredList.ToList();
            ////если комбобоксы не пустые
            if (comboBox1.SelectedItem != null && selectedJobId != 0)
            {
                filltredlist = filteredList.ToList();
                //если комбобоксы не пустые и datefrom dateto тоже
                if (checkBox.Checked)
                {
                    filltredlist = filteredList.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
            }
            //если смена есть, а должности нет
            if (comboBox1.SelectedItem != null && selectedJobId == 0)
            {
                filltredlist = scheduleList;
                //datefrom dateto не пустые
                if (checkBox.Checked)
                {
                    filltredlist = filteredList.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
            }
            //если смены нет, а должность есть
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "" && selectedJobId != 0)
            {
                filltredlist = filltredlist1.ToList();
                //datefrom dateto не пустые
                if (checkBox.Checked)
                {
                    filltredlist = filteredList.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                }
            }
            //если только фильтр по датам
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "" && selectedJobId == 0 && checkBox.Checked)
            {
                filltredlist = listDate;
            }
            try
            {
                if (filltredlist != null)
                {
                    dataGridView1.DataSource = filltredlist;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["EmployeeId"].Visible = false;
                    dataGridView1.Columns["Shift"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "d";
                    dataGridView1.Columns["Presence"].Visible = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int employeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value);
                        var employee = _employeelogic.ReadElement(new EmployeeSearchModel
                        {
                            Id = employeeId
                        });
                        if (employee != null)
                        {
                            row.Cells["Fio"].Value = employee.Surname + " " + employee.Name;
                        }
                        else
                        {
                            row.Cells["Fio"].Value = "Сотрудник не найден";
                        }
                    }
                }
                _logger.LogInformation("Загрузка расписания");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки расписания");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFilterCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonToPdf_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _logic.SaveReportScheduleToPdfFile(new ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        DateFrom = dateTimePickerFrom.Value.ToUniversalTime(),
                        DateTo = dateTimePickerTo.Value.ToUniversalTime()
                    });
                    _logger.LogInformation("Сохранение расписание за период {From}-{To}", dateTimePickerFrom.Value.ToShortDateString(), dateTimePickerTo.Value.ToShortDateString());
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка сохранения списка заказов на период");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
