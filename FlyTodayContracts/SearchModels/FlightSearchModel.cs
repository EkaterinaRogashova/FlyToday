using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class FlightSearchModel
    {
        public int? Id { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? FreePlacesCount {  get; set; }
        public int? DirectionId { get; set; }
        public double? EconomPrice {  get; set; }
        public double? BusinessPrice { get; set; }
    }
}
