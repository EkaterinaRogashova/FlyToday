using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormPlane : Form
    {
        private readonly ILogger _logger;
        private readonly IPlaneLogic _logic;
        private readonly IPlaneSchemeLogic _planeSchemeLogic;
        private int? _id;
        public int Id { set { _id = value; } }
        private readonly List<PlaneSchemeViewModel>? _listPlaneScheme;
        public FormPlane(ILogger<FormPlane> logger, IPlaneLogic logic, IPlaneSchemeLogic planeSchemeLogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _planeSchemeLogic = planeSchemeLogic;
            _listPlaneScheme = planeSchemeLogic.ReadList(null);
            if (_listPlaneScheme != null)
            {
                comboBoxPlaneScheme.DisplayMember = "Name";
                comboBoxPlaneScheme.ValueMember = "Id";
                comboBoxPlaneScheme.DataSource = _listPlaneScheme;
                comboBoxPlaneScheme.SelectedItem = null;
            }
        }

        public int PlaneSchemeId
        {
            get
            {
                return Convert.ToInt32(comboBoxPlaneScheme.SelectedValue);
            }
            set
            {
                comboBoxPlaneScheme.SelectedValue = value;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxPlaneScheme.Text))
            {
                MessageBox.Show("Выберите схему самолета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxModelName.Text))
            {
                MessageBox.Show("Заполните название модели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение самолета");
            var planeScheme = _planeSchemeLogic.ReadElement(new PlaneSchemeSearchModel { Id = PlaneSchemeId });
            try
            {
                if (planeScheme != null)
                {
                    var model = new PlaneBindingModel
                    {
                        Id = _id ?? 0,
                        ModelName = textBoxModelName.Text,
                        EconomPlacesCount = planeScheme.EconomPlacesCount,
                        BusinessPlacesCount = planeScheme.BusinessPlacesCount,
                        PlaneSchemeId = PlaneSchemeId
                    };
                    var operationResult = _id.HasValue ? _logic.Update(model) : _logic.Create(model);
                    if (!operationResult)
                    {
                        throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                    }
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения самолета");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormPlane_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение самолета");
                    var view = _logic.ReadElement(new PlaneSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        textBoxModelName.Text = view.ModelName;
                        PlaneSchemeId = view.PlaneSchemeId;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения самолета");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
