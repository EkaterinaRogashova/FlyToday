using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
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

namespace FlyTodayViews
{
    public partial class FormEmployees : Form
    {
        private readonly ILogger _logger;
        private readonly IEmployeeLogic _logic;
        private readonly IPositionAtWorkLogic _joblogic;
        private readonly IReportLogic _reportlogic;

        public FormEmployees(ILogger<FormEmployee> logger, IEmployeeLogic logic, IFlightLogic flightlogic, IPositionAtWorkLogic joblogic, IDirectionLogic directionlogic, IReportLogic reportLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _reportlogic = reportLogic;
            _joblogic = joblogic;
            dataGridView1.Columns.Add("Job", "Должность");
            dataGridView1.Columns.Add("MedAnalysData", "Медицинский осмотр действует до:");
        }


        private void FormEmployees_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _logic.ReadList(null);
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["Surname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["DateOfBirth"].Visible = false;
                    dataGridView1.Columns["MedAnalys"].Visible = false;
                    dataGridView1.Columns["DateMedAnalys"].Visible = false;
                    dataGridView1.Columns["DateMedAnalys"].DefaultCellStyle.Format = "d";
                    dataGridView1.Columns["PositionAtWorkId"].Visible = false;
                    dataGridView1.Columns["Job"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["MedAnalysData"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Gender"].Visible = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int jobId = Convert.ToInt32(row.Cells["PositionAtWorkId"].Value);
                        var job = _joblogic.ReadElement(new PositionAtWorkSearchModel
                        {
                            Id = jobId
                        });
                        if (job != null)
                        {
                            row.Cells["Job"].Value = job.Name;
                        }
                        else
                        {
                            row.Cells["Job"].Value = "Должность не найдена";
                        }
                        if (row.Cells["DateMedAnalys"].Value != null && row.Cells["DateMedAnalys"].Value.ToString() == new DateTime(1900, 1, 1).ToUniversalTime().ToString())
                        {
                            row.Cells["MedAnalysData"].Value = "Нет осмотра";
                        }
                        else
                        {
                            string dateString = ((DateTime)row.Cells["DateMedAnalys"].Value).ToString("d");
                            row.Cells["MedAnalysData"].Value = dateString;
                        }

                    }

                }
                _logger.LogInformation("Загрузка сотрудников");
                var joblist = _joblogic.ReadList(null);
                comboBoxJob.DataSource = joblist;
                comboBoxJob.DisplayMember = "Name";
                comboBoxJob.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки сотрудников");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPositionAtWorks));
            if (service is FormPositionAtWorks form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEmployee));
            if (service is FormEmployee form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var service = Program.ServiceProvider?.GetService(typeof(FormEmployee));
                if (service is FormEmployee form)
                {
                    form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись?", "Вопрос",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    _logger.LogInformation("Удаление сотрудника");
                    try
                    {
                        if (!_logic.Delete(new EmployeeBindingModel
                        {
                            Id = id
                        }))
                        {
                            throw new Exception("Ошибка при удалении.Дополнительная информация в логах.");
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка удаления сотрудника");
                        MessageBox.Show(ex.Message, "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonSaveFilter_Click(object sender, EventArgs e)
        {
            var selectedJob = (PositionAtWorkViewModel)comboBoxJob.SelectedItem;
            int selectedJobId = selectedJob.Id;
            var filltredlist = _logic.ReadList(new EmployeeSearchModel
            {
                PositionAtWorkId = selectedJobId
            });
            if (filltredlist != null)
            {
                dataGridView1.DataSource = filltredlist;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Surname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["DateOfBirth"].Visible = false;
                dataGridView1.Columns["MedAnalys"].Visible = false;
                dataGridView1.Columns["DateMedAnalys"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["PositionAtWorkId"].Visible = false;
                dataGridView1.Columns["Job"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["Gender"].Visible = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int jobId = Convert.ToInt32(row.Cells["PositionAtWorkId"].Value);
                    var job = _joblogic.ReadElement(new PositionAtWorkSearchModel
                    {
                        Id = jobId
                    });
                    if (job != null)
                    {
                        row.Cells["Job"].Value = job.Name;
                    }
                    else
                    {
                        row.Cells["Job"].Value = "Должность не найдена";
                    }
                    if (row.Cells["DateMedAnalys"].Value != null && row.Cells["DateMedAnalys"].Value.ToString() == new DateTime(1900, 1, 1).ToUniversalTime().ToString())
                    {
                        row.Cells["MedAnalysData"].Value = "Нет осмотра";
                    }
                    if (row.Cells["DateMedAnalys"].Value is DateTime dateMedAnalys && dateMedAnalys < DateTime.Now)
                    {
                        row.Cells["MedAnalysData"].Value = "Закончился";
                    }
                    else { row.Cells["MedAnalysData"].Value = row.Cells["DateMedAnalys"].Value.ToString(); }

                }

            }
        }

        private void buttonDeteteFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormSchedule));
            if (service is FormSchedule form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonScheduleForEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Получаем значение TypeWork из выбранной строки
                int workId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PositionAtWorkId"].Value);
                var typeWork = _joblogic.ReadElement(new PositionAtWorkSearchModel { Id = workId });
                if (typeWork != null)
                {
                    // Проверяем, является ли тип работы "на рейсе"
                    if (typeWork.TypeWork == "На рейсе")
                    {
                        // Выводим сообщение и выходим из метода
                        MessageBox.Show("Этот сотрудник работает на рейсах", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                int employeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var employee = _logic.ReadElement(new EmployeeSearchModel { Id = employeeId });
                if (employee.MedAnalys == false || employee.DateMedAnalys <= DateTime.Now)
                {
                    MessageBox.Show("У сотрудника закончится мед. осмотр", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Если тип работы не "на рейсе", продолжаем выполнение метода
                var service = Program.ServiceProvider?.GetService(typeof(FormScheduleForEmployee));
                if (service is FormScheduleForEmployee form)
                {
                    form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void buttonEmployeePdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Получаем значение TypeWork из выбранной строки
                int workId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PositionAtWorkId"].Value);
                var typeWork = _joblogic.ReadElement(new PositionAtWorkSearchModel { Id = workId });
                if (typeWork != null)
                {
                    // Проверяем, является ли тип работы "на рейсе"
                    if (typeWork.TypeWork == "На рейсе")
                    {
                        // Выводим сообщение и выходим из метода
                        MessageBox.Show("Этот сотрудник работает на рейсах", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                // Получаем значение Id из выбранной строки
                int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _reportlogic.SaveReportScheduleForEmployeeToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                            EmployeeId = Id,
                            DateTo = DateTime.Now,
                            DateFrom = DateTime.Now + TimeSpan.FromDays(7)
                        });
                        _logger.LogInformation("Сохранение расписание за сотрудника");
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка сохранения");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonToPdfMonth_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Получаем значение TypeWork из выбранной строки
                int workId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PositionAtWorkId"].Value);
                var typeWork = _joblogic.ReadElement(new PositionAtWorkSearchModel { Id = workId });
                if (typeWork != null)
                {
                    // Проверяем, является ли тип работы "на рейсе"
                    if (typeWork.TypeWork == "На рейсе")
                    {
                        // Выводим сообщение и выходим из метода
                        MessageBox.Show("Этот сотрудник работает на рейсах", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                // Получаем значение Id из выбранной строки
                int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DateTime currentDate = DateTime.Now;
                        var firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                        _reportlogic.SaveReportScheduleForEmployeeToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                            EmployeeId = Id,
                            DateFrom = firstDayOfMonth.ToUniversalTime(),
                            DateTo = lastDayOfMonth.ToUniversalTime()
                        });
                        _logger.LogInformation("Сохранение расписание за сотрудника");
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка сохранения");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
