using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class TicketSearchModel
    {
        public int? Id { get; set; }
        public int? RentId { get; set; }
        public string? TypeTicket { get; set; } = string.Empty;
        public string? SeriesOfDocument { get; set; } = string.Empty;
        public string? NumberOfDocument { get; set; } = string.Empty;
        public bool? Bags { get; set; }
    }
}
