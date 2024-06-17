using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
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

    public partial class FormRent : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IDirectionLogic _directionlogic;
        private readonly IRentLogic _rentlogic;
        private readonly IPlaneLogic _planelogic;
        private int? _currentUserId;
        public int CurrentUserId { set { _currentUserId = value; } }
        private int? _currentFlightId;
        public int CurrentFlightId { set { _currentFlightId = value; } }
        private int? _directionId;
        public int DirectionId { set { _directionId = value; } }
        private int? _firflId;
        private int? _secflId;
        public int FirFl { set { _firflId = value; } }
        public int SecFl { set { _secflId = value; } }
        public FormRent(ILogger<FormRent> logger, IFlightLogic logic, IRentLogic rentlogic, IDirectionLogic directionLogic, IPlaneLogic planeLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _rentlogic = rentlogic;
            _planelogic = planeLogic;
            _directionlogic = directionLogic;
        }
        private void FormRent_Load(object sender, EventArgs e)
        {
            if (_currentFlightId.HasValue && _currentUserId.HasValue)
            {
                if (_firflId.HasValue && _secflId.HasValue)
                {
                    var firfl = _logic.ReadElement(new FlightSearchModel { Id = _firflId.Value });
                    var secfl = _logic.ReadElement(new FlightSearchModel { Id = _secflId.Value });
                    int FreePlacesCountEconom = firfl.FreePlacesCountEconom <= secfl.FreePlacesCountEconom ? firfl.FreePlacesCountEconom : secfl.FreePlacesCountEconom;
                    int FreePlacesCountBusiness = firfl.FreePlacesCountBusiness <= secfl.FreePlacesCountBusiness ? firfl.FreePlacesCountBusiness : secfl.FreePlacesCountBusiness;
                    try
                    {
                        _logger.LogInformation("Получение информации о рейсах");
                        if (firfl != null && secfl != null)
                        {
                            var direction1 = _directionlogic.ReadElement(new DirectionSearchModel
                            {
                                Id = firfl.DirectionId
                            });
                            var direction2 = _directionlogic.ReadElement(new DirectionSearchModel
                            {
                                Id = secfl.DirectionId
                            });
                            if (direction1 != null && direction2 != null) labelFlight.Text = direction1.CountryFrom + " " + direction1.CityFrom + " - " + direction2.CountryTo + " " + direction2.CityTo;
                            labelDate.Text = firfl.DepartureDate.ToShortDateString() + " " + firfl.DepartureDate.ToShortTimeString() + " МСК";
                            labelFreePlacesBusiness.Text = FreePlacesCountBusiness.ToString();
                            labelFreePlacesEconom.Text = FreePlacesCountEconom.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка получения рейса");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                else
                {
                    try
                    {
                        _logger.LogInformation("Получение информации о рейсе");
                        var view = _logic.ReadElement(new FlightSearchModel { Id = _currentFlightId.Value });
                        if (view != null)
                        {
                            var direction = _directionlogic.ReadElement(new DirectionSearchModel
                            {
                                Id = view.DirectionId
                            });
                            if (direction != null) labelFlight.Text = direction.CountryFrom + " " + direction.CityFrom + " - " + direction.CountryTo + " " + direction.CityTo;
                            labelDate.Text = view.DepartureDate.ToShortDateString() + " " + view.DepartureDate.ToShortTimeString() + " МСК";
                            labelFreePlacesBusiness.Text = view.FreePlacesCountBusiness.ToString();
                            labelFreePlacesEconom.Text = view.FreePlacesCountEconom.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка получения рейса");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void buttonCreateRent_Click(object sender, EventArgs e)
        {
            if (!_currentUserId.HasValue || _currentUserId <= 0) MessageBox.Show("Сначала авторизуйтесь в системе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_currentFlightId.HasValue || _currentFlightId > 0)
                {
                    if (string.IsNullOrEmpty(textBoxEconomy.Text) || string.IsNullOrEmpty(textBoxBusiness.Text))
                    {
                        MessageBox.Show("Заполните поля", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var view = _logic.ReadElement(new FlightSearchModel { Id = _currentFlightId.Value });
                    if (view != null)
                    {
                        if (Convert.ToInt32(textBoxEconomy.Text) > view.FreePlacesCountEconom)
                        {
                            MessageBox.Show("Количество бронируемых мест эконом-класса превышает количество свободных!", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Convert.ToInt32(textBoxBusiness.Text) > view.FreePlacesCountBusiness)
                        {
                            MessageBox.Show("Количество бронируемых мест бизнес-класса превышает количество свободных!", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            _logger.LogInformation("Сохранение бронирования");
                            try
                            {
                                var model = new RentBindingModel
                                {
                                    UserId = _currentUserId.Value,
                                    FlightId = _currentFlightId.Value,
                                    Cost = 0,
                                    NumberOfBusiness = Convert.ToInt32(textBoxBusiness.Text),
                                    NumberOfEconomy = Convert.ToInt32(textBoxEconomy.Text),
                                    Status = "Не оплачено"
                                };
                                var operationResult = _rentlogic.Create(model);
                                if (!operationResult)
                                {
                                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                                }
                                Close();
                                MessageBox.Show("Бронирование находится в личном кабинете", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                            }
                            catch (Exception ex)
                            {
                                _logger.LogError(ex, "Ошибка сохранения бронирования");
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (_firflId.HasValue && _secflId.HasValue)
                {
                    if (string.IsNullOrEmpty(textBoxEconomy.Text) || string.IsNullOrEmpty(textBoxBusiness.Text))
                    {
                        MessageBox.Show("Заполните поля", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var firfl = _logic.ReadElement(new FlightSearchModel { Id = _firflId.Value });
                    var secfl = _logic.ReadElement(new FlightSearchModel { Id = _secflId.Value });
                    int FreePlacesCountEconom = firfl.FreePlacesCountEconom <= secfl.FreePlacesCountEconom ? firfl.FreePlacesCountEconom : secfl.FreePlacesCountEconom;
                    int FreePlacesCountBusiness = firfl.FreePlacesCountBusiness <= secfl.FreePlacesCountBusiness ? firfl.FreePlacesCountBusiness : secfl.FreePlacesCountBusiness;
                    if (firfl != null && secfl != null)
                    {
                        if (Convert.ToInt32(textBoxEconomy.Text) > FreePlacesCountEconom)
                        {
                            MessageBox.Show("Количество бронируемых мест эконом-класса превышает количество свободных!", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Convert.ToInt32(textBoxBusiness.Text) > FreePlacesCountBusiness)
                        {
                            MessageBox.Show("Количество бронируемых мест бизнес-класса превышает количество свободных!", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            _logger.LogInformation("Сохранение бронирования");
                            try
                            {
                                var model1 = new RentBindingModel
                                {
                                    UserId = _currentUserId.Value,
                                    FlightId = _firflId.Value,
                                    Cost = 0,
                                    NumberOfBusiness = Convert.ToInt32(textBoxBusiness.Text),
                                    NumberOfEconomy = Convert.ToInt32(textBoxEconomy.Text),
                                    Status = "Не оплачено"
                                };
                                var operationResult = _rentlogic.Create(model1);
                                var model2 = new RentBindingModel
                                {
                                    UserId = _currentUserId.Value,
                                    FlightId = _secflId.Value,
                                    Cost = 0,
                                    NumberOfBusiness = Convert.ToInt32(textBoxBusiness.Text),
                                    NumberOfEconomy = Convert.ToInt32(textBoxEconomy.Text),
                                    Status = "Не оплачено"
                                };
                                var operationResult1 = _rentlogic.Create(model2);
                                if (!operationResult)
                                {
                                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                                }
                                if (!operationResult1)
                                {
                                    throw new Exception("Ошибка при сохранении второго бронирования. Дополнительная информация в логах.");
                                }
                                Close();
                                if (MessageBox.Show("Бронирования в личном кабинете. Перейти в личный кабинет?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    var service = Program.ServiceProvider?.GetService(typeof(FormProfile));
                                    if (service is FormProfile form)
                                    {
                                        form.Id = _currentUserId.Value;
                                        form.ShowDialog();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                _logger.LogError(ex, "Ошибка сохранения бронирований");
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            
        }
    }
}
