using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class RentSearchModel
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public string? Status { get; set; }
    }
}
