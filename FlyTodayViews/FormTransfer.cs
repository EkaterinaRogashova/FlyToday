using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using FlyTodayDataModels.Enums;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormTransfer : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IDirectionLogic _directionLogic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IUserLogic _userLogic;
        private int? _id;
        private int? _planeId;
        private int? _dir;
        public int IdFirst { set { _id = value; } }
        public int DirectionTo { set { _dir = value; } }
        public int PlaneId { set { _planeId = value; } }
        private int? _currentUserId;
        public int CurrentUserId { set { _currentUserId = value; } }
        private Dictionary<int, int> _flightSubscribers;

        public FormTransfer(ILogger<FormViewFlight> logger, IFlightLogic logic, IDirectionLogic directionLogic, IPlaneLogic planeLogic, IUserLogic userLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _directionLogic = directionLogic;
            _planeLogic = planeLogic;
            _userLogic = userLogic;
            _flightSubscribers = new Dictionary<int, int>();
        }

        public IUserModel? UserModel
        {
            get
            {
                if (_currentUserId.HasValue)
                {
                    var user = _userLogic.ReadElement(new UserSearchModel
                    {
                        Id = _currentUserId.Value
                    });
                    return user;
                }

                return null;
            }
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение информации о рейсе");
                    _flightSubscribers = _logic.GetSubscribers(new FlightSearchModel { Id = _id.Value });
                    if (_currentUserId.HasValue)
                    {
                        if (_flightSubscribers.ContainsKey(_id.Value) && _flightSubscribers.ContainsValue(_currentUserId.Value))
                        {
                            buttonTrackPriceChanges.Text = "Отменить отслеживание изменения цены";
                        }
                    }
                    var view = _logic.ReadElement(new FlightSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        var direction = _directionLogic.ReadElement(new DirectionSearchModel
                        {
                            Id = view.DirectionId
                        });
                        if (direction != null) labelFirstDir.Text = direction.CityFrom + " - " + direction.CityTo;
                        labelDepartureDate1.Text = view.DepartureDate.ToShortDateString() + " " + view.DepartureDate.ToShortTimeString() + " МСК";
                        DateTime arrivalDateTime = view.DepartureDate.AddMinutes(view.TimeInFlight);
                        labelArrivalDate1.Text = arrivalDateTime.ToShortDateString() + " " + arrivalDateTime.ToShortTimeString() + " МСК";
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = view.PlaneId
                        });
                        if (plane != null) labelPlane1.Text = plane.ModelName;
                        labelEconomPrice1.Text = view.EconomPrice.ToString();
                        labelBusinessPrice1.Text = view.BusinessPrice.ToString();
                        int totalHours1 = (int)TimeSpan.FromMinutes(view.TimeInFlight).TotalHours;
                        int totalMinutes1 = (int)TimeSpan.FromMinutes(view.TimeInFlight).Minutes;
                        labelTimeInFlight1.Text = $"{totalHours1} час(ов/а) {totalMinutes1} мин.";
                    }
                    var directionTo = _directionLogic.ReadElement(new DirectionSearchModel { Id = _dir });
                    var viewSecond = _logic.ReadElement(new FlightSearchModel { DirectionId = _dir });
                    if (viewSecond != null)
                    {
                        labelSecondDir.Text = directionTo.CityFrom + " - " + directionTo.CityTo;
                        labelDepartureDate2.Text = viewSecond.DepartureDate.ToShortDateString() + " " + viewSecond.DepartureDate.ToShortTimeString() + " МСК";
                        DateTime arrivalDateTime = viewSecond.DepartureDate.AddMinutes(viewSecond.TimeInFlight);
                        labelArrivalDate2.Text = arrivalDateTime.ToShortDateString() + " " + arrivalDateTime.ToShortTimeString() + " МСК"; 
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = viewSecond.PlaneId
                        });
                        if (plane != null) labelPlane2.Text = plane.ModelName;
                        labelEconomPrice2.Text = viewSecond.EconomPrice.ToString();
                        labelBusinessPrice2.Text = viewSecond.BusinessPrice.ToString();
                        int totalHours2 = (int)TimeSpan.FromMinutes(viewSecond.TimeInFlight).TotalHours;
                        int totalMinutes2 = (int)TimeSpan.FromMinutes(viewSecond.TimeInFlight).Minutes;
                        labelTimeInFlight2.Text = $"{totalHours2} час(ов/а) {totalMinutes2} мин.";
                    }
                    TimeSpan timeBetweenFlights = viewSecond.DepartureDate - view.DepartureDate.AddMinutes(view.TimeInFlight);
                    double totalTimeInFlight = view.TimeInFlight + viewSecond.TimeInFlight + timeBetweenFlights.TotalMinutes;

                    int totalFlightHours = (int)(totalTimeInFlight / 60);
                    int totalFlightMinutes = (int)(totalTimeInFlight % 60);

                    labelGeneralTimeInFlight.Text = $"{totalFlightHours} час(а/ов) {totalFlightMinutes:D2} мин.";

                    int transferHours = (int)(timeBetweenFlights.TotalMinutes / 60);
                    int transferMinutes = (int)(timeBetweenFlights.TotalMinutes % 60);

                    labelTransferDur.Text = $"{transferHours} час(а/ов) {transferMinutes:D2} мин.";


                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения рейса");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonTrackPriceChanges_Click(object sender, EventArgs e)
        {
            if (_currentUserId != null && _id != null)
            {
                var flights = new List<FlightViewModel>
                {
                    _logic.ReadElement(new FlightSearchModel { Id = _id.Value }),
                    _logic.ReadElement(new FlightSearchModel { DirectionId = _dir })
                };
                var user = _userLogic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                if (user != null)
                {
                    foreach (var flight in flights)
                    {
                        if (!user.AllowNotifications)
                        {
                            MessageBox.Show("Сначала разрешите уведомления! Это можно сделать в личном кабинете.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                _flightSubscribers = _logic.GetSubscribers(new FlightSearchModel { Id = flight.Id });
                                if (!_flightSubscribers.ContainsKey(flight.Id) && !_flightSubscribers.ContainsValue(user.Id))
                                {
                                    _flightSubscribers.Add(flight.Id, user.Id);
                                    var dict = new Dictionary<int, IUserModel>
                                    {
                                        { flight.Id, UserModel }
                                    };


                                    var model = new FlightBindingModel
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
                                        FlightSubscribers = dict,
                                        FlightStatus = flight.FlightStatus
                                    };
                                    var operationResult = _logic.Update(model);
                                    if (operationResult)
                                    {
                                        MessageBox.Show("Вы успешно подписались на изменение цены.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    if (_flightSubscribers.ContainsKey(flight.Id))
                                    {
                                        _flightSubscribers.Remove(flight.Id);
                                        var dict = new Dictionary<int, IUserModel>();
                                        dict.Remove(flight.Id);
                                        var model = new FlightBindingModel
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
                                            FlightSubscribers = dict,
                                            FlightStatus = flight.FlightStatus
                                        };
                                        var operationResult = _logic.Update(model);
                                        if (operationResult)
                                        {
                                            MessageBox.Show("Вы успешно отменили подписку на изменение цены.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                Close();
                            }
                            catch (Exception ex)
                            {
                                _logger.LogError(ex, "Ошибка сохранения подписки на рейс");
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (_currentUserId.HasValue || _currentUserId > 0)
            {
                var flights = new List<FlightViewModel>
                {
                    _logic.ReadElement(new FlightSearchModel { Id = _id.Value }),
                    _logic.ReadElement(new FlightSearchModel { DirectionId = _dir })
                };
                try
                {
                    var currentUser = _userLogic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                    if (currentUser.AccessRule == AccessEnum.Взрослый || currentUser.AccessRule == AccessEnum.Администратор)
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormRent));
                        if (service is FormRent form)
                        {
                            form.FirFl = flights[0].Id;
                            form.SecFl = flights[1].Id;
                            form.CurrentUserId = _currentUserId.Value;
                            form.ShowDialog();
                        }
                    }
                    else MessageBox.Show("Недостаточно прав доступа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Сначала авторизуйтесь в системе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}