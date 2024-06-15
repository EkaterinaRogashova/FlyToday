using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;
using LiveCharts;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlyTodayBusinessLogics.BusinessLogics;
using FlyTodayContracts.BindingModels;

namespace FlyTodayViews
{
    public partial class FormStatisticTickets : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _userLogic;
        private readonly ITicketLogic _ticketLogic;
        private readonly IRentLogic _rentLogic;
        private readonly IReportLogic _reportlogic;

        public FormStatisticTickets(ILogger<FormStatisticTickets> logger, IUserLogic userLogic, ITicketLogic ticketLogic, IRentLogic rentLogic, IReportLogic reportlogic)
        {
            InitializeComponent();
            _ticketLogic = ticketLogic;
            _rentLogic = rentLogic;
            _userLogic = userLogic;
            _logger = logger;
            _reportlogic = reportlogic;
        }

        private void FormStatisticTickets_Load(object sender, EventArgs e)
        {
            LoadTicketStatistics();
        }

        private void LoadTicketStatistics()
        {
            var rents = _rentLogic.ReadList(new RentSearchModel { Status = "Оплачено" });
            int femaleCount = 0;
            int maleCount = 0;
            int BagsCount = 0;
            int NotBagsCount = 0;
            int yearsold12 = 0;
            int yearsold1265 = 0;
            int yearsold = 0;
            int totalTickets = 0;
            foreach (var rent in rents)
            {
                var tickets = _ticketLogic.ReadList(new TicketSearchModel { RentId = rent.Id });
                foreach (var ticket in tickets)
                {
                    totalTickets++;
                    if (ticket.Gender == "Ж")
                    {
                        femaleCount++;
                    }
                    else if (ticket.Gender == "М")
                    {
                        maleCount++;
                    }
                    if (ticket.Bags == true)
                    {
                        BagsCount++;
                    }
                    else if (ticket.Bags == false)
                    {
                        NotBagsCount++;
                    }
                    int age = DateTime.Now.Year - ticket.DateOfBirthday.Year;
                    if (age <= 18)
                    {
                        yearsold12++;
                    }
                    else if (age < 65 && age > 18)
                    {
                        yearsold1265++;
                    }
                    else
                    {
                        yearsold++;
                    }
                }
            }
            double femalePercentage = Math.Round((double)femaleCount / totalTickets * 100, 0);
            double malePercentage = Math.Round((double)maleCount / totalTickets * 100, 0);
            double bagsPercentage = Math.Round((double)BagsCount / totalTickets * 100, 0);
            double notBagsPercentage = Math.Round((double)NotBagsCount / totalTickets * 100, 0);
            double yearsOld12Percentage = Math.Round((double)yearsold12 / totalTickets * 100, 0);
            double yearsOld1265Percentage = Math.Round((double)yearsold1265 / totalTickets * 100, 0);
            double yearsOldPercentage = Math.Round((double)yearsold / totalTickets * 100, 0);
            label12.Text = yearsold12.ToString() + " (" + yearsOld12Percentage + "%)";
            label12to65.Text = yearsold1265.ToString() + " (" + yearsOld1265Percentage + "%)";
            label65.Text = yearsold.ToString() + " (" + yearsOldPercentage + "%)";

            labelMale.Text = maleCount.ToString() + " (" + malePercentage + "%)";
            labelFemale.Text = femaleCount.ToString() + " (" + femalePercentage + "%)";
            labelWithBags.Text = BagsCount.ToString() + " (" + bagsPercentage + "%)";
            labelNotWithBags.Text = NotBagsCount.ToString() + " (" + notBagsPercentage + "%)";
        }

        private void buttonSavePdf_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _reportlogic.SaveStatisticTicketToPdf(new ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        Female = labelFemale.Text,
                        Male = labelMale.Text,
                        WithBags = labelWithBags.Text,
                        NotWithBags = labelNotWithBags.Text,
                        Children = label12.Text,
                        People = label12to65.Text,
                        OlderPeople = label65.Text
                    });
                    _logger.LogInformation("Сохранение расписание за сотрудника");
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка сохранения");
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
