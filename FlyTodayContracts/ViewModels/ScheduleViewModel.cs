using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class ScheduleViewModel : IScheduleModel
    {
        [DisplayName("Сотрудник")]
        public int EmployeeId { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Смена")]
        public string Shift { get; set; } = string.Empty;
        [DisplayName("Явка")]
        public bool Presence { get; set; }

        public int Id { get; set; }
    }
}
