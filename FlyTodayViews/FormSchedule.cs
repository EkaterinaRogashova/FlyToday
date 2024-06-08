using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
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
    public partial class FormSchedule : Form
    {
        private readonly ILogger _logger;
        private readonly IScheduleLogic _schedulelogic;
        private readonly IEmployeeLogic _employeelogic;
        public FormSchedule(ILogger<FormSchedule> logger, IScheduleLogic schedulelogic, IEmployeeLogic employeeLogic)
        {
            InitializeComponent();
            _logger = logger;
            _schedulelogic = schedulelogic;
            _employeelogic = employeeLogic;
            dataGridView1.Columns.Add("Fio", "Сотрудник");
        }
        private void FormSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
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
    }
}
