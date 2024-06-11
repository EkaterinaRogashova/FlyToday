using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class FlightSubscriberBindingModel : IFlightSubscriberModel
    {
        public int FlightId { get; set; }

        public int UserId { get; set; }

        public int Id { get; set; }
    }
}
