using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
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
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
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
                        dataGridView1.Columns["Cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns["NumberOfBusiness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns["NumberOfEconomy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                                    row.Cells["Flight"].Value = dir.CityFrom + " - " + dir.CityTo;
                                }
                                else
                                {
                                    row.Cells["Flight"].Value = "Рейс не найден";
                                }
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
                        button1.Enabled = false;
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
                        buttonLookTickets.Enabled = false;
                    }
                }
                else
                {
                    
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
                        button1.Enabled = false;
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
                        buttonLookTickets.Enabled = false;
                    }
                }
            }
        }
    }
}
