using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Models
{
    public class Direction : IDirectionModel
    {
        public int Id { get; private set; }

        public string CountryFrom => throw new NotImplementedException();

        public string CountryTo => throw new NotImplementedException();

        public string CityFrom => throw new NotImplementedException();

        public string CityTo => throw new NotImplementedException();
    }
}
