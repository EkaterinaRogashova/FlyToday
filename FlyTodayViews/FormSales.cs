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
    public partial class FormSales : Form
    {
        private readonly ILogger _logger;
        private readonly ISaleLogic _logic;
        public FormSales(ILogger<FormSales> logger, ISaleLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            dataGridView1.Columns.Add("Age", "Возраст");
        }
        private void FormSales_Load(object sender, EventArgs e)
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
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Percent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["AgeTo"].Visible = false;
                    dataGridView1.Columns["AgeFrom"].Visible = false;
                }
                _logger.LogInformation("Загрузка льгот");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["AgeTo"].Value) == 0 && Convert.ToInt32(row.Cells["AgeFrom"].Value) == 150)
                    {
                        row.Cells["Age"].Value = "Безвозрастная категория";
                    }
                    else
                    {
                        if (Convert.ToInt32(row.Cells["AgeTo"].Value) == 0) { row.Cells["Age"].Value = "До " + row.Cells["AgeFrom"].Value; }
                        else if (Convert.ToInt32(row.Cells["AgeFrom"].Value) == 150) { row.Cells["Age"].Value = "От " + row.Cells["AgeTo"].Value; }
                        else { row.Cells["Age"].Value = "От " + row.Cells["AgeTo"].Value + " до " + row.Cells["AgeFrom"].Value; }
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки льгот");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormSale));
            if (service is FormSale form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var service = Program.ServiceProvider?.GetService(typeof(FormSale));
                if (service is FormSale form)
                {
                    form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись?", "Вопрос",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    _logger.LogInformation("Удаление льготы");
                    try
                    {
                        if (!_logic.Delete(new SaleBindingModel
                        {
                            Id = id
                        }))
                        {
                            throw new Exception("Ошибка при удалении.Дополнительная информация в логах.");
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Ошибка удаления льготы");
                        MessageBox.Show(ex.Message, "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
