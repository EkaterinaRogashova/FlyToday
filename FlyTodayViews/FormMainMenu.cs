using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using Microsoft.Extensions.Logging;
using FlyTodayDataModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FlyTodayViews
{
    public partial class FormMainMenu : Form
    {
        private readonly ILogger _logger;
        private readonly IUserLogic _logic;
        private int _currentUserId;
        public FormMainMenu(ILogger<FormMainMenu> logger, IUserLogic logic)
        {
            InitializeComponent();
            _logger = logger;
            _logic = logic;
        }
        public int CurrentUserId
        {
            get { return _currentUserId; }
            set { _currentUserId = value; }
        }
        private void buttonMainEnter_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEnter));
            if (service is FormEnter form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonMainRegistration_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormRegistration));
            if (service is FormRegistration form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormEmployees));
            if (service is FormEmployees form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider?.GetService(typeof(FormSales));
            if (service is FormSales form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //LoadData();
                }
            }
        }
    }
}
