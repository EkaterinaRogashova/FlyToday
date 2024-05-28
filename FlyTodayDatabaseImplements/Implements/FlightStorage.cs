using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Implements
{
    public class FlightStorage : IFlightStorage
    {
        public FlightViewModel? Delete(FlightBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FlightViewModel? GetElement(FlightSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<FlightViewModel> GetFilteredList(FlightSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<FlightViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public FlightViewModel? Insert(FlightBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FlightViewModel? Update(FlightBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
