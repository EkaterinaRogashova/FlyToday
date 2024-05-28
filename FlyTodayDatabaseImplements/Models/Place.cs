using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Place : IPlaceModel
    {
        public int FlightId => throw new NotImplementedException();

        public bool IsFree => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        string IPlaceModel.Place => throw new NotImplementedException();
    }
}
