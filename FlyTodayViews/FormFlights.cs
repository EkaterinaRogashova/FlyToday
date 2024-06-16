using FlyTodayBusinessLogics.MailWorker;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormFlights : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IDirectionLogic _directionLogic;
        private readonly IUserLogic _userLogic;
        private readonly IReportLogic _reportLogic;
        private readonly IPlaceLogic _placeLogic;
        private readonly IRentLogic _rentLogic;
        private readonly AbstractMailWorker _mailWorker;
        private Dictionary<int, int>? _flightSubscribers;
        public Dictionary<int, int> FlightSubscribers { set { _flightSubscribers = value; } }
    
        public FormFlights(ILogger<FormFlights> logger, IFlightLogic logic, IPlaneLogic planeLogic, IDirectionLogic directionLogic, IUserLogic userLogic, AbstractMailWorker mailWorker, IReportLogic reportLogic, IPlaceLogic placeLogic, IRentLogic rentLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _planeLogic = planeLogic;
            dataGridView.Columns.Add("FlightDirection", "Направление");
            dataGridView.Columns.Add("PlaneModel", "Самолет");
            dataGridView.Columns.Add("Status", "Статус");
            _directionLogic = directionLogic;
            _userLogic = userLogic;
            _mailWorker = mailWorker;
            _reportLogic = reportLogic;
            _placeLogic = placeLogic;            
            _flightSubscribers = new Dictionary<int, int>();
            _rentLogic = rentLogic;
        }

        private void FormFlights_Load(object sender, EventArgs e)
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
                    dataGridView.DataSource = list;
                    dataGridView.Columns["Id"].Visible = false;
                    dataGridView.Columns["DepartureDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["FreePlacesCountEconom"].Visible = false;
                    dataGridView.Columns["FreePlacesCountBusiness"].Visible = false;
                    dataGridView.Columns["EconomPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["BusinessPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["TimeInFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["PlaneId"].Visible = false;
                    dataGridView.Columns["DirectionId"].Visible = false;
                    dataGridView.Columns["HasTransit"].Visible = false;
                    dataGridView.Columns["PlaneModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["FlightDirection"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView.Columns["FlightSubscribers"].Visible = false;
                    dataGridView.Columns["FlightStatus"].Visible = false;

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
                            row.Cells["PlaneModel"].Value = "Модель не найдена";
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
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        int flightId = Convert.ToInt32(row.Cells["Id"].Value);
                        var flight = _logic.ReadElement(new FlightSearchModel { Id = flightId });
                        if (flight != null)
                        {
                            if (flight.FlightStatus == FlightStatusEnum.РегистрацияНеНачалась)
                            {
                                row.Cells["Status"].Value = "Регистрация не началась";
                            }
                            else if (flight.FlightStatus == FlightStatusEnum.РегистрацияИдет)
                            {
                                row.Cells["Status"].Value = "Регистрация идет";
                            }
                            else if (flight.FlightStatus == FlightStatusEnum.РегистрацияЗакончилась)
                            {
                                row.Cells["Status"].Value = "Регистрация закончилась";
                            }
                            else if (flight.FlightStatus == FlightStatusEnum.Отменен)
                            {
                                row.Cells["Status"].Value = "Отменен";
                            }
                            else if (flight.FlightStatus == FlightStatusEnum.Неизвестен)
                            {
                                row.Cells["Status"].Value = "Неизвестен";
                            }
                            dataGridView.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                }
                _logger.LogInformation("Загрузка рейсов");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки рейсов");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormFlight));
            if (service is FormFlight form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var service = Program.ServiceProvider?.GetService(typeof(FormFlight));
                if (service is FormFlight form)
                {
                    form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                    _logger.LogInformation("Удаление рейса");
                    try
                    {
                        if (!_logic.Delete(new FlightBindingModel { Id = id }))
                        {
                            throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка удаления рейса");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCreatePlace_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var places = _placeLogic.ReadList(new PlaceSearchModel { FlightId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value) });
                if (places.Count == 0)
                {
                    var service = Program.ServiceProvider?.GetService(typeof(FormCreatePlaces));
                    if (service is FormCreatePlaces form)
                    {
                        form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Места на текущий рейс уже существуют", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private class PriceReductionNotification
        {
            public int FlightId { get; set; }
            public int UserId { get; set; }
            public double OldPrice { get; set; }
            public double NewPrice { get; set; }
            public bool IsBusiness { get; set; }
            public DateTime SentAt { get; set; }
        }

        private List<PriceReductionNotification> _sentNotifications = new List<PriceReductionNotification>();

        private void SendPriceReductionNotifications(double? newEconomPrice, double? oldEconomPrice, double? newBusinessPrice, double? oldBusinessPrice, List<FlightViewModel> flights)
        {
            ClearOldNotifications();

            foreach (var flight in flights)
            {
                var direction = _directionLogic.ReadElement(new DirectionSearchModel { Id = flight.DirectionId });
                _flightSubscribers = _logic.GetSubscribers(new FlightSearchModel { Id = flight.Id });
                if (_flightSubscribers != null && _flightSubscribers.Count != 0)
                {
                    foreach (var subscriber in _flightSubscribers.Values)
                    {
                        if (subscriber != 0)
                        {
                            var user = _userLogic.ReadElement(new UserSearchModel { Id = subscriber });
                            if (user != null)
                            {
                                if (user.AllowNotifications)
                                {

                                    if (oldEconomPrice.HasValue && newEconomPrice.HasValue)
                                    {
                                        if (!HasSentNotification(flight.Id, subscriber, oldEconomPrice.Value, newEconomPrice.Value, false))
                                        {
                                            var economSubject = $"Снижение цены билетов эконом-класса на рейс {direction.CountryFrom} {direction.CityFrom} - {direction.CountryTo} {direction.CityTo}";
                                            var economText = $"Стоимость билета эконом-класса теперь составляет {newEconomPrice} (была {oldEconomPrice}). \nУспейте приобрести билеты по выгодной цене! \n \n Ваша FlyToday.";
                                            _mailWorker.MailSendAsync(new()
                                            {
                                                MailAddress = user.Email,
                                                Subject = economSubject,
                                                Text = economText
                                            });
                                            _sentNotifications.Add(new PriceReductionNotification
                                            {
                                                FlightId = flight.Id,
                                                UserId = subscriber,
                                                OldPrice = oldEconomPrice.Value,
                                                NewPrice = newEconomPrice.Value,
                                                IsBusiness = false,
                                                SentAt = DateTime.Now
                                            });
                                        }
                                    }

                                    if (oldBusinessPrice.HasValue && newBusinessPrice.HasValue)
                                    {
                                        if (!HasSentNotification(flight.Id, subscriber, oldBusinessPrice.Value, newBusinessPrice.Value, true))
                                        {
                                            var businessSubject = $"Снижение цены билетов бизнес-класса на рейс {direction.CountryFrom} {direction.CityFrom} - {direction.CountryTo} {direction.CityTo}";
                                            var businessText = $"Стоимость билета бизнес-класса теперь составляет {newBusinessPrice} (была {oldBusinessPrice}). \nУспейте приобрести билеты по выгодной цене! \n \n Ваша FlyToday.";
                                            _mailWorker.MailSendAsync(new()
                                            {
                                                MailAddress = user.Email,
                                                Subject = businessSubject,
                                                Text = businessText
                                            });
                                            _sentNotifications.Add(new PriceReductionNotification
                                            {
                                                FlightId = flight.Id,
                                                UserId = subscriber,
                                                OldPrice = oldBusinessPrice.Value,
                                                NewPrice = newBusinessPrice.Value,
                                                IsBusiness = true,
                                                SentAt = DateTime.Now
                                            });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool HasSentNotification(int flightId, int userId, double oldPrice, double newPrice, bool isBusiness)
        {
            return _sentNotifications.Any(n => n.FlightId == flightId && n.UserId == userId && n.OldPrice == oldPrice && n.NewPrice == newPrice && n.IsBusiness == isBusiness);
        }

        private void ClearOldNotifications()
        {
            var expirationTime = TimeSpan.FromDays(10);
            _sentNotifications.RemoveAll(n => n.SentAt < DateTime.Now - expirationTime);
        }

        private void buttonReducePrices_Click(object sender, EventArgs e)
        {
            var list = _logic.ReadList(null);
            bool businessChanged = false;
            bool economChanged = false;
            foreach (var flight in list)
            {
                List<FlightViewModel> flights = new();
                if (flight.FreePlacesCountBusiness <= 10 && flight.BusinessPrice > 10000 &&
                    flight.FreePlacesCountEconom <= 10 && flight.EconomPrice > 1500)
                {
                    flights.Add(flight);
                    economChanged = true;
                    businessChanged = true;
                    var oldEcPrice = flight.EconomPrice;
                    var oldBusPrice = flight.BusinessPrice;
                    var model = new FlightBindingModel
                    {
                        Id = flight.Id,
                        PlaneId = flight.PlaneId,
                        DirectionId = flight.DirectionId,
                        DepartureDate = flight.DepartureDate,
                        FreePlacesCountEconom = flight.FreePlacesCountEconom,
                        FreePlacesCountBusiness = flight.FreePlacesCountBusiness,
                        EconomPrice = flight.EconomPrice * 0.5,
                        BusinessPrice = flight.BusinessPrice * 0.5,
                        TimeInFlight = flight.TimeInFlight,
                        FlightSubscribers = flight.FlightSubscribers
                    };
                    var operationResult = _logic.UpdatePrices(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                    SendPriceReductionNotifications(model.EconomPrice, oldEcPrice, model.BusinessPrice, oldBusPrice, flights);
                }
                else if (flight.FreePlacesCountEconom <= 10 && flight.EconomPrice > 1500)
                {
                    flights.Add(flight);
                    economChanged = true;
                    var oldPrice = flight.EconomPrice;
                    var model = new FlightBindingModel
                    {
                        Id = flight.Id,
                        PlaneId = flight.PlaneId,
                        DirectionId = flight.DirectionId,
                        DepartureDate = flight.DepartureDate,
                        FreePlacesCountEconom = flight.FreePlacesCountEconom,
                        FreePlacesCountBusiness = flight.FreePlacesCountBusiness,
                        EconomPrice = flight.EconomPrice * 0.5,
                        BusinessPrice = flight.BusinessPrice,
                        TimeInFlight = flight.TimeInFlight
                    };
                    var operationResult = _logic.UpdatePrices(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                    SendPriceReductionNotifications(model.EconomPrice, oldPrice, null, null, flights);
                }
                else if (flight.FreePlacesCountBusiness <= 10 && flight.BusinessPrice > 10000)
                {
                    flights.Add(flight);
                    businessChanged = true;
                    var oldPrice = flight.BusinessPrice;
                    var model = new FlightBindingModel
                    {
                        Id = flight.Id,
                        PlaneId = flight.PlaneId,
                        DirectionId = flight.DirectionId,
                        DepartureDate = flight.DepartureDate,
                        FreePlacesCountEconom = flight.FreePlacesCountEconom,
                        FreePlacesCountBusiness = flight.FreePlacesCountBusiness,
                        EconomPrice = flight.EconomPrice,
                        BusinessPrice = flight.BusinessPrice * 0.5,
                        TimeInFlight = flight.TimeInFlight
                    };
                    var operationResult = _logic.UpdatePrices(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                    SendPriceReductionNotifications(null, null, model.BusinessPrice, oldPrice, flights);
                }
            }
            if (economChanged || businessChanged)
            {
                MessageBox.Show("Цены на билеты успешно изменены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Нет билетов, у которых можно снизить цену.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var flight = _logic.ReadElement(new FlightSearchModel
                {
                    Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value)
                });
                if (flight != null)
                {
                    using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            _reportLogic.SaveBoardingPassesToPdf(new ReportBindingModel
                            {
                                FileName = dialog.FileName,
                                FlightId = flight.Id
                            });
                            _logger.LogInformation("Сохранение списка посадочных талонов на рейс {FlightId}", flight.Id);
                            MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, "Ошибка сохранения списка посадочных талонов для рейса");
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите рейс", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCancelFlight_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var flight = _logic.ReadElement(new FlightSearchModel
                {
                    Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value)
                });
                if (flight != null)
                {
                    try
                    {
                        _logic.Update(new FlightBindingModel
                        {
                            Id = flight.Id,
                            PlaneId = flight.PlaneId,
                            DirectionId = flight.DirectionId,
                            DepartureDate = flight.DepartureDate,
                            FreePlacesCountEconom = flight.FreePlacesCountEconom,
                            FreePlacesCountBusiness = flight.FreePlacesCountBusiness,
                            EconomPrice = flight.EconomPrice,
                            BusinessPrice = flight.BusinessPrice,
                            TimeInFlight = flight.TimeInFlight,
                            FlightSubscribers = flight.FlightSubscribers,
                            FlightStatus = FlightStatusEnum.Отменен
                        });
                        _logger.LogInformation("Обновление статуса рейса на Отменен");
                        MessageBox.Show("Рейс успешно отменен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var direction = _directionLogic.ReadElement(new DirectionSearchModel { Id = flight.DirectionId });
                        var rents = _rentLogic.ReadList(null);
                        foreach (var rent in rents)
                        {
                            var users = _userLogic.ReadList(new UserSearchModel
                            {
                                Id = rent.UserId
                            });
                            if (rent.Status == "Оплачено")
                            {
                                foreach (var user in users)
                                {
                                    _mailWorker.MailSendAsync(new()
                                    {
                                        MailAddress = user.Email,
                                        Subject = $"Отмена рейса",
                                        Text = $"Вы оплатили билеты на рейс {direction.CountryFrom} {direction.CityFrom} - {direction.CountryTo} {direction.CityTo} {flight.DepartureDate}, он по техническим причинам был отменен." +
                                        $"\nДля возврата средств обратитесь в Службу работы с клиентами." +
                                        $"\nВаша FlyToday."
                                    });
                                }                                
                            }
                        }   
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка обновления статуса рейса");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите рейс", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns.Contains("TimeInFlight") && e.ColumnIndex == dataGridView.Columns["TimeInFlight"].Index && e.Value is int)
            {
                int totalMinutes = (int)e.Value;
                int hours = (int)totalMinutes / 60;
                int minutes = (int)totalMinutes % 60;
                e.Value = $"{hours} час(ов) {minutes} мин.";
                e.FormattingApplied = true;
            }
            if (dataGridView.Columns.Contains("EconomPrice") && e.ColumnIndex == dataGridView.Columns["EconomPrice"].Index && e.Value is double)
            {
                double price = (double)e.Value;
                e.Value = $"{price} руб.";
                e.FormattingApplied = true;
            }
            if (dataGridView.Columns.Contains("BusinessPrice") && e.ColumnIndex == dataGridView.Columns["BusinessPrice"].Index && e.Value is double)
            {
                double price = (double)e.Value;
                e.Value = $"{price} руб.";
                e.FormattingApplied = true;
            }            
        }
    }
}
