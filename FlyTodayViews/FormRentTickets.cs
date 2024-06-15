using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.Extensions.Logging;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FlyTodayViews
{
    public partial class FormRentTickets : Form
    {
        private readonly ILogger _logger;
        private readonly ITicketLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IBoardingPassLogic _boardingpasslogic;
        private readonly IDirectionLogic _directionlogic;
        private readonly ISaleLogic _salelogic;
        private readonly IPlaceLogic _placelogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IReportLogic _reportlogic;
        private int? _currentRentId;
        public int CurrentRentId { set { _currentRentId = value; } }
        private Dictionary<Button, int> buttonTicketIdMap = new Dictionary<Button, int>();
        public FormRentTickets(ILogger<FormRent> logger, ITicketLogic logic, IRentLogic rentlogic, IBoardingPassLogic boardingpasslogic, IDirectionLogic directionlogic, ISaleLogic salelogic, IPlaceLogic placelogic, IFlightLogic flightlogic, IReportLogic reportlogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _rentlogic = rentlogic;
            _directionlogic = directionlogic;
            _salelogic = salelogic;
            _boardingpasslogic = boardingpasslogic;
            _placelogic = placelogic;
            _flightlogic = flightlogic;
            _reportlogic = reportlogic;
        }

        private GroupBox CloneGroupBox(GroupBox original, int ticketId)
        {
            var clone = new GroupBox();
            clone.Name = original.Name;
            clone.Text = original.Text;
            clone.Size = original.Size;
            clone.Location = original.Location;
            clone.Anchor = original.Anchor;
            clone.ForeColor = original.ForeColor;
            clone.BackColor = original.BackColor;
            clone.Font = new Font(original.Font.FontFamily, original.Font.Size);
            foreach (Control control in original.Controls)
            {
                Control clonedControl = CloneControl(control, control.Name, ticketId);
                clone.Controls.Add(clonedControl);
            }
            return clone;
        }
        private Control CloneControl(Control original, string uniqueName, int ticketId)
        {
            Type type = original.GetType();
            Control clone = (Control)Activator.CreateInstance(type);
            clone.Name = uniqueName;
            clone.Text = original.Text;
            clone.Size = original.Size;
            clone.Location = original.Location;
            clone.Anchor = original.Anchor;
            clone.ForeColor = original.ForeColor;
            clone.BackColor = original.BackColor;
            clone.Font = new Font(original.Font.FontFamily, original.Font.Size);
            if (original is Label)
            {
                ((Label)clone).Text = ((Label)original).Text;
            }
            if (original is Button)
            {
                buttonTicketIdMap[clone as Button] = ticketId;
            }
            return clone;
        }

        public void LoadData()
        {
            if (_currentRentId.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение билетов в бронировании");
                    var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
                    var flight = _flightlogic.ReadElement(new FlightSearchModel { Id = view.FlightId });
                    if (view != null)
                    {
                        var tickets = _logic.ReadList(new TicketSearchModel { RentId = _currentRentId.Value });

                        int totalCount = tickets.Count;

                        for (int i = 0; i < totalCount; i++)
                        {
                            var ticket = tickets[i];
                            var groupBox = CloneGroupBox(groupBoxTicket, ticket.Id);
                            var bordingpasses = _boardingpasslogic.ReadElement(new BoardingPassSearchModel { TicketId = ticket.Id });
                            var labelPlace = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelPlace");
                            var buttonBoardingPass = groupBox.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "buttonCreateBoardingPass");
                            var buttonSave = groupBox.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "buttonSaveBoardingPass");
                            buttonBoardingPass.Click += buttonCreateBoardingPass_Click;
                            buttonSave.Click += buttonSaveBoardingPass_Click;
                            if (DateTime.Now >= flight.DepartureDate - TimeSpan.FromHours(2) && DateTime.Now <= flight.DepartureDate - TimeSpan.FromMinutes(40))
                            {
                                buttonBoardingPass.BackColor = Color.AliceBlue;
                                if (bordingpasses != null)
                                {
                                    var place = _placelogic.ReadElement(new PlaceSearchModel { Id = bordingpasses.PlaceId });
                                    if (place != null) labelPlace.Text = place.PlaceName;
                                    buttonBoardingPass.Enabled = false;
                                }
                                else
                                {
                                    buttonBoardingPass.Enabled = true;
                                    labelPlace.Text = "Билет не зарегестрирован.";
                                }
                            }
                            else
                            {
                                buttonBoardingPass.BackColor = Color.Red;
                                buttonBoardingPass.Enabled = false;
                                if (bordingpasses != null)
                                {
                                    var place = _placelogic.ReadElement(new PlaceSearchModel { Id = bordingpasses.PlaceId });
                                    if (place != null) labelPlace.Text = place.PlaceName;
                                    buttonBoardingPass.Enabled = false;
                                }
                                else
                                {
                                    labelPlace.Text = "Билет не зарегестрирован.";
                                }
                            }
                            var labelF = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelFIO");
                            var labelDoc = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelDocument");
                            var labelType = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelType");
                            var labelCost = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelCost");
                            var labelBag = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelBags");
                            groupBox.Name = $"groupBoxTicket{i + 1}";
                            groupBox.Text = $"Билет {i + 1}";
                            groupBox.Dock = DockStyle.Top;
                            labelF.Text = ticket.Surname + " " + ticket.Name + " " + ticket.LastName;
                            labelDoc.Text = ticket.SeriesOfDocument + " " + ticket.NumberOfDocument;
                            labelType.Text = ticket.TypeTicket;
                            labelCost.Text = ticket.TicketCost.ToString("C");
                            if (ticket.Bags == true)
                            {
                                labelBag.Text = "Да";
                            }
                            else { labelBag.Text = "Нет"; }
                            pnlTickets.Controls.Add(groupBox);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения бронирования");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormRentTickets_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCreateBoardingPass_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormBordingPass));
            if (service is FormBordingPass form)
            {
                if (buttonTicketIdMap.TryGetValue(sender as Button, out int ticketId))
                {
                    form.CurrentTicketId = ticketId;
                    form.CurrentRentId = _currentRentId.Value;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        public void LoadDataRefresh()
        {
            if (_currentRentId.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение билетов в бронировании");
                    var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
                    if (view != null)
                    {
                        var tickets = _logic.ReadList(new TicketSearchModel { RentId = _currentRentId.Value });

                        int totalCount = tickets.Count;

                        for (int i = 0; i < totalCount; i++)
                        {
                            var ticket = tickets[i];
                            var groupBox = pnlTickets.Controls.OfType<GroupBox>().FirstOrDefault(g => g.Name == $"groupBoxTicket{i + 1}");
                            if (groupBox != null)
                            {
                                var bordingpasses = _boardingpasslogic.ReadElement(new BoardingPassSearchModel { TicketId = ticket.Id });
                                var labelPlace = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelPlace");
                                var buttonBoardingPass = groupBox.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "buttonCreateBoardingPass");
                                if (bordingpasses != null)
                                {
                                    var place = _placelogic.ReadElement(new PlaceSearchModel { Id = bordingpasses.PlaceId });
                                    if (place != null) labelPlace.Text = place.PlaceName;
                                    buttonBoardingPass.Enabled = false;
                                }
                                else
                                {
                                    labelPlace.Text = "Билет не зарегестрирован.";
                                    buttonBoardingPass.Enabled = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения бронирования");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataRefresh();
        }

        private void buttonSaveBoardingPass_Click(object sender, EventArgs e)
        {
            if (buttonTicketIdMap.TryGetValue(sender as Button, out int ticketId))
            {
                var boardingpass = _boardingpasslogic.ReadElement(new BoardingPassSearchModel { TicketId = ticketId });
                if (boardingpass == null)
                {
                    MessageBox.Show("Билет еще не зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            _reportlogic.SaveBoardingPassToPdf(new ReportBindingModel
                            {
                                FileName = dialog.FileName,
                                TicketId = ticketId
                            });
                            _logger.LogInformation("Сохранение посадочного талона");
                            MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, "Ошибка сохранения");
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
