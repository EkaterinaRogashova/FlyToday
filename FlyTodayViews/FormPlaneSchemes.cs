using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormPlaneSchemes : Form
    {
        private readonly ILogger _logger;
        private readonly IPlaneSchemeLogic _logic;
        public FormPlaneSchemes(ILogger<FormPlaneSchemes> logger, IPlaneSchemeLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void FormPlaneSchemes_Load(object sender, EventArgs e)
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
                    dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["BusinessPlacesCount"].Visible = false;
                    dataGridView.Columns["EconomPlacesCount"].Visible = false;
                    dataGridView.Columns["PlacesInFirstLineEconom"].Visible = false;
                    dataGridView.Columns["PlacesInMiddleLineEconom"].Visible = false;
                    dataGridView.Columns["PlacesInLastLineEconom"].Visible = false;
                    dataGridView.Columns["PlacesInFirstLineBusiness"].Visible = false;
                    dataGridView.Columns["PlacesInLastLineBusiness"].Visible = false;
                }
                _logger.LogInformation("Загрузка схем самолетов");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки схем самолетов");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPlaneScheme));
            if (service is FormPlaneScheme form)
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
                var service = Program.ServiceProvider?.GetService(typeof(FormPlaneScheme));
                if (service is FormPlaneScheme form)
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
                    _logger.LogInformation("Удаление схемы самолетов");
                    try
                    {
                        if (!_logic.Delete(new PlaneSchemeBindingModel { Id = id }))
                        {
                            throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка удаления схемы самолетоа");
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
