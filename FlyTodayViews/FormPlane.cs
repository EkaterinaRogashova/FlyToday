using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormPlane : Form
    {
        private readonly ILogger _logger;
        private readonly IPlaneLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormPlane(ILogger<FormPlane> logger, IPlaneLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEconomPlacesCount.Text)) {
                MessageBox.Show("Заполните кол-во мест эконом класса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxBusinessPlacesCount.Text))
            {
                MessageBox.Show("Заполните кол-во мест бизнес класса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxModelName.Text))
            {
                MessageBox.Show("Заполните название модели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение самолета");
            try
            {
                var model = new PlaneBindingModel
                {
                    Id = _id ?? 0,
                    ModelName = textBoxModelName.Text,
                    EconomPlacesCount = Convert.ToInt32(textBoxEconomPlacesCount.Text),
                    BusinessPlacesCount = Convert.ToInt32(textBoxBusinessPlacesCount.Text)
                };
                var operationResult = _id.HasValue ? _logic.Update(model) : _logic.Create(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
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
                        textBoxEconomPlacesCount.Text = view.EconomPlacesCount.ToString();
                        textBoxBusinessPlacesCount.Text = view.BusinessPlacesCount.ToString();                   
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
