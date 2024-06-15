using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayBusinessLogics.MailWorker;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using FlyTodayDataModels.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
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
        private readonly IUserLogic _userlogic;
        private readonly AbstractMailWorker _mailWorker;
        private int? _currentRentId;

        public int CurrentRentId { set { _currentRentId = value; } }
        private Dictionary<ComboBox, List<GroupBox>> _comboBoxToGroupBoxes = new Dictionary<ComboBox, List<GroupBox>>();
        private Dictionary<CheckBox, List<GroupBox>> _checkBoxToGroupBoxes = new Dictionary<CheckBox, List<GroupBox>>();
        public FormTickets(ILogger<FormRent> logger, ITicketLogic logic, IRentLogic rentlogic, IFlightLogic flightlogic, IDirectionLogic directionlogic, ISaleLogic salelogic, IUserLogic userlogic, AbstractMailWorker mailWorker)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _rentlogic = rentlogic;
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
            _salelogic = salelogic;
            _userlogic = userlogic;
            _mailWorker = mailWorker;
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
            clone.Font = new Font(original.Font.FontFamily, original.Font.Size);
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
            clone.Font = new Font(original.Font.FontFamily, original.Font.Size);
            if (original is TextBox)
            {
                ((TextBox)clone).ReadOnly = ((TextBox)original).ReadOnly;
                ((TextBox)clone).TextChanged += textBoxCost_Changed;
            }
            if (original is ComboBox)
            {
                ((ComboBox)clone).DataSource = new BindingSource((ComboBox)original, "DataSource");
                ((ComboBox)clone).DisplayMember = ((ComboBox)original).DisplayMember;
                ((ComboBox)clone).ValueMember = ((ComboBox)original).ValueMember;
                ((ComboBox)clone).SelectedIndexChanged += comboBoxSale_SelectedIndexChanged;
                ((ComboBox)clone).DropDownStyle = ((ComboBox)original).DropDownStyle;
            }
            if (original is CheckBox)
            {
                ((CheckBox)clone).CheckedChanged += checkBoxBags_CheckedChanged;
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

                        int economyCount = view.NumberOfEconomy;
                        int businessCount = view.NumberOfBusiness;
                        int totalCount = economyCount + businessCount;

                        for (int i = 0; i < totalCount; i++)
                        {
                            var groupBox = CloneGroupBox(groupBoxTicket);
                            groupBox.Name = $"groupBoxTicket{i + 1}";
                            var textBoxCost = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCost");
                            var labelTT = groupBox.Controls.OfType<Label>().FirstOrDefault(tb => tb.Name == "labelTypeTicket");
                            var selectedSale = (SaleViewModel)comboBoxSale.SelectedItem;

                            groupBox.Text = $"Билет {i + 1}";
                            if (i < economyCount)
                            {
                                if (textBoxCost != null)
                                {
                                    textBoxCost.Name = "textBoxCostEconom";
                                    textBoxCost.Text = flight.EconomPrice.ToString();
                                    labelTT.Text = "Эконом";
                                }
                            }
                            else
                            {
                                if (textBoxCost != null)
                                {
                                    textBoxCost.Text = flight.BusinessPrice.ToString();
                                    textBoxCost.Name = "textBoxCostBusiness";
                                    labelTT.Text = "Бизнес";
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
            CalculateTotalCost();
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
            _checkBoxToGroupBoxes = new Dictionary<CheckBox, List<GroupBox>>();
            foreach (Control control in pnlTickets.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    var checkBox = groupBox.Controls.OfType<CheckBox>().FirstOrDefault(cb => cb.Name == "checkBoxBags");
                    if (checkBox != null)
                    {
                        if (!_checkBoxToGroupBoxes.ContainsKey(checkBox))
                        {
                            _checkBoxToGroupBoxes[checkBox] = new List<GroupBox>();
                        }
                        _checkBoxToGroupBoxes[checkBox].Add(groupBox);
                    }
                }
            }

            comboBoxSale.SelectedIndexChanged += comboBoxSale_SelectedIndexChanged;
            checkBoxBags.CheckedChanged += checkBoxBags_CheckedChanged;
        }
        private void textBoxCost_Changed(object sender, EventArgs e)
        {
            CalculateTotalCost();
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

            double costBags = 0;

            if (selectedSale.Id > 0)
            {
                if (_comboBoxToGroupBoxes.TryGetValue(changedComboBox, out var relatedGroupBoxes))
                {
                    // Обновляем цены билетов только в связанных GroupBox
                    foreach (var groupBox in relatedGroupBoxes)
                    {
                        var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                        var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                        var checkBox = groupBox.Controls.OfType<CheckBox>().FirstOrDefault(tb => tb.Name == "checkBoxBags");
                        if (checkBox.Checked)
                        {
                            if (textBoxCostEconom != null)
                            {
                                costBags = flight.EconomPrice * 1.05;
                                textBoxCostEconom.Text = (costBags * (1 - selectedSale.Percent / 100)).ToString();

                            }
                            if (textBoxCostBusiness != null)
                            {
                                costBags = flight.BusinessPrice * 1.05;
                                textBoxCostBusiness.Text = (costBags * (1 - selectedSale.Percent / 100)).ToString();
                            }
                        }
                        else
                        {
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
                        var checkBox = groupBox.Controls.OfType<CheckBox>().FirstOrDefault(tb => tb.Name == "checkBoxBags");
                        if (checkBox.Checked)
                        {
                            if (textBoxCostEconom != null)
                            {
                                costBags = flight.EconomPrice * 1.05;
                                textBoxCostEconom.Text = costBags.ToString();

                            }
                            if (textBoxCostBusiness != null)
                            {
                                costBags = flight.BusinessPrice * 1.05;
                                textBoxCostBusiness.Text = costBags.ToString();
                            }
                        }
                        else
                        {
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
        private void CalculateTotalCost()
        {
            double totalCost = 0;

            // Перебираем все textBoxCostBusiness и суммируем их
            foreach (Control control in pnlTickets.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                    if (textBoxCostBusiness != null)
                    {
                        if (double.TryParse(textBoxCostBusiness.Text, out double cost))
                        {
                            totalCost += cost;
                        }
                    }
                }
            }

            // Перебираем все textBoxCostEconomy и суммируем их
            foreach (Control control in pnlTickets.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                    if (textBoxCostEconom != null)
                    {
                        if (double.TryParse(textBoxCostEconom.Text, out double cost))
                        {
                            totalCost += cost;
                        }
                    }
                }
            }

            // Устанавливаем значение labelCost.Text
            labelCost.Text = totalCost.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
                var flight = _flightlogic.ReadElement(new FlightSearchModel { Id = view.FlightId });
                int CEFree = flight.FreePlacesCountEconom;
                int CBFree = flight.FreePlacesCountBusiness;
                foreach (Control control in pnlTickets.Controls)
                {
                    if (control is GroupBox groupBox)
                    {

                        var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                        var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                        var comboBoxSale = groupBox.Controls.OfType<ComboBox>().FirstOrDefault(cb => cb.Name == "comboBoxSale");
                        var Surname = groupBox.Controls.OfType<TextBox>().FirstOrDefault(cb => cb.Name == "textBoxSurname");
                        var Name = groupBox.Controls.OfType<TextBox>().FirstOrDefault(cb => cb.Name == "textBoxName");
                        var Lastname = groupBox.Controls.OfType<TextBox>().FirstOrDefault(cb => cb.Name == "textBoxLastname");
                        var Series = groupBox.Controls.OfType<TextBox>().FirstOrDefault(cb => cb.Name == "textBoxSeria");
                        var Number = groupBox.Controls.OfType<TextBox>().FirstOrDefault(cb => cb.Name == "textBoxNumber");
                        var Date = groupBox.Controls.OfType<DateTimePicker>().FirstOrDefault(dtp => dtp.Name == "dateTimePickerBirth");
                        var Gender = groupBox.Controls.OfType<CheckedListBox>().FirstOrDefault(clb => clb.Name == "checkedListBoxGender");
                        var Bags = groupBox.Controls.OfType<CheckBox>().FirstOrDefault(cb => cb.Name == "checkBoxBags");
                        var TypeTicket = groupBox.Controls.OfType<Label>().FirstOrDefault(cb => cb.Name == "labelTypeTicket");
                        string typeTicket = TypeTicket?.Text?.ToLower() ?? "";
                        if (textBoxCostBusiness != null || textBoxCostEconom != null)
                        {
                            var ticket = new TicketBindingModel
                            {
                                RentId = view.Id,
                                TypeTicket = TypeTicket.Text,
                                Surname = Surname.Text,
                                Name = Name.Text,
                                LastName = Lastname.Text,
                                SeriesOfDocument = Series.Text,
                                NumberOfDocument = Number.Text,
                                DateOfBirthday = Date.Value.ToUniversalTime(),
                                Gender = Gender.SelectedItem?.ToString(),
                                TicketCost = double.Parse(typeTicket.Contains("эконом") ? textBoxCostEconom.Text : textBoxCostBusiness.Text),
                                Bags = Bags?.Checked ?? false
                            };
                            if (comboBoxSale?.SelectedValue != null && int.TryParse(comboBoxSale.SelectedValue.ToString(), out int saleId) && saleId > 0)
                            {
                                var sale = _salelogic.ReadElement(new SaleSearchModel { Id = saleId });
                                int age = DateTime.Now.Year - Date.Value.Year;
                                if (DateTime.Now.Month < Date.Value.Month || (DateTime.Now.Month == Date.Value.Month && DateTime.Now.Day < Date.Value.Day))
                                {
                                    age--;
                                }
                                if (age >= sale.AgeTo && age <= sale.AgeFrom) ticket.SaleId = saleId;
                                else
                                {
                                    MessageBox.Show("Возраст не соответствует выбранной категории", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                            }
                            else
                            {
                                ticket.SaleId = null;
                            }
                            if (ticket.TypeTicket == "Бизнес")
                            {
                                CBFree--;
                            }
                            else
                            {
                                CEFree--;
                            }
                            _logic.Create(ticket);
                        }

                    }
                }
                MessageBox.Show("Билеты успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var newView = new RentBindingModel
                {
                    Id = view.Id,
                    Cost = double.Parse(labelCost.Text),
                    Status = "Оплачено"
                };
                _rentlogic.Update(newView);
                var user = _userlogic.ReadElement(new UserSearchModel { Id = view.UserId });
                var dir = _directionlogic.ReadElement(new DirectionSearchModel { Id = flight.DirectionId });
                if (user != null && user.AllowNotifications)
                {
                    _mailWorker.MailSendAsync(new()
                    {
                        MailAddress = user.Email,
                        Subject = "Оплата бронирования",
                        Text = $"Ваше бронирование на рейс {dir.CountryFrom} {dir.CityFrom} - {dir.CountryTo} {dir.CityTo} на сумму {Math.Round(newView.Cost, 2)} руб. успешно оплачено."
                    });
                }
                var curFlight = new FlightBindingModel
                {
                    Id = view.FlightId,
                    PlaneId = flight.PlaneId,
                    DirectionId = flight.DirectionId,
                    DepartureDate = flight.DepartureDate,
                    TimeInFlight = flight.TimeInFlight,
                    BusinessPrice = flight.BusinessPrice,
                    EconomPrice = flight.EconomPrice,
                    FreePlacesCountBusiness = CBFree,
                    FreePlacesCountEconom = CEFree
                };
                _flightlogic.Update(curFlight);
                Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения билетов");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxBags_CheckedChanged(object sender, EventArgs e)
        {
            var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
            var flight = _flightlogic.ReadElement(new FlightSearchModel { Id = view.FlightId });

            var changedCheckBox = (CheckBox)sender;
            double costBags = 0;

            if (changedCheckBox.Checked)
            {
                if (_checkBoxToGroupBoxes.TryGetValue(changedCheckBox, out var relatedGroupBoxes))
                {
                    // Обновляем цены билетов только в связанных GroupBox
                    foreach (var groupBox in relatedGroupBoxes)
                    {
                        var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                        var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                        var Sale = groupBox.Controls.OfType<ComboBox>().FirstOrDefault(tb => tb.Name == "comboBoxSale");
                        var selectedSale = (SaleViewModel)Sale.SelectedItem;
                        if (selectedSale.Id > 0)
                        {
                            if (textBoxCostEconom != null)
                            {
                                costBags = flight.EconomPrice * 1.05;
                                textBoxCostEconom.Text = (costBags * (1 - selectedSale.Percent / 100)).ToString();

                            }
                            if (textBoxCostBusiness != null)
                            {
                                costBags = flight.BusinessPrice * 1.05;
                                textBoxCostBusiness.Text = (costBags * (1 - selectedSale.Percent / 100)).ToString();
                            }
                        }
                        else
                        {
                            if (textBoxCostEconom != null)
                            {
                                costBags = flight.EconomPrice * 1.05;
                                textBoxCostEconom.Text = costBags.ToString();

                            }
                            if (textBoxCostBusiness != null)
                            {
                                costBags = flight.BusinessPrice * 1.05;
                                textBoxCostBusiness.Text = costBags.ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                if (_checkBoxToGroupBoxes.TryGetValue(changedCheckBox, out var relatedGroupBoxes))
                {
                    // Обновляем цены билетов только в связанных GroupBox
                    foreach (var groupBox in relatedGroupBoxes)
                    {
                        var textBoxCostEconom = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostEconom");
                        var textBoxCostBusiness = groupBox.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == "textBoxCostBusiness");
                        var Sale = groupBox.Controls.OfType<ComboBox>().FirstOrDefault(tb => tb.Name == "comboBoxSale");
                        var selectedSale = (SaleViewModel)Sale.SelectedItem;
                        if (selectedSale.Id > 0)
                        {
                            if (textBoxCostEconom != null)
                            {
                                textBoxCostEconom.Text = (flight.EconomPrice * (1 - selectedSale.Percent / 100)).ToString();

                            }
                            if (textBoxCostBusiness != null)
                            {
                                textBoxCostBusiness.Text = (flight.BusinessPrice * (1 - selectedSale.Percent / 100)).ToString();
                            }
                        }
                        else
                        {
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
}

