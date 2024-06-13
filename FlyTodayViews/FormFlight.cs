using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormFlight : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IPlaneLogic _planeLogic;
        private int? _id;
        public int Id { set { _id = value; } }
        private readonly List<DirectionViewModel>? _listDirection;
        private readonly List<PlaneViewModel>? _listPlane;

        public FormFlight(ILogger<FormFlight> logger, IFlightLogic logic, IDirectionLogic directionLogic, IPlaneLogic planeLogic)
        {
            InitializeComponent();

            _listPlane = planeLogic.ReadList(null);
            _listDirection = directionLogic.ReadList(null);

            if (_listPlane != null)
            {
                comboBoxSelectPlane.DisplayMember = "ModelName";
                comboBoxSelectPlane.ValueMember = "Id";
                comboBoxSelectPlane.DataSource = _listPlane;
                comboBoxSelectPlane.SelectedItem = null;
            }

            if (_listDirection != null)
            {
                comboBoxSelectDirection.ValueMember = "Id";
                comboBoxSelectDirection.DataSource = _listDirection;
                comboBoxSelectDirection.SelectedItem = null;
            }

            _logger = logger;
            _logic = logic;
            _planeLogic = planeLogic;
            dateTimePickerDeparture.Format = DateTimePickerFormat.Custom;
            dateTimePickerDeparture.CustomFormat = "dd.MM.yyyy HH:mm";
        }

        public int DirectionId
        {
            get
            {
                return Convert.ToInt32(comboBoxSelectDirection.SelectedValue);
            }
            set
            {
                comboBoxSelectDirection.SelectedValue = value;
            }
        }
        public IDirectionModel? DirectionModel
        {
            get
            {
                if (_listDirection == null)
                {
                    return null;
                }
                foreach (var elem in _listDirection)
                {
                    if (elem.Id == DirectionId)
                    {
                        return elem;
                    }
                }
                return null;
            }
        }


        public int PlaneId
        {
            get
            {
                return Convert.ToInt32(comboBoxSelectPlane.SelectedValue);
            }
            set
            {
                comboBoxSelectPlane.SelectedValue = value;
            }
        }
        public IPlaneModel? PlaneModel
        {
            get
            {
                if (_listPlane == null)
                {
                    return null;
                }
                foreach (var elem in _listPlane)
                {
                    if (elem.Id == PlaneId)
                    {
                        return elem;
                    }
                }
                return null;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDeparture.Value > DateTime.Now + TimeSpan.FromDays(1))
            {
                if (string.IsNullOrEmpty(comboBoxSelectDirection.Text) || string.IsNullOrEmpty(dateTimePickerDeparture.Text) || string.IsNullOrEmpty(comboBoxSelectPlane.Text) || string.IsNullOrEmpty(textBoxEconomCost.Text) || string.IsNullOrEmpty(textBoxBusinessCost.Text) || string.IsNullOrEmpty(textBoxTimeInFlight.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _logger.LogInformation("Сохранение рейса");
                var placesCountEconom = _planeLogic.ReadElement(new PlaneSearchModel { Id = PlaneId }).EconomPlacesCount;
                var placesCountBusiness = _planeLogic.ReadElement(new PlaneSearchModel { Id = PlaneId }).BusinessPlacesCount;
                try
                {
                    var model = new FlightBindingModel
                    {
                        Id = _id ?? 0,
                        PlaneId = PlaneId,
                        DirectionId = DirectionId,
                        DepartureDate = dateTimePickerDeparture.Value.ToUniversalTime() + TimeSpan.FromHours(4),
                        FreePlacesCountEconom = placesCountEconom,
                        FreePlacesCountBusiness = placesCountBusiness,
                        EconomPrice = Convert.ToInt32(textBoxEconomCost.Text),
                        BusinessPrice = Convert.ToInt32(textBoxBusinessCost.Text),
                        TimeInFlight = Convert.ToDouble(textBoxTimeInFlight.Text)
                    };
                    var operationResult = _id.HasValue ? _logic.Update(model) : _logic.Create(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка сохранения рейса");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
            else MessageBox.Show("Нельзя создать рейс на выбранную дату и время", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormFlight_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение рейса");
                    var view = _logic.ReadElement(new FlightSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        comboBoxSelectDirection.SelectedValue = view.DirectionId;
                        dateTimePickerDeparture.Value = view.DepartureDate.ToUniversalTime();
                        comboBoxSelectPlane.SelectedValue = view.PlaneId;
                        textBoxEconomCost.Text = view.EconomPrice.ToString();
                        textBoxBusinessCost.Text = view.BusinessPrice.ToString();
                        textBoxTimeInFlight.Text = view.TimeInFlight.ToString();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения рейса");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComboBoxSelectDirection_Format(object sender, ListControlConvertEventArgs e)
        {
            string countryFrom = ((DirectionViewModel)e.ListItem).CountryFrom;
            string cityFrom = ((DirectionViewModel)e.ListItem).CityFrom;
            string cityTo = ((DirectionViewModel)e.ListItem).CityTo;
            string countryTo = ((DirectionViewModel)e.ListItem).CountryTo;
            e.Value = countryFrom + " " + cityFrom + " - " + countryTo + " " + cityTo;
        }
    }
}
