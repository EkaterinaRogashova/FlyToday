using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class BoardingPassSearchModel
    {
        public int? Id { get; set; }
        public int? TicketId { get; set; }
        public int? PlaceId { get; set; }
    }
}
