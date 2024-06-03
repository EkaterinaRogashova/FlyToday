using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class EmployeeSearchModel
    {
        public int? Id { get; set; }
        public string? Surname { get; set; }
        public bool? MedAnalys { get; set; }
        public int? PositionAtWorkId { get; set; }
        public string? FlightId { get; set;}
    }
}
