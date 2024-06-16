using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayDataModels.Enums;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace FlyTodayViews
{
    public partial class FormProfile : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private int? _id;
        public int Id { set { _id = value; } }
        public FormProfile(ILogger<FormProfile> logger, IUserLogic logic, IRentLogic rentLogic, IFlightLogic flightlogic, IDirectionLogic directionlogic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
            _rentlogic = rentLogic;
            dataGridView1.Columns.Add("Flight", "Рейс");
            dataGridView1.Columns.Add("StatusFlight", "Состояние");
            _flightlogic = flightlogic;
            _directionlogic = directionlogic;
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            var user = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
            var service = Program.ServiceProvider?.GetService(typeof(FormEditProfile));
            if (service is FormEditProfile form)
            {
                if (_id != null)
                {
                    Hide();
                    form.Id = _id.Value;
                    form.Email = user.Email;
                    form.Password = user.Password;
                    form.Show();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы дейстительно хотите удалить профиль?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _logger.LogInformation("Удаление пользователя");
                try
                {
                    if (!_logic.Delete(new UserBindingModel { Id = _id.Value }))
                    {
                        throw new Exception("Ошибка при удалении. Дополнительная информация в логах.");
                    }
                    else
                    {
                        MessageBox.Show("Профиль успешно удален.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        _id = null;
                        var service = Program.ServiceProvider?.GetService(typeof(FormMainMenu));
                        if (service is FormMainMenu form)
                        {
                            form.Show();
                            form.LoadData();
                            form.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка удаления пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonMyRents_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormMainMenu));
            if (service is FormMainMenu newForm)
            {
                newForm.CurrentUserId = _id.Value;
                newForm.Show();
                newForm.LoadData();
                newForm.Refresh();
                Close();
            }
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение пользователя");
                    var view = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
                    if (view != null)
                    {
                        labelFIO.Text = view.Surname + " " + view.Name + " " + view.LastName;
                        labelDateOfBirth.Text = view.DateOfBirthday.ToShortDateString();
                        labelEmail.Text = view.Email;
                        checkBoxAllowNotif.Checked = view.AllowNotifications;
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения пользователя");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadData()
        {
            try
            {
                if (_id.HasValue)
                {
                    var list = _rentlogic.ReadList(new RentSearchModel
                    {
                        UserId = _id.Value
                    });
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["UserId"].Visible = false;
                        dataGridView1.Columns["FlightId"].Visible = false;
                        dataGridView1.Columns["Flight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                        dataGridView1.Columns["Cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns["NumberOfBusiness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        dataGridView1.Columns["NumberOfEconomy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        dataGridView1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns["StatusFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            int flightId = Convert.ToInt32(row.Cells["FlightId"].Value);
                            var flight = _flightlogic.ReadElement(new FlightSearchModel
                            {
                                Id = flightId
                            });
                            if (flight != null)
                            {
                                var dir = _directionlogic.ReadElement(new DirectionSearchModel
                                {
                                    Id = flight.DirectionId
                                });
                                if (dir != null)
                                {
                                    row.Cells["Flight"].Value = dir.CityFrom + " - " + dir.CityTo + " " + flight.DepartureDate;
                                }
                                else
                                {
                                    row.Cells["Flight"].Value = "Рейс не найден";
                                }
                            }
                            if (DateTime.Now >= flight.DepartureDate)
                            {
                                row.Cells["StatusFlight"].Value = "Вылетел";
                            }
                            if (DateTime.Now >= flight.DepartureDate - TimeSpan.FromMinutes(40) && DateTime.Now < flight.DepartureDate)
                            {
                                row.Cells["StatusFlight"].Value = "Регистрация закончилась";
                            }

                            if (DateTime.Now > flight.DepartureDate - TimeSpan.FromHours(2) && DateTime.Now < flight.DepartureDate - TimeSpan.FromMinutes(40))
                            {
                                row.Cells["StatusFlight"].Value = "Регистрация идет";
                            }
                            if (DateTime.Now < flight.DepartureDate - TimeSpan.FromHours(2))
                            {
                                row.Cells["StatusFlight"].Value = "Регистрация еще не началась";
                            }
                        }

                    }
                    _logger.LogInformation("Загрузка бронирований");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка загрузки бронирований");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxAllowNotif_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var currentUser = _logic.ReadElement(new UserSearchModel { Id = _id.Value });
                bool isAllowNotifications = checkBoxAllowNotif.Checked;
                var model = new UserBindingModel
                {
                    Id = currentUser.Id,
                    Surname = currentUser.Surname,
                    Name = currentUser.Name,
                    LastName = currentUser.LastName,
                    DateOfBirthday = currentUser.DateOfBirthday,
                    Email = currentUser.Email,
                    Password = currentUser.Password,
                    AccessRule = currentUser.AccessRule,
                    AllowNotifications = isAllowNotifications
                };
                var operationResult = _logic.UpdateNotifications(model);
                if (!operationResult)
                {
                    throw new Exception("Ошибка при сохранении. Дополнительная информация в логах.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка сохранения пользователя");
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormMainMenu));
            if (service is FormMainMenu newForm)
            {
                newForm.CurrentUserId = _id.Value;
                newForm.Show();
                newForm.LoadData();
                newForm.Refresh();
                Close();
            }
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var rent = _rentlogic.ReadElement(new RentSearchModel { Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) });
                if (rent != null)
                {
                    if (dataGridView1.SelectedRows[0].Cells["StatusFlight"].Value == "Вылетел" || dataGridView1.SelectedRows[0].Cells["StatusFlight"].Value == "Регистрация закончилась")
                    {
                        MessageBox.Show("Нельзя оформить билет на данный рейс", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (rent.Status == "Оплачено")
                    {
                        MessageBox.Show("Билеты уже оформлены. Вы можете их только посмотреть и зарегистрировать на рейс", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormTickets));
                        if (service is FormTickets form)
                        {
                            form.CurrentRentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                LoadData();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите бронирование", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonCreateBoardingPass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var rent = _rentlogic.ReadElement(new RentSearchModel { Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) });
                if (rent != null)
                {
                    if (rent.Status == "Оплачено")
                    {
                        var service = Program.ServiceProvider?.GetService(typeof(FormRentTickets));
                        if (service is FormRentTickets form)
                        {
                            form.CurrentRentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                LoadData();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сначала надо оформить билеты!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
