using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class ReportScheduleForEmployeeViewModel
    {
        public string EmloyeeFIO { get; set; } = string.Empty;
        public List<Tuple<int, string>> Schedule { get; set; } = new();
    }
}
