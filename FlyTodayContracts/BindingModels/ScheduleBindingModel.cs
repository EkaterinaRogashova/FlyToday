using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class ScheduleBindingModel : IScheduleModel
    {
        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public string Shift { get; set; } = string.Empty;

        public bool Presence { get; set; }

        public int Id { get; set; }
    }
}
