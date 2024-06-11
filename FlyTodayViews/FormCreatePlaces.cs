using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormCreatePlaces : Form
    {
        private readonly ILogger _logger;
        private readonly IPlaceLogic _logic;
        private readonly IFlightLogic _flightLogic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IDirectionLogic _directionLogic;
        private int? _id;
        public int Id { set { _id = value; } }

        public FormCreatePlaces(ILogger<FormFlight> logger, IFlightLogic flightLogic, IDirectionLogic directionLogic, IPlaneLogic planeLogic, IPlaceLogic logic)
        {
            InitializeComponent();

            _logger = logger;
            _logic = logic;
            _flightLogic = flightLogic;
            _planeLogic = planeLogic;
            _directionLogic = directionLogic;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {            
            _logger.LogInformation("Сохранение мест на рейс");
            try
            {
                if (_id != null)
                {
                    var flight = _flightLogic.ReadElement(new FlightSearchModel { Id = _id.Value });
                    for (int i = 0; i < (flight.FreePlacesCountBusiness); i++)
                    {
                        var model = new PlaceBindingModel
                        {
                            Id = 0,
                            PlaceName = GeneratePlaceName(i, true),
                            FlightId = _id.Value,
                            IsFree = true
                        };
                        var operationResult = _logic.Create(model);
                        if (!operationResult)
                        {
                            throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                        }                        
                    }
                    for (int i = 0; i < (flight.FreePlacesCountEconom); i++)
                    {
                        var model = new PlaceBindingModel
                        {
                            Id = 0,
                            PlaceName = GeneratePlaceName(i, false),
                            FlightId = _id.Value,
                            IsFree = true
                        };
                        var operationResult = _logic.Create(model);
                        if (!operationResult)
                        {
                            throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                        }                        
                    }
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения места");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GeneratePlaceName(int placeNumber, bool isBusiness)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string placeName = "";

            int quotient = (placeNumber - 1) / alphabet.Length;
            int remainder = (placeNumber - 1) % alphabet.Length;

            if (isBusiness)
                placeName = alphabet[quotient].ToString() + (remainder + 1).ToString() + " - business";
            else
                placeName = alphabet[quotient].ToString() + (remainder + 1).ToString() + " - econom";

            return placeName;
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormCreatePlaces_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение мест");
                    var flight = _flightLogic.ReadElement(new FlightSearchModel { Id = _id.Value });
                    var dir = _directionLogic.ReadElement(new DirectionSearchModel { Id = flight.DirectionId });
                    var plane = _planeLogic.ReadElement(new PlaneSearchModel { Id = flight.PlaneId });
                    if (flight != null && dir != null && plane != null)
                    {
                        labelFlightDirection.Text = dir.CountryFrom + " " + dir.CityFrom + " - " + dir.CountryTo + " " + dir.CityTo;
                        labelPlane.Text = plane.ModelName;
                        labelBusinessPlacesCount.Text = flight.FreePlacesCountBusiness.ToString();
                        labelEconomPlacesCount.Text = flight.FreePlacesCountEconom.ToString();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения мест");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

