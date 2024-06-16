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
    public partial class FormViewFlight : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IDirectionLogic _directionLogic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IUserLogic _userLogic;
        private int? _id;
        private int? _directionId;
        private int? _planeId;
        public int Id { set { _id = value; } }
        public int DirectionId { set { _directionId = value; } }
        public int PlaneId { set { _planeId = value; } }
        private int? _currentUserId;
        public int CurrentUserId { set { _currentUserId = value; } }
        private Dictionary<int, int> _flightSubscribers;

        public FormViewFlight(ILogger<FormViewFlight> logger, IFlightLogic logic, IDirectionLogic directionLogic, IPlaneLogic planeLogic, IUserLogic userLogic)
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

        private void FormFlight_Load(object sender, EventArgs e)
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
                        if (direction != null) labelDirection.Text = direction.CountryFrom + " " + direction.CityFrom + " - " + direction.CountryTo + " " + direction.CityTo;
                        labelDepartureDate.Text = view.DepartureDate.ToShortDateString() + " " + view.DepartureDate.ToShortTimeString() + " МСК";
                        labelArrivalDate.Text = (view.DepartureDate + TimeSpan.FromHours(view.TimeInFlight)).ToShortDateString() + " " + (view.DepartureDate + TimeSpan.FromHours(view.TimeInFlight)).ToShortTimeString() + " МСК";
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = view.PlaneId
                        });
                        if (plane != null) labelPlane.Text = plane.ModelName;
                        labelFreePlacesCountEconom.Text = view.FreePlacesCountEconom.ToString();
                        labelFreePlacesCountBusiness.Text = view.FreePlacesCountBusiness.ToString();
                        labelEconomPrice.Text = view.EconomPrice.ToString();
                        labelBusinessPrice.Text = view.BusinessPrice.ToString();
                        labelTimeInFlight.Text = TimeSpan.FromHours(view.TimeInFlight).TotalHours + " час(ов/а)";
                    }
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
                var flight = _logic.ReadElement(new FlightSearchModel { Id = _id.Value });
                var user = _userLogic.ReadElement(new UserSearchModel { Id = _currentUserId.Value });
                if (user != null)
                {
                    if (flight != null)
                    {
                        if (!user.AllowNotifications)
                        {
                            MessageBox.Show("Сначала разрешите уведомления! Это можно сделать в личном кабинете.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                _flightSubscribers = _logic.GetSubscribers(new FlightSearchModel { Id = flight.Id});
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
                                    MessageBox.Show("Вы уже подписаны на этот рейс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    else MessageBox.Show("Рейс не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
