using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayBusinessLogics.MailWorker;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using MigraDoc.DocumentObjectModel.Tables;

namespace FlyTodayViews
{
    public partial class FormFlightsSchedule : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IDirectionLogic _directionLogic;
        public FormFlightsSchedule(ILogger<FormFlights> logger, IFlightLogic logic, IPlaneLogic planeLogic, IDirectionLogic directionLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _planeLogic = planeLogic;
            _directionLogic = directionLogic;
        }

        private void FormFlightsSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
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
            clone.FlatStyle = original.FlatStyle;
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

        public void LoadData()
        {
            try
            {
                _logger.LogInformation("Получение расписания рейсов");
                var list = _logic.ReadList(null);
                var flights = new List<FlightViewModel>();
                var today = DateTime.Today;
                var startOfDay = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
                var endOfDay = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59);

                if (list != null)
                    flights = list.Where(f => f.DepartureDate >= startOfDay && f.DepartureDate <= endOfDay).ToList();

                if (flights.Count > 0)
                {
                    foreach (var flight in flights)
                    {
                        var groupBox = CloneGroupBox(groupBoxFlight);
                        var direction = _directionLogic.ReadElement(new DirectionSearchModel { Id = flight.DirectionId });
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel { Id = flight.PlaneId });

                        var labelDir = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelDirection");
                        var labelDate = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelDepartureDate");
                        var labelPlane = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelPlane");
                        var labelRegist = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelRegistration");

                        groupBox.Name = $"groupBoxTicket{flight.Id}";
                        groupBox.Dock = DockStyle.Top;
                        labelDir.Text = direction.CountryFrom + " " + direction.CityFrom + " - " + direction.CountryTo + " " + direction.CityTo;
                        labelDate.Text = flight.DepartureDate.ToShortDateString() + " " + flight.DepartureDate.ToShortTimeString();
                        labelPlane.Text = plane.ModelName;
                        labelRegist.TextAlign = ContentAlignment.MiddleCenter;
                        labelDir.Font = new Font(labelDir.Font.FontFamily, labelDir.Font.Size, FontStyle.Bold | FontStyle.Italic);
                        if (DateTime.Now >= flight.DepartureDate)
                        {
                            labelRegist.Text = "Вылетел";
                            labelRegist.ForeColor = Color.Blue;
                        }
                        if (DateTime.Now >= flight.DepartureDate - TimeSpan.FromMinutes(40) && DateTime.Now < flight.DepartureDate)
                        {
                            labelRegist.Text = "Регистрация закончилась";
                            labelRegist.ForeColor = Color.Red;
                        }

                        if (DateTime.Now > flight.DepartureDate - TimeSpan.FromHours(2) && DateTime.Now < flight.DepartureDate - TimeSpan.FromMinutes(40))
                        {
                            labelRegist.Text = "Регистрация идет";
                            labelRegist.ForeColor = Color.Green;
                        }
                        if (DateTime.Now < flight.DepartureDate - TimeSpan.FromHours(2))
                        {
                            labelRegist.Text = "Регистрация еще не началась";
                        }
                        panel1.Controls.Add(groupBox);
                    }
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
