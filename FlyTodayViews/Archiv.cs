using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Enums;
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
    public partial class Archiv : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private int? _id;
        public int CurrentUserId { set { _id = value; } }
        public Archiv(ILogger<FormMyRents> logger, IUserLogic logic, IRentLogic rentLogic, IFlightLogic flightlogic, IDirectionLogic directionlogic)
        {
            InitializeComponent();
            _logic = logic;
            _logger = logger;
            _rentlogic = rentLogic;
            dataGridView1.Columns.Add("Flight", "Рейс");
            dataGridView1.Columns.Add("StatusFlight", "Состояние");
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
        }

        private void Archiv_Load(object sender, EventArgs e)
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
                    var flightlistOtmena = _flightlogic.ReadList(new FlightSearchModel { FlightStatus = FlightStatusEnum.Отменен });
                    var flightlistViletel = _flightlogic.ReadList(new FlightSearchModel { FlightStatus = FlightStatusEnum.Вылетел });

                    var flights = flightlistOtmena.Concat(flightlistViletel);

                    // Фильтруем список бронирований по UserId и FlightId
                    var filteredList = new List<RentViewModel>();
                    foreach (var flight in flights)
                    {
                        filteredList.AddRange(list.Where(r => flight.Id.Equals(r.FlightId)).ToList());
                    }

                    if (filteredList != null)
                    {
                        dataGridView1.DataSource = filteredList;
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
                                if (flight.FlightStatus == FlightStatusEnum.РегистрацияНеНачалась)
                                {
                                    row.Cells["StatusFlight"].Value = "Регистрация не началась";
                                }
                                else if (flight.FlightStatus == FlightStatusEnum.РегистрацияИдет)
                                {
                                    row.Cells["StatusFlight"].Value = "Регистрация идет";
                                }
                                else if (flight.FlightStatus == FlightStatusEnum.РегистрацияЗакончилась)
                                {
                                    row.Cells["StatusFlight"].Value = "Регистрация закончилась";
                                }
                                else if (flight.FlightStatus == FlightStatusEnum.Отменен)
                                {
                                    row.Cells["StatusFlight"].Value = "Отменен";
                                }
                                else if (flight.FlightStatus == FlightStatusEnum.Неизвестен)
                                {
                                    row.Cells["StatusFlight"].Value = "Неизвестен";
                                }
                                else if (flight.FlightStatus == FlightStatusEnum.Вылетел)
                                {
                                    row.Cells["StatusFlight"].Value = "Вылетел";
                                }
                                dataGridView1.Columns["StatusFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
    }
}
