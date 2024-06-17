using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayViews
{
    public partial class FormPlaneScheme : Form
    {
        private readonly ILogger _logger;
        private readonly IPlaneSchemeLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormPlaneScheme(ILogger<FormSale> logger, IPlaneSchemeLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEconomPlacesCount.Text) ||
                string.IsNullOrEmpty(textBoxFirstLineCountEconom.Text) || string.IsNullOrEmpty(textBoxSecondLineCountEconom.Text) ||
                string.IsNullOrEmpty(textBoxLastLineCountEconom.Text) || string.IsNullOrEmpty(textBoxBusinessPlacesCount.Text) ||
                string.IsNullOrEmpty(textBoxFirstLineCountBusiness.Text) || string.IsNullOrEmpty(textBoxLastLineCountBusiness.Text))
            {
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((Convert.ToInt32(textBoxBusinessPlacesCount.Text) == 0 && Convert.ToInt32(textBoxFirstLineCountBusiness.Text) != 0 && Convert.ToInt32(textBoxLastLineCountBusiness.Text) != 0)
                || (Convert.ToInt32(textBoxEconomPlacesCount.Text) == 0 && Convert.ToInt32(textBoxFirstLineCountEconom.Text) != 0 && Convert.ToInt32(textBoxSecondLineCountEconom.Text) != 0 && Convert.ToInt32(textBoxLastLineCountEconom.Text) != 0))
            {
                MessageBox.Show("Количество мест в рядах не может быть больше общего количества мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                _logger.LogInformation("Сохранение схемы самолета");
            try
            {

                    var model = new PlaneSchemeBindingModel
                    {
                        Id = _id ?? 0,
                        Name = $"Эконом {textBoxEconomPlacesCount.Text}: {textBoxFirstLineCountEconom.Text}, {textBoxSecondLineCountEconom.Text}, {textBoxLastLineCountEconom.Text}; Бизнес {textBoxBusinessPlacesCount.Text}: {textBoxFirstLineCountBusiness.Text}, {textBoxLastLineCountBusiness.Text}",
                        BusinessPlacesCount = Convert.ToInt32(textBoxBusinessPlacesCount.Text),
                        EconomPlacesCount = Convert.ToInt32(textBoxEconomPlacesCount.Text),
                        PlacesInFirstLineEconom = Convert.ToInt32(textBoxFirstLineCountEconom.Text),
                        PlacesInMiddleLineEconom = Convert.ToInt32(textBoxSecondLineCountEconom.Text),
                        PlacesInLastLineEconom = Convert.ToInt32(textBoxLastLineCountEconom.Text),
                        PlacesInFirstLineBusiness = Convert.ToInt32(textBoxFirstLineCountBusiness.Text),
                        PlacesInLastLineBusiness = Convert.ToInt32(textBoxLastLineCountBusiness.Text)
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
                _logger.LogError(ex, "Ошибка сохранения схемы самолета");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormPlaneScheme_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение схемы самолета");
                    var view = _logic.ReadElement(new PlaneSchemeSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxEconomPlacesCount.Text = view.EconomPlacesCount.ToString();
                        textBoxBusinessPlacesCount.Text = view.BusinessPlacesCount.ToString();
                        textBoxFirstLineCountEconom.Text = view.PlacesInFirstLineEconom.ToString();
                        textBoxSecondLineCountEconom.Text = view.PlacesInMiddleLineEconom.ToString();
                        textBoxLastLineCountEconom.Text = view.PlacesInLastLineEconom.ToString();
                        textBoxFirstLineCountBusiness.Text = view.PlacesInFirstLineBusiness.ToString();
                        textBoxLastLineCountBusiness.Text = view.PlacesInLastLineBusiness.ToString();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения схемы самолета");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
