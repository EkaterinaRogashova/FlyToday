using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class ScheduleSearchModel
    {
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public string? Shift { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

    }
}
