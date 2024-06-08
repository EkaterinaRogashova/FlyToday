﻿using FlyTodayBusinessLogics.BusinessLogics;
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

        public FormEmployees(ILogger<FormEmployee> logger, IEmployeeLogic logic, IFlightLogic flightlogic, IPositionAtWorkLogic joblogic, IDirectionLogic directionlogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
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
                    dataGridView1.Columns["TypeWork"].Visible = false;
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
                        else {
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
    }
}
