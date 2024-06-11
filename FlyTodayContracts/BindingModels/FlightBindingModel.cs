using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class FlightBindingModel : IFlightModel
    {
        public int PlaneId { get; set; }

        public DateTime DepartureDate { get; set; }

        public int FreePlacesCountEconom { get; set; }
        public int FreePlacesCountBusiness { get; set; }

        public int DirectionId { get; set; }

        public double EconomPrice { get; set; }

        public double BusinessPrice { get; set; }

        public double TimeInFlight { get; set; }

        public int Id { get; set; }        
    }
}
