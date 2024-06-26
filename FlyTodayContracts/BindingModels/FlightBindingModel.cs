﻿using FlyTodayDataModels.Enums;
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

        public int TimeInFlight { get; set; }
        public FlightStatusEnum FlightStatus { get; set; }

        public int Id { get; set; }
        public Dictionary<int, IUserModel> FlightSubscribers { get; set; } = new();
    }
}
