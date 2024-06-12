using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
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
    public partial class FormBordingPass : Form
    {
        private readonly ILogger _logger;
        private readonly ITicketLogic _ticketlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IRentLogic _rentlogic;
        private readonly IPlaneLogic _planelogic;
        private readonly IPlaceLogic _placelogic;
        private readonly IBoardingPassLogic _boardingpasslogic;
        private int? _currentTicketId;
        public int CurrentTicketId { set { _currentTicketId = value; } }
        private int? _currentRentId;
        public int CurrentRentId { set { _currentRentId = value; } }
        private List<Button> allButtons = new List<Button>();
        private Button selectedButton = null;

        public FormBordingPass(ILogger<FormMyRents> logger, ITicketLogic ticketLogic, IFlightLogic flightlogic, IPlaneLogic planelogic, IRentLogic rentlogic, IPlaceLogic placelogic, IBoardingPassLogic boardingPassLogic)
        {
            InitializeComponent();
            _logger = logger;
            _ticketlogic = ticketLogic;
            _flightlogic = flightlogic;
            _planelogic = planelogic;
            _rentlogic = rentlogic;
            _placelogic = placelogic;
            _boardingpasslogic = boardingPassLogic;
            allButtons = new List<Button>();
        }
        private void LoadData()
        {
            var ticket = _ticketlogic.ReadElement(new TicketSearchModel
            {
                Id = _currentTicketId.Value
            });
            var rent = _rentlogic.ReadElement(new RentSearchModel
            {
                Id = ticket.RentId
            });
            var flight = _flightlogic.ReadElement(new FlightSearchModel
            {
                Id = rent.FlightId
            });
            var planeticket = _planelogic.ReadElement(new PlaneSearchModel
            {
                Id = flight.PlaneId
            });
            int CountPlacesEconom = planeticket.EconomPlacesCount;
            int CountPlacesBusiness = planeticket.BusinessPlacesCount;
            var place = _placelogic.ReadList(new PlaceSearchModel
            {
                FlightId = flight.Id
            });
            if (ticket.TypeTicket == "Эконом")
            {
                panelBusiness.Enabled = false;
            }
            else
            {
                panelEconom.Enabled = false;
            }

            if (place != null)
            {
                int buttonWidth = 45;
                int buttonHeight = 45;
                int buttonSpacing = 5; // промежуток между кнопками
                int rowIndexEconom = 0;
                int rowIndexBusiness = 0;
                int colIndexEconom = 0;
                int colIndexBusiness = 0;
                var sortedPlaces = place.OrderBy(p => p.Id);
                int totalButtons = sortedPlaces.Count();
                int maxButtonsPerRowEconom = (panelEconom.Width - buttonSpacing) / (buttonWidth + buttonSpacing);
                int maxButtonsPerRowBusiness = (panelBusiness.Width - buttonSpacing) / (buttonWidth + buttonSpacing);
                int rowCountEconom = (totalButtons + maxButtonsPerRowEconom - 1) / maxButtonsPerRowEconom;
                int rowCountBusiness = (totalButtons + maxButtonsPerRowBusiness - 1) / maxButtonsPerRowBusiness;

                foreach (var pl in sortedPlaces)
                {
                    Button btn = new Button();
                    btn.Size = new Size(buttonWidth, buttonHeight);
                    btn.Text = pl.PlaceName;
                    if (pl.IsFree == false)
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }
                    btn.Click += (sender, e) =>
                    {
                        ToggleButtonsState(btn);
                    };
                    allButtons.Add(btn);

                    int x = 0;
                    int y = 0;
                    if (pl.PlaceName.Contains("econom"))
                    {
                        x = colIndexEconom * (buttonWidth + buttonSpacing);
                        y = rowIndexEconom * (buttonHeight + buttonSpacing);
                        panelEconom.Controls.Add(btn);
                        colIndexEconom++;
                        if (colIndexEconom >= maxButtonsPerRowEconom)
                        {
                            colIndexEconom = 0;
                            rowIndexEconom++;
                        }
                    }
                    else if (pl.PlaceName.Contains("business"))
                    {
                        x = colIndexBusiness * (buttonWidth + buttonSpacing);
                        y = rowIndexBusiness * (buttonHeight + buttonSpacing);
                        panelBusiness.Controls.Add(btn);
                        colIndexBusiness++;
                        if (colIndexBusiness >= maxButtonsPerRowBusiness)
                        {
                            colIndexBusiness = 0;
                            rowIndexBusiness++;
                        }
                    }
                    btn.Location = new Point(x, y);
                }
            }


        }

        private void FormBordingPass_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ToggleButtonsState(Button clickedButton)
        {
            if (selectedButton == clickedButton)
            {
                // Если кнопка была нажата повторно, включаем все кнопки
                foreach (var button in allButtons)
                {
                    if (button.BackColor != Color.Red) { button.Enabled = true; }
                }
                selectedButton.BackColor = Color.Green;
                selectedButton = null;
            }
            else
            {
                // Если нажата новая кнопка, выключаем все, кроме выбранной
                foreach (var button in allButtons)
                {
                    button.Enabled = button == clickedButton;
                }
                selectedButton = clickedButton;
                selectedButton.BackColor = Color.Blue;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (selectedButton != null)
            {
                // Обновляем состояние места
                var ticket = _ticketlogic.ReadElement(new TicketSearchModel
                {
                    Id = _currentTicketId.Value
                });
                var rent = _rentlogic.ReadElement(new RentSearchModel
                {
                    Id = ticket.RentId
                });
                var flight = _flightlogic.ReadElement(new FlightSearchModel
                {
                    Id = rent.FlightId
                });
                var place = _placelogic.ReadList(new PlaceSearchModel
                {
                    FlightId = flight.Id
                });
                
                foreach (var pl in place)
                {
                    if (pl.PlaceName == selectedButton.Text)
                    {
                        var placeBindingModel = _placelogic.ReadElement(new PlaceSearchModel
                        {
                            FlightId = flight.Id,
                            PlaceName = pl.PlaceName
                        });
                        var placeUpd = new PlaceBindingModel
                        {
                            Id = pl.Id,
                            FlightId = flight.Id,
                            PlaceName = pl.PlaceName,
                            IsFree = false
                        };
                        var operationResult = _placelogic.Update(placeUpd);
                        if (operationResult)
                        {
                            var model = new BoardingPassBindingModel
                            {
                                Id = 0,
                                TicketId = ticket.Id,
                                PlaceId = pl.Id
                            };
                            var createPass = _boardingpasslogic.Create(model); 
                            if (createPass) {
                                MessageBox.Show("Билет зарегистрирован на рейс", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            
                        }
                    }
                }
                selectedButton = null;
            }
        }
    }
}
