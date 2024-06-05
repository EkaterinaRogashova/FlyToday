using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormFlights : Form
    {
        private readonly ILogger _logger;
        private readonly IFlightLogic _logic;
        private readonly IPlaneLogic _planeLogic;
        private readonly IDirectionLogic _directionLogic;
        public FormFlights(ILogger<FormFlights> logger, IFlightLogic logic, IPlaneLogic planeLogic, IDirectionLogic directionLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _planeLogic = planeLogic;
            dataGridView.Columns.Add("FlightDirection", "Направление");
            dataGridView.Columns.Add("PlaneModel", "Самолет");
            _directionLogic = directionLogic;
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
                    dataGridView.Columns["FreePlacesCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["EconomPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["BusinessPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["TimeInFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["PlaneId"].Visible = false;
                    dataGridView.Columns["DirectionId"].Visible = false;
                    dataGridView.Columns["PlaneModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridView.Columns["FlightDirection"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        int planeId = Convert.ToInt32(row.Cells["PlaneId"].Value);
                        var plane = _planeLogic.ReadElement(new PlaneSearchModel
                        {
                            Id = planeId
                        });
                        if (plane != null)
                        {
                            row.Cells["PlaneModel"].Value = plane.ModelName;
                        }
                        else
                        {
                            row.Cells["PlaneModel"].Value = "Модель не найдена";
                        }

                        int directionId = Convert.ToInt32(row.Cells["DirectionId"].Value);
                        var direction = _directionLogic.ReadElement(new DirectionSearchModel
                        {
                            Id = directionId
                        });
                        if (direction != null)
                        {
                            row.Cells["FlightDirection"].Value = direction.CountryFrom + " " + direction.CityFrom + " - " + direction.CountryTo + " " + direction.CityTo;
                        }
                        else
                        {
                            row.Cells["FlightDirection"].Value = "Направление не найдено";
                        }
                    }

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
