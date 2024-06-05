using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormFlights : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        public FormFlights(ILogger<FormFlights> logger, IFlightLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void FormFlights_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _logic.ReadList(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns["Id"].Visible = false;
                    dataGridView.Columns["DepartureDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["FreePlacesCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["EconomPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["BusinessPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["TimeInFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["DirectionId"].DataPropertyName = "Direction.CountryFrom + ' - ' + Direction.CityFrom + ' - ' + Direction.CountryTo + ' - ' + Direction.CityTo";
                    dataGridView.Columns["PlaneId"].DataPropertyName = "Plane.ModelName";
                }
                _logger.LogInformation("Загрузка рейсов");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки рейсов");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormFlight));
            if (service is FormFlight form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var service = Program.ServiceProvider?.GetService(typeof(FormFlight));
                if (service is FormFlight form)
                {
                    form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                    _logger.LogInformation("Удаление рейса");
                    try
                    {
                        if (!_logic.Delete(new FlightBindingModel { Id = id }))
                        {
                            throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка удаления рейса");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
