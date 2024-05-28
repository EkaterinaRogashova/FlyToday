using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Flight : IFlightModel
    {
        public int Id { get; private set; }

        public int PlaneId => throw new NotImplementedException();

        public DateTime DepartureDate => throw new NotImplementedException();

        public int FreePlacesCount => throw new NotImplementedException();

        public int DirectionId => throw new NotImplementedException();

        public double EconomPrice => throw new NotImplementedException();

        public double BusinessPrice => throw new NotImplementedException();

        public double TimeInFlight => throw new NotImplementedException();
    }
}
