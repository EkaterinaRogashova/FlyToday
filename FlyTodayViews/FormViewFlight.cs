using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormViewFlight : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IDirectionLogic _directionLogic;
        private readonly IPlaneLogic _planeLogic;
        private int? _id;
        private int? _directionId;
        private int? _planeId;
        public int Id { set { _id = value; } }
        public int DirectionId { set { _directionId = value; } }
        public int PlaneId { set { _planeId = value; } }
        private int? _currentUserId;
        public int CurrentUserId { set { _currentUserId = value; } }

        public FormViewFlight(ILogger<FormViewFlight> logger, IFlightLogic logic, IDirectionLogic directionLogic, IPlaneLogic planeLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _directionLogic = directionLogic;
            _planeLogic = planeLogic;
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
                        labelFreePlacesCount.Text = view.FreePlacesCount.ToString();
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

        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (_currentUserId.HasValue || _currentUserId > 0)
            {
                try
                {
                    var service = Program.ServiceProvider?.GetService(typeof(FormRent));
                    if (service is FormRent form)
                    {
                        form.CurrentFlightId = _id.Value;
                        form.CurrentUserId = _currentUserId.Value;
                        form.ShowDialog();
                    }
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
