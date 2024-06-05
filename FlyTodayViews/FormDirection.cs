using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormDirection : Form
    {
        private readonly ILogger _logger;
        private readonly IDirectionLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormDirection(ILogger<FormDirection> logger, IDirectionLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxSelectCityTo.Text) || string.IsNullOrEmpty(comboBoxSelectCityFrom.Text) || string.IsNullOrEmpty(textBoxCountryFrom.Text) || string.IsNullOrEmpty(textBoxCountryTo.Text))
            {
                MessageBox.Show("Заполните названия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _logger.LogInformation("Сохранение направления");
            try
            {
                var model = new DirectionBindingModel
                {
                    Id = _id ?? 0,
                    CountryFrom = textBoxCountryFrom.Text,
                    CountryTo = textBoxCountryTo.Text,
                    CityFrom = comboBoxSelectCityFrom.Text,
                    CityTo = comboBoxSelectCityTo.Text
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
                _logger.LogError(ex, "Ошибка сохранения направления");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormDirection_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение направления");
                    var view = _logic.ReadElement(new DirectionSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        textBoxCountryFrom.Text = view.CountryFrom;
                        textBoxCountryTo.Text = view.CountryTo;
                        comboBoxSelectCityFrom.Text = view.CityFrom;
                        comboBoxSelectCityTo.Text = view.CityTo;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения направления");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
