using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.StoragesContracts
{
    public interface IFlightStorage
    {
        List<FlightViewModel> GetFullList();
        List<FlightViewModel> GetFilteredList(FlightSearchModel model);
        FlightViewModel? GetElement(FlightSearchModel model);
        FlightViewModel? Insert(FlightBindingModel model);
        FlightViewModel? Update(FlightBindingModel model);
        FlightViewModel? Delete(FlightBindingModel model);
        public Dictionary<int, int> GetSubscribers(FlightSearchModel model);
        public FlightViewModel? SimpleUpdate(FlightBindingModel model);
    }
}
