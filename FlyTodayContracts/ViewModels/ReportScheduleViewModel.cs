using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class ReportScheduleViewModel
    {
        public DateTime Date { get; set; }
        public string Shift { get; set; } = string.Empty;
        public string EmployeeFIO { get; set; } = string.Empty;
    }
}
