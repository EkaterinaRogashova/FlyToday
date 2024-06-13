using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using MigraDoc.DocumentObjectModel.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormMyRents : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private int? _id;
        public int CurrentUserId { set { _id = value; } }
        public FormMyRents(ILogger<FormMyRents> logger, IUserLogic logic, IRentLogic rentLogic, IFlightLogic flightlogic, IDirectionLogic directionlogic)
        {
            InitializeComponent();
            _logic = logic;
            _logger = logger;
            _rentlogic = rentLogic;
            dataGridView1.Columns.Add("Flight", "Рейс");
            dataGridView1.Columns.Add("StatusFlight", "Состояние");
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
            buttonDeleteRent.Enabled = false;
        }

        private void FormMyRents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (_id.HasValue)
                {
                    var list = _rentlogic.ReadList(new RentSearchModel
                    {
                        UserId = _id.Value
                    });
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["UserId"].Visible = false;
                        dataGridView1.Columns["FlightId"].Visible = false;
                        dataGridView1.Columns["Flight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                        dataGridView1.Columns["Cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns["NumberOfBusiness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        dataGridView1.Columns["NumberOfEconomy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        dataGridView1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns["StatusFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            int flightId = Convert.ToInt32(row.Cells["FlightId"].Value);
                            var flight = _flightlogic.ReadElement(new FlightSearchModel
                            {
                                Id = flightId
                            });
                            if (flight != null)
                            {
                                var dir = _directionlogic.ReadElement(new DirectionSearchModel
                                {
                                    Id = flight.DirectionId
                                });
                                if (dir != null)
                                {
                                    row.Cells["Flight"].Value = dir.CityFrom + " - " + dir.CityTo + " " + flight.DepartureDate;
                                }
                                else
                                {
                                    row.Cells["Flight"].Value = "Рейс не найден";
                                }
                            }
                            if (DateTime.Now >= flight.DepartureDate)
                            {
                                row.Cells["StatusFlight"].Value = "Вылетел";
                                buttonDeleteRent.Enabled = true;
                            }
                            if (DateTime.Now >= flight.DepartureDate - TimeSpan.FromMinutes(40) && DateTime.Now < flight.DepartureDate)
                            {
                                row.Cells["StatusFlight"].Value = "Регистрация закончилась";
                            }
                            
                            if (DateTime.Now > flight.DepartureDate - TimeSpan.FromHours(2) && DateTime.Now < flight.DepartureDate - TimeSpan.FromMinutes(40))
                            {
                                row.Cells["StatusFlight"].Value = "Регистрация идет";
                            }
                            if (DateTime.Now < flight.DepartureDate - TimeSpan.FromHours(2))
                            {
                                row.Cells["StatusFlight"].Value = "Регистрация еще не началась";
                            }
                        }

                    }
                    _logger.LogInformation("Загрузка бронирований");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки бронирований");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                var rent = _rentlogic.ReadElement(new RentSearchModel { Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) });
                if (rent != null)
                {
                    if (rent.Status == "Оплачено")
                    {
                        MessageBox.Show("Билеты уже оформлены. Вы можете их только посмотреть и зарегистрировать на рейс", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormTickets));
                        if (service is FormTickets form)
                        {
                            form.CurrentRentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                LoadData();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите бронирование", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonLookTickets_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var rent = _rentlogic.ReadElement(new RentSearchModel { Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) });
                if (rent != null)
                {
                    if (rent.Status == "Оплачено")
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormRentTickets));
                        if (service is FormRentTickets form)
                        {
                            form.CurrentRentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                LoadData();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сначала надо оформить билеты!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonDeleteRent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string statusFlight = dataGridView1.SelectedRows[0].Cells["StatusFlight"].Value.ToString();
                if (statusFlight == "Вылетел")
                {
                    if (MessageBox.Show("Удалить запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                        _logger.LogInformation("Удаление брони");
                        try
                        {
                            if (!_rentlogic.Delete(new RentBindingModel { Id = id }))
                            {
                                throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                            }
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, "Ошибка удаления брони");
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не можете удалить запись, так как самолет еще не вылетел.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
