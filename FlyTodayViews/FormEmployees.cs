using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
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
    public partial class FormEmployees : Form
    {
        private readonly ILogger _logger;
        private readonly IEmployeeLogic _logic;
        private readonly IFlightLogic _flightlogic;
        private readonly IPositionAtWorkLogic _joblogic;

        public FormEmployees(ILogger<FormEmployee> logger, IEmployeeLogic logic, IFlightLogic flightlogic, IPositionAtWorkLogic joblogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _flightlogic = flightlogic;
            _joblogic = joblogic;
            dataGridView1.Columns.Add("Flight", "Рейс");
            dataGridView1.Columns.Add("Job", "Должность");
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
                    dataGridView1.Columns["DateOfBirth"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["MedAnalys"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["DateMedAnalys"].Visible = false;
                    dataGridView1.Columns["PositionAtWorkId"].Visible = false;
                    dataGridView1.Columns["FlightId"].Visible = false;
                    dataGridView1.Columns["Job"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Flight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

                        int flightId = Convert.ToInt32(row.Cells["FlightId"].Value);
                        var flight = _flightlogic.ReadElement(new FlightSearchModel
                        {
                            Id = flightId
                        });
                        if (flight != null)
                        {
                            row.Cells["Flight"].Value = flight.Id;
                        }
                        else
                        {
                            row.Cells["Flight"].Value = "Рейс не найден";
                        }
                    }

                }
                _logger.LogInformation("Загрузка сотрудников");
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
    }
}
