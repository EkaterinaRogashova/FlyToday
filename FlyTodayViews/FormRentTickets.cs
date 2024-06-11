using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
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
    public partial class FormRentTickets : Form
    {
        private readonly ILogger _logger;
        private readonly ITicketLogic _logic;
        private readonly IRentLogic _rentlogic;
        private readonly IFlightLogic _flightlogic;
        private readonly IDirectionLogic _directionlogic;
        private readonly ISaleLogic _salelogic;
        private int? _currentRentId;
        public int CurrentRentId { set { _currentRentId = value; } }
        public FormRentTickets(ILogger<FormRent> logger, ITicketLogic logic, IRentLogic rentlogic, IFlightLogic flightlogic, IDirectionLogic directionlogic, ISaleLogic salelogic)
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
                ((ComboBox)clone).DropDownStyle = ((ComboBox)original).DropDownStyle;
            }
            if (original is Label)
            {
                ((Label)clone).Text = ((Label)original).Text;
            }
            return clone;
        }

        public void LoadData()
        {
            if (_currentRentId.HasValue)
            {
                try
                {
                    _logger.LogInformation("Получение билетов в бронировании");
                    var view = _rentlogic.ReadElement(new RentSearchModel { Id = _currentRentId.Value });
                    if (view != null)
                    {
                        int economyCount = view.NumberOfEconomy;
                        int businessCount = view.NumberOfBusiness;
                        int totalCount = economyCount + businessCount;

                        for (int i = 0; i < totalCount; i++)
                        {
                            var groupBox = CloneGroupBox(groupBoxTicket);
                            groupBox.Name = $"groupBoxTicket{i + 1}";

                            groupBox.Text = $"Билет {i + 1}";
                            groupBox.Dock = DockStyle.Top;
                            pnlTickets.Controls.Add(groupBox);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка получения бронирования");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
