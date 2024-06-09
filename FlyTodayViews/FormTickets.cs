using FlyTodayBusinessLogics.BusinessLogics;
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
    public partial class FormTickets : Form
    {
        private readonly ILogger _logger;
        private readonly ITicketLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private int? _currentRentId;
        public int CurrentRentId { set { _currentRentId = value; } }
        public FormTickets(ILogger<FormRent> logger, ITicketLogic logic, IRentLogic rentlogic, IFlightLogic flightlogic, IDirectionLogic directionlogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _rentlogic = rentlogic;
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
        }
        private void FormTicket_Load(object sender, EventArgs e)
        {
            if (_currentRentId.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение информации о бронировании");
                    var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
                    if (view != null)
                    {
                        var flight = _flightlogic.ReadElement(new FlightSearchModel { Id =  view.FlightId });
                        if (flight != null)
                        {
                            var direction = _directionlogic.ReadElement(new DirectionSearchModel
                            {
                                Id = flight.DirectionId
                            });
                            if (direction != null) labelFlight.Text = direction.CityFrom + " - " + direction.CityTo;
                            labelDate.Text = flight.DepartureDate.ToShortDateString() + " " + flight.DepartureDate.ToShortTimeString() + " МСК";
                        }
                    }
                    if (!string.IsNullOrEmpty(textBoxCost.Text)) labelCost.Text = textBoxCost.Text;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения бронирования");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
