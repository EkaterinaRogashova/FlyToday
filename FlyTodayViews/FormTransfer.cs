using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using FlyTodayDataModels.Enums;
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
        private readonly IFlightSubscriberLogic _flightSubscriberLogic;
        private int? _id;
        private int? _planeId;
        private int? _dir;
        public int IdFirst { set { _id = value; } }
        public int DirectionTo { set { _dir = value; } }
        public int PlaneId { set { _planeId = value; } }
        private int? _currentUserId;
        public int CurrentUserId { set { _currentUserId = value; } }

        public FormTransfer(ILogger<FormViewFlight> logger, IFlightLogic logic, IDirectionLogic directionLogic, IPlaneLogic planeLogic, IUserLogic userLogic, IFlightSubscriberLogic flightSubscriberLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _directionLogic = directionLogic;
            _planeLogic = planeLogic;
            _userLogic = userLogic;
            _flightSubscriberLogic = flightSubscriberLogic;
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение информации о рейсе");
                    var view = _logic.ReadElement(new FlightSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        var direction = _directionLogic.ReadElement(new DirectionSearchModel
                        {
                            Id = view.DirectionId
                        });
                        if (direction != null) labelFirstDir.Text = direction.CityFrom + " - " + direction.CityTo;
                        labelDepartureDate1.Text = view.DepartureDate.ToShortDateString() + " " + view.DepartureDate.ToShortTimeString() + " МСК";
                        labelArrivalDate1.Text = (view.DepartureDate + TimeSpan.FromHours(view.TimeInFlight)).ToShortDateString() + " " + (view.DepartureDate + TimeSpan.FromHours(view.TimeInFlight)).ToShortTimeString() + " МСК";
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = view.PlaneId
                        });
                        if (plane != null) labelPlane1.Text = plane.ModelName;
                        labelEconomPrice1.Text = view.EconomPrice.ToString();
                        labelBusinessPrice1.Text = view.BusinessPrice.ToString();
                        labelTimeInFlight1.Text = TimeSpan.FromHours(view.TimeInFlight).TotalHours + " час(ов/а)";
                    }
                    var directionTo = _directionLogic.ReadElement(new DirectionSearchModel { Id = _dir });
                    var viewSecond = _logic.ReadElement(new FlightSearchModel { DirectionId = _dir });
                    if (viewSecond != null)
                    {                        
                        labelSecondDir.Text = directionTo.CityFrom + " - " + directionTo.CityTo;
                        labelDepartureDate2.Text = viewSecond.DepartureDate.ToShortDateString() + " " + viewSecond.DepartureDate.ToShortTimeString() + " МСК";
                        labelArrivalDate2.Text = (viewSecond.DepartureDate + TimeSpan.FromHours(viewSecond.TimeInFlight)).ToShortDateString() + " " + (viewSecond.DepartureDate + TimeSpan.FromHours(viewSecond.TimeInFlight)).ToShortTimeString() + " МСК";
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = viewSecond.PlaneId
                        });
                        if (plane != null) labelPlane2.Text = plane.ModelName;
                        labelEconomPrice2.Text = viewSecond.EconomPrice.ToString();
                        labelBusinessPrice2.Text = viewSecond.BusinessPrice.ToString();
                        labelTimeInFlight2.Text = TimeSpan.FromHours(viewSecond.TimeInFlight).TotalHours + " час(ов/а)";
                    }
                    TimeSpan timeBetweenFlights = viewSecond.DepartureDate - (view.DepartureDate.AddHours(view.TimeInFlight));
                    double duration = Math.Round(timeBetweenFlights.TotalHours, 2);
                    double totalTimeInFlight = Math.Round(view.TimeInFlight + viewSecond.TimeInFlight + duration, 2);

                    labelGeneralTimeInFlight.Text = totalTimeInFlight.ToString() + " час(а/ов)";
                    labelTransferDur.Text = duration.ToString() + " час(а/ов)";
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
                                var model = new FlightSubscriberBindingModel
                                {
                                    Id = 0,
                                    UserId = user.Id,
                                    FlightId = flight.Id
                                };
                                var operationResult = _flightSubscriberLogic.Create(model);
                                if (!operationResult)
                                {
                                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                                }
                                MessageBox.Show("Вы успешно подписались на изменение цены.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                try
                {
                    var currentUser = _userLogic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                    if (currentUser.AccessRule == AccessEnum.Взрослый || currentUser.AccessRule == AccessEnum.Администратор)
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormRent));
                        if (service is FormRent form)
                        {
                            form.CurrentFlightId = _id.Value;
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
