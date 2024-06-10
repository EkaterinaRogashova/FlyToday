using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using System.Windows.Forms.VisualStyles;

namespace FlyTodayViews
{
    public partial class FormTickets : Form
    {
        private readonly ILogger _logger;
        private readonly ITicketLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private readonly ISaleLogic _salelogic;
        private int? _currentRentId;

        public int CurrentRentId { set { _currentRentId = value; } }
        private Dictionary<ComboBox, List<GroupBox>> _comboBoxToGroupBoxes = new Dictionary<ComboBox, List<GroupBox>>();
        public FormTickets(ILogger<FormRent> logger, ITicketLogic logic, IRentLogic rentlogic, IFlightLogic flightlogic, IDirectionLogic directionlogic, ISaleLogic salelogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _rentlogic = rentlogic;
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
            _salelogic = salelogic;
        }
        private GroupBox CloneGroupBox(GroupBox original)
        {
            var clone = new GroupBox();
            clone.Name = original.Name;
            clone.Text = original.Text;
            clone.Size = original.Size;
            clone.Location = original.Location;
            clone.Anchor = original.Anchor;
            clone.ForeColor = original.ForeColor;
            clone.BackColor = original.BackColor;
            foreach (Control control in original.Controls)
            {
                Control clonedControl = CloneControl(control, control.Name);
                clone.Controls.Add(clonedControl);
            }
            return clone;
        }
        private Control CloneControl(Control original, string uniqueName)
        {
            Type type = original.GetType();
            Control clone = (Control)Activator.CreateInstance(type);
            clone.Name = uniqueName;
            clone.Text = original.Text;
            clone.Size = original.Size;
            clone.Location = original.Location;
            clone.Anchor = original.Anchor;
            clone.ForeColor = original.ForeColor;
            clone.BackColor = original.BackColor;
            if (original is ComboBox)
            {
                ((ComboBox)clone).DataSource = new BindingSource((ComboBox)original, "DataSource");
                ((ComboBox)clone).DisplayMember = ((ComboBox)original).DisplayMember;
                ((ComboBox)clone).ValueMember = ((ComboBox)original).ValueMember;
                ((ComboBox)clone).SelectedIndexChanged += comboBoxSale_SelectedIndexChanged;
            }
            if (original is CheckedListBox)
            {
                foreach (var item in ((CheckedListBox)original).Items)
                {
                    ((CheckedListBox)clone).Items.Add(item);
                }
            ((CheckedListBox)clone).ItemCheck += CheckedListBox_ItemCheck;
            }
            if (original is Label)
            {
                ((Label)clone).Text = ((Label)original).Text;
            }
            return clone;
        }
        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            // Проверяем, что только один элемент может быть выбран
            if (checkedListBox.CheckedItems.Count > 0 && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }
        public void LoadData()
        {
            if (_currentRentId.HasValue)
            {
                try
                {
                    var list = _salelogic.ReadList(null);
                    list.Insert(0, new SaleViewModel { Id = 0, Category = "Выберите льготу" });
                    comboBoxSale.DataSource = list;
                    comboBoxSale.DisplayMember = "Category";
                    comboBoxSale.ValueMember = "Id";
                    _logger.LogInformation("Получение информации о бронировании");
                    var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
                    if (view != null)
                    {
                        var flight = _flightlogic.ReadElement(new FlightSearchModel { Id = view.FlightId });
                        if (flight != null)
                        {
                            var direction = _directionlogic.ReadElement(new DirectionSearchModel
                            {
                                Id = flight.DirectionId
                            });
                            if (direction != null) labelFlight.Text = direction.CityFrom + " - " + direction.CityTo;
                            labelDate.Text = flight.DepartureDate.ToShortDateString() + " " + flight.DepartureDate.ToShortTimeString() + " МСК";
                        }
                        labelCost.Text = view.Cost.ToString();
                        int economyCount = view.NumberOfEconomy;
                        int businessCount = view.NumberOfBusiness;
                        int totalCount = economyCount + businessCount;

                        for (int i = 0; i < totalCount; i++)
                        {
                            var groupBox = CloneGroupBox(groupBoxTicket);
                            groupBox.Name = $"groupBoxTicket{i + 1}";
                            var textBoxCost = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCost");
                            var selectedSale = (SaleViewModel)comboBoxSale.SelectedItem;
                            if (i < economyCount)
                            {
                                groupBox.Text = $"Билет {i + 1} эконом";

                                if (textBoxCost != null)
                                {
                                    textBoxCost.Name = "textBoxCostEconom";
                                    textBoxCost.Text = flight.EconomPrice.ToString();
                                }
                            }
                            else
                            {
                                groupBox.Text = $"Билет {i - economyCount + 1} бизнес";
                                if (textBoxCost != null)
                                {
                                    textBoxCost.Text = flight.BusinessPrice.ToString();
                                    textBoxCost.Name = "textBoxCostBusiness";
                                }
                            }
                            if (!_comboBoxToGroupBoxes.ContainsKey(comboBoxSale))
                            {
                                _comboBoxToGroupBoxes[comboBoxSale] = new List<GroupBox>();
                            }
                            _comboBoxToGroupBoxes[comboBoxSale].Add(groupBox);
                            groupBox.Dock = DockStyle.Top;
                            pnlTickets.Controls.Add(groupBox);
                        }
                    }
                    if (!string.IsNullOrEmpty(textBoxCost.Text)) labelCost.Text = textBoxCost.Text;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения бронирования");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FormTicket_Load(object sender, EventArgs e)
        {
            LoadData();
            // Инициализируем словарь _comboBoxToGroupBoxes
            _comboBoxToGroupBoxes = new Dictionary<ComboBox, List<GroupBox>>();
            foreach (Control control in pnlTickets.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    var comboBox = groupBox.Controls.OfType<ComboBox>().FirstOrDefault(cb => cb.Name == "comboBoxSale");
                    if (comboBox != null)
                    {
                        if (!_comboBoxToGroupBoxes.ContainsKey(comboBox))
                        {
                            _comboBoxToGroupBoxes[comboBox] = new List<GroupBox>();
                        }
                        _comboBoxToGroupBoxes[comboBox].Add(groupBox);
                    }
                }
            }

            comboBoxSale.SelectedIndexChanged += comboBoxSale_SelectedIndexChanged;
        }
        private void comboBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем текущий выбранный элемент
            // Получаем ComboBox, где произошло изменение
            var changedComboBox = (ComboBox)sender;

            // Получаем текущий выбранный элемент
            var selectedSale = (SaleViewModel)changedComboBox.SelectedItem;
            var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
            var flight = _flightlogic.ReadElement(new FlightSearchModel { Id = view.FlightId });
            if (selectedSale.Id > 0)
            {
                // Ищем все элементы TextBox с ценой внутри каждого groupBox
                if (_comboBoxToGroupBoxes.TryGetValue(changedComboBox, out var relatedGroupBoxes))
                {
                    // Обновляем цены билетов только в связанных GroupBox
                    foreach (var groupBox in relatedGroupBoxes)
                    {
                        var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                        var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                        if (textBoxCostEconom != null)
                        {
                            textBoxCostEconom.Text = (flight.EconomPrice * (1 - selectedSale.Percent / 100)).ToString();

                        }
                        if (textBoxCostBusiness != null)
                        {
                            textBoxCostBusiness.Text = (flight.BusinessPrice * (1 - selectedSale.Percent / 100)).ToString();
                        }
                    }
                }
            }
            else
            {
                if (_comboBoxToGroupBoxes.TryGetValue(changedComboBox, out var relatedGroupBoxes))
                {
                    // Обновляем цены билетов только в связанных GroupBox
                    foreach (var groupBox in relatedGroupBoxes)
                    {
                        var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                        var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                        if (textBoxCostEconom != null)
                        {
                            textBoxCostEconom.Text = flight.EconomPrice.ToString();

                        }
                        if (textBoxCostBusiness != null)
                        {
                            textBoxCostBusiness.Text = flight.BusinessPrice.ToString();
                        }
                    }
                }
            }
            
        }

    }
}
