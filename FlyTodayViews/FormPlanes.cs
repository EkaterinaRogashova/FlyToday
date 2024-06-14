using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormPlanes : Form
    {
        private readonly ILogger _logger;
        private readonly IPlaneLogic _logic;
        private readonly IPlaneSchemeLogic _planeSchemeLogic;
        public FormPlanes(ILogger<FormPlanes> logger, IPlaneLogic logic, IPlaneSchemeLogic planeSchemeLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            dataGridView.Columns.Add("PlaneScheme", "Схема самолета");
            dataGridView.Columns["PlaneScheme"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _planeSchemeLogic = planeSchemeLogic;
        }

        private void FormPlanes_Load(object sender, EventArgs e)
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
                    dataGridView.Columns["ModelName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns["PlaneSchemeId"].Visible = false;
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    int planeSchemeId = Convert.ToInt32(row.Cells["PlaneSchemeId"].Value);
                    var planeScheme = _planeSchemeLogic.ReadElement(new PlaneSchemeSearchModel
                    {
                        Id = planeSchemeId
                    });
                    if (planeScheme != null)
                    {
                        row.Cells["PlaneScheme"].Value = planeScheme.Name;
                    }
                    else
                    {
                        row.Cells["PlaneScheme"].Value = "Схема не найдена";
                    }                    
                }

                _logger.LogInformation("Загрузка самолетов");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки самолетов");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPlane));
            if (service is FormPlane form)
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
                var service = Program.ServiceProvider?.GetService(typeof(FormPlane));
                if (service is FormPlane form)
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
                    _logger.LogInformation("Удаление самолета");
                    try
                    {
                        if (!_logic.Delete(new PlaneBindingModel { Id = id }))
                        {
                            throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка удаления самолета");
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonPlaneSchemes_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormPlaneSchemes));
            if (service is FormPlaneSchemes form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
