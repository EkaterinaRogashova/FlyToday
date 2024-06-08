using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
namespace FlyTodayViews
{
    public partial class FormSearchFlights : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IDirectionLogic _directionLogic;
        public FormSearchFlights(ILogger<FormFlights> logger, IFlightLogic logic, IPlaneLogic planeLogic, IDirectionLogic directionLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _planeLogic = planeLogic;
            dataGridView.Columns.Add("FlightDirection", "Направление");
            dataGridView.Columns.Add("PlaneModel", "Самолет");
            dataGridView.Columns["PlaneModel"].Visible = false;
            dataGridView.Columns["FlightDirection"].Visible = false;
            dataGridView.Visible = false;
            _directionLogic = directionLogic;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (!textBoxDirectionCountryFrom.Text.IsNullOrEmpty() || !textBoxDirectionCityFrom.Text.IsNullOrEmpty() || !textBoxDirectionCountryTo.Text.IsNullOrEmpty() || !textBoxDirectionCityTo.Text.IsNullOrEmpty())
                {
                    List<FlightViewModel> foundFlights = [];
                    var directions = _directionLogic.ReadList(new DirectionSearchModel
                    {
                        CountryFrom = textBoxDirectionCountryFrom.Text,
                        CityFrom = textBoxDirectionCityFrom.Text,
                        CountryTo = textBoxDirectionCountryTo.Text,
                        CityTo = textBoxDirectionCityTo.Text
                    });

                    if (directions != null)
                    {
                        foreach (var dir in directions)
                        {
                            var flights = _logic.ReadList(new FlightSearchModel
                            {
                                DirectionId = dir.Id
                            });
                            if (flights != null)
                            {
                                foreach (var flight in flights)
                                {
                                    foundFlights.Add(flight);
                                }                                
                            }                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("По запросу ничего не найдено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridView.Visible = true;
                    dataGridView.DataSource = foundFlights;
                    dataGridView.Columns["Id"].Visible = false;
                    dataGridView.Columns["DepartureDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["FreePlacesCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["EconomPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["BusinessPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["TimeInFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["PlaneId"].Visible = false;
                    dataGridView.Columns["DirectionId"].Visible = false;
                    dataGridView.Columns["PlaneModel"].Visible = true;
                    dataGridView.Columns["FlightDirection"].Visible = true;
                    dataGridView.Columns["PlaneModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["FlightDirection"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        int planeId = Convert.ToInt32(row.Cells["PlaneId"].Value);
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = planeId
                        });
                        if (plane != null)
                        {
                            row.Cells["PlaneModel"].Value = plane.ModelName;
                        }
                        else
                        {
                            row.Cells["PlaneModel"].Value = "Модель самолета не найдена";
                        }

                        int directionId = Convert.ToInt32(row.Cells["DirectionId"].Value);
                        var direction = _directionLogic.ReadElement(new DirectionSearchModel
                        {
                            Id = directionId
                        });
                        if (direction != null)
                        {
                            row.Cells["FlightDirection"].Value = direction.CountryFrom + " " + direction.CityFrom + " - " + direction.CountryTo + " " + direction.CityTo;
                        }
                        else
                        {
                            row.Cells["FlightDirection"].Value = "Направление не найдено";
                        }
                    }
                }
                MessageBox.Show("Поиск завершен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _logger.LogInformation("Загрузка рейсов");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки рейсов");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSearchFlights_Load(object sender, EventArgs e)
        {            
        }

        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
