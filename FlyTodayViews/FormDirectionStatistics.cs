using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.Extensions.Logging;
using System.Drawing;
using System.Numerics;

namespace FlyTodayViews
{
    public partial class FormDirectionStatistics : Form
    {
        private readonly ILogger _logger;
        private readonly IDirectionLogic _logic;
        private readonly IFlightLogic _flightLogic;
        private readonly ITicketLogic _ticketLogic;
        private readonly IRentLogic _rentLogic;
        public FormDirectionStatistics(ILogger<FormDirectionStatistics> logger, IDirectionLogic logic, IFlightLogic flightLogic, ITicketLogic ticketLogic, IRentLogic rentLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _flightLogic = flightLogic;
            _ticketLogic = ticketLogic;
            _rentLogic = rentLogic;
        }

        private GroupBox CloneGroupBox(GroupBox original)
        {
            var clone = new GroupBox();
            clone.Name = original.Name;
            clone.Text = original.Text;
            clone.Size = original.Size;
            clone.Location = original.Location;
            clone.Anchor = original.Anchor;
            clone.ForeColor = original.ForeColor;
            clone.BackColor = original.BackColor;
            foreach (Control control in original.Controls)
            {
                Control clonedControl = CloneControl(control, control.Name);
                clone.Controls.Add(clonedControl);
            }
            return clone;
        }
        private Control CloneControl(Control original, string uniqueName)
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
            if (original is Label)
            {
                ((Label)clone).Text = ((Label)original).Text;
            }
            return clone;
        }
        private void LoadData()
        {
            try
            {
                _logger.LogInformation("Получение статистики по направлениям");
                int ticketCount = 0;
                Dictionary<DirectionViewModel, int> directionsTickets = new();
                var uniqueDirections = new HashSet<int>();
                if (dateTimePickerDateFrom.Value <= dateTimePickerDateTo.Value)
                {
                    var rents = _rentLogic.ReadList(null);
                    if (rents != null)
                    {
                        foreach (var rent in rents)
                        {
                            if (rent.Status == "Оплачено")
                            {
                                ticketCount = 0;
                                var tickets = _ticketLogic.ReadList(new TicketSearchModel { RentId = rent.Id });
                                if (tickets != null) ticketCount += tickets.Count;
                                var flight = _flightLogic.ReadElement(new FlightSearchModel { Id = rent.FlightId });
                                if (flight != null)
                                {
                                    if (flight.DepartureDate >= dateTimePickerDateFrom.Value && flight.DepartureDate <= dateTimePickerDateTo.Value)
                                    {
                                        var direction = _logic.ReadElement(new DirectionSearchModel { Id = flight.DirectionId });
                                        if (direction != null && !uniqueDirections.Contains(direction.Id))
                                        {
                                            directionsTickets.Add(direction, ticketCount);
                                            uniqueDirections.Add(direction.Id);
                                        }
                                    }
                                }
                            }                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не корректные значения периода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var dir in directionsTickets.OrderBy(d => d.Value))
                {
                    if (dir.Key != null && dir.Value != 0)
                    {
                        var groupBox = CloneGroupBox(groupBoxDir);

                        var labelDir = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelDir");
                        var labelTicketsCount = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelTicketsCount");
                        var labelPercent = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelPercent");

                        groupBox.Name = $"groupBoxDirection{dir.Key.Id}";
                        groupBox.Dock = DockStyle.Top;
                        labelDir.Text = dir.Key.CityFrom + " - " + dir.Key.CityTo;
                        labelTicketsCount.Text = dir.Value.ToString();

                        int totalTickets = directionsTickets.Sum(d => d.Value);
                        double percent = (double)dir.Value / totalTickets * 100;
                        labelPercent.Text = $"{Math.Round(percent, 0)} %";
                        panel1.Controls.Add(groupBox);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка получения направлений");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
