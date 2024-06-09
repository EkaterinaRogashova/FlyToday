using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
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
            dateTimePickerDateFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateFrom.CustomFormat = "dd.MM.yyyy hh:mm";
            dateTimePickerDateTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateTo.CustomFormat = "dd.MM.yyyy hh:mm";
            textBoxFilterEconomPriceFrom.Text = "0";
            textBoxFilterEconomPriceTo.Text = "10000";
            textBoxFilterBusinessPriceFrom.Text = "0";
            textBoxFilterBusinessPriceTo.Text = "10000";
            textBoxFilterTimeInFlightFrom.Text = "0";
            textBoxFilterTimeInFlightTo.Text = "10";
            textBoxFilterFreePlacesCountFrom.Text = "0";
            textBoxFilterFreePlacesCountTo.Text = "100";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = null;
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

                    if (dateTimePickerDateFrom.Value > dateTimePickerDateTo.Value)
                    {
                        MessageBox.Show("Начало периода не может быть позже конца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }                        

                    if (directions != null)
                    {
                        foreach (var dir in directions)
                        {
                            var flights = _logic.ReadList(new FlightSearchModel { DirectionId = dir.Id });
                            if (flights != null)
                            {
                                var filteredFlights = flights.Where(f => f.DepartureDate >= dateTimePickerDateFrom.Value.ToUniversalTime() && f.DepartureDate <= dateTimePickerDateTo.Value.ToUniversalTime()).ToList();
                                foundFlights.AddRange(filteredFlights);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("По запросу ничего не найдено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (checkBoxFilterEconomPrice.Checked)
                    {
                        foundFlights = FilterByEconomPrice(foundFlights);
                    }

                    if (checkBoxFilterBusinessPrice.Checked)
                    {
                        foundFlights = FilterByBusinessPrice(foundFlights);
                    }

                    if (checkBoxFilterTimeInFlight.Checked)
                    {
                        foundFlights = FilterByTimeInFlight(foundFlights);
                    }

                    if (checkBoxFilterFreePlacesCount.Checked)
                    {
                        foundFlights = FilterByFreePlacesCount(foundFlights);
                    }

                    dataGridView.Visible = true;
                    dataGridView.DataSource = foundFlights;
                    dataGridView.Columns["Id"].Visible = false;
                    dataGridView.Columns["DepartureDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["FreePlacesCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["EconomPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["BusinessPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["TimeInFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["PlaneId"].Visible = false;
                    dataGridView.Columns["DirectionId"].Visible = false;
                    dataGridView.Columns["PlaneModel"].Visible = true;
                    dataGridView.Columns["FlightDirection"].Visible = true;
                    dataGridView.Columns["PlaneModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["FlightDirection"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

                    ShowPlanesAndDirections();
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

        private void ShowPlanesAndDirections()
        {
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

        private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var service = Program.ServiceProvider?.GetService(typeof(FormViewFlight));
                if (service is FormViewFlight form)
                {
                    form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                    form.DirectionId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["DirectionId"].Value);
                    form.PlaneId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["PlaneId"].Value);
                    form.ShowDialog();
                }
            }
        }

        private void FormSearchFlights_Load(object sender, EventArgs e)
        {
            checkBoxNoFilters.Checked = true;
            textBoxDirectionCountryFrom.Text = "Россия";
            textBoxDirectionCountryTo.Text = "Россия";            
        }

        private List<FlightViewModel> FilterByBusinessPrice(List<FlightViewModel> list)
        {
            if (double.TryParse(textBoxFilterBusinessPriceFrom.Text, out double from) && double.TryParse(textBoxFilterBusinessPriceTo.Text, out double to))
            {
                var filteredFlights = list.Where(f => f.BusinessPrice >= from && f.BusinessPrice <= to).ToList();
                return filteredFlights;
            }
            else
            {
                MessageBox.Show("Параметры фильтра заполнены в недопустимом формате.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

        private List<FlightViewModel> FilterByEconomPrice(List<FlightViewModel> list)
        {
            if (double.TryParse(textBoxFilterEconomPriceFrom.Text, out double from) && double.TryParse(textBoxFilterEconomPriceTo.Text, out double to))
            {
                var filteredFlights = list.Where(f => f.EconomPrice >= from && f.EconomPrice <= to).ToList();
                return filteredFlights;
            }
            else
            {
                MessageBox.Show("Параметры фильтра заполнены в недопустимом формате.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

        private List<FlightViewModel> FilterByTimeInFlight(List<FlightViewModel> list)
        {
            if (double.TryParse(textBoxFilterTimeInFlightFrom.Text, out double from) && double.TryParse(textBoxFilterTimeInFlightTo.Text, out double to))
            {
                var filteredFlights = list.Where(f => f.TimeInFlight >= from && f.TimeInFlight <= to).ToList();
                return filteredFlights;
            }
            else
            {
                MessageBox.Show("Параметры фильтра заполнены в недопустимом формате.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }
        private List<FlightViewModel> FilterByFreePlacesCount(List<FlightViewModel> list)
        {
            if (int.TryParse(textBoxFilterFreePlacesCountFrom.Text, out int from) && int.TryParse(textBoxFilterFreePlacesCountTo.Text, out int to))
            {
                var filteredFlights = list.Where(f => f.FreePlacesCount >= from && f.FreePlacesCount <= to).ToList();
                return filteredFlights;
            }
            else
            {
                MessageBox.Show("Параметры фильтра заполнены в недопустимом формате.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }
        private void checkBoxFilterEconomPrice_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNoFilters.Checked = false;
            textBoxFilterEconomPriceFrom.ReadOnly = !checkBoxFilterEconomPrice.Checked;
            textBoxFilterEconomPriceTo.ReadOnly = !checkBoxFilterEconomPrice.Checked;
        }

        private void checkBoxFilterBusinessPrice_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNoFilters.Checked = false;
            textBoxFilterBusinessPriceFrom.ReadOnly = !checkBoxFilterBusinessPrice.Checked;
            textBoxFilterBusinessPriceTo.ReadOnly = !checkBoxFilterBusinessPrice.Checked;
        }

        private void checkBoxFilterTimeInFlight_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNoFilters.Checked = false;
            textBoxFilterTimeInFlightFrom.ReadOnly = !checkBoxFilterTimeInFlight.Checked;
            textBoxFilterTimeInFlightTo.ReadOnly = !checkBoxFilterTimeInFlight.Checked;
        }

        private void checkBoxFilterFreePlacesCount_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNoFilters.Checked = false;
            textBoxFilterFreePlacesCountFrom.ReadOnly = !checkBoxFilterFreePlacesCount.Checked;
            textBoxFilterFreePlacesCountTo.ReadOnly = !checkBoxFilterFreePlacesCount.Checked;
        }

        private void checkBoxNoFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoFilters.Checked)
            {
                checkBoxFilterEconomPrice.Checked = false;
                checkBoxFilterBusinessPrice.Checked = false;
                checkBoxFilterTimeInFlight.Checked = false;
                checkBoxFilterFreePlacesCount.Checked = false;
            }
        }

        private bool isAscending = true;
        private void dataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                var list = (List<FlightViewModel>)dataGridView.DataSource;
                var sortedList = SortList(list, dataGridView.Columns[e.ColumnIndex].DataPropertyName, isAscending);
                dataGridView.DataSource = sortedList;
                ShowPlanesAndDirections();
                dataGridView.Refresh();

                isAscending = !isAscending;
            }
        }

        private List<T> SortList<T>(List<T> list, string propertyName, bool isAscending)
        {
            var property = typeof(T).GetProperty(propertyName);

            if (property != null)
            {
                if (isAscending)
                {
                    return list.OrderBy(x => GetPropertyValue(x, propertyName)).ToList();
                }
                else
                {
                    return list.OrderByDescending(x => GetPropertyValue(x, propertyName)).ToList();
                }
            }

            return list;
        }

        private object? GetPropertyValue<T>(T obj, string propertyName)
        {
            var property = typeof(T).GetProperty(propertyName);
            return property?.GetValue(obj, null);
        }

    }
}
