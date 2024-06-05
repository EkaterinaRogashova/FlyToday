using FlyTodayContracts.BusinessLogicContracts;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormMainMenu : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private int _currentUserId;
        public FormMainMenu(ILogger<FormMainMenu> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }
        public int CurrentUserId
        {
            get { return _currentUserId; }
            set { _currentUserId = value; }
        }
        private void buttonMainEnter_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEnter));
            if (service is FormEnter form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonMainRegistration_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormRegistration));
            if (service is FormRegistration form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEmployees));
            if (service is FormEmployees form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormSales));
            if (service is FormSales form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonMainSearch_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormFlights));
            if (service is FormFlights form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonPlanes_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPlanes));
            if (service is FormPlanes form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonDirections_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormDirections));
            if (service is FormDirections form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }
    }
}
