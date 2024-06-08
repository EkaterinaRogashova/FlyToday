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

namespace FlyTodayViews
{
    public partial class FormSchedule : Form
    {
        private readonly ILogger _logger;
        private readonly IScheduleLogic _schedulelogic;
        private readonly IEmployeeLogic _employeelogic;
        private readonly IPositionAtWorkLogic _joblogic;
        public FormSchedule(ILogger<FormSchedule> logger, IScheduleLogic schedulelogic, IEmployeeLogic employeeLogic, IPositionAtWorkLogic joblogic)
        {
            InitializeComponent();
            _logger = logger;
            _schedulelogic = schedulelogic;
            _employeelogic = employeeLogic;
            dataGridView1.Columns.Add("Fio", "Сотрудник");
            _joblogic = joblogic;
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
            var list = _schedulelogic.ReadList(null);
            var selectedJob = (PositionAtWorkViewModel)comboBox2.SelectedItem;
            int selectedJobId = selectedJob.Id;

            // Получаем список сотрудников с выбранной должностью
            var employeesList = _employeelogic.ReadList(new EmployeeSearchModel
            {
                PositionAtWorkId = selectedJobId
            });

            // Получаем список расписания
            var scheduleList = _schedulelogic.ReadList(new ScheduleSearchModel
            {
                Shift = comboBox1.SelectedItem?.ToString()
            });

            // Объединяем списки сотрудников и расписания
            var filteredList = from employee in employeesList
                               join schedule in scheduleList
                               on employee.Id equals schedule.EmployeeId
                               select schedule;

            var filltredlist1 = from employee in employeesList
                           join schedule in list
                           on employee.Id equals schedule.EmployeeId
                           select schedule;
            // Сохраняем результат в filltredlist
            var filltredlist = filteredList.ToList();
            if (comboBox1.SelectedItem != null && selectedJobId != 0)
            {
                filltredlist = filteredList.ToList();
            }
            if (comboBox1.SelectedItem != null && selectedJobId == 0)
            {
                filltredlist = scheduleList;
            }
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "" && selectedJobId != 0)
            {
                filltredlist = filltredlist1.ToList();
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
    }
}
