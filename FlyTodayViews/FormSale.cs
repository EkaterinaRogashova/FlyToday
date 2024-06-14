using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormSale : Form
    {
        private readonly ILogger _logger;
        private readonly ISaleLogic _logic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormSale(ILogger<FormSale> logger, ISaleLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }
        private void FormSale_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение льготы");
                    var view = _logic.ReadElement(new SaleSearchModel
                    {
                        Id = _id.Value
                    });
                    if (view != null)
                    {
                        if (view.AgeTo != 0) textBoxAgeTo.Text = view.AgeTo.ToString();
                        if (view.AgeFrom != 150) textBoxAgeFrom.Text = view.AgeFrom.ToString();
                        textBoxCategoryName.Text = view.Category;
                        textBoxPercent.Text = view.Percent.ToString();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения льготы");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCategoryName.Text) || string.IsNullOrEmpty(textBoxPercent.Text))
            {
                MessageBox.Show("Заполните поля", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ageTo;
            int ageFrom;

            if (string.IsNullOrEmpty(textBoxAgeTo.Text) && string.IsNullOrEmpty(textBoxAgeFrom.Text))
            {
                ageTo = 0;
                ageFrom = 150;
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxAgeTo.Text)) {ageTo = 0; ageFrom = Convert.ToInt32(textBoxAgeFrom.Text); }
                else if (string.IsNullOrEmpty(textBoxAgeFrom.Text)) { ageFrom = 150; ageTo = Convert.ToInt32(textBoxAgeTo.Text); }
                else
                {
                    ageFrom = Convert.ToInt32(textBoxAgeFrom.Text);
                    ageTo = Convert.ToInt32(textBoxAgeTo.Text);
                }
                
            }
            _logger.LogInformation("Сохранение льготы");
            try
            {
                var model = new SaleBindingModel
                {
                    Id = _id ?? 0,
                    Category = textBoxCategoryName.Text,
                    Percent = Convert.ToDouble(textBoxPercent.Text),
                    AgeTo = ageTo,
                    AgeFrom = ageFrom
                };
                var operationResult = _id.HasValue ? _logic.Update(model) :
               _logic.Create(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения льготы");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
